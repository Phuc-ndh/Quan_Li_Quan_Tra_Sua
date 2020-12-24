
namespace QuanLyQuanTraSua
{
    partial class frmMatHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gDataGridView1 = new Guna.UI.WinForms.GunaDataGridView();
            this.panelThongTinMH = new System.Windows.Forms.Panel();
            this.gunaGroupBoxThongTinMH = new Guna.UI.WinForms.GunaGroupBox();
            this.lblGia = new System.Windows.Forms.Label();
            this.gtxtTenMatHang = new Guna.UI.WinForms.GunaTextBox();
            this.gtxtGia = new Guna.UI.WinForms.GunaTextBox();
            this.lblLoai = new System.Windows.Forms.Label();
            this.gcbbLoai = new Guna.UI.WinForms.GunaComboBox();
            this.lblTenMatHang = new System.Windows.Forms.Label();
            this.panelButton = new System.Windows.Forms.Panel();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            this.btnSua = new FontAwesome.Sharp.IconButton();
            this.gunaGroupBox2 = new Guna.UI.WinForms.GunaGroupBox();
            this.gunaCheckBox1 = new Guna.UI.WinForms.GunaCheckBox();
            this.gunaCheckBox2 = new Guna.UI.WinForms.GunaCheckBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pnlData = new System.Windows.Forms.Panel();
            this.pnlCustom = new System.Windows.Forms.Panel();
            this.panelFull = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gDataGridView1)).BeginInit();
            this.panelThongTinMH.SuspendLayout();
            this.gunaGroupBoxThongTinMH.SuspendLayout();
            this.panelButton.SuspendLayout();
            this.gunaGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelFull.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 44;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(950, 798);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // gDataGridView1
            // 
            this.gDataGridView1.AllowUserToResizeColumns = false;
            this.gDataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.gDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gDataGridView1.ColumnHeadersHeight = 32;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 13.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.gDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gDataGridView1.EnableHeadersVisualStyles = false;
            this.gDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gDataGridView1.Location = new System.Drawing.Point(0, 0);
            this.gDataGridView1.Name = "gDataGridView1";
            this.gDataGridView1.ReadOnly = true;
            this.gDataGridView1.RowHeadersVisible = false;
            this.gDataGridView1.RowHeadersWidth = 44;
            this.gDataGridView1.RowTemplate.Height = 35;
            this.gDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gDataGridView1.Size = new System.Drawing.Size(818, 798);
            this.gDataGridView1.TabIndex = 1;
            this.gDataGridView1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gDataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gDataGridView1.ThemeStyle.HeaderStyle.Height = 32;
            this.gDataGridView1.ThemeStyle.ReadOnly = true;
            this.gDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gDataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 13.5F);
            this.gDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gDataGridView1.ThemeStyle.RowsStyle.Height = 35;
            this.gDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gDataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // panelThongTinMH
            // 
            this.panelThongTinMH.Controls.Add(this.panelButton);
            this.panelThongTinMH.Controls.Add(this.gunaGroupBoxThongTinMH);
            this.panelThongTinMH.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelThongTinMH.Location = new System.Drawing.Point(0, 0);
            this.panelThongTinMH.Name = "panelThongTinMH";
            this.panelThongTinMH.Size = new System.Drawing.Size(621, 385);
            this.panelThongTinMH.TabIndex = 32;
            // 
            // gunaGroupBoxThongTinMH
            // 
            this.gunaGroupBoxThongTinMH.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBoxThongTinMH.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBoxThongTinMH.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBoxThongTinMH.Controls.Add(this.lblTenMatHang);
            this.gunaGroupBoxThongTinMH.Controls.Add(this.gcbbLoai);
            this.gunaGroupBoxThongTinMH.Controls.Add(this.lblLoai);
            this.gunaGroupBoxThongTinMH.Controls.Add(this.gtxtGia);
            this.gunaGroupBoxThongTinMH.Controls.Add(this.gtxtTenMatHang);
            this.gunaGroupBoxThongTinMH.Controls.Add(this.lblGia);
            this.gunaGroupBoxThongTinMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.882353F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBoxThongTinMH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaGroupBoxThongTinMH.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBoxThongTinMH.Location = new System.Drawing.Point(27, 54);
            this.gunaGroupBoxThongTinMH.Name = "gunaGroupBoxThongTinMH";
            this.gunaGroupBoxThongTinMH.Radius = 10;
            this.gunaGroupBoxThongTinMH.Size = new System.Drawing.Size(426, 211);
            this.gunaGroupBoxThongTinMH.TabIndex = 22;
            this.gunaGroupBoxThongTinMH.Text = "Thông tin mặt hàng";
            this.gunaGroupBoxThongTinMH.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGia.Location = new System.Drawing.Point(34, 154);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(87, 20);
            this.lblGia.TabIndex = 17;
            this.lblGia.Text = "Giá (VNĐ)";
            // 
            // gtxtTenMatHang
            // 
            this.gtxtTenMatHang.BackColor = System.Drawing.Color.Transparent;
            this.gtxtTenMatHang.BaseColor = System.Drawing.Color.White;
            this.gtxtTenMatHang.BorderColor = System.Drawing.Color.Silver;
            this.gtxtTenMatHang.BorderSize = 1;
            this.gtxtTenMatHang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxtTenMatHang.FocusedBaseColor = System.Drawing.Color.White;
            this.gtxtTenMatHang.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gtxtTenMatHang.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gtxtTenMatHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gtxtTenMatHang.Location = new System.Drawing.Point(159, 60);
            this.gtxtTenMatHang.Name = "gtxtTenMatHang";
            this.gtxtTenMatHang.PasswordChar = '\0';
            this.gtxtTenMatHang.Radius = 10;
            this.gtxtTenMatHang.SelectedText = "";
            this.gtxtTenMatHang.Size = new System.Drawing.Size(211, 33);
            this.gtxtTenMatHang.TabIndex = 20;
            this.gtxtTenMatHang.TextOffsetX = 10;
            // 
            // gtxtGia
            // 
            this.gtxtGia.BackColor = System.Drawing.Color.Transparent;
            this.gtxtGia.BaseColor = System.Drawing.Color.White;
            this.gtxtGia.BorderColor = System.Drawing.Color.Silver;
            this.gtxtGia.BorderSize = 1;
            this.gtxtGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxtGia.FocusedBaseColor = System.Drawing.Color.White;
            this.gtxtGia.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gtxtGia.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gtxtGia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gtxtGia.Location = new System.Drawing.Point(159, 147);
            this.gtxtGia.Name = "gtxtGia";
            this.gtxtGia.PasswordChar = '\0';
            this.gtxtGia.Radius = 10;
            this.gtxtGia.SelectedText = "";
            this.gtxtGia.Size = new System.Drawing.Size(211, 33);
            this.gtxtGia.TabIndex = 20;
            this.gtxtGia.TextOffsetX = 10;
            // 
            // lblLoai
            // 
            this.lblLoai.AutoSize = true;
            this.lblLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoai.Location = new System.Drawing.Point(34, 112);
            this.lblLoai.Name = "lblLoai";
            this.lblLoai.Size = new System.Drawing.Size(41, 20);
            this.lblLoai.TabIndex = 14;
            this.lblLoai.Text = "Loại";
            // 
            // gcbbLoai
            // 
            this.gcbbLoai.BackColor = System.Drawing.Color.Transparent;
            this.gcbbLoai.BaseColor = System.Drawing.Color.White;
            this.gcbbLoai.BorderColor = System.Drawing.Color.Silver;
            this.gcbbLoai.BorderSize = 1;
            this.gcbbLoai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gcbbLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gcbbLoai.FocusedColor = System.Drawing.Color.Empty;
            this.gcbbLoai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcbbLoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gcbbLoai.FormattingEnabled = true;
            this.gcbbLoai.Location = new System.Drawing.Point(159, 105);
            this.gcbbLoai.Name = "gcbbLoai";
            this.gcbbLoai.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gcbbLoai.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gcbbLoai.Radius = 10;
            this.gcbbLoai.Size = new System.Drawing.Size(142, 31);
            this.gcbbLoai.TabIndex = 21;
            // 
            // lblTenMatHang
            // 
            this.lblTenMatHang.AutoSize = true;
            this.lblTenMatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenMatHang.Location = new System.Drawing.Point(34, 68);
            this.lblTenMatHang.Name = "lblTenMatHang";
            this.lblTenMatHang.Size = new System.Drawing.Size(111, 20);
            this.lblTenMatHang.TabIndex = 13;
            this.lblTenMatHang.Text = "Tên mặt hàng";
            // 
            // panelButton
            // 
            this.panelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(177)))), ((int)(((byte)(186)))));
            this.panelButton.Controls.Add(this.btnSua);
            this.panelButton.Controls.Add(this.btnThem);
            this.panelButton.Controls.Add(this.btnXoa);
            this.panelButton.Location = new System.Drawing.Point(28, 288);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(451, 45);
            this.panelButton.TabIndex = 10;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnXoa.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            this.btnXoa.IconColor = System.Drawing.Color.White;
            this.btnXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoa.IconSize = 30;
            this.btnXoa.Location = new System.Drawing.Point(322, 0);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnXoa.Size = new System.Drawing.Size(129, 45);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnThem.IconColor = System.Drawing.Color.White;
            this.btnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThem.IconSize = 28;
            this.btnThem.Location = new System.Drawing.Point(0, 0);
            this.btnThem.Name = "btnThem";
            this.btnThem.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnThem.Size = new System.Drawing.Size(129, 45);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.btnSua.IconColor = System.Drawing.Color.White;
            this.btnSua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSua.IconSize = 30;
            this.btnSua.Location = new System.Drawing.Point(163, 0);
            this.btnSua.Name = "btnSua";
            this.btnSua.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnSua.Size = new System.Drawing.Size(129, 45);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // gunaGroupBox2
            // 
            this.gunaGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox2.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox2.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox2.Controls.Add(this.gunaCheckBox2);
            this.gunaGroupBox2.Controls.Add(this.gunaCheckBox1);
            this.gunaGroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.176471F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox2.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox2.Location = new System.Drawing.Point(94, 391);
            this.gunaGroupBox2.Name = "gunaGroupBox2";
            this.gunaGroupBox2.Radius = 9;
            this.gunaGroupBox2.Size = new System.Drawing.Size(282, 131);
            this.gunaGroupBox2.TabIndex = 31;
            this.gunaGroupBox2.Text = "Tùy chỉnh";
            this.gunaGroupBox2.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // gunaCheckBox1
            // 
            this.gunaCheckBox1.BaseColor = System.Drawing.Color.White;
            this.gunaCheckBox1.CheckedOffColor = System.Drawing.Color.Gray;
            this.gunaCheckBox1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaCheckBox1.FillColor = System.Drawing.Color.White;
            this.gunaCheckBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.29412F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaCheckBox1.Location = new System.Drawing.Point(42, 52);
            this.gunaCheckBox1.Name = "gunaCheckBox1";
            this.gunaCheckBox1.Size = new System.Drawing.Size(214, 22);
            this.gunaCheckBox1.TabIndex = 25;
            this.gunaCheckBox1.Text = "Điều chỉnh kích thước cột";
            this.gunaCheckBox1.CheckedChanged += new System.EventHandler(this.gunaCheckBox1_CheckedChanged);
            // 
            // gunaCheckBox2
            // 
            this.gunaCheckBox2.BaseColor = System.Drawing.Color.White;
            this.gunaCheckBox2.CheckedOffColor = System.Drawing.Color.Gray;
            this.gunaCheckBox2.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaCheckBox2.FillColor = System.Drawing.Color.White;
            this.gunaCheckBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.29412F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaCheckBox2.Location = new System.Drawing.Point(42, 80);
            this.gunaCheckBox2.Name = "gunaCheckBox2";
            this.gunaCheckBox2.Size = new System.Drawing.Size(229, 22);
            this.gunaCheckBox2.TabIndex = 25;
            this.gunaCheckBox2.Text = "Điều chỉnh kích thước hàng";
            this.gunaCheckBox2.CheckedChanged += new System.EventHandler(this.gunaCheckBox2_CheckedChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(177)))), ((int)(((byte)(186)))));
            this.splitContainer1.Panel1.Controls.Add(this.gunaGroupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.panelThongTinMH);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gDataGridView1);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(1443, 798);
            this.splitContainer1.SplitterDistance = 621;
            this.splitContainer1.TabIndex = 33;
            // 
            // pnlData
            // 
            this.pnlData.AutoSize = true;
            this.pnlData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.pnlData.Location = new System.Drawing.Point(504, 0);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(1008, 935);
            this.pnlData.TabIndex = 1;
            // 
            // pnlCustom
            // 
            this.pnlCustom.AutoSize = true;
            this.pnlCustom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(177)))), ((int)(((byte)(186)))));
            this.pnlCustom.Location = new System.Drawing.Point(0, 0);
            this.pnlCustom.Name = "pnlCustom";
            this.pnlCustom.Size = new System.Drawing.Size(557, 798);
            this.pnlCustom.TabIndex = 0;
            // 
            // panelFull
            // 
            this.panelFull.Controls.Add(this.pnlCustom);
            this.panelFull.Controls.Add(this.pnlData);
            this.panelFull.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFull.Location = new System.Drawing.Point(0, 0);
            this.panelFull.Name = "panelFull";
            this.panelFull.Size = new System.Drawing.Size(1443, 798);
            this.panelFull.TabIndex = 0;
            // 
            // frmMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 798);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panelFull);
            this.Name = "frmMatHang";
            this.Text = "frmMatHang";
            this.Load += new System.EventHandler(this.frmMatHang_Load);
            this.SizeChanged += new System.EventHandler(this.frmMatHang_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gDataGridView1)).EndInit();
            this.panelThongTinMH.ResumeLayout(false);
            this.gunaGroupBoxThongTinMH.ResumeLayout(false);
            this.gunaGroupBoxThongTinMH.PerformLayout();
            this.panelButton.ResumeLayout(false);
            this.gunaGroupBox2.ResumeLayout(false);
            this.gunaGroupBox2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelFull.ResumeLayout(false);
            this.panelFull.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI.WinForms.GunaDataGridView gDataGridView1;
        private System.Windows.Forms.Panel panelThongTinMH;
        private System.Windows.Forms.Panel panelButton;
        private FontAwesome.Sharp.IconButton btnSua;
        private FontAwesome.Sharp.IconButton btnThem;
        private FontAwesome.Sharp.IconButton btnXoa;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBoxThongTinMH;
        private System.Windows.Forms.Label lblTenMatHang;
        private Guna.UI.WinForms.GunaComboBox gcbbLoai;
        private System.Windows.Forms.Label lblLoai;
        private Guna.UI.WinForms.GunaTextBox gtxtGia;
        private Guna.UI.WinForms.GunaTextBox gtxtTenMatHang;
        private System.Windows.Forms.Label lblGia;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox2;
        private Guna.UI.WinForms.GunaCheckBox gunaCheckBox2;
        public Guna.UI.WinForms.GunaCheckBox gunaCheckBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.Panel pnlCustom;
        private System.Windows.Forms.Panel panelFull;
    }
}