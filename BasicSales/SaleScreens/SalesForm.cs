using DBManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using FTimer = System.Windows.Forms.Timer;
using FRadioButton = System.Windows.Forms.RadioButton;

namespace BasicSales.SaleScreens
{
    public partial class SalesForm : Form
    {
        DataTable Products;
        double Surcharge = 0;
        double Discount = 0;
        double DiscountPercent = 1;

        public delegate bool RegisterStockDelegate(string operation, int quantity, int productId);

        public SalesForm()
        {
            InitializeComponent();
        }

        #region Actions
        private void menuBarChangeMode_Click(object sender, EventArgs e)
        {
            CommonMethods.AlternateWindow(new ManagerForm(), this);
        }

        private void SalesForm_Load(object sender, EventArgs e)
        {
            FTimer MyTimer = new FTimer();
            MyTimer.Interval = 1000;
            MyTimer.Tick += new EventHandler(ActualHourTimer_Tick);
            MyTimer.Start();

            DBController controller = new DBController();

            Products = controller.GetProductsForSale();
        }

        public void ActualHourTimer_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            LabelDayMonth.Text = now.ToString("dd/MM");
            LabelTime.Text = now.ToString("HH:mm:ss");
        }

        private void ProductQtd_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonMethods.NumbersValidation(e, ProductQtd.Text, false);
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            ProductsViewGrid.Rows.Clear();

            DataView result = new DataView(Products);

            string search_text = Search.Text.Trim();

            if (string.IsNullOrEmpty(search_text))
            {
                ProductsViewGrid.Rows.Clear();
            }
            else
            {
                string filter = $"product_name LIKE '%{search_text}%' OR bar_code LIKE '%{search_text}%'";

                result.RowFilter = filter;

                foreach (DataRowView filtered_line in result)
                {
                    DataRow row = filtered_line.Row;

                    ProductsViewGrid.Rows.Add(row.ItemArray);
                }

                ProductsViewGrid.Sort(ProductsViewGrid.Columns["product_name"], ListSortDirection.Ascending);
                
                if (ProductSaleGrid.Rows.Count > 1)
                {
                    ProductSaleGrid.Rows[0].Selected = true;
                }

                if (ProductsViewGrid.Rows.Count == 1)
                {
                    DataGridViewRow row = ProductsViewGrid.Rows[0];

                    if (row.Cells["bar_code"].Value.ToString() == Search.Text.Trim())
                    {
                        row.Selected = true;

                        AddProductToSale();
                    }
                }
            }
        }

        private void ProductsViewGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AddProductToSale();
        }

        private void Search_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (ProductsViewGrid.Rows.Count > 0)
            {
                if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
                {
                    ProductsViewGrid.Focus();
                    ProductsViewGrid.Rows[0].Selected = true;
                }
            }
        }

        private void ProductsViewGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                AddProductToSale();
            }
        }

        private void ProductSaleGrid_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            WhenEmptyBag();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            string sure = "Are you sure you want to cancel the sale?";
            DialogResult = MessageBox.Show(sure, "Cancel Sale", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (DialogResult == DialogResult.Yes)
            {
                ProductSaleGrid.Rows.Clear();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (ProductSaleGrid.SelectedRows.Count > 0)
            {
                int rowIndex = ProductSaleGrid.SelectedRows[0].Index;
                ProductSaleGrid.Rows.RemoveAt(rowIndex);

                SaleGridChanged();
            }
        }

        private void btnUpdateQuantity_Click(object sender, EventArgs e)
        {
            if (ProductSaleGrid.SelectedRows.Count > 0)
            {
                int rowIndex = ProductSaleGrid.SelectedRows[0].Index;
                int new_qtd = CommonMethods.IntNullValidation(ProductQtd.Text.Trim());
                double new_t_price = double.Parse(ProductSaleGrid.Rows[rowIndex].Cells["total_price"].Value.ToString());

                if (new_qtd == 0)
                {
                    new_qtd = 1;
                }

                ProductSaleGrid.Rows[rowIndex].Cells["quantity"].Value = new_qtd;
                ProductSaleGrid.Rows[rowIndex].Cells["total_price"].Value = (new_t_price * new_qtd).ToString("F2");

                ProductQtd.Text = string.Empty;

                SaleGridChanged();
            }
        }

        private void btnSurcharge_Click(object sender, EventArgs e)
        {
            using (SalesSurcharge s = new SalesSurcharge())
            {
                if (s.ShowDialog() == DialogResult.OK)
                {
                    Surcharge = s.Surcharge;

                    SaleGridChanged();
                }
            }
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            using (SalesDiscount d = new SalesDiscount())
            {
                DialogResult result = d.ShowDialog();

                if (result == DialogResult.OK)
                {
                    Discount = d.Discount;

                    SaleGridChanged();
                }
                else if (result == DialogResult.Yes)
                {
                    DiscountPercent = d.DiscountPercent;

                    SaleGridChanged();
                }
            }
        }

        private void btnConclude_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Do you want to complete the sale?", "Complete Sale", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult == DialogResult.Yes)
            {
                ConcludeSale();
            }
        }

        private void viewSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesView s = new SalesView();
            s.ShowDialog();
        }
        #endregion

        private void AddProductToSale()
        {
            if (ProductsViewGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow row = ProductsViewGrid.SelectedRows[0];

                bool exists = false;
                int exist_row_index = 0;
                int id = (int)row.Cells["id"].Value;
                string product_name = row.Cells["product_name"].Value.ToString();
                double price = double.Parse(row.Cells["sale_price"].Value.ToString());

                int qtd = CommonMethods.IntNullValidation(ProductQtd.Text.Trim());

                if (qtd == 0)
                {
                    qtd = 1;
                }

                double total_price = price * qtd;

                if (ProductSaleGrid.Rows.Count > 0)
                {
                    foreach (DataGridViewRow r in ProductSaleGrid.Rows)
                    {
                        if (id == (int)r.Cells["id_product"].Value)
                        {
                            exists = true;
                            exist_row_index = r.Index;
                        }
                    }
                }
                
                if (!exists)
                {
                    int rowIndex = ProductSaleGrid.Rows.Add();

                    ProductSaleGrid.Rows[rowIndex].Cells["id_product"].Value = id;
                    ProductSaleGrid.Rows[rowIndex].Cells["product_name_sale"].Value = product_name;
                    ProductSaleGrid.Rows[rowIndex].Cells["price"].Value = price.ToString("F2");
                    ProductSaleGrid.Rows[rowIndex].Cells["quantity"].Value = qtd;
                    ProductSaleGrid.Rows[rowIndex].Cells["total_price"].Value = total_price.ToString("F2");
                }
                else
                {
                    double new_price = double.Parse(ProductSaleGrid.Rows[exist_row_index].Cells["price"].Value.ToString());
                    int new_qtd = (int)ProductSaleGrid.Rows[exist_row_index].Cells["quantity"].Value;
                    new_qtd += qtd;

                    double new_total = new_qtd * new_price;

                    ProductSaleGrid.Rows[exist_row_index].Cells["quantity"].Value = new_qtd;
                    ProductSaleGrid.Rows[exist_row_index].Cells["total_price"].Value = new_total.ToString("F2");
                }

                ProductQtd.Text = string.Empty;
                ProductsViewGrid.Rows.Clear();
                Search.Text = string.Empty;
                Search.Focus();

                SaleGridChanged();
            }
        }

        private void SaleGridChanged()
        {
            if (ProductSaleGrid.Rows.Count > 0)
            {
                btnCancel.Enabled = true;
                btnRemove.Enabled = true;
                btnSurcharge.Enabled = true;
                btnDiscount.Enabled = true;
                btnUpdateQuantity.Enabled = true;
                btnConclude.Enabled = true;

                double purchase_price = 0;

                foreach (DataGridViewRow row in ProductSaleGrid.Rows)
                {
                    double p = double.Parse(row.Cells["total_price"].Value.ToString());
                    purchase_price += p;
                }

                if (Surcharge > 0)
                {
                    purchase_price += Surcharge;
                }
                if (Discount > 0)
                {
                    if (purchase_price - Discount < 0)
                    {
                        purchase_price = 0;
                    }
                    else
                    {
                        purchase_price -= Discount;
                    }
                }

                purchase_price *= DiscountPercent;

                FinalPrice.Text = purchase_price.ToString("F2");

                ProductSaleGrid.Rows[ProductSaleGrid.Rows.Count - 1].Selected = true;
            }
        }

        private void WhenEmptyBag()
        {
            if (ProductSaleGrid.Rows.Count == 0)
            {
                btnCancel.Enabled = false;
                btnRemove.Enabled = false;
                btnSurcharge.Enabled = false;
                btnDiscount.Enabled = false;
                btnUpdateQuantity.Enabled = false;
                btnConclude.Enabled = false;
                radioCash.Checked = true;

                FinalPrice.Text = "0,00";

                Surcharge = 0;
                Discount = 0;
                DiscountPercent = 1;
            }
        }

        private string PaymentSelected()
        {
            var selectedRadioButton = PaymentGroupBox.Controls.OfType<FRadioButton>()
                                        .FirstOrDefault(r => r.Checked);
            return selectedRadioButton?.Text;
        }

        private string ActualModifierToString()
        {
            StringBuilder modifier = new StringBuilder();

            if (Surcharge > 0)
            {
                modifier.Append("S-" + Surcharge.ToString() + ";");
            }
            if (Discount > 0)
            {
                modifier.Append("D-" + Discount.ToString() + ";");
            }
            if (DiscountPercent != 1)
            {
                modifier.Append("%-" + (1 - DiscountPercent).ToString());
            }

            string result = modifier.ToString().TrimEnd(';');

            return string.IsNullOrEmpty(result) ? null : result;
        }

        private string ProductsToString()
        {
            if (ProductSaleGrid.Rows.Count > 0)
            {
                StringBuilder products = new StringBuilder();

                foreach (DataGridViewRow row in ProductSaleGrid.Rows)
                {
                    int id = (int)row.Cells["id_product"].Value;
                    int qtd = (int)row.Cells["quantity"].Value;
                    double price = double.Parse(row.Cells["price"].Value.ToString());

                    products.Append(id.ToString() + "-" + qtd.ToString() + "-" + price.ToString() + ";");
                }

                string result = products.ToString().TrimEnd(',');

                return result;
            }

            return null;
        }

        private Dictionary<int, int> ProductsToDict()
        {
            if (ProductSaleGrid.Rows.Count > 0)
            {
                Dictionary<int, int> products = new Dictionary<int, int>();

                foreach (DataGridViewRow row in ProductSaleGrid.Rows)
                {
                    int id = (int)row.Cells["id_product"].Value;
                    int qtd = (int)row.Cells["quantity"].Value;

                    products.Add(id, qtd);
                }

                return products;
            }

            return null;
        }

        private void ConcludeSale()
        {
            bool sucess = false;
            DBController controller = new DBController();

            string products = ProductsToString();
            string payment = PaymentSelected();
            string modifier = ActualModifierToString();
            double total = double.Parse(FinalPrice.Text);

            sucess = controller.CreateSale(products, payment, modifier, total);

            if (sucess)
            {
                RegisterStockDelegate registerDelegate = new RegisterStockDelegate(RegisterStockSale);

                Dictionary<int, int> productsDict = ProductsToDict();

                foreach (var product in productsDict)
                {
                    registerDelegate("Sale", product.Value, product.Key);
                }

                bool completed = controller.UpdateStock(ProductsToDict());

                if (completed)
                {
                    MessageBox.Show("Sale completed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("The sale was registered but could not be deducted from the inventory due to an error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Sale could not be completed due to an error, please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ProductSaleGrid.Rows.Clear();
        }

        private bool RegisterStockSale(string operation, int quantity, int productId)
        {
            DBController controller = new DBController();
            return controller.CreateRegister(operation, quantity, productId);
        }
    }
}
