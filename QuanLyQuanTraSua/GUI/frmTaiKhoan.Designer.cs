
namespace QuanLyQuanTraSua
{
    partial class frmTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaiKhoan));
            this.pnlTopM = new System.Windows.Forms.Panel();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.pnlMove = new System.Windows.Forms.Panel();
            this.lblMinimize = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.ptrEmail1 = new System.Windows.Forms.PictureBox();
            this.ptrPhone1 = new System.Windows.Forms.PictureBox();
            this.ptrName1 = new System.Windows.Forms.PictureBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.pctrB_Email_Gr = new System.Windows.Forms.PictureBox();
            this.gbtnAfterE = new Guna.UI.WinForms.GunaButton();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.pctrB_SDT_Gr = new System.Windows.Forms.PictureBox();
            this.gbtnAfterSDT = new Guna.UI.WinForms.GunaButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.pctrB_Name_Gr = new System.Windows.Forms.PictureBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.ptrUser1 = new System.Windows.Forms.PictureBox();
            this.pctrB_User_Gr = new System.Windows.Forms.PictureBox();
            this.gbtnAfterU = new Guna.UI.WinForms.GunaButton();
            this.gbtnAfterN = new Guna.UI.WinForms.GunaButton();
            this.gbtnSua = new Guna.UI.WinForms.GunaButton();
            this.gbtnDoiMK = new Guna.UI.WinForms.GunaButton();
            this.pnlTopM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.pnlMove.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrEmail1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrPhone1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrName1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrB_Email_Gr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrB_SDT_Gr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrB_Name_Gr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrUser1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrB_User_Gr)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTopM
            // 
            this.pnlTopM.BackColor = System.Drawing.Color.White;
            this.pnlTopM.Controls.Add(this.pictureBoxIcon);
            this.pnlTopM.Controls.Add(this.pnlMove);
            this.pnlTopM.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopM.Location = new System.Drawing.Point(0, 0);
            this.pnlTopM.Name = "pnlTopM";
            this.pnlTopM.Size = new System.Drawing.Size(429, 138);
            this.pnlTopM.TabIndex = 152;
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIcon.Image")));
            this.pictureBoxIcon.Location = new System.Drawing.Point(149, 38);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(130, 95);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIcon.TabIndex = 0;
            this.pictureBoxIcon.TabStop = false;
            // 
            // pnlMove
            // 
            this.pnlMove.BackColor = System.Drawing.Color.Teal;
            this.pnlMove.Controls.Add(this.lblMinimize);
            this.pnlMove.Controls.Add(this.lblClose);
            this.pnlMove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlMove.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMove.Location = new System.Drawing.Point(0, 0);
            this.pnlMove.Name = "pnlMove";
            this.pnlMove.Size = new System.Drawing.Size(429, 31);
            this.pnlMove.TabIndex = 2;
            // 
            // lblMinimize
            // 
            this.lblMinimize.AutoSize = true;
            this.lblMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.11765F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimize.ForeColor = System.Drawing.Color.Snow;
            this.lblMinimize.Location = new System.Drawing.Point(379, 0);
            this.lblMinimize.Name = "lblMinimize";
            this.lblMinimize.Size = new System.Drawing.Size(20, 25);
            this.lblMinimize.TabIndex = 2;
            this.lblMinimize.Text = "-";
            this.lblMinimize.Click += new System.EventHandler(this.lblMinimize_Click);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.70588F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.Snow;
            this.lblClose.Location = new System.Drawing.Point(406, 2);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(22, 22);
            this.lblClose.TabIndex = 3;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // ptrEmail1
            // 
            this.ptrEmail1.Image = global::QuanLyQuanTraSua.Properties.Resources.email1;
            this.ptrEmail1.Location = new System.Drawing.Point(66, 386);
            this.ptrEmail1.Name = "ptrEmail1";
            this.ptrEmail1.Size = new System.Drawing.Size(28, 27);
            this.ptrEmail1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptrEmail1.TabIndex = 201;
            this.ptrEmail1.TabStop = false;
            this.ptrEmail1.Visible = false;
            // 
            // ptrPhone1
            // 
            this.ptrPhone1.Image = global::QuanLyQuanTraSua.Properties.Resources.phone1;
            this.ptrPhone1.Location = new System.Drawing.Point(65, 321);
            this.ptrPhone1.Name = "ptrPhone1";
            this.ptrPhone1.Size = new System.Drawing.Size(26, 26);
            this.ptrPhone1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptrPhone1.TabIndex = 197;
            this.ptrPhone1.TabStop = false;
            this.ptrPhone1.Visible = false;
            // 
            // ptrName1
            // 
            this.ptrName1.Image = global::QuanLyQuanTraSua.Properties.Resources.name1;
            this.ptrName1.Location = new System.Drawing.Point(65, 251);
            this.ptrName1.Name = "ptrName1";
            this.ptrName1.Size = new System.Drawing.Size(33, 33);
            this.ptrName1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptrName1.TabIndex = 193;
            this.ptrName1.TabStop = false;
            this.ptrName1.Visible = false;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12.70588F);
            this.txtEmail.ForeColor = System.Drawing.Color.Gray;
            this.txtEmail.Location = new System.Drawing.Point(105, 385);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(261, 24);
            this.txtEmail.TabIndex = 199;
            this.txtEmail.Text = "Email";
            // 
            // pctrB_Email_Gr
            // 
            this.pctrB_Email_Gr.Image = global::QuanLyQuanTraSua.Properties.Resources.email_gr;
            this.pctrB_Email_Gr.Location = new System.Drawing.Point(66, 386);
            this.pctrB_Email_Gr.Name = "pctrB_Email_Gr";
            this.pctrB_Email_Gr.Size = new System.Drawing.Size(28, 27);
            this.pctrB_Email_Gr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctrB_Email_Gr.TabIndex = 200;
            this.pctrB_Email_Gr.TabStop = false;
            // 
            // gbtnAfterE
            // 
            this.gbtnAfterE.AnimationHoverSpeed = 0.07F;
            this.gbtnAfterE.AnimationSpeed = 0.03F;
            this.gbtnAfterE.BackColor = System.Drawing.Color.Transparent;
            this.gbtnAfterE.BaseColor = System.Drawing.Color.White;
            this.gbtnAfterE.BorderColor = System.Drawing.Color.Silver;
            this.gbtnAfterE.BorderSize = 2;
            this.gbtnAfterE.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gbtnAfterE.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gbtnAfterE.FocusedColor = System.Drawing.Color.Empty;
            this.gbtnAfterE.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbtnAfterE.ForeColor = System.Drawing.Color.White;
            this.gbtnAfterE.Image = null;
            this.gbtnAfterE.ImageSize = new System.Drawing.Size(20, 20);
            this.gbtnAfterE.Location = new System.Drawing.Point(57, 378);
            this.gbtnAfterE.Name = "gbtnAfterE";
            this.gbtnAfterE.OnHoverBaseColor = System.Drawing.Color.White;
            this.gbtnAfterE.OnHoverBorderColor = System.Drawing.Color.Silver;
            this.gbtnAfterE.OnHoverForeColor = System.Drawing.Color.White;
            this.gbtnAfterE.OnHoverImage = null;
            this.gbtnAfterE.OnPressedColor = System.Drawing.Color.White;
            this.gbtnAfterE.Radius = 8;
            this.gbtnAfterE.Size = new System.Drawing.Size(315, 40);
            this.gbtnAfterE.TabIndex = 202;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.White;
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 12.70588F);
            this.txtPhone.ForeColor = System.Drawing.Color.Gray;
            this.txtPhone.Location = new System.Drawing.Point(104, 320);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(261, 24);
            this.txtPhone.TabIndex = 195;
            this.txtPhone.Text = "SĐT";
            // 
            // pctrB_SDT_Gr
            // 
            this.pctrB_SDT_Gr.Image = global::QuanLyQuanTraSua.Properties.Resources.phone_gr;
            this.pctrB_SDT_Gr.Location = new System.Drawing.Point(65, 321);
            this.pctrB_SDT_Gr.Name = "pctrB_SDT_Gr";
            this.pctrB_SDT_Gr.Size = new System.Drawing.Size(26, 26);
            this.pctrB_SDT_Gr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctrB_SDT_Gr.TabIndex = 196;
            this.pctrB_SDT_Gr.TabStop = false;
            // 
            // gbtnAfterSDT
            // 
            this.gbtnAfterSDT.AnimationHoverSpeed = 0.07F;
            this.gbtnAfterSDT.AnimationSpeed = 0.03F;
            this.gbtnAfterSDT.BackColor = System.Drawing.Color.Transparent;
            this.gbtnAfterSDT.BaseColor = System.Drawing.Color.White;
            this.gbtnAfterSDT.BorderColor = System.Drawing.Color.Silver;
            this.gbtnAfterSDT.BorderSize = 2;
            this.gbtnAfterSDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gbtnAfterSDT.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gbtnAfterSDT.FocusedColor = System.Drawing.Color.Empty;
            this.gbtnAfterSDT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbtnAfterSDT.ForeColor = System.Drawing.Color.White;
            this.gbtnAfterSDT.Image = null;
            this.gbtnAfterSDT.ImageSize = new System.Drawing.Size(20, 20);
            this.gbtnAfterSDT.Location = new System.Drawing.Point(56, 313);
            this.gbtnAfterSDT.Name = "gbtnAfterSDT";
            this.gbtnAfterSDT.OnHoverBaseColor = System.Drawing.Color.White;
            this.gbtnAfterSDT.OnHoverBorderColor = System.Drawing.Color.Silver;
            this.gbtnAfterSDT.OnHoverForeColor = System.Drawing.Color.White;
            this.gbtnAfterSDT.OnHoverImage = null;
            this.gbtnAfterSDT.OnPressedColor = System.Drawing.Color.White;
            this.gbtnAfterSDT.Radius = 8;
            this.gbtnAfterSDT.Size = new System.Drawing.Size(315, 40);
            this.gbtnAfterSDT.TabIndex = 198;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 12.70588F);
            this.txtName.ForeColor = System.Drawing.Color.Gray;
            this.txtName.Location = new System.Drawing.Point(104, 254);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(261, 24);
            this.txtName.TabIndex = 191;
            this.txtName.Text = "Họ Tên";
            // 
            // pctrB_Name_Gr
            // 
            this.pctrB_Name_Gr.Image = global::QuanLyQuanTraSua.Properties.Resources.name_gr;
            this.pctrB_Name_Gr.Location = new System.Drawing.Point(65, 251);
            this.pctrB_Name_Gr.Name = "pctrB_Name_Gr";
            this.pctrB_Name_Gr.Size = new System.Drawing.Size(33, 33);
            this.pctrB_Name_Gr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctrB_Name_Gr.TabIndex = 192;
            this.pctrB_Name_Gr.TabStop = false;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 12.70588F);
            this.txtUsername.ForeColor = System.Drawing.Color.Gray;
            this.txtUsername.Location = new System.Drawing.Point(104, 188);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(261, 24);
            this.txtUsername.TabIndex = 178;
            this.txtUsername.Text = "Tên Đăng Nhập";
            // 
            // ptrUser1
            // 
            this.ptrUser1.Image = ((System.Drawing.Image)(resources.GetObject("ptrUser1.Image")));
            this.ptrUser1.Location = new System.Drawing.Point(65, 189);
            this.ptrUser1.Name = "ptrUser1";
            this.ptrUser1.Size = new System.Drawing.Size(28, 27);
            this.ptrUser1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptrUser1.TabIndex = 182;
            this.ptrUser1.TabStop = false;
            this.ptrUser1.Visible = false;
            // 
            // pctrB_User_Gr
            // 
            this.pctrB_User_Gr.Image = global::QuanLyQuanTraSua.Properties.Resources.user_gr;
            this.pctrB_User_Gr.Location = new System.Drawing.Point(65, 189);
            this.pctrB_User_Gr.Name = "pctrB_User_Gr";
            this.pctrB_User_Gr.Size = new System.Drawing.Size(28, 27);
            this.pctrB_User_Gr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctrB_User_Gr.TabIndex = 181;
            this.pctrB_User_Gr.TabStop = false;
            // 
            // gbtnAfterU
            // 
            this.gbtnAfterU.AnimationHoverSpeed = 0.07F;
            this.gbtnAfterU.AnimationSpeed = 0.03F;
            this.gbtnAfterU.BackColor = System.Drawing.Color.Transparent;
            this.gbtnAfterU.BaseColor = System.Drawing.Color.White;
            this.gbtnAfterU.BorderColor = System.Drawing.Color.Silver;
            this.gbtnAfterU.BorderSize = 2;
            this.gbtnAfterU.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gbtnAfterU.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gbtnAfterU.FocusedColor = System.Drawing.Color.Empty;
            this.gbtnAfterU.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbtnAfterU.ForeColor = System.Drawing.Color.White;
            this.gbtnAfterU.Image = null;
            this.gbtnAfterU.ImageSize = new System.Drawing.Size(20, 20);
            this.gbtnAfterU.Location = new System.Drawing.Point(56, 181);
            this.gbtnAfterU.Name = "gbtnAfterU";
            this.gbtnAfterU.OnHoverBaseColor = System.Drawing.Color.White;
            this.gbtnAfterU.OnHoverBorderColor = System.Drawing.Color.Silver;
            this.gbtnAfterU.OnHoverForeColor = System.Drawing.Color.White;
            this.gbtnAfterU.OnHoverImage = null;
            this.gbtnAfterU.OnPressedColor = System.Drawing.Color.White;
            this.gbtnAfterU.Radius = 8;
            this.gbtnAfterU.Size = new System.Drawing.Size(315, 40);
            this.gbtnAfterU.TabIndex = 185;
            // 
            // gbtnAfterN
            // 
            this.gbtnAfterN.AnimationHoverSpeed = 0.07F;
            this.gbtnAfterN.AnimationSpeed = 0.03F;
            this.gbtnAfterN.BackColor = System.Drawing.Color.Transparent;
            this.gbtnAfterN.BaseColor = System.Drawing.Color.White;
            this.gbtnAfterN.BorderColor = System.Drawing.Color.Silver;
            this.gbtnAfterN.BorderSize = 2;
            this.gbtnAfterN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gbtnAfterN.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gbtnAfterN.FocusedColor = System.Drawing.Color.Empty;
            this.gbtnAfterN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbtnAfterN.ForeColor = System.Drawing.Color.White;
            this.gbtnAfterN.Image = null;
            this.gbtnAfterN.ImageSize = new System.Drawing.Size(20, 20);
            this.gbtnAfterN.Location = new System.Drawing.Point(56, 247);
            this.gbtnAfterN.Name = "gbtnAfterN";
            this.gbtnAfterN.OnHoverBaseColor = System.Drawing.Color.White;
            this.gbtnAfterN.OnHoverBorderColor = System.Drawing.Color.Silver;
            this.gbtnAfterN.OnHoverForeColor = System.Drawing.Color.White;
            this.gbtnAfterN.OnHoverImage = null;
            this.gbtnAfterN.OnPressedColor = System.Drawing.Color.White;
            this.gbtnAfterN.Radius = 8;
            this.gbtnAfterN.Size = new System.Drawing.Size(315, 40);
            this.gbtnAfterN.TabIndex = 194;
            // 
            // gbtnSua
            // 
            this.gbtnSua.AnimationHoverSpeed = 0.07F;
            this.gbtnSua.AnimationSpeed = 0.03F;
            this.gbtnSua.BackColor = System.Drawing.Color.Transparent;
            this.gbtnSua.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gbtnSua.BorderColor = System.Drawing.Color.Black;
            this.gbtnSua.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gbtnSua.FocusedColor = System.Drawing.Color.Empty;
            this.gbtnSua.Font = new System.Drawing.Font("Segoe UI", 14.11765F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtnSua.ForeColor = System.Drawing.Color.White;
            this.gbtnSua.Image = null;
            this.gbtnSua.ImageSize = new System.Drawing.Size(20, 20);
            this.gbtnSua.Location = new System.Drawing.Point(57, 477);
            this.gbtnSua.Name = "gbtnSua";
            this.gbtnSua.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gbtnSua.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gbtnSua.OnHoverForeColor = System.Drawing.Color.White;
            this.gbtnSua.OnHoverImage = null;
            this.gbtnSua.OnPressedColor = System.Drawing.Color.Black;
            this.gbtnSua.Radius = 6;
            this.gbtnSua.Size = new System.Drawing.Size(315, 43);
            this.gbtnSua.TabIndex = 203;
            this.gbtnSua.Text = "Sửa Thông Tin";
            this.gbtnSua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gbtnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // gbtnDoiMK
            // 
            this.gbtnDoiMK.AnimationHoverSpeed = 0.07F;
            this.gbtnDoiMK.AnimationSpeed = 0.03F;
            this.gbtnDoiMK.BackColor = System.Drawing.Color.Transparent;
            this.gbtnDoiMK.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gbtnDoiMK.BorderColor = System.Drawing.Color.Black;
            this.gbtnDoiMK.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gbtnDoiMK.FocusedColor = System.Drawing.Color.Empty;
            this.gbtnDoiMK.Font = new System.Drawing.Font("Segoe UI", 14.11765F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtnDoiMK.ForeColor = System.Drawing.Color.White;
            this.gbtnDoiMK.Image = null;
            this.gbtnDoiMK.ImageSize = new System.Drawing.Size(20, 20);
            this.gbtnDoiMK.Location = new System.Drawing.Point(57, 545);
            this.gbtnDoiMK.Name = "gbtnDoiMK";
            this.gbtnDoiMK.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gbtnDoiMK.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gbtnDoiMK.OnHoverForeColor = System.Drawing.Color.White;
            this.gbtnDoiMK.OnHoverImage = null;
            this.gbtnDoiMK.OnPressedColor = System.Drawing.Color.Black;
            this.gbtnDoiMK.Radius = 6;
            this.gbtnDoiMK.Size = new System.Drawing.Size(315, 43);
            this.gbtnDoiMK.TabIndex = 203;
            this.gbtnDoiMK.Text = "Thay Đổi Mật Khẩu";
            this.gbtnDoiMK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gbtnDoiMK.Click += new System.EventHandler(this.btnDoiMK_Click);
            // 
            // frmTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(429, 625);
            this.Controls.Add(this.gbtnDoiMK);
            this.Controls.Add(this.gbtnSua);
            this.Controls.Add(this.ptrEmail1);
            this.Controls.Add(this.ptrPhone1);
            this.Controls.Add(this.ptrName1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.pctrB_Email_Gr);
            this.Controls.Add(this.gbtnAfterE);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.pctrB_SDT_Gr);
            this.Controls.Add(this.gbtnAfterSDT);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.pctrB_Name_Gr);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.ptrUser1);
            this.Controls.Add(this.pctrB_User_Gr);
            this.Controls.Add(this.gbtnAfterU);
            this.Controls.Add(this.gbtnAfterN);
            this.Controls.Add(this.pnlTopM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông Tin Tài Khoản";
            this.Load += new System.EventHandler(this.frmTaiKhoan_Load);
            this.pnlTopM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.pnlMove.ResumeLayout(false);
            this.pnlMove.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrEmail1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrPhone1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrName1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrB_Email_Gr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrB_SDT_Gr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrB_Name_Gr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrUser1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrB_User_Gr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlTopM;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.Panel pnlMove;
        private System.Windows.Forms.Label lblMinimize;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.PictureBox ptrEmail1;
        private System.Windows.Forms.PictureBox ptrPhone1;
        private System.Windows.Forms.PictureBox ptrName1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.PictureBox pctrB_Email_Gr;
        private Guna.UI.WinForms.GunaButton gbtnAfterE;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.PictureBox pctrB_SDT_Gr;
        private Guna.UI.WinForms.GunaButton gbtnAfterSDT;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.PictureBox pctrB_Name_Gr;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.PictureBox ptrUser1;
        private System.Windows.Forms.PictureBox pctrB_User_Gr;
        private Guna.UI.WinForms.GunaButton gbtnAfterU;
        private Guna.UI.WinForms.GunaButton gbtnAfterN;
        private Guna.UI.WinForms.GunaButton gbtnSua;
        private Guna.UI.WinForms.GunaButton gbtnDoiMK;
    }
}