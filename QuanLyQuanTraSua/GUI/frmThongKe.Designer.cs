
namespace QuanLyQuanTraSua
{
    partial class frmThongKe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.cldDateTime = new System.Windows.Forms.DateTimePicker();
            this.gnpnlGroupReport = new Guna.UI.WinForms.GunaGroupBox();
            this.gnbtnReportYear = new Guna.UI.WinForms.GunaButton();
            this.gnbtnReportMonth = new Guna.UI.WinForms.GunaButton();
            this.gnbtnDateReport = new Guna.UI.WinForms.GunaButton();
            this.chartSellAndMoney = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartSellPercent = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartMoneyPercent = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.gunacbbMonth = new Guna.UI.WinForms.GunaComboBox();
            this.gunacldDateTime = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gbtnReport = new Guna.UI.WinForms.GunaButton();
            this.cbbMonth = new System.Windows.Forms.ComboBox();
            this.gnpnlGroupReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSellAndMoney)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSellPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMoneyPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cldDateTime
            // 
            this.cldDateTime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cldDateTime.CalendarForeColor = System.Drawing.Color.Gray;
            this.cldDateTime.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cldDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cldDateTime.Location = new System.Drawing.Point(43, 14);
            this.cldDateTime.Name = "cldDateTime";
            this.cldDateTime.Size = new System.Drawing.Size(251, 26);
            this.cldDateTime.TabIndex = 0;
            this.cldDateTime.Visible = false;
            // 
            // gnpnlGroupReport
            // 
            this.gnpnlGroupReport.BackColor = System.Drawing.Color.Transparent;
            this.gnpnlGroupReport.BaseColor = System.Drawing.Color.White;
            this.gnpnlGroupReport.BorderColor = System.Drawing.Color.Gainsboro;
            this.gnpnlGroupReport.Controls.Add(this.gnbtnReportYear);
            this.gnpnlGroupReport.Controls.Add(this.gnbtnReportMonth);
            this.gnpnlGroupReport.Controls.Add(this.gnbtnDateReport);
            this.gnpnlGroupReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.882353F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gnpnlGroupReport.ForeColor = System.Drawing.Color.Gray;
            this.gnpnlGroupReport.LineColor = System.Drawing.Color.Gainsboro;
            this.gnpnlGroupReport.Location = new System.Drawing.Point(12, 14);
            this.gnpnlGroupReport.Name = "gnpnlGroupReport";
            this.gnpnlGroupReport.Radius = 10;
            this.gnpnlGroupReport.Size = new System.Drawing.Size(125, 187);
            this.gnpnlGroupReport.TabIndex = 23;
            this.gnpnlGroupReport.Text = "Thống kê theo";
            this.gnpnlGroupReport.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // gnbtnReportYear
            // 
            this.gnbtnReportYear.AnimationHoverSpeed = 0.07F;
            this.gnbtnReportYear.AnimationSpeed = 0.03F;
            this.gnbtnReportYear.BackColor = System.Drawing.Color.Transparent;
            this.gnbtnReportYear.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gnbtnReportYear.BorderColor = System.Drawing.Color.Black;
            this.gnbtnReportYear.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gnbtnReportYear.FocusedColor = System.Drawing.Color.Empty;
            this.gnbtnReportYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.gnbtnReportYear.ForeColor = System.Drawing.Color.White;
            this.gnbtnReportYear.Image = null;
            this.gnbtnReportYear.ImageSize = new System.Drawing.Size(20, 20);
            this.gnbtnReportYear.Location = new System.Drawing.Point(12, 136);
            this.gnbtnReportYear.Name = "gnbtnReportYear";
            this.gnbtnReportYear.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(79)))), ((int)(((byte)(229)))));
            this.gnbtnReportYear.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gnbtnReportYear.OnHoverForeColor = System.Drawing.Color.White;
            this.gnbtnReportYear.OnHoverImage = null;
            this.gnbtnReportYear.OnPressedColor = System.Drawing.Color.Black;
            this.gnbtnReportYear.Radius = 10;
            this.gnbtnReportYear.Size = new System.Drawing.Size(101, 40);
            this.gnbtnReportYear.TabIndex = 14;
            this.gnbtnReportYear.Text = "Năm";
            this.gnbtnReportYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gnbtnReportMonth
            // 
            this.gnbtnReportMonth.AnimationHoverSpeed = 0.07F;
            this.gnbtnReportMonth.AnimationSpeed = 0.03F;
            this.gnbtnReportMonth.BackColor = System.Drawing.Color.Transparent;
            this.gnbtnReportMonth.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gnbtnReportMonth.BorderColor = System.Drawing.Color.Black;
            this.gnbtnReportMonth.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gnbtnReportMonth.FocusedColor = System.Drawing.Color.Empty;
            this.gnbtnReportMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.gnbtnReportMonth.ForeColor = System.Drawing.Color.White;
            this.gnbtnReportMonth.Image = null;
            this.gnbtnReportMonth.ImageSize = new System.Drawing.Size(20, 20);
            this.gnbtnReportMonth.Location = new System.Drawing.Point(12, 88);
            this.gnbtnReportMonth.Name = "gnbtnReportMonth";
            this.gnbtnReportMonth.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(79)))), ((int)(((byte)(229)))));
            this.gnbtnReportMonth.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gnbtnReportMonth.OnHoverForeColor = System.Drawing.Color.White;
            this.gnbtnReportMonth.OnHoverImage = null;
            this.gnbtnReportMonth.OnPressedColor = System.Drawing.Color.Black;
            this.gnbtnReportMonth.Radius = 10;
            this.gnbtnReportMonth.Size = new System.Drawing.Size(101, 40);
            this.gnbtnReportMonth.TabIndex = 14;
            this.gnbtnReportMonth.Text = "Tháng";
            this.gnbtnReportMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gnbtnReportMonth.Click += new System.EventHandler(this.gnbtnMonthReport_Click);
            // 
            // gnbtnDateReport
            // 
            this.gnbtnDateReport.AnimationHoverSpeed = 0.07F;
            this.gnbtnDateReport.AnimationSpeed = 0.03F;
            this.gnbtnDateReport.BackColor = System.Drawing.Color.Transparent;
            this.gnbtnDateReport.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gnbtnDateReport.BorderColor = System.Drawing.Color.Black;
            this.gnbtnDateReport.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gnbtnDateReport.FocusedColor = System.Drawing.Color.Empty;
            this.gnbtnDateReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.gnbtnDateReport.ForeColor = System.Drawing.Color.White;
            this.gnbtnDateReport.Image = null;
            this.gnbtnDateReport.ImageSize = new System.Drawing.Size(20, 20);
            this.gnbtnDateReport.Location = new System.Drawing.Point(12, 40);
            this.gnbtnDateReport.Name = "gnbtnDateReport";
            this.gnbtnDateReport.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(79)))), ((int)(((byte)(229)))));
            this.gnbtnDateReport.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gnbtnDateReport.OnHoverForeColor = System.Drawing.Color.White;
            this.gnbtnDateReport.OnHoverImage = null;
            this.gnbtnDateReport.OnPressedColor = System.Drawing.Color.Black;
            this.gnbtnDateReport.Radius = 10;
            this.gnbtnDateReport.Size = new System.Drawing.Size(101, 40);
            this.gnbtnDateReport.TabIndex = 14;
            this.gnbtnDateReport.Text = "Ngày";
            this.gnbtnDateReport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gnbtnDateReport.Click += new System.EventHandler(this.gnbtnDateReport_Click);
            // 
            // chartSellAndMoney
            // 
            this.chartSellAndMoney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(177)))), ((int)(((byte)(186)))));
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(177)))), ((int)(((byte)(186)))));
            chartArea1.Name = "Sell Number";
            this.chartSellAndMoney.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(177)))), ((int)(((byte)(186)))));
            legend1.Name = "Legend1";
            this.chartSellAndMoney.Legends.Add(legend1);
            this.chartSellAndMoney.Location = new System.Drawing.Point(3, 126);
            this.chartSellAndMoney.Name = "chartSellAndMoney";
            series1.ChartArea = "Sell Number";
            series1.Legend = "Legend1";
            series1.Name = "Số lượng";
            series2.ChartArea = "Sell Number";
            series2.Legend = "Legend1";
            series2.Name = "Doanh thu";
            this.chartSellAndMoney.Series.Add(series1);
            this.chartSellAndMoney.Series.Add(series2);
            this.chartSellAndMoney.Size = new System.Drawing.Size(763, 617);
            this.chartSellAndMoney.TabIndex = 9;
            this.chartSellAndMoney.Text = "Collum chart";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            title1.Name = "Title1";
            title1.Text = "Số lượng bán và doanh thu";
            this.chartSellAndMoney.Titles.Add(title1);
            this.chartSellAndMoney.Visible = false;
            // 
            // chartSellPercent
            // 
            this.chartSellPercent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(177)))), ((int)(((byte)(186)))));
            this.chartSellPercent.BorderlineWidth = 5;
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(177)))), ((int)(((byte)(186)))));
            chartArea2.Name = "ChartArea1";
            this.chartSellPercent.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(177)))), ((int)(((byte)(186)))));
            legend2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.882353F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            legend2.Title = "Thức uống";
            legend2.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.882353F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartSellPercent.Legends.Add(legend2);
            this.chartSellPercent.Location = new System.Drawing.Point(24, 122);
            this.chartSellPercent.Name = "chartSellPercent";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.IsValueShownAsLabel = true;
            series3.LabelFormat = "#,##%";
            series3.Legend = "Legend1";
            series3.Name = "Drink";
            this.chartSellPercent.Series.Add(series3);
            this.chartSellPercent.Size = new System.Drawing.Size(412, 352);
            this.chartSellPercent.TabIndex = 8;
            this.chartSellPercent.Text = "Pie Chart";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            title2.Name = "Title1";
            title2.Text = "Tỉ lệ số sản phẩm bán ra";
            this.chartSellPercent.Titles.Add(title2);
            this.chartSellPercent.Visible = false;
            // 
            // chartMoneyPercent
            // 
            this.chartMoneyPercent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(177)))), ((int)(((byte)(186)))));
            chartArea3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(177)))), ((int)(((byte)(186)))));
            chartArea3.Name = "ChartArea1";
            this.chartMoneyPercent.ChartAreas.Add(chartArea3);
            legend3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(177)))), ((int)(((byte)(186)))));
            legend3.Name = "Money";
            legend3.Title = "Thức uống";
            this.chartMoneyPercent.Legends.Add(legend3);
            this.chartMoneyPercent.Location = new System.Drawing.Point(25, 441);
            this.chartMoneyPercent.Name = "chartMoneyPercent";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.IsValueShownAsLabel = true;
            series4.LabelFormat = "#,##%";
            series4.Legend = "Money";
            series4.Name = "Money";
            this.chartMoneyPercent.Series.Add(series4);
            this.chartMoneyPercent.Size = new System.Drawing.Size(412, 352);
            this.chartMoneyPercent.TabIndex = 10;
            this.chartMoneyPercent.Text = "Pie Chart";
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            title3.Name = "MoneyPercent";
            title3.Text = "Tỉ lệ doanh thu từng loại";
            this.chartMoneyPercent.Titles.Add(title3);
            this.chartMoneyPercent.Visible = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gnpnlGroupReport);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1354, 733);
            this.splitContainer1.SplitterDistance = 158;
            this.splitContainer1.TabIndex = 24;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.gunacbbMonth);
            this.splitContainer2.Panel1.Controls.Add(this.gunacldDateTime);
            this.splitContainer2.Panel1.Controls.Add(this.gbtnReport);
            this.splitContainer2.Panel1.Controls.Add(this.cbbMonth);
            this.splitContainer2.Panel1.Controls.Add(this.cldDateTime);
            this.splitContainer2.Panel1.Controls.Add(this.chartSellPercent);
            this.splitContainer2.Panel1.Controls.Add(this.chartMoneyPercent);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.chartSellAndMoney);
            this.splitContainer2.Size = new System.Drawing.Size(1192, 733);
            this.splitContainer2.SplitterDistance = 463;
            this.splitContainer2.TabIndex = 0;
            // 
            // gunacbbMonth
            // 
            this.gunacbbMonth.BackColor = System.Drawing.Color.Transparent;
            this.gunacbbMonth.BaseColor = System.Drawing.Color.White;
            this.gunacbbMonth.BorderColor = System.Drawing.Color.Silver;
            this.gunacbbMonth.BorderSize = 1;
            this.gunacbbMonth.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gunacbbMonth.DropDownHeight = 107;
            this.gunacbbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gunacbbMonth.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunacbbMonth.Font = new System.Drawing.Font("Segoe UI", 12.70588F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunacbbMonth.ForeColor = System.Drawing.Color.Black;
            this.gunacbbMonth.FormattingEnabled = true;
            this.gunacbbMonth.IntegralHeight = false;
            this.gunacbbMonth.Items.AddRange(new object[] {
            "Tháng Một",
            "Tháng Hai",
            "Tháng Ba",
            "Tháng Bốn ",
            "Tháng Năm",
            "Tháng Sáu",
            "Tháng Bảy",
            "Tháng Tám",
            "Tháng Chín",
            "Tháng Mười",
            "Tháng Mười Một",
            "Tháng Mười Hai"});
            this.gunacbbMonth.Location = new System.Drawing.Point(103, 13);
            this.gunacbbMonth.Name = "gunacbbMonth";
            this.gunacbbMonth.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunacbbMonth.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gunacbbMonth.Radius = 5;
            this.gunacbbMonth.Size = new System.Drawing.Size(174, 31);
            this.gunacbbMonth.TabIndex = 12;
            this.gunacbbMonth.Visible = false;
            // 
            // gunacldDateTime
            // 
            this.gunacldDateTime.BackColor = System.Drawing.Color.Transparent;
            this.gunacldDateTime.BaseColor = System.Drawing.Color.White;
            this.gunacldDateTime.BorderColor = System.Drawing.Color.Silver;
            this.gunacldDateTime.BorderSize = 1;
            this.gunacldDateTime.CustomFormat = null;
            this.gunacldDateTime.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.gunacldDateTime.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunacldDateTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunacldDateTime.ForeColor = System.Drawing.Color.Black;
            this.gunacldDateTime.Location = new System.Drawing.Point(0, 11);
            this.gunacldDateTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.gunacldDateTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.gunacldDateTime.Name = "gunacldDateTime";
            this.gunacldDateTime.OnHoverBaseColor = System.Drawing.Color.White;
            this.gunacldDateTime.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunacldDateTime.OnHoverForeColor = System.Drawing.Color.Black;
            this.gunacldDateTime.OnPressedColor = System.Drawing.Color.Black;
            this.gunacldDateTime.Radius = 5;
            this.gunacldDateTime.Size = new System.Drawing.Size(277, 36);
            this.gunacldDateTime.TabIndex = 11;
            this.gunacldDateTime.Text = "09 Tháng Mười Hai 2020";
            this.gunacldDateTime.Value = new System.DateTime(2020, 12, 9, 10, 58, 29, 705);
            this.gunacldDateTime.Visible = false;
            // 
            // gbtnReport
            // 
            this.gbtnReport.AnimationHoverSpeed = 0.07F;
            this.gbtnReport.AnimationSpeed = 0.03F;
            this.gbtnReport.BackColor = System.Drawing.Color.Transparent;
            this.gbtnReport.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gbtnReport.BorderColor = System.Drawing.Color.Black;
            this.gbtnReport.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gbtnReport.FocusedColor = System.Drawing.Color.Empty;
            this.gbtnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.gbtnReport.ForeColor = System.Drawing.Color.White;
            this.gbtnReport.Image = null;
            this.gbtnReport.ImageSize = new System.Drawing.Size(20, 20);
            this.gbtnReport.Location = new System.Drawing.Point(300, 12);
            this.gbtnReport.Name = "gbtnReport";
            this.gbtnReport.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(79)))), ((int)(((byte)(229)))));
            this.gbtnReport.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gbtnReport.OnHoverForeColor = System.Drawing.Color.White;
            this.gbtnReport.OnHoverImage = null;
            this.gbtnReport.OnPressedColor = System.Drawing.Color.Black;
            this.gbtnReport.Radius = 10;
            this.gbtnReport.Size = new System.Drawing.Size(79, 31);
            this.gbtnReport.TabIndex = 14;
            this.gbtnReport.Text = "Report";
            this.gbtnReport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gbtnReport.Visible = false;
            this.gbtnReport.Click += new System.EventHandler(this.gbtnReport_Click);
            // 
            // cbbMonth
            // 
            this.cbbMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbMonth.FormattingEnabled = true;
            this.cbbMonth.Items.AddRange(new object[] {
            "Tháng Một",
            "Tháng Hai",
            "Tháng Ba",
            "Tháng Bốn ",
            "Tháng Năm",
            "Tháng Sáu",
            "Tháng Bảy",
            "Tháng Tám",
            "Tháng Chín",
            "Tháng Mười",
            "Tháng Mười Một",
            "Tháng Mười Hai"});
            this.cbbMonth.Location = new System.Drawing.Point(61, 12);
            this.cbbMonth.Name = "cbbMonth";
            this.cbbMonth.Size = new System.Drawing.Size(208, 28);
            this.cbbMonth.TabIndex = 6;
            this.cbbMonth.Visible = false;
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(177)))), ((int)(((byte)(186)))));
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmThongKe";
            this.Text = "frmThongKe";
            this.SizeChanged += new System.EventHandler(this.frmThongKe_SizeChanged);
            this.gnpnlGroupReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartSellAndMoney)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSellPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMoneyPercent)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker cldDateTime;
        private Guna.UI.WinForms.GunaGroupBox gnpnlGroupReport;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSellAndMoney;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSellPercent;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMoneyPercent;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private Guna.UI.WinForms.GunaDateTimePicker gunacldDateTime;
        private Guna.UI.WinForms.GunaComboBox gunacbbMonth;
        private Guna.UI.WinForms.GunaButton gnbtnDateReport;
        private Guna.UI.WinForms.GunaButton gnbtnReportYear;
        private Guna.UI.WinForms.GunaButton gnbtnReportMonth;
        private Guna.UI.WinForms.GunaButton gbtnReport;
        private System.Windows.Forms.ComboBox cbbMonth;
    }
}