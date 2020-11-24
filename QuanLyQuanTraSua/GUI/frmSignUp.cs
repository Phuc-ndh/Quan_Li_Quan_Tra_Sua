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
            //frmMain1 frmM1 = new frmMain1();
            //frmM1.Show();
            
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            //ptrUsername.BackgroundImage = Properties.Resources.user1;
            this.ptrUser1.Visible = true;
            pnlUser.ForeColor = Color.FromArgb(78, 184, 206);
            txtUsername.ForeColor = Color.FromArgb(78, 184, 206);

            //ptrPassword.BackgroundImage = Properties.Resources.pass;
            this.ptrPass1.Visible = false;
            pnlPass.ForeColor = Color.White;
            txtPassword.ForeColor = Color.White;

            this.ptrRetypePass1.Visible = false;
            pnlRetypePass.ForeColor = Color.White;
            txtRePassword.ForeColor = Color.White;

            this.ptrName1.Visible = false;
            pnlName.ForeColor = Color.White;
            txtName.ForeColor = Color.White;

            this.ptrPhone1.Visible = false;
            pnlPhone.ForeColor = Color.White;
            txtPhone.ForeColor = Color.White;

            this.ptrEmail1.Visible = false;
            pnlEmail.ForeColor = Color.White;
            txtEmail.ForeColor = Color.White;
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtPassword.PasswordChar = '*';
            //ptrPassword.BackgroundImage = Properties.Resources.pass1;
            this.ptrPass1.Visible = true;
            pnlPass.ForeColor = Color.FromArgb(78, 184, 206);
            txtPassword.ForeColor = Color.FromArgb(78, 184, 206);

            //ptrUsername.BackgroundImage = Properties.Resources.user;
            this.ptrUser1.Visible = false;
            pnlUser.ForeColor = Color.White;
            txtUsername.ForeColor = Color.White;

            this.ptrRetypePass1.Visible = false;
            pnlRetypePass.ForeColor = Color.White;
            txtRePassword.ForeColor = Color.White;

            this.ptrName1.Visible = false;
            pnlName.ForeColor = Color.White;
            txtName.ForeColor = Color.White;

            this.ptrPhone1.Visible = false;
            pnlPhone.ForeColor = Color.White;
            txtPhone.ForeColor = Color.White;

            this.ptrEmail1.Visible = false;
            pnlEmail.ForeColor = Color.White;
            txtEmail.ForeColor = Color.White;
        }

        private void txtRetypePass_Click(object sender, EventArgs e)
        {
            txtRePassword.Clear();
            txtRePassword.PasswordChar = '*';
            //ptrRetypePass.BackgroundImage = Properties.Resources.pass1;
            this.ptrRetypePass1.Visible = true;
            pnlRetypePass.ForeColor = Color.FromArgb(78, 184, 206);
            txtRePassword.ForeColor = Color.FromArgb(78, 184, 206);

            //ptrPassword.BackgroundImage = Properties.Resources.pass;
            this.ptrPass1.Visible = false;
            pnlPass.ForeColor = Color.White;
            txtPassword.ForeColor = Color.White;

            this.ptrUser1.Visible = false;
            pnlUser.ForeColor = Color.White;
            txtUsername.ForeColor = Color.White;

            this.ptrName1.Visible = false;
            pnlName.ForeColor = Color.White;
            txtName.ForeColor = Color.White;

            this.ptrPhone1.Visible = false;
            pnlPhone.ForeColor = Color.White;
            txtPhone.ForeColor = Color.White;

            this.ptrEmail1.Visible = false;
            pnlEmail.ForeColor = Color.White;
            txtEmail.ForeColor = Color.White;
        }

        private void txtName_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            //ptrName.BackgroundImage = Properties.Resources.name;
            this.ptrName1.Visible = true;
            pnlName.ForeColor = Color.FromArgb(78, 184, 206);
            txtName.ForeColor = Color.FromArgb(78, 184, 206);

            //ptrPassword.BackgroundImage = Properties.Resources.pass;
            this.ptrPass1.Visible = false;
            pnlPass.ForeColor = Color.White;
            txtPassword.ForeColor = Color.White;

            this.ptrUser1.Visible = false;
            pnlUser.ForeColor = Color.White;
            txtUsername.ForeColor = Color.White;

            this.ptrRetypePass1.Visible = false;
            pnlRetypePass.ForeColor = Color.White;
            txtRePassword.ForeColor = Color.White;

            this.ptrPhone1.Visible = false;
            pnlPhone.ForeColor = Color.White;
            txtPhone.ForeColor = Color.White;

            this.ptrEmail1.Visible = false;
            pnlEmail.ForeColor = Color.White;
            txtEmail.ForeColor = Color.White;
        }

        private void txtPhone_Click(object sender, EventArgs e)
        {
            txtPhone.Clear();
            //ptrPassword.BackgroundImage = Properties.Resources.pass1;
            this.ptrPhone1.Visible = true;
            pnlPhone.ForeColor = Color.FromArgb(78, 184, 206);
            txtPhone.ForeColor = Color.FromArgb(78, 184, 206);

            //ptrPassword.BackgroundImage = Properties.Resources.pass;
            this.ptrPass1.Visible = false;
            pnlPass.ForeColor = Color.White;
            txtPassword.ForeColor = Color.White;

            this.ptrUser1.Visible = false;
            pnlUser.ForeColor = Color.White;
            txtUsername.ForeColor = Color.White;
            this.ptrRetypePass1.Visible = false;
            pnlRetypePass.ForeColor = Color.White;
            txtRePassword.ForeColor = Color.White;

            this.ptrName1.Visible = false;
            pnlName.ForeColor = Color.White;
            txtName.ForeColor = Color.White;

            this.ptrEmail1.Visible = false;
            pnlEmail.ForeColor = Color.White;
            txtEmail.ForeColor = Color.White;
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
            //ptrPassword.BackgroundImage = Properties.Resources.pass1;
            this.ptrEmail1.Visible = true;
            pnlEmail.ForeColor = Color.FromArgb(78, 184, 206);
            txtEmail.ForeColor = Color.FromArgb(78, 184, 206);

            //ptrPassword.BackgroundImage = Properties.Resources.pass;
            this.ptrPass1.Visible = false;
            pnlPass.ForeColor = Color.White;
            txtPassword.ForeColor = Color.White;

            this.ptrUser1.Visible = false;
            pnlUser.ForeColor = Color.White;
            txtUsername.ForeColor = Color.White;
            this.ptrRetypePass1.Visible = false;
            pnlRetypePass.ForeColor = Color.White;
            txtRePassword.ForeColor = Color.White;

            this.ptrName1.Visible = false;
            pnlName.ForeColor = Color.White;
            txtName.ForeColor = Color.White;

            this.ptrPhone1.Visible = false;
            pnlPhone.ForeColor = Color.White;
            txtPhone.ForeColor = Color.White;

        }



        //=== TextChanged ================
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            //ptrUsername.BackgroundImage = Properties.Resources.user1;
            this.ptrUser1.Visible = true;
            pnlUser.ForeColor = Color.FromArgb(78, 184, 206);
            txtUsername.ForeColor = Color.FromArgb(78, 184, 206);

            //ptrPassword.BackgroundImage = Properties.Resources.pass;
            this.ptrPass1.Visible = false;
            pnlPass.ForeColor = Color.White;
            txtPassword.ForeColor = Color.White;

            this.ptrRetypePass1.Visible = false;
            pnlRetypePass.ForeColor = Color.White;
            txtRePassword.ForeColor = Color.White;

            this.ptrName1.Visible = false;
            pnlName.ForeColor = Color.White;
            txtName.ForeColor = Color.White;

            this.ptrPhone1.Visible = false;
            pnlPhone.ForeColor = Color.White;
            txtPhone.ForeColor = Color.White;

            this.ptrEmail1.Visible = false;
            pnlEmail.ForeColor = Color.White;
            txtEmail.ForeColor = Color.White;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
            //ptrPassword.BackgroundImage = Properties.Resources.pass1;
            this.ptrPass1.Visible = true;
            pnlPass.ForeColor = Color.FromArgb(78, 184, 206);
            txtPassword.ForeColor = Color.FromArgb(78, 184, 206);

            //ptrUsername.BackgroundImage = Properties.Resources.user;
            this.ptrUser1.Visible = false;
            pnlUser.ForeColor = Color.White;
            txtUsername.ForeColor = Color.White;

            this.ptrRetypePass1.Visible = false;
            pnlRetypePass.ForeColor = Color.White;
            txtRePassword.ForeColor = Color.White;

            this.ptrName1.Visible = false;
            pnlName.ForeColor = Color.White;
            txtName.ForeColor = Color.White;

            this.ptrPhone1.Visible = false;
            pnlPhone.ForeColor = Color.White;
            txtPhone.ForeColor = Color.White;

            this.ptrEmail1.Visible = false;
            pnlEmail.ForeColor = Color.White;
            txtEmail.ForeColor = Color.White;
        }

        private void txtRetypePass_TextChanged(object sender, EventArgs e)
        {
            txtRePassword.PasswordChar = '*';
            //ptrRetypePass.BackgroundImage = Properties.Resources.pass1;
            this.ptrRetypePass1.Visible = true;
            pnlRetypePass.ForeColor = Color.FromArgb(78, 184, 206);
            txtRePassword.ForeColor = Color.FromArgb(78, 184, 206);

            //ptrPassword.BackgroundImage = Properties.Resources.pass;
            this.ptrPass1.Visible = false;
            pnlPass.ForeColor = Color.White;
            txtPassword.ForeColor = Color.White;

            this.ptrUser1.Visible = false;
            pnlUser.ForeColor = Color.White;
            txtUsername.ForeColor = Color.White;

            this.ptrName1.Visible = false;
            pnlName.ForeColor = Color.White;
            txtName.ForeColor = Color.White;

            this.ptrPhone1.Visible = false;
            pnlPhone.ForeColor = Color.White;
            txtPhone.ForeColor = Color.White;

            this.ptrEmail1.Visible = false;
            pnlEmail.ForeColor = Color.White;
            txtEmail.ForeColor = Color.White;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            //ptrName.BackgroundImage = Properties.Resources.name;
            this.ptrName1.Visible = true;
            pnlName.ForeColor = Color.FromArgb(78, 184, 206);
            txtName.ForeColor = Color.FromArgb(78, 184, 206);

            //ptrPassword.BackgroundImage = Properties.Resources.pass;
            this.ptrPass1.Visible = false;
            pnlPass.ForeColor = Color.White;
            txtPassword.ForeColor = Color.White;

            this.ptrUser1.Visible = false;
            pnlUser.ForeColor = Color.White;
            txtUsername.ForeColor = Color.White;

            this.ptrRetypePass1.Visible = false;
            pnlRetypePass.ForeColor = Color.White;
            txtRePassword.ForeColor = Color.White;

            this.ptrPhone1.Visible = false;
            pnlPhone.ForeColor = Color.White;
            txtPhone.ForeColor = Color.White;

            this.ptrEmail1.Visible = false;
            pnlEmail.ForeColor = Color.White;
            txtEmail.ForeColor = Color.White;
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            //ptrPassword.BackgroundImage = Properties.Resources.pass1;
            this.ptrPhone1.Visible = true;
            pnlPhone.ForeColor = Color.FromArgb(78, 184, 206);
            txtPhone.ForeColor = Color.FromArgb(78, 184, 206);

            //ptrPassword.BackgroundImage = Properties.Resources.pass;
            this.ptrPass1.Visible = false;
            pnlPass.ForeColor = Color.White;
            txtPassword.ForeColor = Color.White;

            this.ptrUser1.Visible = false;
            pnlUser.ForeColor = Color.White;
            txtUsername.ForeColor = Color.White;
            this.ptrRetypePass1.Visible = false;
            pnlRetypePass.ForeColor = Color.White;
            txtRePassword.ForeColor = Color.White;

            this.ptrName1.Visible = false;
            pnlName.ForeColor = Color.White;
            txtName.ForeColor = Color.White;

            this.ptrEmail1.Visible = false;
            pnlEmail.ForeColor = Color.White;
            txtEmail.ForeColor = Color.White;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            //ptrPassword.BackgroundImage = Properties.Resources.pass1;
            this.ptrEmail1.Visible = true;
            pnlEmail.ForeColor = Color.FromArgb(78, 184, 206);
            txtEmail.ForeColor = Color.FromArgb(78, 184, 206);

            //ptrPassword.BackgroundImage = Properties.Resources.pass;
            this.ptrPass1.Visible = false;
            pnlPass.ForeColor = Color.White;
            txtPassword.ForeColor = Color.White;

            this.ptrUser1.Visible = false;
            pnlUser.ForeColor = Color.White;
            txtUsername.ForeColor = Color.White;
            this.ptrRetypePass1.Visible = false;
            pnlRetypePass.ForeColor = Color.White;
            txtRePassword.ForeColor = Color.White;

            this.ptrName1.Visible = false;
            pnlName.ForeColor = Color.White;
            txtName.ForeColor = Color.White;

            this.ptrPhone1.Visible = false;
            pnlPhone.ForeColor = Color.White;
            txtPhone.ForeColor = Color.White;

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
