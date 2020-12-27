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
using System.IO;

namespace QuanLyQuanTraSua
{
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();

            // xoa dum file tmp hoac anh trong do cx dc
            //File.Delete("tmp");
            // tao lai file tmp
            //File.Create("tmp");
        }
        public void CanChinhViTri()
        {
            if (WindowState == FormWindowState.Maximized)
            {
                //panel2.Location = new Point(260,40);

            }
            //panel2.Location = new Point(260,40);
            //chartPie.Location = new Point(260, 40);
            //chartPie.Location = new Point(chartPie.Location.X + 30, chartPie.Location.Y + 30);
            //chartPie.Location = new Point(30, 60);
            // chartSellPercent.Location = new Point((splitContainer2.Panel1.Width - chartSellPercent.Width) / 2,
            //    (splitContainer2.Panel1.Height - gbtnReport.Height - chartSellPercent.Height - chartMoneyPercent.Height) * 26 / 50 + gbtnReport.Height);
            //chartMoneyPercent.Location = new Point((splitContainer2.Panel1.Width - chartSellPercent.Width) / 2,
            //    (splitContainer2.Panel1.Height - gbtnReport.Height - chartSellPercent.Height - chartMoneyPercent.Height) * 4 / 5 + gbtnReport.Height +chartSellPercent.Height);
            // chia docj theo 1,2,1,1 =>5 === 2,2,1
            //chartPie.ChartAreas(0).BackColor = Color.Orange;
            //chartPie.ChartAreas[0].BackColor = Color.Orange;
        }

        public void CanChinhKichThuoc()
        {
            //chartSellPercent.Size = new Size(splitContainer2.Panel1.Width * 95 / 100, splitContainer2.Panel1.Height * 4 / 10);
            //chartMoneyPercent.Size = new Size(splitContainer2.Panel1.Width * 95 / 100, splitContainer2.Panel1.Height * 4 / 10);
            //chartSellAndMoney.Size = new Size(splitContainer2.Panel2.Width * 99 / 100, splitContainer2.Panel2.Height * 7 / 10);

            //============
            //chartPie.Titles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            //MessageBox.Show(splitContainer2.Panel1.Width + "");

            var fontsiz = 1F;
            //int x = splitContainer2.Panel1.Width * 10 / 348;
            //MessageBox.Show(typeof(splitContainer2.Panel1.Width)+"");
            //for (int j = 0; j < x; j++)
            //   fontsiz += 1;
            //if (fontsiz == 0)
            //fontsiz = 1;
            //MessageBox.Show(x + "");
            //fontsiz += 10;
            foreach (var i in chartSellPercent.Titles)
            {
            i.Font = new System.Drawing.Font("Microsoft Sans Serif", fontsiz, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            }
            foreach (var i in chartMoneyPercent.Titles)
            {
            i.Font = new System.Drawing.Font("Microsoft Sans Serif", fontsiz, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            }
            foreach (var i in chartSellAndMoney.Titles)
            {
            i.Font = new System.Drawing.Font("Microsoft Sans Serif", fontsiz, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            }
            //==
            foreach( var i in chartSellPercent.Legends)
            {
                i.Font = new Font("Microsoft Sans Serif", fontsiz*2/3);
                i.TitleFont = new Font("Microsoft Sans Serif", fontsiz * 2 / 3,FontStyle.Bold);
            }
            foreach( var i in chartMoneyPercent.Legends)
            {
                i.Font = new Font("Microsoft Sans Serif", fontsiz*2/3);
                i.TitleFont = new Font("Microsoft Sans Serif", fontsiz * 2 / 3,FontStyle.Bold);
            }
            foreach( var i in chartSellAndMoney.Legends)
            {
                i.Font = new Font("Microsoft Sans Serif", fontsiz*2/3);
                i.TitleFont = new Font("Microsoft Sans Serif", fontsiz * 2 / 3,FontStyle.Bold);
            }
            //foreach (var i in chartPie.)
        }
        BillBUS billBUS = new BillBUS();

        DataTable dt;

        private bool dateReport = false;
        private bool monthReport = false;

        private int _day;
        private int _month;
        private int _year;

        // lay gia tri ngay, thang, nam
        private void getDateTime()
        {
            if (dateReport)
            {
                //DateTime date = cldDateTime.Value.Date;
                DateTime date = gunacldDateTime.Value.Date;
                _day = date.Day;
                _month = date.Month;
                _year = date.Year;
            }
            if (monthReport)
            {
                
                //_month = (this.cbbMonth.SelectedIndex) + 1;               
                _month = (this.gunacbbMonth.SelectedIndex) + 1;
                _year = DateTime.Now.Year;
            }
        }

        private void getData()
        {
            if (dateReport)
            {
                dt = billBUS.getReportByDate(_day, _month, _year);
            } else
            {
                if (monthReport)
                {
                    dt = billBUS.getReportByMonth(_month);
                }
            }
        }

        // ve chart
        private void paintChart()
        {

            // bieu do tron ti le so hang ban ra
            chartSellPercent.DataSource = dt;          
            chartSellPercent.Series["Drink"].XValueMember = "Name";
            chartSellPercent.Series["Drink"].YValueMembers = "PERCENTAGE_DRINK";
            chartSellPercent.Series["Drink"].ChartType = SeriesChartType.Pie;

            // bieu do tron ti le doanh thu   
            chartMoneyPercent.DataSource = dt;
            chartMoneyPercent.Series["Money"].XValueMember = "Name";
            chartMoneyPercent.Series["Money"].YValueMembers = "PERCENTAGE_MONEY";
            chartMoneyPercent.Series["Money"].ChartType = SeriesChartType.Pie;

            // bieu do cot doanh thu va so luong ban ra     
            chartSellAndMoney.DataSource = dt;
            chartSellAndMoney.Series[0].XValueMember = "Name";
            chartSellAndMoney.Series[0].YValueMembers = "SO_LUONG";
            chartSellAndMoney.ChartAreas[0].AxisX.Title = "Loại đồ uống";
            chartSellAndMoney.ChartAreas[0].AxisY.Title = "Số lượng";

            chartSellAndMoney.Series[1].XValueMember = "Name";
            chartSellAndMoney.Series[1].YValueMembers = "MONEY";

            chartSellAndMoney.Series[1].YAxisType = AxisType.Secondary;
            
            // xoa line truc x bieu do cot
            chartSellAndMoney.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chartSellAndMoney.ChartAreas[0].AxisX.MinorGrid.Enabled = false;

            // xoa line truc y 1 bieu do cot
            chartSellAndMoney.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chartSellAndMoney.ChartAreas[0].AxisY.MinorGrid.Enabled = false;

            // xoa line truc y 2 bieu do cot
            chartSellAndMoney.ChartAreas[0].AxisY2.MajorGrid.Enabled = false;
            chartSellAndMoney.ChartAreas[0].AxisY2.MinorGrid.Enabled = false;


            chartSellAndMoney.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;

            // hien thi label tung cot
            chartSellAndMoney.Series[0].IsValueShownAsLabel = true;
            chartSellAndMoney.Series[1].IsValueShownAsLabel = true;

            chartSellAndMoney.Series[0].ChartType = SeriesChartType.Column;
            chartSellAndMoney.Series[1].ChartType = SeriesChartType.Column;
        }

        // an chart
        private void hideChart()
        {
            chartSellPercent.Visible = false;
            chartSellAndMoney.Visible = false;
            chartMoneyPercent.Visible = false;
            lblIncomeMoney.Visible = false;
            lblNumber.Visible = false;
            gbtnPrint.Enabled = false;
            gpnlSumary.Visible = false;
        }

        // nut bao cao theo ngay
        private void gnbtnDateReport_Click(object sender, EventArgs e)
        {
            hideChart();
            dt = new DataTable();

            dateReport = true;
            monthReport = false;

            gunacldDateTime.Visible = true;
            gunacbbMonth.Visible = false;
            gbtnReport.Visible = true;

            gbtnReport_Click(sender, e);
        }

        // nut bao cao theo thang
        private void gnbtnMonthReport_Click(object sender, EventArgs e)
        {
            hideChart();
            dt = new DataTable();
            gbtnPrint.Enabled = false;

            dateReport = false;
            monthReport = true;

            gbtnReport.Visible = true;           
            gunacbbMonth.Visible = true;
            gunacldDateTime.Visible = false;

            // lay gia tri thang hien tai
            this.gunacbbMonth.SelectedIndex = DateTime.Now.Month - 1;

            gbtnReport_Click(sender, e);
        }

        // click report botton
        private void gbtnReport_Click(object sender, EventArgs e)
        {
            getDateTime();
            getData();
            gbtnPrint.Enabled = false;
            
            if (dt.Rows.Count == 0)
            {
                lblDataNull.Visible = true;
                gbtnPrint.Enabled = false;
                hideChart();
                return;
            } else
            {
                lblDataNull.Visible = false;
                gbtnPrint.Enabled = true; 
                gpnlSumary.Visible = true;

                chartSellPercent.Update();
                chartMoneyPercent.Update();
                chartSellAndMoney.Update();
                gbtnPrint.Enabled = true;
                
                chartSellAndMoney.Visible = true;
                chartSellPercent.Visible = true;
                chartMoneyPercent.Visible = true;
                
                paintChart();
                reportInfoChart();
                
            }

            
            //
            //CanChinhViTri();
        }

        private void reportInfoChart()
        {
            getInfoFromChart();
            lblIncomeMoney.Visible = true;
            lblNumber.Visible = true;
            if (dateReport)
            {
                lblIncomeMoney.Text = "Doanh thu ngay " + _day.ToString() + " thang " + _month.ToString() + " nam " + _year.ToString() + ": " + incomeMoney.ToString();
                lblNumber.Text = "So tien thu duoc trong ngay: " + numberSell.ToString();
            } else
            {
                if (monthReport)
                {
                    lblIncomeMoney.Text = "Doanh thu thang " + _month.ToString() + ": " + incomeMoney.ToString();
                    lblNumber.Text = "So tien thu duoc trong thang: " + numberSell.ToString();
                }
            }
        }

        private double incomeMoney;
        private int numberSell;
        private void getInfoFromChart()
        {
            incomeMoney = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                incomeMoney += Convert.ToInt32(dt.Rows[i].ItemArray[2].ToString());
                numberSell += Convert.ToInt32(dt.Rows[i].ItemArray[3].ToString());
            }
        }

        private void frmThongKe_SizeChanged(object sender, EventArgs e)
        {
            //CanChinhKichThuoc();
            //CanChinhViTri();
        }

        private int i = 0;
        private void gbtnPrint_Click(object sender, EventArgs e)
        {
           
            try
            {
                i++;
                chartSellPercent.SaveImage("tmp/sell_percent_tmp"+ i.ToString() +".jpg", ChartImageFormat.Jpeg);
                chartMoneyPercent.SaveImage("tmp/money_percent_tmp" + i.ToString() +".jpg", ChartImageFormat.Jpeg);
                chartSellAndMoney.SaveImage("tmp/sell_money_tmp"+ i.ToString() +".jpg", ChartImageFormat.Jpeg);
            }
            catch (Exception)
            {
                MessageBox.Show("Loi");
            }
            
            if (dateReport)
            {
                printReport pr = new printReport(_day, _month, _year, i, lblIncomeMoney.Text, lblNumber.Text);
                pr.exportReport();
            } 
            else
            {
                if (monthReport)
                {
                   printReport pr = new printReport(_month, _year, i, lblIncomeMoney.Text, lblNumber.Text);
                    pr.exportReport();
                }
            }
            
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            gunacldDateTime.Value = DateTime.Now;
        }
    }
}
