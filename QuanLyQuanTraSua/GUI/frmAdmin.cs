﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
            panel2.MouseDown += panelTitleBar_MouseDown;
            List<Account> listAccount = accountBUS.GetAccountList();
            foreach (Account account in listAccount)
            {
                Button btn = new Button() { Width = 120, Height = 60, Text = account.Username, Tag = account };
                btn.ForeColor = Color.Black;
                btn.BackColor = Color.FromArgb(192, 255, 255);
                //btn.FlatStyle = FlatStyle.Flat;
                //btn.FlatAppearance.BorderSize = 1;
                //btn.FlatAppearance.BorderColor = Color.FromArgb(151, 143, 255);
                btn.Font = new Font("Arial", 12f);
                if (account.Type == 1)
                {
                    btn.ForeColor = Color.Black;
                    btn.Font = new Font("Arial", 12f,FontStyle.Bold);
                    btn.BackColor = Color.FromArgb(78, 184, 206);
                }
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
            if (selectedAccount.Username != null)
            {
                if (selectedAccount.Username == "admin")
                {
                    MessageBox.Show("Không thể xóa tài khoản này");
                }
                else
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
            }
            else
                MessageBox.Show("Chọn một tài khoản trước khi xóa");
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (selectedAccount.Username != null)
            {
                frmTaiKhoan frm1 = new frmTaiKhoan(selectedAccount.Username);
                frm1.ShowDialog();
                flowLayoutPanel1.Controls.Clear();
                frmAdmin_Load(sender, e);
            }
            else
                MessageBox.Show("Chọn một tài khoản để sửa thông tin");
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.Clicks == 1)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
        }

        //viền shadow
        private const int CS_DropShadow = 0x20000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DropShadow;
                return cp;
            }
        }

    }
}
