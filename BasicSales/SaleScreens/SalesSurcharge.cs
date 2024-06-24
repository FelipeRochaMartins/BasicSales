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
    public partial class SalesSurcharge : Form
    {
        public double Surcharge = 0;

        public SalesSurcharge()
        {
            InitializeComponent();
        }

        private void SurchargeValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonMethods.NumbersValidation(e, SurchargeValue.Text, true);
        }

        private void btnSurcharge_Click(object sender, EventArgs e)
        {
            Surcharge = double.Parse(SurchargeValue.Text);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void SurchargeValue_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SurchargeValue.Text))
            {
                btnSurcharge.Enabled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
