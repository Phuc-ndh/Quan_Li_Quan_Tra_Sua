using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;


namespace QuanLyQuanTraSua
{
    public partial class frmChangePass : Form
    {
        public frmChangePass()
        {
            InitializeComponent();
        }

        private string username;
        public frmChangePass(string _username) : this()
        {
            this.username = _username;
        }

        AccountBUS accountBus = new AccountBUS();

        private bool checkCurrentPass = false;
        private bool checkReType = false;

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            Regex passwordRegex = new Regex(@"^[A-z0-9]{5,12}$");
            if (accountBus.getHashMD5(txtCurrentPass.Text).ToString() == accountBus.getPasswordByUsername(username).ToString())
            {
                checkCurrentPass = true;
            }
            if (txtNewPass.Text == txtReNewPass.Text)
            {
                checkReType = true;
            }

            if (checkReType && checkCurrentPass && passwordRegex.IsMatch(txtNewPass.Text))
            {
                accountBus.updatePassword(username, txtNewPass.Text);
                MessageBox.Show("Đổi mật khẩu thành công");
            } else
            {
                if (!checkCurrentPass)
                {
                    MessageBox.Show("Mật khẩu hiện tại không đúng");
                } 
                else if (!checkReType)
                {
                    MessageBox.Show("Mật khẩu nhập lại không khớp");
                }
                else
                {
                    MessageBox.Show("Mật khẩu mới không phù hợp");
                }
            }
            btnCancel_Click(sender, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmChangePass_Load(object sender, EventArgs e)
        {
        }

        private void txtCurrentPass_TextChanged(object sender, EventArgs e)
        {
            if (!(txtCurrentPass.Text == "Mật Khẩu Hiện Tại" || txtCurrentPass.Text == ""))
            {
                txtCurrentPass.PasswordChar = '*';
            }
            txtCurrentPass.ForeColor = Color.Black;
        }

        private void txtNewPass_TextChanged(object sender, EventArgs e)
        {
            if (!(txtNewPass.Text == "Mật Khẩu Mới" || txtNewPass.Text == ""))
            {
                txtNewPass.PasswordChar = '*';
            }
            txtNewPass.ForeColor = Color.Black;
        }

        private void txtReNewPass_TextChanged(object sender, EventArgs e)
        {
            if (!(txtReNewPass.Text == "Nhập Lại Mật Khẩu Mới" || txtReNewPass.Text == ""))
            {
                txtReNewPass.PasswordChar = '*';
            }
            txtReNewPass.ForeColor = Color.Black;
        }

        private void txtCurrentPass_Click(object sender, EventArgs e)
        {
            if (txtCurrentPass.Text == "Mật Khẩu Hiện Tại")
            {
                txtCurrentPass.Clear();
            }
        }

        private void txtNewPass_Click(object sender, EventArgs e)
        {
            if (txtNewPass.Text == "Mật Khẩu Mới")
            {
                txtNewPass.Clear();
            }
        }

        private void txtReNewPass_Click(object sender, EventArgs e)
        {
            if (txtReNewPass.Text == "Nhập Lại Mật Khẩu Mới")
            {
                txtReNewPass.Clear();
            }
        }

        private void txtCurrentPass_Leave(object sender, EventArgs e)
        {
            if (txtCurrentPass.Text == "")
            {
                txtCurrentPass.Text = "Mật Khẩu Hiện Tại";
                txtCurrentPass.PasswordChar = default;
            }
            if (txtCurrentPass.Text == "Mật Khẩu Hiện Tại")
                txtCurrentPass.ForeColor = Color.Gray;
            else
                txtCurrentPass.ForeColor = Color.Black;
        }

        private void txtNewPass_Leave(object sender, EventArgs e)
        {
            if (txtNewPass.Text == "")
            {
                txtNewPass.Text = "Mật Khẩu Mới";
                txtNewPass.PasswordChar = default;
            }
            if (txtNewPass.Text == "Mật Khẩu Mới")
                txtNewPass.ForeColor = Color.Gray;
            else
                txtNewPass.ForeColor = Color.Black;
        }

        private void txtReNewPass_Leave(object sender, EventArgs e)
        {
            if (txtReNewPass.Text == "")
            {
                txtReNewPass.Text = "Nhập Lại Mật Khẩu Mới";
                txtReNewPass.PasswordChar = default;
            }
            if (txtReNewPass.Text == "Nhập Lại Mật Khẩu Mới")
                txtReNewPass.ForeColor = Color.Gray;
            else
                txtReNewPass.ForeColor = Color.Black;
        }
    }
}
