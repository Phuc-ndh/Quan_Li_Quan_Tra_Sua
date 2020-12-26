using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QuanLyQuanTraSua
{
    public partial class frmTaiKhoan : Form
    {
        AccountBUS accountBUS = new AccountBUS();
        private frmMain1 parent;
        public frmTaiKhoan(frmMain1 parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            Account currentAccount = new Account();
            currentAccount = accountBUS.getAccountByUsername(this.parent.currentUser.Username);
            txtUsername.Text = currentAccount.Username;
            txtName.Text = currentAccount.Realname;
            txtPhone.Text = currentAccount.PhoneNumber;
            txtEmail.Text = currentAccount.Email;
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
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
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            frmChangePass FrmChangePass = new frmChangePass(this.parent.currentUser.Username);
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
    }
}
