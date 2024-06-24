using BasicSales.ManagerScreens.Products;
using BasicSales.SaleScreens;
using DBManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicSales.ManagerScreens.Extracts
{
    public partial class StockExtract : Form
    {
        DBController controller = new DBController();
        DataTable StockPerDay;

        int x;
        int y;
        int w;
        int h;

        private int DayIndex = 0;
        private int StockIndex = 0;

        bool header = true;
        bool dayLabel = true;
        bool stockLabel = true;

        int column_width;

        readonly Font datesFont = new Font("Calibri", 16, FontStyle.Bold, GraphicsUnit.Point);
        readonly Font titleFont = new Font("Calibri", 28, FontStyle.Bold, GraphicsUnit.Point);
        readonly Font smallFont = new Font("Calibri", 12, FontStyle.Regular, GraphicsUnit.Point);
        readonly Font stockFont = new Font("Calibri", 12, FontStyle.Regular, GraphicsUnit.Point);

        readonly StringFormat stockFormat = new StringFormat();
        readonly StringFormat titleFormat = new StringFormat();
        readonly StringFormat smallFormat = new StringFormat();
        readonly StringFormat totalFormat = new StringFormat();

        public StockExtract()
        {
            InitializeComponent();
        }

        #region Navigation
        private void label1_Click(object sender, EventArgs e)
        {
            CommonMethods.AlternateWindow(new ManagerForm(), this);
        }

        private void ListProduct_3_Click(object sender, EventArgs e)
        {
            CommonMethods.AlternateWindow(new ListProduct(), this);
        }

        private void AddProduct_3_Click(object sender, EventArgs e)
        {
            CommonMethods.AlternateWindow(new AddProduct(), this);
        }

        private void SalesExtract_3_Click(object sender, EventArgs e)
        {
            CommonMethods.AlternateWindow(new SalesExtract(), this);
        }

        private void ChangeMode_3_Click(object sender, EventArgs e)
        {
            CommonMethods.AlternateWindow(new SalesForm(), this);
        }
        #endregion

        private void ListStockExtract_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (ListStockExtract.Rows.Count == 0)
            {
                btnExport.Enabled = false;
                btnRemove.Enabled = false;
            }
            else
            {
                btnExport.Enabled = true;
                btnRemove.Enabled = true;

                ListStockExtract.Rows[ListStockExtract.Rows.Count - 1].Selected = true;
            }
        }

        private void ListStockExtract_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (ListStockExtract.Rows.Count > 0)
            {
                btnExport.Enabled = true;
                btnRemove.Enabled = true;

                ListStockExtract.Rows[ListStockExtract.Rows.Count - 1].Selected = true;
            }
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
                StockPerDay = controller.GetStock(Start, End);

                FillStockExtract();
            }
        }

        private void FillStockExtract()
        {
            ListStockExtract.Rows.Clear();

            foreach (DataRow row in StockPerDay.Rows)
            {
                int index = ListStockExtract.Rows.Add();

                string day = DateTime.ParseExact(row["day"].ToString(), "yyyy-MM-dd", CultureInfo.InvariantCulture).ToShortDateString();

                ListStockExtract.Rows[index].Cells["sale_date"].Value = day;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (ListStockExtract.SelectedRows.Count > 0)
            {
                int index = ListStockExtract.SelectedRows[0].Index;

                DateTime date_unformatted = DateTime.ParseExact(ListStockExtract.Rows[index].Cells["sale_date"].Value.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                string date = date_unformatted.ToString("yyyy-MM-dd");

                bool removed = controller.DeleteStock(date);

                if (removed)
                {
                    string msg = date_unformatted.ToShortDateString() + " day stock were successfully removed";
                    MessageBox.Show(msg, "Successfully Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ListStockExtract.Rows.RemoveAt(index);

                }
                else
                {
                    string msg = "Due to an error, the " + date_unformatted.ToShortDateString() + " day's stock could not be removed, please try again";
                    MessageBox.Show(msg, "Removal failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (ListStockExtract.Rows.Count > 0)
            {
                x = 50;
                y = 50;
                w = StockExtractDocument.DefaultPageSettings.Bounds.Width;
                h = StockExtractDocument.DefaultPageSettings.Bounds.Height;

                StockExtractDialog.Document = StockExtractDocument;
                if (StockExtractDialog.ShowDialog() != DialogResult.Cancel)
                {
                    stockFormat.Alignment = StringAlignment.Center;
                    stockFormat.LineAlignment = StringAlignment.Center;
                    titleFormat.Alignment = StringAlignment.Center;
                    titleFormat.LineAlignment = StringAlignment.Center;
                    smallFormat.LineAlignment = StringAlignment.Center;
                    smallFormat.Alignment = StringAlignment.Far;
                    totalFormat.Alignment = StringAlignment.Far;
                    totalFormat.LineAlignment = StringAlignment.Center;

                    w = StockExtractDocument.DefaultPageSettings.Bounds.Width;
                    h = StockExtractDocument.DefaultPageSettings.Bounds.Height;

                    column_width = (w - x - 140) / 4;


                    StockExtractDocument.PrinterSettings = StockExtractDialog.Document.PrinterSettings;
                    StockExtractDocument.Print();
                }
            }
        }

        private void StockExtractDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            for (; DayIndex < ListStockExtract.Rows.Count; DayIndex++)
            {
                DataGridViewRow row = ListStockExtract.Rows[DayIndex];

                DateTime date_unformatted = DateTime.ParseExact(row.Cells["sale_date"].Value.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                string date = date_unformatted.ToString("yyyy-MM-dd");

                DataTable stock = controller.GetStock(date);
                int rows_total = stock.Rows.Count;

                if (header)
                {
                    e.Graphics.DrawString("Stock Extract", titleFont, Brushes.MidnightBlue, new Rectangle(x, y, w - 100, 30), titleFormat);
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
                    string line = "Stock Movement At Day " + row.Cells["sale_date"].Value.ToString();

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

                if (stockLabel)
                {
                    e.Graphics.DrawLines(Pens.MidnightBlue, new Point[] { new Point(x + 20, y + 25), new Point(x + 20, y + 50), new Point(x + 70, y + 50) });
                    y += 35;
                    e.Graphics.DrawString("Hour", stockFont, Brushes.MidnightBlue, new Rectangle(x + 90, y, column_width, 30), stockFormat);
                    e.Graphics.DrawString("Product", stockFont, Brushes.MidnightBlue, new Rectangle(x + 90 + column_width, y, column_width, 30), stockFormat);
                    e.Graphics.DrawString("Operation", stockFont, Brushes.MidnightBlue, new Rectangle(x + 90 + (column_width * 2), y, column_width, 30), stockFormat);
                    e.Graphics.DrawString("Alteration", stockFont, Brushes.MidnightBlue, new Rectangle(x + 90 + (column_width * 3), y, column_width, 30), stockFormat);

                    y += 31;

                    e.Graphics.DrawLine(Pens.MidnightBlue, new Point(x + 90, y), new Point(w - 50, y));

                    y += 1;

                    stockLabel = false;
                }

                for (; StockIndex < rows_total; StockIndex++)
                {
                    if (y >= h - 90)
                    {
                        e.HasMorePages = true;
                        y = 50;
                        return;
                    }

                    DateTime day = (DateTime)stock.Rows[StockIndex]["date"];
                    string hour = day.ToString("HH:mm:ss");

                    string operation = stock.Rows[StockIndex]["operation"].ToString();

                    string alteration = stock.Rows[StockIndex]["quantity"].ToString();

                    string product = controller.GetProductName((int)stock.Rows[StockIndex]["product_id"]);


                    e.Graphics.DrawString(hour, stockFont, Brushes.RoyalBlue, new Rectangle(x + 90, y, column_width, 30), stockFormat);
                    e.Graphics.DrawString(product, stockFont, Brushes.RoyalBlue, new Rectangle(x + 90 + column_width, y, column_width, 30), stockFormat);
                    e.Graphics.DrawString(operation, stockFont, Brushes.RoyalBlue, new Rectangle(x + 90 + (column_width * 2), y, column_width, 30), stockFormat);
                    e.Graphics.DrawString(alteration, stockFont, Brushes.RoyalBlue, new Rectangle(x + 90 + (column_width * 3), y, column_width, 30), stockFormat);

                    y += 31;

                    e.Graphics.DrawLine(Pens.MidnightBlue, new Point(x + 90, y), new Point(w - 50, y));

                    y += 1;
                }

                StockIndex = 0;

                dayLabel = true;
                stockLabel = true;

                y += 70;

                if (y >= h - 70)
                {
                    e.HasMorePages = true;
                    y = 50;
                    return;
                }
            }

           
            header = true;
            e.HasMorePages = false;
            DayIndex = 0;
            StockIndex = 0;
        }
    }
}
