using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Diagnostics;
using BUS;

namespace QuanLyQuanTraSua
{
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
        }

        private void chartPie_Click(object sender, EventArgs e)
        {

        }
        AccountBUS accountBUS = new AccountBUS();
        DataTable dt;
        private int _day;
        private int _month;
        private int _year;

        private void btnReport_Click(object sender, EventArgs e)
        {
            DateTime date = cldDateTime.Value.Date;
            _day = date.Day;
            _month = date.Month;
            _year = date.Year;

            dt = new DataTable();

            chartPie.Update();
            dt = accountBUS.getReportByDate(_day, _month, _year);
            chartPie.DataSource = dt;

            chartPie.Series["Drink"].XValueMember = "Name";
            chartPie.Series["Drink"].YValueMembers = "PERCENTAGE";
            chartPie.Series["Drink"].ChartType = SeriesChartType.Pie;

            chartCollum.Update();
            chartCollum.DataSource = dt;
            chartCollum.Series["Sell Number"].XValueMember = "Name";
            chartCollum.Series["Sell Number"].YValueMembers = "SO_LUONG";
            chartCollum.ChartAreas["Sell Number"].AxisX.Title = "Loại đồ uống";
            chartCollum.ChartAreas["Sell Number"].AxisY.Title = "Số lượng";

            chartCollum.Series["Sell Money"].XValueMember = "Name";
            chartCollum.Series["Sell Money"].YValueMembers = "MONEY";
            // chartCollum.Series["Sell Moeny"].YAxisType = AxisName.Y2;
            chartCollum.Series["Sell Money"].YAxisType = AxisType.Secondary;

            //chartCollum.ChartAreas["Sell Money"].AxisY2.Enabled = AxisEnabled.True;
            //chartCollum.ChartAreas["Sell Money"].AxisY2.IsStartedFromZero = chartCollum.ChartAreas["Sell Money"].AxisY.IsStartedFromZero;

            chartCollum.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chartCollum.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
            chartCollum.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chartCollum.ChartAreas[0].AxisY.MinorGrid.Enabled = false;

            chartCollum.Series["Sell Number"].IsValueShownAsLabel = true;
            chartCollum.Series["Sell Money"].IsValueShownAsLabel = true;

            chartCollum.Series["Sell Number"].ChartType = SeriesChartType.Column;
            chartCollum.Series["Sell Money"].ChartType = SeriesChartType.Column;
        }
    }
}
