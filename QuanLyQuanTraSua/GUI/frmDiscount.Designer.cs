﻿
namespace QuanLyQuanTraSua
{
    partial class frmDiscount
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panelThongTinGG = new System.Windows.Forms.Panel();
            this.panelButton = new System.Windows.Forms.Panel();
            this.btnSua = new FontAwesome.Sharp.IconButton();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.gunaGroupBoxThongTinGG = new Guna.UI.WinForms.GunaGroupBox();
            this.lblMaGiamGia = new System.Windows.Forms.Label();
            this.gtxtGiaTriGiam = new Guna.UI.WinForms.GunaTextBox();
            this.gtxtMaGiamGia = new Guna.UI.WinForms.GunaTextBox();
            this.lblGiaTriGiam = new System.Windows.Forms.Label();
            this.gDataGridView1 = new Guna.UI.WinForms.GunaDataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelThongTinGG.SuspendLayout();
            this.panelButton.SuspendLayout();
            this.gunaGroupBoxThongTinGG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(177)))), ((int)(((byte)(186)))));
            this.splitContainer1.Panel1.Controls.Add(this.panelThongTinGG);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gDataGridView1);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(1805, 902);
            this.splitContainer1.SplitterDistance = 775;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 34;
            // 
            // panelThongTinGG
            // 
            this.panelThongTinGG.Controls.Add(this.panelButton);
            this.panelThongTinGG.Controls.Add(this.gunaGroupBoxThongTinGG);
            this.panelThongTinGG.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelThongTinGG.Location = new System.Drawing.Point(0, 0);
            this.panelThongTinGG.Margin = new System.Windows.Forms.Padding(4);
            this.panelThongTinGG.Name = "panelThongTinGG";
            this.panelThongTinGG.Size = new System.Drawing.Size(775, 422);
            this.panelThongTinGG.TabIndex = 32;
            // 
            // panelButton
            // 
            this.panelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(177)))), ((int)(((byte)(186)))));
            this.panelButton.Controls.Add(this.btnSua);
            this.panelButton.Controls.Add(this.btnThem);
            this.panelButton.Controls.Add(this.btnXoa);
            this.panelButton.Location = new System.Drawing.Point(37, 318);
            this.panelButton.Margin = new System.Windows.Forms.Padding(4);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(601, 55);
            this.panelButton.TabIndex = 10;
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
            this.btnSua.Location = new System.Drawing.Point(216, 0);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.btnSua.Size = new System.Drawing.Size(172, 55);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = false;
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
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.btnThem.Size = new System.Drawing.Size(172, 55);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
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
            this.btnXoa.Location = new System.Drawing.Point(429, 0);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.btnXoa.Size = new System.Drawing.Size(172, 55);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // gunaGroupBoxThongTinGG
            // 
            this.gunaGroupBoxThongTinGG.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBoxThongTinGG.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBoxThongTinGG.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBoxThongTinGG.Controls.Add(this.lblMaGiamGia);
            this.gunaGroupBoxThongTinGG.Controls.Add(this.gtxtGiaTriGiam);
            this.gunaGroupBoxThongTinGG.Controls.Add(this.gtxtMaGiamGia);
            this.gunaGroupBoxThongTinGG.Controls.Add(this.lblGiaTriGiam);
            this.gunaGroupBoxThongTinGG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.882353F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBoxThongTinGG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaGroupBoxThongTinGG.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBoxThongTinGG.Location = new System.Drawing.Point(36, 66);
            this.gunaGroupBoxThongTinGG.Margin = new System.Windows.Forms.Padding(4);
            this.gunaGroupBoxThongTinGG.Name = "gunaGroupBoxThongTinGG";
            this.gunaGroupBoxThongTinGG.Radius = 10;
            this.gunaGroupBoxThongTinGG.Size = new System.Drawing.Size(603, 214);
            this.gunaGroupBoxThongTinGG.TabIndex = 22;
            this.gunaGroupBoxThongTinGG.Text = "Thông tin giảm giá";
            this.gunaGroupBoxThongTinGG.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // lblMaGiamGia
            // 
            this.lblMaGiamGia.AutoSize = true;
            this.lblMaGiamGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaGiamGia.Location = new System.Drawing.Point(45, 84);
            this.lblMaGiamGia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaGiamGia.Name = "lblMaGiamGia";
            this.lblMaGiamGia.Size = new System.Drawing.Size(118, 25);
            this.lblMaGiamGia.TabIndex = 13;
            this.lblMaGiamGia.Text = "Mã giảm giá";
            // 
            // gtxtGiaTriGiam
            // 
            this.gtxtGiaTriGiam.BackColor = System.Drawing.Color.Transparent;
            this.gtxtGiaTriGiam.BaseColor = System.Drawing.Color.White;
            this.gtxtGiaTriGiam.BorderColor = System.Drawing.Color.Silver;
            this.gtxtGiaTriGiam.BorderSize = 1;
            this.gtxtGiaTriGiam.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxtGiaTriGiam.FocusedBaseColor = System.Drawing.Color.White;
            this.gtxtGiaTriGiam.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gtxtGiaTriGiam.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gtxtGiaTriGiam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gtxtGiaTriGiam.Location = new System.Drawing.Point(252, 135);
            this.gtxtGiaTriGiam.Margin = new System.Windows.Forms.Padding(4);
            this.gtxtGiaTriGiam.Name = "gtxtGiaTriGiam";
            this.gtxtGiaTriGiam.PasswordChar = '\0';
            this.gtxtGiaTriGiam.Radius = 10;
            this.gtxtGiaTriGiam.SelectedText = "";
            this.gtxtGiaTriGiam.Size = new System.Drawing.Size(291, 46);
            this.gtxtGiaTriGiam.TabIndex = 20;
            this.gtxtGiaTriGiam.TextOffsetX = 10;
            this.gtxtGiaTriGiam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gtxtGiaTriGiam_KeyPress);
            // 
            // gtxtMaGiamGia
            // 
            this.gtxtMaGiamGia.BackColor = System.Drawing.Color.Transparent;
            this.gtxtMaGiamGia.BaseColor = System.Drawing.Color.White;
            this.gtxtMaGiamGia.BorderColor = System.Drawing.Color.Silver;
            this.gtxtMaGiamGia.BorderSize = 1;
            this.gtxtMaGiamGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxtMaGiamGia.FocusedBaseColor = System.Drawing.Color.White;
            this.gtxtMaGiamGia.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gtxtMaGiamGia.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gtxtMaGiamGia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gtxtMaGiamGia.Location = new System.Drawing.Point(252, 74);
            this.gtxtMaGiamGia.Margin = new System.Windows.Forms.Padding(4);
            this.gtxtMaGiamGia.Name = "gtxtMaGiamGia";
            this.gtxtMaGiamGia.PasswordChar = '\0';
            this.gtxtMaGiamGia.Radius = 10;
            this.gtxtMaGiamGia.SelectedText = "";
            this.gtxtMaGiamGia.Size = new System.Drawing.Size(291, 46);
            this.gtxtMaGiamGia.TabIndex = 20;
            this.gtxtMaGiamGia.TextOffsetX = 10;
            // 
            // lblGiaTriGiam
            // 
            this.lblGiaTriGiam.AutoSize = true;
            this.lblGiaTriGiam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaTriGiam.Location = new System.Drawing.Point(45, 144);
            this.lblGiaTriGiam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGiaTriGiam.Name = "lblGiaTriGiam";
            this.lblGiaTriGiam.Size = new System.Drawing.Size(146, 25);
            this.lblGiaTriGiam.TabIndex = 17;
            this.lblGiaTriGiam.Text = "Giá trị giảm (%)";
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
            this.gDataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.gDataGridView1.Name = "gDataGridView1";
            this.gDataGridView1.ReadOnly = true;
            this.gDataGridView1.RowHeadersVisible = false;
            this.gDataGridView1.RowHeadersWidth = 44;
            this.gDataGridView1.RowTemplate.Height = 35;
            this.gDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gDataGridView1.Size = new System.Drawing.Size(1025, 902);
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
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 44;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1267, 982);
            this.dataGridView1.TabIndex = 0;
            // 
            // frmDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1805, 902);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDiscount";
            this.Text = "frmDiscount";
            this.Load += new System.EventHandler(this.frmDiscount_Load);
            this.SizeChanged += new System.EventHandler(this.frmDiscount_SizeChanged);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelThongTinGG.ResumeLayout(false);
            this.panelButton.ResumeLayout(false);
            this.gunaGroupBoxThongTinGG.ResumeLayout(false);
            this.gunaGroupBoxThongTinGG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panelThongTinGG;
        private System.Windows.Forms.Panel panelButton;
        private FontAwesome.Sharp.IconButton btnSua;
        private FontAwesome.Sharp.IconButton btnThem;
        private FontAwesome.Sharp.IconButton btnXoa;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBoxThongTinGG;
        private System.Windows.Forms.Label lblMaGiamGia;
        private Guna.UI.WinForms.GunaTextBox gtxtGiaTriGiam;
        private Guna.UI.WinForms.GunaTextBox gtxtMaGiamGia;
        private System.Windows.Forms.Label lblGiaTriGiam;
        private Guna.UI.WinForms.GunaDataGridView gDataGridView1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}