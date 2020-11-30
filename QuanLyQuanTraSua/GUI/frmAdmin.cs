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
    public partial class frmAdmin : Form
    {
        public Account selectedAccount = new Account();
        AccountBUS accountBUS = new AccountBUS();
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            List<Account> listAccount = accountBUS.GetAccountList();
            foreach (Account account in listAccount)
            {
                Button btn = new Button() { Width = 120, Height = 60, Text = account.Username, Tag = account };
                btn.Click += Btn_Click;
                flowLayoutPanel1.Controls.Add(btn);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            selectedAccount = (sender as Button).Tag as Account;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (accountBUS.deleteAccount(selectedAccount.Username))
            {
                MessageBox.Show("Đã xóa thành công");
                flowLayoutPanel1.Controls.Clear();
                frmAdmin_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }    
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            frmUpdateTK frm1 = new frmUpdateTK(this);
            frm1.ShowDialog();
            flowLayoutPanel1.Controls.Clear();
            frmAdmin_Load(sender, e);
        }
    }
}
