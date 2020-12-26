using System;
using System.Drawing;
using System.Windows.Forms;
using BUS;
using System.Runtime.InteropServices;
using DTO;

namespace QuanLyQuanTraSua
{
    public partial class frmLogin : Form
    {
        AccountBUS accountBus = new AccountBUS();
        public Account currentUser;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (accountBus.Login(txtUsername.Text, txtPassword.Text))
            {
                this.Hide();
                currentUser = accountBus.getAccountByUsername(txtUsername.Text);
                frmMain1 form = new frmMain1(this);
                form.ShowDialog();
                this.Show();
                //--
                currentUser = null;
                txtUsername.Text = "Username";
                txtPassword.Text = "Password";
                txtPassword.PasswordChar = default;
                txtUsername.Focus();
            }
            else
            {
                MessageBox.Show("Sai mật khẩu hoặc tài khoản");
                txtPassword.Text = "";
                txtUsername.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void txtUsername_Click(object sender, EventArgs e)
        {
            txtUsername.Focus();

            if (txtUsername.Text == "Tên Đăng Nhập")
            {
                txtUsername.Clear();
            }
            this.pctrB_User.Visible = true;
            txtUsername.ForeColor = Color.FromArgb(100, 88, 255);
            gbtnAfterU.BorderColor = Color.FromArgb(100, 88, 255);
            //
            //ptrPassword.BackgroundImage = Properties.Resources.pass;
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Focus();
            if (txtPassword.Text == "Mật Khẩu")
            {
                txtPassword.Clear();
            }
            this.pctrB_Pass.Visible = true;
            txtPassword.ForeColor = Color.FromArgb(100, 88, 255);
            gbtnAfterP.BorderColor = Color.FromArgb(100, 88, 255);
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            this.pctrB_User.Visible = true;
            txtUsername.ForeColor = Color.FromArgb(100, 88, 255);
            gbtnAfterU.BorderColor = Color.FromArgb(100, 88, 255);
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (!(txtPassword.Text == "Mật Khẩu" || txtPassword.Text == ""))
            {
                txtPassword.PasswordChar = '*';
            }
            //
            this.pctrB_Pass.Visible = true;
            txtPassword.ForeColor = Color.FromArgb(100, 88, 255);
            gbtnAfterP.BorderColor = Color.FromArgb(100, 88, 255);
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

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            gbtnAfterU.BorderColor = Color.Silver;
            if (txtUsername.Text == "")
                txtUsername.Text = "Tên Đăng Nhập";
            if (txtUsername.Text == "Tên Đăng Nhập")
                txtUsername.ForeColor = Color.Gray;
            else
                txtUsername.ForeColor = Color.Black;
            this.pctrB_User.Visible = false;

        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            gbtnAfterP.BorderColor = Color.Silver;
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Mật Khẩu";
                txtPassword.PasswordChar = default;
            }
            if (txtPassword.Text == "Mật Khẩu")
                txtPassword.ForeColor = Color.Gray;
            else
                txtPassword.ForeColor = Color.Black;
            this.pctrB_Pass.Visible = false;
        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pctrB_Eye_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && txtPassword.Text != "Mật Khẩu")
            {
                if (txtPassword.PasswordChar == '*')
                    txtPassword.PasswordChar = default;
                else
                    txtPassword.PasswordChar = '*';
            }
        }

        //viền shadow
        //
        private const int CS_DropShadow = 0x20000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DropShadow;
                return cp;
            }
        }
    }
}
