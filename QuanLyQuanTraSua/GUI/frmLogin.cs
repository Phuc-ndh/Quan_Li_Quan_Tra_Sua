using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using BUS;
using System.Runtime.InteropServices;


namespace QuanLyQuanTraSua
{
    public partial class frmLogin : Form
    {
        AccountBUS accountBus = new AccountBUS();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (accountBus.Login(txtPassword.Text, txtPassword.Text))
            {
                this.Hide();
                frmMain1 form = new frmMain1();
                form.ShowDialog();
                this.Show();
                //--
                txtUsername.Text = "Username";
                txtPassword.Text = "Password";
                txtUsername.Focus();
            }
            else
            {
                MessageBox.Show("Sai mật khẩu hoặc tài khoản");
                txtPassword.Text = "";
                //txtPassword.Focus();
                txtUsername.Focus();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnLogin_Click(sender, e);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            ptrUsername.BackgroundImage = Properties.Resources.user1;
            this.ptrUser1.Visible = true;
            pnlUser.ForeColor = Color.FromArgb(78, 184, 206);
            txtUsername.ForeColor = Color.FromArgb(78, 184, 206);

            ptrPassword.BackgroundImage = Properties.Resources.pass;
            this.ptrPass1.Visible = false;
            pnlPass.ForeColor = Color.White;
            txtPassword.ForeColor = Color.White;

        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtPassword.PasswordChar = '*';
            ptrPassword.BackgroundImage = Properties.Resources.pass1;
            this.ptrPass1.Visible = true;
            pnlPass.ForeColor = Color.FromArgb(78, 184, 206);
            txtPassword.ForeColor = Color.FromArgb(78, 184, 206);


            ptrUsername.BackgroundImage = Properties.Resources.user;
            this.ptrUser1.Visible = false;
            pnlUser.ForeColor = Color.White;
            txtUsername.ForeColor = Color.White;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
            //ptrPassword.BackgroundImage = Properties.Resources.pass1;
            this.ptrUser1.Visible = true;
            pnlUser.ForeColor = Color.FromArgb(78, 184, 206);
            txtUsername.ForeColor = Color.FromArgb(78, 184, 206);


            //ptrUsername.BackgroundImage = Properties.Resources.user;
            this.ptrPass1.Visible = false;
            pnlPass.ForeColor = Color.White;
            txtPassword.ForeColor = Color.White;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            //ptrUsername.BackgroundImage = Properties.Resources.user1;
            this.ptrPass1.Visible = true;
            pnlPass.ForeColor = Color.FromArgb(78, 184, 206);
            txtPassword.ForeColor = Color.FromArgb(78, 184, 206);

            //ptrPassword.BackgroundImage = Properties.Resources.pass;
            this.ptrUser1.Visible = false;
            pnlUser.ForeColor = Color.White;
            txtUsername.ForeColor = Color.White;
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void pnlMove_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
