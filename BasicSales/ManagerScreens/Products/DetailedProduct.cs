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
using System.Xml.Schema;

namespace BasicSales.ManagerScreens.Products
{
    public partial class DetailedProduct : Form
    {
        DataRow Product;
        int ProductID;
        
        public DetailedProduct(int id, string product_name)
        {
            InitializeComponent();
            Text += product_name;
            lblProductName.Text = product_name;
            ProductID = id;   
        }

        #region Actions
        private void DetailedProduct_Load(object sender, EventArgs e)
        {
            DBController controller = new DBController();
            Product = controller.GetProductById(ProductID);

            FillFields();
        }
        private void radioPerishable1_CheckedChanged(object sender, EventArgs e)
        {
            ValidityTime1.Enabled = radioPerishable1.Checked;
        }
        private void txtPurchasePrice1_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonMethods.NumbersValidation(e, txtPurchasePrice1.Text, true);
        }
        private void txtSalePrice1_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonMethods.NumbersValidation(e, txtSalePrice1.Text, true);
        }
        private void txtBarCode1_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonMethods.NumbersValidation(e, txtBarCode1.Text, false);
        }
        private void NumberProducts1_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonMethods.NumbersValidation(e, NumberProducts1.Text, false);
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            bool updated = false;
            bool valid = false;

            string Name = CommonMethods.StringNullValidation(txtProductName1.Text);
            string BarCode = CommonMethods.StringNullValidation(txtBarCode1.Text);
            string Description = CommonMethods.StringNullValidation(txtProductDescription1.Text);
            DateTime Validity;
            double PurchasePrice = CommonMethods.DoubleNullValidation(txtPurchasePrice1.Text);
            double SalePrice = CommonMethods.DoubleNullValidation(txtSalePrice1.Text);
            int Stock = CommonMethods.IntNullValidation(NumberProducts1.Text);

            if (ValidityTime1.Enabled)
            {
                Validity = ValidityTime1.Value.Date;
            }
            else
            {
                Validity = new DateTime(1753, 1, 1);
            }

            if (PurchasePrice != 0 && SalePrice != 0 && Stock != 0 && Name != null && BarCode != null)
            {
                valid = true;
            }

            if (valid)
            {
                DBController controller = new DBController();

                updated = controller.UpdateProduct(ProductID, Name, BarCode, Description, Validity, PurchasePrice, SalePrice, Stock);
            }

            if (updated && valid)
            {
                string msg = "The product " + Name + " has been updated successfully";
                MessageBox.Show(msg, "Updated Product", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Close();
            }
            else
            {
                string msg = "Due to an error the product was not updated, please try again";
                MessageBox.Show(msg, "Product Not Updated", MessageBoxButtons.OK, MessageBoxIcon.Error);

                FillFields();
            }
        }
        #endregion

        #region Details Methods
        private void CalculateProfit(object sender, EventArgs e)
        {
            if (txtPurchasePrice1.Text != "" && txtSalePrice1.Text != "")
            {
                decimal purchase = decimal.Parse(txtPurchasePrice1.Text);
                decimal sale = decimal.Parse(txtSalePrice1.Text);

                decimal profit = sale - purchase;

                if (profit != 0 && sale != 0)
                {
                    decimal profitPercent = (profit / purchase) * 100;

                    lblProfitDecimal1.Text = profit.ToString();
                    lblProfitPercent1.Text = profitPercent.ToString("F2") + "%";

                    if (profit > 0)
                    {
                        lblProfitDecimal1.ForeColor = Color.OliveDrab;
                        lblProfitPercent1.ForeColor = Color.OliveDrab;
                    }
                    else
                    {
                        lblProfitDecimal1.ForeColor = Color.Maroon;
                        lblProfitPercent1.ForeColor = Color.Maroon;
                    }
                }
            }
        }

        private void FillFields()
        {
            txtProductName1.Text = (string)Product["product_name"];
            txtBarCode1.Text = (string)Product["bar_code"];
            txtPurchasePrice1.Text = Product["purchase_price"].ToString();
            txtSalePrice1.Text = Product["sale_price"].ToString();
            NumberProducts1.Text = Product["stock"].ToString();

            if (Product["description"] is DBNull)
            {
                txtProductDescription1.Text = string.Empty;
            }
            else
            {
                txtProductDescription1.Text = (string)Product["description"];
            }

            if ((DateTime)Product["validity"] == new DateTime(1753, 1, 1))
            {
                radioNonPerishable1.Checked = true;
            }
            else
            {
                radioPerishable1.Checked = true;
                ValidityTime1.Value = (DateTime)Product["validity"];
            }
        }

        #endregion

        
    }
}
