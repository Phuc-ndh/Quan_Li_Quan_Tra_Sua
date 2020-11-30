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
    public partial class frmUpdateTK : Form
    {
        AccountBUS accountBUS = new AccountBUS();
        frmAdmin parent = new frmAdmin();
        public frmUpdateTK(frmAdmin parent)
        {
            this.parent = parent;
            InitializeComponent();
        }
        private void frmUpdateTK_Load(object sender, EventArgs e)
        {
            txtUsername.Text = this.parent.selectedAccount.Username;
            txtName.Text = this.parent.selectedAccount.Realname;
            txtPhone.Text = this.parent.selectedAccount.PhoneNumber;
            txtEmail.Text = this.parent.selectedAccount.Email;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (accountBUS.updateAccount(txtUsername.Text, txtName.Text, txtPhone.Text, txtEmail.Text))
            {
                MessageBox.Show("OK");
            }
            else
            {
                MessageBox.Show("Khong duoc");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
