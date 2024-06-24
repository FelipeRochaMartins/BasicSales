using BasicSales.ManagerScreens.Extracts;
using BasicSales.SaleScreens;
using DBManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicSales.ManagerScreens.Products
{
    public partial class ListProduct : Form
    {
        DataTable Table;
        private AutoResetEvent detailClosedEvent = new AutoResetEvent(false);

        public ListProduct()
        {
            InitializeComponent();
        }

        #region Navigation
        private void label1_Click(object sender, EventArgs e)
        {
            CommonMethods.AlternateWindow(new ManagerForm(), this);
        }

        private void AddProduct_2_Click(object sender, EventArgs e)
        {
            CommonMethods.AlternateWindow(new AddProduct(), this);
        }

        private void StockExtract_2_Click(object sender, EventArgs e)
        {
            CommonMethods.AlternateWindow(new StockExtract(), this);
        }

        private void SalesExtract_2_Click(object sender, EventArgs e)
        {
            CommonMethods.AlternateWindow(new SalesExtract(), this);
        }


        private void ChangeMode_2_Click(object sender, EventArgs e)
        {
            CommonMethods.AlternateWindow(new SalesForm(), this);
        }
        #endregion

        #region Actions
        private void ListProduct_Load(object sender, EventArgs e)
        {
            DBController controller = new DBController();
            Table = controller.GetAllProducts();

            RefreshProducts();
        }

        private void ListProductsDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            NumberProducts.Enabled = true;
            btnAddToStock.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void txtListSearch_TextChanged(object sender, EventArgs e)
        {
            DataView result = new DataView(Table);

            string search_text = txtListSearch.Text.Trim();
            string filter = $"product_name LIKE '%{search_text}%' OR bar_code LIKE '%{search_text}%'";

            result.RowFilter = filter;

            ListProductsDataGrid.Rows.Clear();

            foreach (DataRowView filtered_line in result)
            {
                DataRow row = filtered_line.Row;

                ListProductsDataGrid.Rows.Add(row.ItemArray);
            }

            ListProductsDataGrid.Sort(ListProductsDataGrid.Columns["product_name"], ListSortDirection.Ascending);
        }

        private void btnAddToStock_Click(object sender, EventArgs e)
        {
            bool sucess = false;

            int id = (int)ListProductsDataGrid.SelectedRows[0].Cells[0].Value;
            int rowIndex = ListProductsDataGrid.SelectedRows[0].Index;
            int to_add = CommonMethods.IntNullValidation(NumberProducts.Text);
            NumberProducts.Text = string.Empty;

            if (to_add > 0)
            {
                DBController controller = new DBController();
                sucess = controller.UpdateStock(id, to_add);

                if (sucess)
                {
                    controller.CreateRegister("Added", to_add, id);

                    string msg = "The stock of product " + (string)ListProductsDataGrid.SelectedRows[0].Cells[1].Value + " was added to " + to_add.ToString();
                    MessageBox.Show(msg, "Updated Stock", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Table = controller.GetAllProducts();

                    RefreshProducts();
                }
                else
                {
                    string msg = "Due to an error, the product was not updated in stock, please try again";
                    MessageBox.Show(msg, "Stock not updated", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                string msg = "Due to an error, the product was not updated in stock, please try again";
                MessageBox.Show(msg, "Stock Not Updated", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool sucess = false;

            int id = (int)ListProductsDataGrid.SelectedRows[0].Cells[0].Value;
            int rowIndex = ListProductsDataGrid.SelectedRows[0].Index;

            string product_name = (string)ListProductsDataGrid.SelectedRows[0].Cells[1].Value;

            string sure = "Are you sure you want to delete product " + product_name + "?";
            DialogResult = MessageBox.Show(sure, "Delete Product", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (DialogResult == DialogResult.Yes)
            {
                DBController controller = new DBController();
                sucess = controller.DeleteProduct(id);

                if (sucess)
                {
                    string msg = "Product " + product_name + " was successfully deleted.";
                    MessageBox.Show(msg, "Deleted product", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Table = controller.GetAllProducts();

                    RefreshProducts();
                }
                else
                {
                    string msg = "Due to an error, the product was not deleted, please try again";
                    MessageBox.Show(msg, "Product Not Deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ListProductsDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string product_name = (string)ListProductsDataGrid.Rows[e.RowIndex].Cells[1].Value;
                int id = (int)ListProductsDataGrid.Rows[e.RowIndex].Cells[0].Value;

                detailClosedEvent.Reset();

                Thread t = new Thread(() =>
                {
                    Form detailedProductForm = new DetailedProduct(id, product_name);

                    detailedProductForm.FormClosed += (s, args) => detailClosedEvent.Set();

                    Application.Run(detailedProductForm);
                });
                t.SetApartmentState(ApartmentState.STA);
                t.Start();


                Thread waitingThread = new Thread(() =>
                {
                    detailClosedEvent.WaitOne();

                    BeginInvoke((Action)(() =>
                    {
                        DBController controller = new DBController();
                        Table = controller.GetAllProducts();

                        RefreshProducts();
                        Focus();
                    }));
                });
                waitingThread.Start();
            }
            catch
            {

            }
        }
        #endregion

        private void RefreshProducts()
        {
            ListProductsDataGrid.Rows.Clear();

            foreach (DataRow row in Table.Rows)
            {
                ListProductsDataGrid.Rows.Add(row.ItemArray);
            }

            ListProductsDataGrid.Sort(ListProductsDataGrid.Columns["product_name"], ListSortDirection.Ascending);
        }
    }
}
