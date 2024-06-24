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
    public partial class SalesView : Form
    {
        DataTable SalesPerDay;

        public SalesView()
        {
            InitializeComponent();
        }

        private void SalesView_Load(object sender, EventArgs e)
        {
            DBController controller = new DBController();

            SalesPerDay = controller.GetSales();

            FillSalesPerDay();
        }

        private void FillSalesPerDay()
        {
            SalesPerDayDataGrid.Rows.Clear();

            foreach (DataRow row in SalesPerDay.Rows)
            {
                string str_day = (string)row[0];
                string day = DateTime.ParseExact(str_day, "yyyy-MM-dd", CultureInfo.InvariantCulture).ToShortDateString();

                double total = Convert.ToDouble(row[1]);

                int rowIndex = SalesPerDayDataGrid.Rows.Add();
                SalesPerDayDataGrid.Rows[rowIndex].Cells["day"].Value = day;
                SalesPerDayDataGrid.Rows[rowIndex].Cells["total"].Value = total;
            }

            SalesPerDayDataGrid.Sort(SalesPerDayDataGrid.Columns["day"], ListSortDirection.Ascending);
        }

        private void SalesPerDayDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (SalesPerDayDataGrid.SelectedRows.Count > 0)
            {
                int index = SalesPerDayDataGrid.SelectedRows[0].Index;

                DataGridViewRow row = SalesPerDayDataGrid.SelectedRows[0];
                string day_str = row.Cells["day"].Value.ToString();

                DateTime day = DateTime.ParseExact(day_str, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                SalesViewDetailed s = new SalesViewDetailed(day);
                s.ShowDialog();

                double new_total = s.Total;

                SalesPerDayDataGrid.Rows[index].Cells["total"].Value = new_total.ToString("F2");
            }
        }
    }
}
