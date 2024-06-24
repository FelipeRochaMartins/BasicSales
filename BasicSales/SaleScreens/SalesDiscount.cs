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
    public partial class SalesDiscount : Form
    {
        public double Discount = 0;
        public double DiscountPercent = 1;

        public SalesDiscount()
        {
            InitializeComponent();
        }

        private void radioCash_CheckedChanged(object sender, EventArgs e)
        {
            txtCash.Enabled = radioCash.Checked;
            if (txtCash.Enabled == false)
            {
                txtCash.Text = string.Empty;
            }
        }

        private void radioPercent_CheckedChanged(object sender, EventArgs e)
        {
            numPercent.Enabled = radioPercent.Checked;
            if (numPercent.Enabled == false)
            {
                numPercent.Value = 0;
            }
        }

        private void btnCancel1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void txtCash_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCash.Text))
            {
                btnApply.Enabled = true;
            }
        }

        private void txtCash_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonMethods.NumbersValidation(e, txtCash.Text, true);
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (txtCash.Enabled)
            {
                Discount = double.Parse(txtCash.Text);

                DialogResult = DialogResult.OK;
                Close();
            }
            else if (numPercent.Enabled)
            {
                DiscountPercent = (100 - (double)numPercent.Value) / 100;

                DialogResult = DialogResult.Yes;
                Close();
            }
        }

        private void numPercent_ValueChanged(object sender, EventArgs e)
        {
            if (numPercent.Value > 0)
            {
                btnApply.Enabled = true;
            }
        }
    }
}
