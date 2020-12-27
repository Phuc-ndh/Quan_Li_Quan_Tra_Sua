using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QuanLyQuanTraSua
{
    public partial class frmTaiKhoan : Form
    {
        bool flag;
        AccountBUS accountBUS = new AccountBUS();
        private string username;
        public frmTaiKhoan(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            Account currentAccount = new Account();
            currentAccount = accountBUS.getAccountByUsername(this.username);
            txtUsername.Text = currentAccount.Username;
            txtName.Text = currentAccount.Realname;
            txtPhone.Text = currentAccount.PhoneNumber;
            txtEmail.Text = currentAccount.Email;
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            Regex emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Regex phoneRegex = new Regex(@"^[0-9]{1,12}$");
            flag = true;
            string errorMessage = null;
            if (txtName.Enabled == false)
            {
                txtUsername.Enabled = false;
                txtName.Enabled = true;
                txtPhone.Enabled = true;
                txtEmail.Enabled = true;
                gbtnSua.Text = "Hoàn Tất";
            }
            else
            {
                if (txtPhone.TextLength > 0 && txtPhone.Text != "SĐT") //Kiểm tra điều kiện SĐT
                {
                    if (!phoneRegex.IsMatch(txtPhone.Text))
                    {
                        errorMessage += "- Số điện thoại không hợp lệ\n";
                        flag = false;
                    }
                }
                if (txtEmail.TextLength > 0 && txtEmail.Text != "Email") //Kiểm tra điều kiện email
                {
                    if (!emailRegex.IsMatch(txtEmail.Text))
                    {
                        errorMessage += "- Email không hợp lệ\n";
                        flag = false;
                    }
                }
                if (flag)
                {
                    if (accountBUS.updateAccount(txtUsername.Text, txtName.Text, txtPhone.Text, txtEmail.Text))
                    {
                        MessageBox.Show("Cập nhật thành công");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại");
                    }
                    txtUsername.Enabled = false;
                    txtName.Enabled = false;
                    txtPhone.Enabled = false;
                    txtEmail.Enabled = false;
                    gbtnSua.Text = "Sửa Thông Tin";
                }
                else
                    MessageBox.Show(errorMessage);
            }
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            frmChangePass FrmChangePass = new frmChangePass(this.username);
            FrmChangePass.ShowDialog();
        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Drag Form
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pnlMove_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.Clicks == 1)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
