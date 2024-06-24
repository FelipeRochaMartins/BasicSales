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

namespace BasicSales.SaleScreens
{
    public partial class SalesViewChange : Form
    {
        DataTable Products;
        DataRow SaleInfo;

        DBController controller = new DBController();

        int ID;
        string Modifiers;
        public double Total;

        string[] products;
        int[] ids;
        int[] qtd;
        double[] products_price;

        public bool deleted = false;
        public bool altered = false;
        string new_products;

        public SalesViewChange(int id)
        {
            InitializeComponent();

            ID = id;

            SaleInfo = controller.GetSales(ID);
            Modifiers = SaleInfo["modifier"].ToString();
            InterpretModifiers(Modifiers);

            InterpretProducts(SaleInfo["products"].ToString());
            Products = controller.GetProductsById(ids);

            FillProductsDataGrid();

            CalculeTotal();
            lblTotal.Text = Total.ToString("F2");
            Text += SaleInfo["sale_date"].ToString();
            lblPayment.Text = SaleInfo["payment"].ToString();
        }

        #region Actions
        private void NewProductQtd_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonMethods.NumbersValidation(e, NewProductQtd.Text, false);
        }

        private void NewProductQtd_TextChanged(object sender, EventArgs e)
        {
            if (NewProductQtd.Text.Length > 0 && ProductsViewDataGrid.Rows.Count > 0)
            {
                btnUpdate.Enabled = true;
            }
            else
            {
                btnUpdate.Enabled = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ProductsViewDataGrid.SelectedRows.Count > 0)
            {
                int id = (int)ProductsViewDataGrid.SelectedRows[0].Cells["id"].Value;

                int old_qtd = (int)ProductsViewDataGrid.SelectedRows[0].Cells["quantity"].Value;
                int new_qtd = int.Parse(NewProductQtd.Text);

                if (new_qtd != old_qtd)
                {
                    int difference = 0;

                    if (new_qtd > old_qtd) 
                    {
                        difference = new_qtd - old_qtd;
                        controller.UpdateStock(id, difference, false);
                        controller.CreateRegister("Complementation", difference, id);
                    }
                    else if (new_qtd < old_qtd) 
                    {
                        difference = old_qtd - new_qtd;
                        controller.UpdateStock(id, difference, true);
                        controller.CreateRegister("Devolution", difference, id);
                    }

                    ProductsViewDataGrid.SelectedRows[0].Cells["quantity"].Value = new_qtd;

                    CalculeTotal();
                    lblTotal.Text = Total.ToString("F2");

                    UpdateSaleToSave();
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (ProductsViewDataGrid.SelectedRows.Count > 0)
            {
                int index = ProductsViewDataGrid.SelectedRows[0].Index;

                if ((ProductsViewDataGrid.Rows.Count - 1) > 0)
                {
                    ProductsViewDataGrid.Rows.RemoveAt(index);

                    CalculeTotal();
                    lblTotal.Text = Total.ToString("F2");

                    UpdateSaleToSave();

                    altered = true;
                }
                else
                {
                    deleted = true;
                    controller.DeleteSale(ID);
                    Close();
                }
            }
        }
        #endregion

        #region Fill Data and DataGrid
        private void InterpretProducts(string products_str)
        {
            products = products_str.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            ids = new int[products.Length];
            qtd = new int[products.Length];
            products_price = new double[products.Length];

            int counter = 0;

            foreach (string product in products)
            {
                string[] data = product.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);

                ids[counter] = int.Parse(data[0]);
                qtd[counter] = int.Parse(data[1]);
                products_price[counter] = double.Parse(data[2]);

                counter++;
            }
        }

        private void FillProductsDataGrid()
        {
            int counter = 0;

            foreach (DataRow row in Products.Rows)
            {
                int rowIndex = ProductsViewDataGrid.Rows.Add();

                ProductsViewDataGrid.Rows[rowIndex].Cells["id"].Value = row["id"];
                ProductsViewDataGrid.Rows[rowIndex].Cells["product_name"].Value = row["product_name"];
                ProductsViewDataGrid.Rows[rowIndex].Cells["quantity"].Value = qtd[counter];
                ProductsViewDataGrid.Rows[rowIndex].Cells["price"].Value = products_price[counter].ToString("F2");
                ProductsViewDataGrid.Rows[rowIndex].Cells["stock"].Value = row["stock"];


                counter++;
            }

            btnRemove.Enabled = true;
            NewProductQtd.Enabled = true;

            ProductsViewDataGrid.Sort(ProductsViewDataGrid.Columns["product_name"], ListSortDirection.Ascending);
        }
        #endregion

        #region Final Value
        private void CalculeTotal()
        {
            if (ProductsViewDataGrid.Rows.Count > 0)
            {
                double value = 0;

                foreach (DataGridViewRow row in ProductsViewDataGrid.Rows)
                {
                    int qtd = (int)row.Cells["quantity"].Value;
                    double price = double.Parse(row.Cells["price"].Value.ToString());

                    value += qtd * price;
                }

                Total = TotalTreaty(value);
            }
        }

        private void InterpretModifiers(string modifiers_str)
        {
            if (Modifiers != null)
            {
                string[] mods = modifiers_str.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string mod in mods)
                {
                    string[] i = mod.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);

                    string TrueModifier = i[0];
                    double Value = double.Parse(i[1].ToString());

                    if (TrueModifier == "S")
                    {
                        lblSurcharge.Text = Value.ToString("F2");
                    }
                    if (TrueModifier == "D")
                    {
                        lblDiscount.Text = Value.ToString("F2");
                    }
                    if (TrueModifier == "%")
                    {
                        lblPercent.Text = (Value * 100).ToString();
                    }
                }
            }
        }

        private double TotalTreaty(double total)
        {
            double surcharge = double.Parse(lblSurcharge.Text);
            double discount = double.Parse(lblDiscount.Text);
            double percent = double.Parse(lblPercent.Text);

            if (percent == 0)
            {
                percent = 1;
            }
            else
            {
                percent = 1 - (percent / 100);
            }


            if (surcharge > 0)
            {
                total += surcharge;
            }
            if (discount > 0)
            {
                if (total - discount < 0)
                {
                    total = 0;
                }
                else
                {
                    total -= discount;
                }
            }

            total *= percent;

            if (total < 0)
            {
                total = 0;
            }

            return total;
        }
        #endregion

        private void UpdateSaleToSave()
        {
            if (ProductsViewDataGrid.Rows.Count > 0)
            {
                StringBuilder products = new StringBuilder();

                double total = 0;

                foreach (DataGridViewRow row in ProductsViewDataGrid.Rows)
                {
                    int id = (int)row.Cells["id"].Value;
                    int qtd = (int)row.Cells["quantity"].Value;
                    double price = double.Parse(row.Cells["price"].Value.ToString());

                    total += qtd * price;

                    products.Append(id.ToString() + "-" + qtd.ToString() + "-" + price.ToString() + ";");
                }

                new_products = products.ToString().TrimEnd(',');

                altered = true;
            }
        }

        private void SalesViewChange_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (altered)
            {
                controller.UpdateSale(ID, new_products, Total);
            }
        }
    }
}
