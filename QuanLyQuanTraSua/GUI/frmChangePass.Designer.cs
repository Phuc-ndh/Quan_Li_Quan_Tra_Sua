﻿
namespace QuanLyQuanTraSua
{
    partial class frmChangePass
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
            this.gunaGroupBoxThongTinMH = new Guna.UI.WinForms.GunaGroupBox();
            this.txtReNewPass = new Guna.UI.WinForms.GunaTextBox();
            this.txtCurrentPass = new Guna.UI.WinForms.GunaTextBox();
            this.txtNewPass = new Guna.UI.WinForms.GunaTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlCurrentPass = new System.Windows.Forms.Panel();
            this.pnlNewPass = new System.Windows.Forms.Panel();
            this.pnlReType = new System.Windows.Forms.Panel();
            this.btnChangePass = new FontAwesome.Sharp.IconButton();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.gunaGroupBoxThongTinMH.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaGroupBoxThongTinMH
            // 
            this.gunaGroupBoxThongTinMH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaGroupBoxThongTinMH.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBoxThongTinMH.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBoxThongTinMH.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBoxThongTinMH.Controls.Add(this.btnCancel);
            this.gunaGroupBoxThongTinMH.Controls.Add(this.btnChangePass);
            this.gunaGroupBoxThongTinMH.Controls.Add(this.panel1);
            this.gunaGroupBoxThongTinMH.Controls.Add(this.pnlReType);
            this.gunaGroupBoxThongTinMH.Controls.Add(this.pnlNewPass);
            this.gunaGroupBoxThongTinMH.Controls.Add(this.pnlCurrentPass);
            this.gunaGroupBoxThongTinMH.Controls.Add(this.txtNewPass);
            this.gunaGroupBoxThongTinMH.Controls.Add(this.txtReNewPass);
            this.gunaGroupBoxThongTinMH.Controls.Add(this.txtCurrentPass);
            this.gunaGroupBoxThongTinMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.882353F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBoxThongTinMH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaGroupBoxThongTinMH.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBoxThongTinMH.Location = new System.Drawing.Point(-1, 0);
            this.gunaGroupBoxThongTinMH.Name = "gunaGroupBoxThongTinMH";
            this.gunaGroupBoxThongTinMH.Radius = 10;
            this.gunaGroupBoxThongTinMH.Size = new System.Drawing.Size(470, 266);
            this.gunaGroupBoxThongTinMH.TabIndex = 23;
            this.gunaGroupBoxThongTinMH.Text = "Đổi password";
            this.gunaGroupBoxThongTinMH.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // txtReNewPass
            // 
            this.txtReNewPass.BackColor = System.Drawing.Color.Transparent;
            this.txtReNewPass.BaseColor = System.Drawing.Color.White;
            this.txtReNewPass.BorderColor = System.Drawing.Color.Silver;
            this.txtReNewPass.BorderSize = 1;
            this.txtReNewPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReNewPass.FocusedBaseColor = System.Drawing.Color.White;
            this.txtReNewPass.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtReNewPass.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtReNewPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReNewPass.Location = new System.Drawing.Point(44, 165);
            this.txtReNewPass.Name = "txtReNewPass";
            this.txtReNewPass.PasswordChar = '\0';
            this.txtReNewPass.Radius = 10;
            this.txtReNewPass.SelectedText = "";
            this.txtReNewPass.Size = new System.Drawing.Size(313, 33);
            this.txtReNewPass.TabIndex = 2;
            this.txtReNewPass.Text = "Nhập lại pasword mới";
            this.txtReNewPass.TextOffsetX = 10;
            this.txtReNewPass.TextChanged += new System.EventHandler(this.txtReNewPass_TextChanged);
            this.txtReNewPass.Click += new System.EventHandler(this.txtReNewPass_Click);
            // 
            // txtCurrentPass
            // 
            this.txtCurrentPass.BackColor = System.Drawing.Color.Transparent;
            this.txtCurrentPass.BaseColor = System.Drawing.Color.White;
            this.txtCurrentPass.BorderColor = System.Drawing.Color.Silver;
            this.txtCurrentPass.BorderSize = 1;
            this.txtCurrentPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCurrentPass.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCurrentPass.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtCurrentPass.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCurrentPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentPass.Location = new System.Drawing.Point(44, 53);
            this.txtCurrentPass.Name = "txtCurrentPass";
            this.txtCurrentPass.PasswordChar = '\0';
            this.txtCurrentPass.Radius = 10;
            this.txtCurrentPass.SelectedText = "";
            this.txtCurrentPass.Size = new System.Drawing.Size(313, 33);
            this.txtCurrentPass.TabIndex = 0;
            this.txtCurrentPass.Text = "Password hiện tại";
            this.txtCurrentPass.TextOffsetX = 10;
            this.txtCurrentPass.TextChanged += new System.EventHandler(this.txtCurrentPass_TextChanged);
            this.txtCurrentPass.Click += new System.EventHandler(this.txtCurrentPass_Click);
            // 
            // txtNewPass
            // 
            this.txtNewPass.BackColor = System.Drawing.Color.Transparent;
            this.txtNewPass.BaseColor = System.Drawing.Color.White;
            this.txtNewPass.BorderColor = System.Drawing.Color.Silver;
            this.txtNewPass.BorderSize = 1;
            this.txtNewPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPass.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNewPass.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtNewPass.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNewPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPass.Location = new System.Drawing.Point(44, 107);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '\0';
            this.txtNewPass.Radius = 10;
            this.txtNewPass.SelectedText = "";
            this.txtNewPass.Size = new System.Drawing.Size(313, 33);
            this.txtNewPass.TabIndex = 1;
            this.txtNewPass.Text = "Password mới";
            this.txtNewPass.TextOffsetX = 10;
            this.txtNewPass.TextChanged += new System.EventHandler(this.txtNewPass_TextChanged);
            this.txtNewPass.Click += new System.EventHandler(this.txtNewPass_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(88)))));
            this.panel1.Location = new System.Drawing.Point(1, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(28, 237);
            this.panel1.TabIndex = 22;
            // 
            // pnlCurrentPass
            // 
            this.pnlCurrentPass.BackColor = System.Drawing.Color.Aqua;
            this.pnlCurrentPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlCurrentPass.Location = new System.Drawing.Point(54, 89);
            this.pnlCurrentPass.Name = "pnlCurrentPass";
            this.pnlCurrentPass.Size = new System.Drawing.Size(288, 3);
            this.pnlCurrentPass.TabIndex = 22;
            // 
            // pnlNewPass
            // 
            this.pnlNewPass.BackColor = System.Drawing.Color.Aqua;
            this.pnlNewPass.Location = new System.Drawing.Point(56, 143);
            this.pnlNewPass.Name = "pnlNewPass";
            this.pnlNewPass.Size = new System.Drawing.Size(288, 3);
            this.pnlNewPass.TabIndex = 23;
            // 
            // pnlReType
            // 
            this.pnlReType.BackColor = System.Drawing.Color.Aqua;
            this.pnlReType.Location = new System.Drawing.Point(56, 202);
            this.pnlReType.Name = "pnlReType";
            this.pnlReType.Size = new System.Drawing.Size(288, 3);
            this.pnlReType.TabIndex = 24;
            // 
            // btnChangePass
            // 
            this.btnChangePass.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnChangePass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnChangePass.FlatAppearance.BorderSize = 0;
            this.btnChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnChangePass.ForeColor = System.Drawing.Color.White;
            this.btnChangePass.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnChangePass.IconColor = System.Drawing.Color.White;
            this.btnChangePass.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChangePass.IconSize = 28;
            this.btnChangePass.Location = new System.Drawing.Point(228, 218);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnChangePass.Size = new System.Drawing.Size(129, 45);
            this.btnChangePass.TabIndex = 3;
            this.btnChangePass.Text = "Đổi";
            this.btnChangePass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChangePass.UseVisualStyleBackColor = false;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.Backward;
            this.btnCancel.IconColor = System.Drawing.Color.White;
            this.btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancel.IconSize = 28;
            this.btnCancel.Location = new System.Drawing.Point(44, 218);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnCancel.Size = new System.Drawing.Size(129, 45);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Thoát";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 268);
            this.Controls.Add(this.gunaGroupBoxThongTinMH);
            this.Name = "frmChangePass";
            this.Text = "frmChangePass";
            this.Load += new System.EventHandler(this.frmChangePass_Load);
            this.gunaGroupBoxThongTinMH.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGroupBox gunaGroupBoxThongTinMH;
        private Guna.UI.WinForms.GunaTextBox txtNewPass;
        private Guna.UI.WinForms.GunaTextBox txtReNewPass;
        private Guna.UI.WinForms.GunaTextBox txtCurrentPass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlCurrentPass;
        private System.Windows.Forms.Panel pnlReType;
        private System.Windows.Forms.Panel pnlNewPass;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnChangePass;
    }
}