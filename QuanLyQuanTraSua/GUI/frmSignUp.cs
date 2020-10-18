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

namespace QuanLyQuanTraSua
{
    public partial class frmSignUp : Form
    {
        public frmSignUp()
        {
            InitializeComponent();
        }

        AccountBUS accountBUS = new AccountBUS();

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == txtRePassword.Text)
            {
                if (accountBUS.insertAccount(txtUsername.Text, txtName.Text, txtPassword.Text, txtPhone.Text, txtEmail.Text))
                {
                    MessageBox.Show("Đăng ký tài khoản thành công");
                    this.Close();
                }
            } 
            else
            {
                MessageBox.Show("Mật khẩu không trùng khớp");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
