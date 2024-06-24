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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicSales.ManagerScreens.Products
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        #region Navigation
        private void label1_Click(object sender, EventArgs e)
        {
            CommonMethods.AlternateWindow(new ManagerForm(), this);
        }

        private void ListProduct_1_Click(object sender, EventArgs e)
        {
            CommonMethods.AlternateWindow(new ListProduct(), this);
        }

        private void StockExtract_1_Click(object sender, EventArgs e)
        {
            CommonMethods.AlternateWindow(new StockExtract(), this);
        }

        private void SalesExtract_1_Click(object sender, EventArgs e)
        {
            CommonMethods.AlternateWindow(new SalesExtract(), this);
        }

        private void ChangeMode_1_Click(object sender, EventArgs e)
        {
            CommonMethods.AlternateWindow(new SalesForm(), this);
        }
        #endregion

        #region Fields Validation
        private void txtPurchasePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonMethods.NumbersValidation(e, txtPurchasePrice.Text, true);
        }   

        private void txtSalePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonMethods.NumbersValidation(e, txtSalePrice.Text, true);
        }

        private void txtBarCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonMethods.NumbersValidation(e, txtBarCode.Text, false);
        }

        private void NumberProducts_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonMethods.NumbersValidation(e, NumberProducts.Text, false);
        }

        private void radioPerishable_CheckedChanged(object sender, EventArgs e)
        {
            ValidityTime.Enabled = radioPerishable.Checked;
        }
        #endregion

        #region Profit Calculation
        private void CalculateProfit(object sender, EventArgs e)
        {
            if (txtPurchasePrice.Text != "" && txtSalePrice.Text != "")
            {
                decimal purchase = decimal.Parse(txtPurchasePrice.Text);
                decimal sale = decimal.Parse(txtSalePrice.Text);

                decimal profit = sale - purchase;

                if (profit != 0 && sale != 0)
                {
                    decimal profitPercent = (profit / purchase) * 100;

                    lblProfitDecimal.Text = profit.ToString();
                    lblProfitPercent.Text = profitPercent.ToString("F2") + "%";

                    if (profit > 0)
                    {
                        lblProfitDecimal.ForeColor = Color.OliveDrab;
                        lblProfitPercent.ForeColor = Color.OliveDrab;
                    }
                    else
                    {
                        lblProfitDecimal.ForeColor = Color.Maroon;
                        lblProfitPercent.ForeColor = Color.Maroon;
                    }
                }
            }
        }
        #endregion

        #region Buttons 
        private void btnClean_Click(object sender, EventArgs e)
        {
            txtProductName.Text = string.Empty;
            txtProductDescription.Text = string.Empty;
            txtBarCode.Text = string.Empty;
            txtSalePrice.Text = string.Empty;
            txtPurchasePrice.Text = string.Empty;
            lblProfitDecimal.Text = "0,00";
            lblProfitDecimal.ForeColor = Color.Black;
            lblProfitPercent.ForeColor = Color.Black;
            lblProfitPercent.Text = "0%";
            ValidityTime.Value = DateTime.Now;
            NumberProducts.Text = string.Empty;
            radioPerishable.Checked = true;
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            bool added = false;
            bool valid = false;

            string Name = CommonMethods.StringNullValidation(txtProductName.Text);
            string BarCode = CommonMethods.StringNullValidation(txtBarCode.Text);
            string Description = CommonMethods.StringNullValidation(txtProductDescription.Text); ;
            DateTime Validity;
            double PurchasePrice = CommonMethods.DoubleNullValidation(txtPurchasePrice.Text);
            double SalePrice = CommonMethods.DoubleNullValidation(txtSalePrice.Text);
            int Stock = CommonMethods.IntNullValidation(NumberProducts.Text);

            if (ValidityTime.Enabled)
            {
                Validity = ValidityTime.Value.Date;
            }
            else
            {
                Validity = new DateTime(1753,1,1);
            }

            if (PurchasePrice != 0 && SalePrice !=0 && Stock != 0 && Name != null && BarCode != null)
            {
                valid = true;
            }

            if (valid)
            {
                DBController controller = new DBController();

                added = controller.CreateProduct(Name, BarCode, Description, Validity, PurchasePrice, SalePrice, Stock);
            }

            btnClean.PerformClick();

            if (added && valid)
            {
                string msg = "The product " + Name + " has been added successfully";
                MessageBox.Show(msg, "Product Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string msg = "Due to an error the product was not added, please try again";
                MessageBox.Show(msg, "Unadded Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
