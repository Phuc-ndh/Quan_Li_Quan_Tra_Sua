
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.btnDateReport = new System.Windows.Forms.Button();
            this.btnMonthReport = new System.Windows.Forms.Button();
            this.btnYearReport = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReport = new System.Windows.Forms.Button();
            this.cldDateTime = new System.Windows.Forms.DateTimePicker();
            this.chartPie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartCollum = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCollum)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDateReport
            // 
            this.btnDateReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnDateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDateReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDateReport.ForeColor = System.Drawing.Color.White;
            this.btnDateReport.Location = new System.Drawing.Point(0, 1);
            this.btnDateReport.Name = "btnDateReport";
            this.btnDateReport.Size = new System.Drawing.Size(111, 52);
            this.btnDateReport.TabIndex = 2;
            this.btnDateReport.Text = "Theo ngày";
            this.btnDateReport.UseVisualStyleBackColor = false;
            // 
            // btnMonthReport
            // 
            this.btnMonthReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnMonthReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonthReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnMonthReport.ForeColor = System.Drawing.Color.White;
            this.btnMonthReport.Location = new System.Drawing.Point(0, 50);
            this.btnMonthReport.Name = "btnMonthReport";
            this.btnMonthReport.Size = new System.Drawing.Size(111, 52);
            this.btnMonthReport.TabIndex = 3;
            this.btnMonthReport.Text = "Theo tháng";
            this.btnMonthReport.UseVisualStyleBackColor = false;
            // 
            // btnYearReport
            // 
            this.btnYearReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnYearReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYearReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnYearReport.ForeColor = System.Drawing.Color.White;
            this.btnYearReport.Location = new System.Drawing.Point(0, 98);
            this.btnYearReport.Name = "btnYearReport";
            this.btnYearReport.Size = new System.Drawing.Size(111, 52);
            this.btnYearReport.TabIndex = 4;
            this.btnYearReport.Text = "Theo năm";
            this.btnYearReport.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.panel1.Controls.Add(this.chartCollum);
            this.panel1.Controls.Add(this.chartPie);
            this.panel1.Controls.Add(this.btnReport);
            this.panel1.Controls.Add(this.cldDateTime);
            this.panel1.Location = new System.Drawing.Point(107, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1245, 718);
            this.panel1.TabIndex = 5;
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnReport.Location = new System.Drawing.Point(300, 13);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(94, 26);
            this.btnReport.TabIndex = 3;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // cldDateTime
            // 
            this.cldDateTime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cldDateTime.CalendarForeColor = System.Drawing.Color.Gray;
            this.cldDateTime.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cldDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cldDateTime.Location = new System.Drawing.Point(8, 11);
            this.cldDateTime.Name = "cldDateTime";
            this.cldDateTime.Size = new System.Drawing.Size(251, 26);
            this.cldDateTime.TabIndex = 0;
            // 
            // chartPie
            // 
            chartArea2.Name = "ChartArea1";
            this.chartPie.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartPie.Legends.Add(legend2);
            this.chartPie.Location = new System.Drawing.Point(10, 49);
            this.chartPie.Name = "chartPie";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.IsValueShownAsLabel = true;
            series3.LabelFormat = "#,##%";
            series3.Legend = "Legend1";
            series3.Name = "Drink";
            this.chartPie.Series.Add(series3);
            this.chartPie.Size = new System.Drawing.Size(458, 404);
            this.chartPie.TabIndex = 4;
            this.chartPie.Text = "Pie Chart";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            title2.Name = "Title1";
            title2.Text = "Tỉ lệ bán hàng";
            this.chartPie.Titles.Add(title2);
            this.chartPie.Click += new System.EventHandler(this.chartPie_Click);
            // 
            // chartCollum
            // 
            chartArea1.Name = "Sell Number";
            this.chartCollum.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartCollum.Legends.Add(legend1);
            this.chartCollum.Location = new System.Drawing.Point(489, 49);
            this.chartCollum.Name = "chartCollum";
            series1.ChartArea = "Sell Number";
            series1.Legend = "Legend1";
            series1.Name = "Sell Number";
            series2.ChartArea = "Sell Number";
            series2.Legend = "Legend1";
            series2.Name = "Sell Money";
            this.chartCollum.Series.Add(series1);
            this.chartCollum.Series.Add(series2);
            this.chartCollum.Size = new System.Drawing.Size(559, 404);
            this.chartCollum.TabIndex = 5;
            this.chartCollum.Text = "Collum chart";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            title1.Name = "Title1";
            title1.Text = "Số lượng bán và doanh thu";
            this.chartCollum.Titles.Add(title1);
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnYearReport);
            this.Controls.Add(this.btnMonthReport);
            this.Controls.Add(this.btnDateReport);
            this.Name = "frmThongKe";
            this.Text = "frmThongKe";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartPie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCollum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDateReport;
        private System.Windows.Forms.Button btnMonthReport;
        private System.Windows.Forms.Button btnYearReport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPie;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.DateTimePicker cldDateTime;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCollum;
    }
}