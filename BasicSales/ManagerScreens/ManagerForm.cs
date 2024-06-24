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
using BasicSales.ManagerScreens.Extracts;
using BasicSales.ManagerScreens.Products;
using BasicSales.SaleScreens;
using FTimer = System.Windows.Forms.Timer;
using DBManager;

namespace BasicSales
{
    public partial class ManagerForm : Form
    {
        DataTable Expiring;

        public ManagerForm()
        {
            InitializeComponent();

            DBController controller = new DBController();
            Expiring = controller.GetExpiringProducts();
        }    

        #region Navigation
        private void ChangeMode_Click(object sender, EventArgs e)
        {
            CommonMethods.AlternateWindow(new SalesForm(), this);
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            CommonMethods.AlternateWindow(new AddProduct(), this);
        }

        private void ListProduct_Click(object sender, EventArgs e)
        {
            CommonMethods.AlternateWindow(new ListProduct(), this);
        }

        private void StockExtract_Click(object sender, EventArgs e)
        {
            CommonMethods.AlternateWindow(new StockExtract(), this);
        }

        private void SalesExtract_Click(object sender, EventArgs e)
        {
            CommonMethods.AlternateWindow(new SalesExtract(), this);
        }
        #endregion

        #region Timer Setup
        private void ActualHourTimer_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            LabelActualDay.Text = now.ToString("dd/MM/yyyy");
            LabelActualHour.Text = now.ToString("HH:mm:ss");
        }

        private void TimerStart()
        {
            FTimer MyTimer = new FTimer();
            MyTimer.Interval = 1000;
            MyTimer.Tick += new EventHandler(ActualHourTimer_Tick);
            MyTimer.Start();
        }
        #endregion

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            TimerStart();

            foreach (DataRow row in Expiring.Rows)
            {
                StringBuilder notice = new StringBuilder();

                DateTime date = (DateTime)row["validity"];
                string product = row["product_name"].ToString();

                TimeSpan days = date - DateTime.Now.Date;

                if (days.TotalDays < 0)
                {
                    notice.AppendFormat("{0} expired {1} days ago.", product, Math.Abs(days.TotalDays));
                }
                else if (days.TotalDays == 0)
                {
                    notice.AppendFormat("{0} expires today.", product);
                }
                else if (days.TotalDays <= 14)
                {
                    notice.AppendFormat("{0} will expire in {1} days.", product, days.TotalDays);
                }

                ExpiringList.Items.Add(notice.ToString());
            }
        }

        private void ExpiringList_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            ListBox listBox = (ListBox)sender;

            string text = listBox.Items[e.Index].ToString();


            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Near;
            sf.LineAlignment = StringAlignment.Center;

            Color backgroundColor;
            if (e.Index % 2 == 0)
            {
                backgroundColor = SystemColors.Control;

                using (SolidBrush backgroundBrush = new SolidBrush(backgroundColor))
                {
                    e.Graphics.FillRectangle(backgroundBrush, e.Bounds);
                }

                e.Graphics.DrawString(text, e.Font, Brushes.MidnightBlue, e.Bounds, sf);
            }
            else
            {
                backgroundColor = Color.MidnightBlue;

                using (SolidBrush backgroundBrush = new SolidBrush(backgroundColor))
                {
                    e.Graphics.FillRectangle(backgroundBrush, e.Bounds);
                }

                e.Graphics.DrawString(text, e.Font, Brushes.White, e.Bounds, sf);
            }
        }
    }
}
