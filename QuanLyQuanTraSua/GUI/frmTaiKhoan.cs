using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void label5_Click(object sender, EventArgs e)
        {
            btnCancel_Click(sender, e);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtName.Enabled == false)
            {
                txtUsername.Enabled = false;
                txtName.Enabled = true;
                txtPhone.Enabled = true;
                txtEmail.Enabled = true;
                btnSua.Text = "Hoàn Tất";
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
                btnSua.Text = "Sửa Thông Tin";
            }
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            frmChangePass FrmChangePass = new frmChangePass(this.parent.currentUser.Username);
            FrmChangePass.ShowDialog();
        }
    }
}
