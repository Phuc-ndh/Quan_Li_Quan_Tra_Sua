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

        protected AccountBUS accountBUS;

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == txtRePassword.Text)
            {
                if (accountBUS.SignUp(txtUsername.Text, txtName.Text, txtPassword.Text, txtPhone.Text, txtEmail.Text))
                {
                    MessageBox.Show("Dang Ky thanh cong !");
                    this.Close();
                }
            } else
            {
                MessageBox.Show("Mat khau khong khop");
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
