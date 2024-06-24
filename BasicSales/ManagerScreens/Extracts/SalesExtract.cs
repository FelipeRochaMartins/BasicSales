using BasicSales.ManagerScreens.Products;
using BasicSales.SaleScreens;
using DBManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicSales.ManagerScreens.Extracts
{
    public partial class SalesExtract : Form
    {
        DBController controller = new DBController();
        DataTable SalesPerDay;

        int x;
        int y;
        int w;
        int h;

        private int DayIndex = 0;
        private int SaleIndex = 0;

        bool header = true;
        bool dayLabel = true;
        bool salesLabel = true;

        int column_width;
        double Total;

        readonly Font datesFont = new Font("Calibri", 16, FontStyle.Bold, GraphicsUnit.Point);
        readonly Font titleFont = new Font("Calibri", 28, FontStyle.Bold, GraphicsUnit.Point);
        readonly Font smallFont = new Font("Calibri", 12, FontStyle.Regular, GraphicsUnit.Point);
        readonly Font salesFont = new Font("Calibri", 14, FontStyle.Regular, GraphicsUnit.Point);

        readonly StringFormat salesFormat = new StringFormat();
        readonly StringFormat titleFormat = new StringFormat();
        readonly StringFormat smallFormat = new StringFormat();
        readonly StringFormat totalFormat = new StringFormat();

        public SalesExtract()
        {
            InitializeComponent();
        }

        #region Navigation
        private void label1_Click(object sender, EventArgs e)
        {
            CommonMethods.AlternateWindow(new ManagerForm(), this);
        }

        private void ListProduct_4_Click(object sender, EventArgs e)
        {
            CommonMethods.AlternateWindow(new ListProduct(), this);
        }

        private void AddProduct_4_Click(object sender, EventArgs e)
        {
            CommonMethods.AlternateWindow(new AddProduct(), this);
        }

        private void StockExtract_4_Click(object sender, EventArgs e)
        {
            CommonMethods.AlternateWindow(new StockExtract(), this);
        }

        private void ChangeMode_4_Click(object sender, EventArgs e)
        {
            CommonMethods.AlternateWindow(new SalesForm(), this);
        }
        #endregion

        private void FillSalesExtract()
        {
            ListSalesExtract.Rows.Clear();

            double t = 0;

            foreach(DataRow row in SalesPerDay.Rows)
            {
                int index = ListSalesExtract.Rows.Add();

                string day = DateTime.ParseExact(row["day"].ToString(), "yyyy-MM-dd", CultureInfo.InvariantCulture).ToShortDateString();
                double total = Convert.ToDouble(row[1]);

                ListSalesExtract.Rows[index].Cells["sale_date"].Value = day;
                ListSalesExtract.Rows[index].Cells["total"].Value = total.ToString("F2");

                t += total;
            }

            lblTotal.Text = t.ToString("F2");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DateTime Start = StartDate.Value.Date;
            DateTime End = EndDate.Value.Date.AddHours(23).AddMinutes(59).AddSeconds(59);

            if (Start > End)
            {
                string msg = "The final time value is greater than the initial value, please try again";
                MessageBox.Show(msg, "Invalid Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SalesPerDay = controller.GetSales(Start, End);
                
                if (SalesPerDay.Rows.Count > 0)
                {
                    FillSalesExtract();
                }    
            }
        }

        private void ListSalesExtract_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (ListSalesExtract.Rows.Count == 0)
            {
                btnExport.Enabled = false;
                btnRemove.Enabled = false;
            }
            else
            {
                btnExport.Enabled = true;
                btnRemove.Enabled = true;

                ListSalesExtract.Rows[ListSalesExtract.Rows.Count - 1].Selected = true;
            }
        }

        private void ListSalesExtract_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (ListSalesExtract.Rows.Count > 0)
            {
                btnExport.Enabled = true;
                btnRemove.Enabled = true;

                ListSalesExtract.Rows[ListSalesExtract.Rows.Count - 1].Selected = true;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (ListSalesExtract.SelectedRows.Count > 0)
            {
                int index = ListSalesExtract.SelectedRows[0].Index;

                DateTime date_unformatted = DateTime.ParseExact(ListSalesExtract.Rows[index].Cells["sale_date"].Value.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                string date = date_unformatted.ToString("yyyy-MM-dd");

                bool removed = controller.DeleteSale(date);

                if (removed)
                {
                    string msg = date_unformatted.ToShortDateString() + " day sales were successfully removed";
                    MessageBox.Show(msg, "Successfully Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    double remove = double.Parse(ListSalesExtract.Rows[index].Cells["total"].Value.ToString());

                    ListSalesExtract.Rows.RemoveAt(index);

                    double t = double.Parse(lblTotal.Text);

                    lblTotal.Text = (t - remove).ToString("F2");
                }
                else
                {
                    string msg = "Due to an error, the " + date_unformatted.ToShortDateString() + " day's sales could not be removed, please try again";
                    MessageBox.Show(msg, "Removal failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ListSalesExtract_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (ListSalesExtract.SelectedRows.Count > 0)
            {
                int index = ListSalesExtract.SelectedRows[0].Index;

                DataGridViewRow row = ListSalesExtract.SelectedRows[0];
                string day_str = row.Cells["sale_date"].Value.ToString();

                DateTime day = DateTime.ParseExact(day_str, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                SalesViewDetailed s = new SalesViewDetailed(day);
                s.ShowDialog();

                double new_total = s.Total;

                ListSalesExtract.Rows[index].Cells["total"].Value = new_total.ToString("F2");
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (ListSalesExtract.Rows.Count > 0)
            {
                x = 50;
                y = 50;
                w = SaleExtractDocument.DefaultPageSettings.Bounds.Width;
                h = SaleExtractDocument.DefaultPageSettings.Bounds.Height;

                SaleExtractDialog.Document = SaleExtractDocument;
                if (SaleExtractDialog.ShowDialog() != DialogResult.Cancel)
                {
                    salesFormat.Alignment = StringAlignment.Center;
                    salesFormat.LineAlignment = StringAlignment.Center;
                    titleFormat.Alignment = StringAlignment.Center;
                    titleFormat.LineAlignment = StringAlignment.Center;
                    smallFormat.LineAlignment = StringAlignment.Center;
                    smallFormat.Alignment = StringAlignment.Far;
                    totalFormat.Alignment = StringAlignment.Far;
                    totalFormat.LineAlignment = StringAlignment.Center;

                    w = SaleExtractDocument.DefaultPageSettings.Bounds.Width;
                    h = SaleExtractDocument.DefaultPageSettings.Bounds.Height;

                    column_width = (w - x - 140) / 3;


                    SaleExtractDocument.PrinterSettings = SaleExtractDialog.Document.PrinterSettings;
                    SaleExtractDocument.Print();
                }
            }  
        }

        private void SaleExtractDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            for (; DayIndex < ListSalesExtract.Rows.Count; DayIndex++)
            {
                DataGridViewRow row = ListSalesExtract.Rows[DayIndex];

                DateTime date_unformatted = DateTime.ParseExact(row.Cells["sale_date"].Value.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                string date = date_unformatted.ToString("yyyy-MM-dd");

                DataTable sales = controller.GetSales(date);
                int rows_total = sales.Rows.Count;

                if (header)
                {
                    e.Graphics.DrawString("Sales Extract", titleFont, Brushes.MidnightBlue, new Rectangle(x, y, w - 100, 30), titleFormat);
                    y += 60;

                    e.Graphics.DrawString("Consulted at " + DateTime.Now.ToString("dd/MM - HH:mm"), smallFont, Brushes.MidnightBlue, new Rectangle(x, y, w - 100, 25), smallFormat);
                    y += 30;

                    e.Graphics.DrawLine(Pens.MidnightBlue, new Point(x, y), new Point(w - x, y));

                    y += 20;

                    header = false;
                }

                if (y >= h - 70)
                {
                    e.HasMorePages = true;
                    y = 50;
                    return;
                }

                if (dayLabel)
                {
                    string line = "Sales Day " + row.Cells["sale_date"].Value.ToString();

                    e.Graphics.DrawString(line, datesFont, Brushes.MidnightBlue, new Point(x, y));
                    y += 10;

                    dayLabel = false;
                }

                if (y >= h - 120)
                {
                    e.HasMorePages = true;
                    y = 50;
                    return;
                }

                if (salesLabel)
                {
                    e.Graphics.DrawLines(Pens.MidnightBlue, new Point[] { new Point(x + 20, y + 25), new Point(x + 20, y + 50), new Point(x + 70, y + 50) });
                    y += 35;
                    e.Graphics.DrawString("Time Of Sale", salesFont, Brushes.MidnightBlue, new Rectangle(x + 90, y, column_width, 30), salesFormat);
                    e.Graphics.DrawString("Payment Method", salesFont, Brushes.MidnightBlue, new Rectangle(x + 90 + column_width, y, column_width, 30), salesFormat);
                    e.Graphics.DrawString("Total Sale Amount", salesFont, Brushes.MidnightBlue, new Rectangle(x + 90 + (column_width * 2), y, column_width, 30), salesFormat);

                    y += 31;

                    e.Graphics.DrawLine(Pens.MidnightBlue, new Point(x + 90, y), new Point(w - 50, y));

                    y += 1;

                    salesLabel = false;
                }

                for (; SaleIndex < rows_total; SaleIndex++)
                {
                    if (y >= h - 90)
                    {
                        e.HasMorePages = true;
                        y = 50;
                        return;
                    }

                    DateTime day = (DateTime)sales.Rows[SaleIndex]["sale_date"];
                    string hour = day.ToString("HH:mm:ss");

                    double v = double.Parse(sales.Rows[SaleIndex]["total_price"].ToString());
                    string total = v.ToString("F2");

                    string payment = sales.Rows[SaleIndex]["payment"].ToString();

                    e.Graphics.DrawString(hour, salesFont, Brushes.RoyalBlue, new Rectangle(x + 90, y, column_width, 30), salesFormat);
                    e.Graphics.DrawString(payment, salesFont, Brushes.RoyalBlue, new Rectangle(x + 90 + column_width, y, column_width, 30), salesFormat);
                    e.Graphics.DrawString(total, salesFont, Brushes.RoyalBlue, new Rectangle(x + 90 + (column_width * 2), y, column_width, 30), salesFormat);

                    y += 31;

                    e.Graphics.DrawLine(Pens.MidnightBlue, new Point(x + 90, y), new Point(w - 50, y));

                    y += 1;

                    Total += v;
                }

                SaleIndex = 0;

                dayLabel = true;
                salesLabel = true;

                y += 70;

                if (y >= h - 70)
                {
                    e.HasMorePages = true;
                    y = 50;
                    return;
                }
            }

            y += 20;
            e.Graphics.DrawLine(Pens.MidnightBlue, new Point(x, y), new Point(w - x, y));
            y += 10;

            e.Graphics.DrawString("Total Sales Value:", datesFont, Brushes.MidnightBlue, new Rectangle(x + 90 + column_width, y, column_width, 30), totalFormat);
            e.Graphics.DrawString(Total.ToString("F2"), datesFont, Brushes.MidnightBlue, new Rectangle(x + 90 + (column_width * 2), y, column_width, 30), salesFormat);

            header = true;
            e.HasMorePages = false;
            DayIndex = 0;
            SaleIndex = 0;
        }

    }
}
