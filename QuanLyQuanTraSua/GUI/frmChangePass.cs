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
            if (accountBus.getHashMD5(txtCurrentPass.Text).ToString() == accountBus.getPasswordByUsername(username).ToString())
            {
                checkCurrentPass = true;
            }
            if (txtNewPass.Text == txtReNewPass.Text)
            {
                checkReType = true;
            }

            if (checkReType && checkCurrentPass)
            {
                accountBus.updatePassword(username, txtNewPass.Text);
                MessageBox.Show("Doi mk thanh cong");
            } else
            {
                if (!checkCurrentPass)
                {
                    MessageBox.Show("Mat khau hien tai khong dung");
                    // hien label mk hien tai sai
                } else
                {
                    if (!checkReType)
                    {
                        MessageBox.Show("Mat khau moi khong khop");
                        // hien label mk ko khop
                    }
                }
            }
            btnCancel_Click(sender, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void focusTextBox()
        {
            if (txtCurrentPass.Focused == true)
            {
                pnlCurrentPass.BackColor = Color.Aqua;
                pnlNewPass.BackColor = Color.White;
                pnlReType.BackColor = Color.White;
            } else
            {
                if (txtNewPass.Focused == true)
                {
                    pnlCurrentPass.BackColor = Color.White;
                    pnlNewPass.BackColor = Color.Aqua;
                    pnlReType.BackColor = Color.White;
                } else
                {
                    if (txtReNewPass.Focused == true)
                    {
                        pnlCurrentPass.BackColor = Color.White;
                        pnlNewPass.BackColor = Color.White;
                        pnlReType.BackColor = Color.Aqua;
                    }
                }
            }
        }

        private void frmChangePass_Load(object sender, EventArgs e)
        {
            pnlCurrentPass.BackColor = Color.White;
            pnlNewPass.BackColor = Color.White;
            pnlReType.BackColor = Color.White;
        }

        private void txtCurrentPass_TextChanged(object sender, EventArgs e)
        {
            pnlCurrentPass.ForeColor = Color.Aqua;
            pnlCurrentPass.BackColor = Color.Aqua;

            pnlNewPass.BackColor = Color.White;
            pnlReType.BackColor = Color.White;
            txtNewPass.ForeColor = Color.Gray;
            txtReNewPass.ForeColor = Color.Gray;
        }

        private void txtNewPass_TextChanged(object sender, EventArgs e)
        {
            //pnlNewPass.ForeColor = Color.Aqua;
            pnlNewPass.BackColor = Color.Aqua;

            pnlCurrentPass.BackColor = Color.White;
            pnlReType.BackColor = Color.White;
            txtReNewPass.ForeColor = Color.Gray;
            txtNewPass.ForeColor = Color.Gray;
        }

        private void txtReNewPass_TextChanged(object sender, EventArgs e)
        {
            //pnlReType.ForeColor = Color.Aqua;
            pnlReType.BackColor = Color.Aqua;

            pnlNewPass.BackColor = Color.White;
            pnlReType.BackColor = Color.White;
            txtNewPass.ForeColor = Color.Gray;
            txtReNewPass.ForeColor = Color.Gray;

        }

        private void txtCurrentPass_Click(object sender, EventArgs e)
        {
            if (txtCurrentPass.Text == "Password hiện tại")
            {
                txtCurrentPass.Clear();
                focusTextBox(); 
            }
        }

        private void txtNewPass_Click(object sender, EventArgs e)
        {
            if (txtNewPass.Text == "Password mới")
            {
                txtNewPass.Clear();
                focusTextBox();
            }
        }

        private void txtReNewPass_Click(object sender, EventArgs e)
        {
            if (txtReNewPass.Text == "Nhập lại pasword mới")
            {
                txtReNewPass.Clear();
                focusTextBox();
            }
        }
    }
}
