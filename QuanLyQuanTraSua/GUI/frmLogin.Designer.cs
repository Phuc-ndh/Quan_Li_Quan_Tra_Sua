namespace QuanLyQuanTraSua
{
    partial class frmLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pnlMoveL = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlTopL = new System.Windows.Forms.Panel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.gCircleButton3 = new Guna.UI.WinForms.GunaCircleButton();
            this.gCircleButton2 = new Guna.UI.WinForms.GunaCircleButton();
            this.gCircleButton1 = new Guna.UI.WinForms.GunaCircleButton();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.gbtnAfterU = new Guna.UI.WinForms.GunaButton();
            this.gbtnAfterP = new Guna.UI.WinForms.GunaButton();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pctrB_Eye = new System.Windows.Forms.PictureBox();
            this.pctrB_User = new System.Windows.Forms.PictureBox();
            this.pctrB_User_Gr = new System.Windows.Forms.PictureBox();
            this.pnlTopM = new System.Windows.Forms.Panel();
            this.lblMinimize = new System.Windows.Forms.Label();
            this.pnlTopR = new System.Windows.Forms.Panel();
            this.lblClose = new System.Windows.Forms.Label();
            this.glblDangNhap = new Guna.UI.WinForms.GunaLabel();
            this.pnlMoveR = new System.Windows.Forms.Panel();
            this.gbtnLogin = new Guna.UI.WinForms.GunaButton();
            this.pctrB_Pass = new System.Windows.Forms.PictureBox();
            this.pctrB_Pass_Gr = new System.Windows.Forms.PictureBox();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrB_Eye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrB_User)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrB_User_Gr)).BeginInit();
            this.pnlTopM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrB_Pass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrB_Pass_Gr)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMoveL
            // 
            this.pnlMoveL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlMoveL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlMoveL.Location = new System.Drawing.Point(1, 1);
            this.pnlMoveL.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMoveL.Name = "pnlMoveL";
            this.pnlMoveL.Size = new System.Drawing.Size(497, 38);
            this.pnlMoveL.TabIndex = 69;
            this.pnlMoveL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlMove_MouseDown);
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlLeft.Controls.Add(this.pnlTopL);
            this.pnlLeft.Controls.Add(this.gunaLabel2);
            this.pnlLeft.Controls.Add(this.pnlMoveL);
            this.pnlLeft.Controls.Add(this.pictureBoxIcon);
            this.pnlLeft.Controls.Add(this.gCircleButton3);
            this.pnlLeft.Controls.Add(this.gCircleButton2);
            this.pnlLeft.Controls.Add(this.gCircleButton1);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(499, 539);
            this.pnlLeft.TabIndex = 33;
            // 
            // pnlTopL
            // 
            this.pnlTopL.BackColor = System.Drawing.Color.Teal;
            this.pnlTopL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlTopL.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopL.Location = new System.Drawing.Point(0, 0);
            this.pnlTopL.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTopL.Name = "pnlTopL";
            this.pnlTopL.Size = new System.Drawing.Size(499, 4);
            this.pnlTopL.TabIndex = 5;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9.882353F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(109, 420);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(255, 23);
            this.gunaLabel2.TabIndex = 3;
            this.gunaLabel2.Text = "Phần mềm quản lý quán trà sữa";
            this.gunaLabel2.Visible = false;
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIcon.Image")));
            this.pictureBoxIcon.Location = new System.Drawing.Point(115, 149);
            this.pictureBoxIcon.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(253, 242);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIcon.TabIndex = 2;
            this.pictureBoxIcon.TabStop = false;
            // 
            // gCircleButton3
            // 
            this.gCircleButton3.AnimationHoverSpeed = 0.07F;
            this.gCircleButton3.AnimationSpeed = 0.03F;
            this.gCircleButton3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gCircleButton3.BorderColor = System.Drawing.Color.Black;
            this.gCircleButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gCircleButton3.Enabled = false;
            this.gCircleButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gCircleButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gCircleButton3.ForeColor = System.Drawing.Color.White;
            this.gCircleButton3.Image = null;
            this.gCircleButton3.ImageSize = new System.Drawing.Size(52, 52);
            this.gCircleButton3.Location = new System.Drawing.Point(356, 426);
            this.gCircleButton3.Margin = new System.Windows.Forms.Padding(4);
            this.gCircleButton3.Name = "gCircleButton3";
            this.gCircleButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gCircleButton3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gCircleButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gCircleButton3.OnHoverImage = null;
            this.gCircleButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gCircleButton3.Size = new System.Drawing.Size(27, 25);
            this.gCircleButton3.TabIndex = 4;
            // 
            // gCircleButton2
            // 
            this.gCircleButton2.AnimationHoverSpeed = 0.07F;
            this.gCircleButton2.AnimationSpeed = 0.03F;
            this.gCircleButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gCircleButton2.BorderColor = System.Drawing.Color.Black;
            this.gCircleButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gCircleButton2.Enabled = false;
            this.gCircleButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gCircleButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gCircleButton2.ForeColor = System.Drawing.Color.White;
            this.gCircleButton2.Image = null;
            this.gCircleButton2.ImageSize = new System.Drawing.Size(52, 52);
            this.gCircleButton2.Location = new System.Drawing.Point(53, 342);
            this.gCircleButton2.Margin = new System.Windows.Forms.Padding(4);
            this.gCircleButton2.Name = "gCircleButton2";
            this.gCircleButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gCircleButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gCircleButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gCircleButton2.OnHoverImage = null;
            this.gCircleButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gCircleButton2.Size = new System.Drawing.Size(53, 49);
            this.gCircleButton2.TabIndex = 4;
            // 
            // gCircleButton1
            // 
            this.gCircleButton1.AnimationHoverSpeed = 0.07F;
            this.gCircleButton1.AnimationSpeed = 0.03F;
            this.gCircleButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gCircleButton1.BorderColor = System.Drawing.Color.Black;
            this.gCircleButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gCircleButton1.Enabled = false;
            this.gCircleButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gCircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gCircleButton1.ForeColor = System.Drawing.Color.White;
            this.gCircleButton1.Image = null;
            this.gCircleButton1.ImageSize = new System.Drawing.Size(52, 52);
            this.gCircleButton1.Location = new System.Drawing.Point(380, 129);
            this.gCircleButton1.Margin = new System.Windows.Forms.Padding(4);
            this.gCircleButton1.Name = "gCircleButton1";
            this.gCircleButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gCircleButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gCircleButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gCircleButton1.OnHoverImage = null;
            this.gCircleButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gCircleButton1.Size = new System.Drawing.Size(40, 37);
            this.gCircleButton1.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12.70588F);
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword.Location = new System.Drawing.Point(175, 289);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(317, 29);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = "Mật Khẩu";
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_Click);
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Click);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 12.70588F);
            this.txtUsername.ForeColor = System.Drawing.Color.Gray;
            this.txtUsername.Location = new System.Drawing.Point(175, 210);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(317, 29);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Text = "Tên Đăng Nhập";
            this.txtUsername.Click += new System.EventHandler(this.txtUsername_Click);
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Click);
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
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
            this.gbtnAfterU.Location = new System.Drawing.Point(111, 202);
            this.gbtnAfterU.Margin = new System.Windows.Forms.Padding(4);
            this.gbtnAfterU.Name = "gbtnAfterU";
            this.gbtnAfterU.OnHoverBaseColor = System.Drawing.Color.White;
            this.gbtnAfterU.OnHoverBorderColor = System.Drawing.Color.Silver;
            this.gbtnAfterU.OnHoverForeColor = System.Drawing.Color.White;
            this.gbtnAfterU.OnHoverImage = null;
            this.gbtnAfterU.OnPressedColor = System.Drawing.Color.White;
            this.gbtnAfterU.Radius = 8;
            this.gbtnAfterU.Size = new System.Drawing.Size(389, 49);
            this.gbtnAfterU.TabIndex = 4;
            this.gbtnAfterU.Click += new System.EventHandler(this.txtUsername_Click);
            // 
            // gbtnAfterP
            // 
            this.gbtnAfterP.AnimationHoverSpeed = 0.07F;
            this.gbtnAfterP.AnimationSpeed = 0.03F;
            this.gbtnAfterP.BackColor = System.Drawing.Color.Transparent;
            this.gbtnAfterP.BaseColor = System.Drawing.Color.White;
            this.gbtnAfterP.BorderColor = System.Drawing.Color.Silver;
            this.gbtnAfterP.BorderSize = 2;
            this.gbtnAfterP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gbtnAfterP.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gbtnAfterP.FocusedColor = System.Drawing.Color.Empty;
            this.gbtnAfterP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbtnAfterP.ForeColor = System.Drawing.Color.White;
            this.gbtnAfterP.Image = null;
            this.gbtnAfterP.ImageSize = new System.Drawing.Size(20, 20);
            this.gbtnAfterP.Location = new System.Drawing.Point(111, 281);
            this.gbtnAfterP.Margin = new System.Windows.Forms.Padding(4);
            this.gbtnAfterP.Name = "gbtnAfterP";
            this.gbtnAfterP.OnHoverBaseColor = System.Drawing.Color.White;
            this.gbtnAfterP.OnHoverBorderColor = System.Drawing.Color.Silver;
            this.gbtnAfterP.OnHoverForeColor = System.Drawing.Color.White;
            this.gbtnAfterP.OnHoverImage = null;
            this.gbtnAfterP.OnPressedColor = System.Drawing.Color.White;
            this.gbtnAfterP.Radius = 8;
            this.gbtnAfterP.Size = new System.Drawing.Size(389, 49);
            this.gbtnAfterP.TabIndex = 4;
            this.gbtnAfterP.Click += new System.EventHandler(this.txtPassword_Click);
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.White;
            this.pnlRight.Controls.Add(this.pctrB_Eye);
            this.pnlRight.Controls.Add(this.txtPassword);
            this.pnlRight.Controls.Add(this.txtUsername);
            this.pnlRight.Controls.Add(this.pctrB_User);
            this.pnlRight.Controls.Add(this.pctrB_User_Gr);
            this.pnlRight.Controls.Add(this.pnlTopM);
            this.pnlRight.Controls.Add(this.gbtnLogin);
            this.pnlRight.Controls.Add(this.pctrB_Pass);
            this.pnlRight.Controls.Add(this.pctrB_Pass_Gr);
            this.pnlRight.Controls.Add(this.gbtnAfterU);
            this.pnlRight.Controls.Add(this.gbtnAfterP);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(499, 0);
            this.pnlRight.Margin = new System.Windows.Forms.Padding(4);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(600, 539);
            this.pnlRight.TabIndex = 32;
            // 
            // pctrB_Eye
            // 
            this.pctrB_Eye.Image = ((System.Drawing.Image)(resources.GetObject("pctrB_Eye.Image")));
            this.pctrB_Eye.Location = new System.Drawing.Point(436, 287);
            this.pctrB_Eye.Margin = new System.Windows.Forms.Padding(4);
            this.pctrB_Eye.Name = "pctrB_Eye";
            this.pctrB_Eye.Size = new System.Drawing.Size(56, 37);
            this.pctrB_Eye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctrB_Eye.TabIndex = 50;
            this.pctrB_Eye.TabStop = false;
            this.pctrB_Eye.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pctrB_Eye_MouseDown);
            // 
            // pctrB_User
            // 
            this.pctrB_User.Image = ((System.Drawing.Image)(resources.GetObject("pctrB_User.Image")));
            this.pctrB_User.Location = new System.Drawing.Point(123, 212);
            this.pctrB_User.Margin = new System.Windows.Forms.Padding(4);
            this.pctrB_User.Name = "pctrB_User";
            this.pctrB_User.Size = new System.Drawing.Size(37, 33);
            this.pctrB_User.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctrB_User.TabIndex = 48;
            this.pctrB_User.TabStop = false;
            this.pctrB_User.Visible = false;
            // 
            // pctrB_User_Gr
            // 
            this.pctrB_User_Gr.Image = global::QuanLyQuanTraSua.Properties.Resources.user_gr;
            this.pctrB_User_Gr.Location = new System.Drawing.Point(123, 212);
            this.pctrB_User_Gr.Margin = new System.Windows.Forms.Padding(4);
            this.pctrB_User_Gr.Name = "pctrB_User_Gr";
            this.pctrB_User_Gr.Size = new System.Drawing.Size(37, 33);
            this.pctrB_User_Gr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctrB_User_Gr.TabIndex = 46;
            this.pctrB_User_Gr.TabStop = false;
            // 
            // pnlTopM
            // 
            this.pnlTopM.BackColor = System.Drawing.Color.White;
            this.pnlTopM.Controls.Add(this.lblMinimize);
            this.pnlTopM.Controls.Add(this.pnlTopR);
            this.pnlTopM.Controls.Add(this.lblClose);
            this.pnlTopM.Controls.Add(this.glblDangNhap);
            this.pnlTopM.Controls.Add(this.pnlMoveR);
            this.pnlTopM.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopM.Location = new System.Drawing.Point(0, 0);
            this.pnlTopM.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTopM.Name = "pnlTopM";
            this.pnlTopM.Size = new System.Drawing.Size(600, 160);
            this.pnlTopM.TabIndex = 47;
            // 
            // lblMinimize
            // 
            this.lblMinimize.AutoSize = true;
            this.lblMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.11765F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimize.ForeColor = System.Drawing.Color.Maroon;
            this.lblMinimize.Location = new System.Drawing.Point(528, 4);
            this.lblMinimize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinimize.Name = "lblMinimize";
            this.lblMinimize.Size = new System.Drawing.Size(22, 29);
            this.lblMinimize.TabIndex = 4;
            this.lblMinimize.Text = "-";
            this.lblMinimize.Click += new System.EventHandler(this.lblMinimize_Click);
            // 
            // pnlTopR
            // 
            this.pnlTopR.BackColor = System.Drawing.Color.Teal;
            this.pnlTopR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlTopR.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopR.Location = new System.Drawing.Point(0, 0);
            this.pnlTopR.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTopR.Name = "pnlTopR";
            this.pnlTopR.Size = new System.Drawing.Size(600, 4);
            this.pnlTopR.TabIndex = 55;
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.BackColor = System.Drawing.Color.White;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.70588F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblClose.Location = new System.Drawing.Point(561, 7);
            this.lblClose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(28, 26);
            this.lblClose.TabIndex = 54;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // glblDangNhap
            // 
            this.glblDangNhap.AutoSize = true;
            this.glblDangNhap.Font = new System.Drawing.Font("Segoe UI", 16.23529F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glblDangNhap.Location = new System.Drawing.Point(204, 80);
            this.glblDangNhap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.glblDangNhap.Name = "glblDangNhap";
            this.glblDangNhap.Size = new System.Drawing.Size(166, 38);
            this.glblDangNhap.TabIndex = 4;
            this.glblDangNhap.Text = "Đăng Nhập";
            // 
            // pnlMoveR
            // 
            this.pnlMoveR.BackColor = System.Drawing.Color.White;
            this.pnlMoveR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlMoveR.Location = new System.Drawing.Point(0, 0);
            this.pnlMoveR.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMoveR.Name = "pnlMoveR";
            this.pnlMoveR.Size = new System.Drawing.Size(600, 38);
            this.pnlMoveR.TabIndex = 68;
            this.pnlMoveR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlMove_MouseDown);
            // 
            // gbtnLogin
            // 
            this.gbtnLogin.AnimationHoverSpeed = 0.07F;
            this.gbtnLogin.AnimationSpeed = 0.03F;
            this.gbtnLogin.BackColor = System.Drawing.Color.Transparent;
            this.gbtnLogin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gbtnLogin.BorderColor = System.Drawing.Color.Black;
            this.gbtnLogin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gbtnLogin.FocusedColor = System.Drawing.Color.Empty;
            this.gbtnLogin.Font = new System.Drawing.Font("Segoe UI", 14.11765F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtnLogin.ForeColor = System.Drawing.Color.White;
            this.gbtnLogin.Image = null;
            this.gbtnLogin.ImageSize = new System.Drawing.Size(20, 20);
            this.gbtnLogin.Location = new System.Drawing.Point(115, 407);
            this.gbtnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.gbtnLogin.Name = "gbtnLogin";
            this.gbtnLogin.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gbtnLogin.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gbtnLogin.OnHoverForeColor = System.Drawing.Color.White;
            this.gbtnLogin.OnHoverImage = null;
            this.gbtnLogin.OnPressedColor = System.Drawing.Color.Black;
            this.gbtnLogin.Radius = 6;
            this.gbtnLogin.Size = new System.Drawing.Size(389, 49);
            this.gbtnLogin.TabIndex = 3;
            this.gbtnLogin.Text = "Đăng Nhập";
            this.gbtnLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gbtnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pctrB_Pass
            // 
            this.pctrB_Pass.Image = ((System.Drawing.Image)(resources.GetObject("pctrB_Pass.Image")));
            this.pctrB_Pass.Location = new System.Drawing.Point(123, 290);
            this.pctrB_Pass.Margin = new System.Windows.Forms.Padding(4);
            this.pctrB_Pass.Name = "pctrB_Pass";
            this.pctrB_Pass.Size = new System.Drawing.Size(37, 33);
            this.pctrB_Pass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctrB_Pass.TabIndex = 49;
            this.pctrB_Pass.TabStop = false;
            this.pctrB_Pass.Visible = false;
            // 
            // pctrB_Pass_Gr
            // 
            this.pctrB_Pass_Gr.Image = global::QuanLyQuanTraSua.Properties.Resources.pass_gr;
            this.pctrB_Pass_Gr.Location = new System.Drawing.Point(123, 290);
            this.pctrB_Pass_Gr.Margin = new System.Windows.Forms.Padding(4);
            this.pctrB_Pass_Gr.Name = "pctrB_Pass_Gr";
            this.pctrB_Pass_Gr.Size = new System.Drawing.Size(37, 33);
            this.pctrB_Pass_Gr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctrB_Pass_Gr.TabIndex = 45;
            this.pctrB_Pass_Gr.TabStop = false;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 7;
            this.gunaElipse1.TargetControl = this;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.gbtnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1099, 539);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlRight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrB_Eye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrB_User)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrB_User_Gr)).EndInit();
            this.pnlTopM.ResumeLayout(false);
            this.pnlTopM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrB_Pass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrB_Pass_Gr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMoveL;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlTopL;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaCircleButton gCircleButton3;
        private Guna.UI.WinForms.GunaCircleButton gCircleButton2;
        private Guna.UI.WinForms.GunaCircleButton gCircleButton1;
        private System.Windows.Forms.PictureBox pctrB_Eye;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.PictureBox pctrB_User;
        private System.Windows.Forms.PictureBox pctrB_User_Gr;
        private System.Windows.Forms.PictureBox pctrB_Pass;
        private System.Windows.Forms.PictureBox pctrB_Pass_Gr;
        private Guna.UI.WinForms.GunaButton gbtnAfterU;
        private Guna.UI.WinForms.GunaButton gbtnAfterP;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlTopM;
        private System.Windows.Forms.Label lblMinimize;
        private System.Windows.Forms.Panel pnlTopR;
        private System.Windows.Forms.Label lblClose;
        private Guna.UI.WinForms.GunaLabel glblDangNhap;
        private System.Windows.Forms.Panel pnlMoveR;
        private Guna.UI.WinForms.GunaButton gbtnLogin;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
    }
}

