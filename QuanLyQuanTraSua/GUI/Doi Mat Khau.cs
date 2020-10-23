using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanTraSua
{
    public partial class frmChangeInfo : Form
    {
        public frmChangeInfo()
        {
            InitializeComponent();
        }

        BUS.AccountBUS accountBUS = new BUS.AccountBUS();

        private bool chkPass = false;
        
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (accountBUS.getPasswordByUsername(txtUsername.Text) == accountBUS.getHashMD5(txtCurrentPassword.Text).ToString())
            {
                chkPass = true;
            }
            if (chkPass){
                accountBUS.updateInfo(txtUsername.Text, txtName.Text, txtPhone.Text, txtEmail.Text);
                MessageBox.Show("Doi thong tin thanh cong");
            }
            else
            {
                MessageBox.Show("Loi");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
