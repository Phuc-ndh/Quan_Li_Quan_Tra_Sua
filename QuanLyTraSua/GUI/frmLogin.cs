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

namespace GUI
{
    public partial class frmLogin : Form
    {
        AccountBUS accountBus;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (accountBus.Login(txtID.Text, txtPassword.Text))
            {
                this.Hide();
                frmMain form = new frmMain();
                form.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai mật khẩu hoặc tài khoản");
                txtPassword.Text = "";
                txtPassword.Focus();
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
    }
}
