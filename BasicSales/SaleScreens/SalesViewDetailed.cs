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

namespace BasicSales.SaleScreens
{
    public partial class SalesViewDetailed : Form
    {
        DataTable Sales;
        DateTime day;

        public double Total;

        public SalesViewDetailed(DateTime d)
        {
            InitializeComponent();

            day = d;
            string formated_day = day.ToString("yyyy-MM-dd").Trim();

            DBController controller = new DBController();
            Sales = controller.GetSales(formated_day);
        }

        #region Actions
        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SalesViewDetailed_Load(object sender, EventArgs e)
        {
            FillSaleDetailedGrid();
            CalculeTotal();
        }

        private void SalesDetailedDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (SalesDetailedDataGrid.SelectedRows.Count > 0)
            {
                int id = (int)SalesDetailedDataGrid.SelectedRows[0].Cells["id"].Value;

                int index = SalesDetailedDataGrid.SelectedRows[0].Index;

                SalesViewChange s = new SalesViewChange(id);
                s.ShowDialog();

                if (s.altered)
                {
                    double new_total = s.Total;

                    SalesDetailedDataGrid.Rows[index].Cells["total"].Value = new_total.ToString("F2");

                    CalculeTotal();
                }
                if (s.deleted)
                {
                    SalesDetailedDataGrid.Rows.RemoveAt(index);

                    CalculeTotal();
                }
            }
        }

        #endregion

        private void FillSaleDetailedGrid()
        {
            SalesDetailedDataGrid.Rows.Clear();

            foreach (DataRow row in Sales.Rows)
            {
                DateTime hour = (DateTime)row["sale_date"];

                double v = double.Parse(row["total_price"].ToString());

                int rowIndex = SalesDetailedDataGrid.Rows.Add();
                SalesDetailedDataGrid.Rows[rowIndex].Cells["id"].Value = row["id"];
                SalesDetailedDataGrid.Rows[rowIndex].Cells["hour"].Value = hour.ToString("HH:mm:ss");
                SalesDetailedDataGrid.Rows[rowIndex].Cells["payment"].Value = row["payment"];
                SalesDetailedDataGrid.Rows[rowIndex].Cells["total"].Value = v.ToString("F2");
            }

            SalesDetailedDataGrid.Sort(SalesDetailedDataGrid.Columns["hour"], ListSortDirection.Ascending);
        }

        private void CalculeTotal()
        {
            if (SalesDetailedDataGrid.Rows.Count > 0)
            {
                double total = 0;

                foreach (DataGridViewRow row in SalesDetailedDataGrid.Rows)
                {
                    double v = double.Parse(row.Cells["total"].Value.ToString());

                    total += v;
                }

                lblTotal.Text = total.ToString("F2");

                Total = total;
            }
        }
    }
}
