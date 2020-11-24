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
using FontAwesome.Sharp;

namespace QuanLyQuanTraSua
{
    public partial class frmMain1 : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public frmMain1()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            pnlMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        //Change color of button
        private struct RGBColors
        {
            //public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color1 = Color.FromArgb(197, 190, 250);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                //currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                //currentBtn.BackColor = Color.FromArgb(69,69,69);
                currentBtn.BackColor = Color.FromArgb(90,90,90);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                //currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                //currentBtn.BackColor = Color.FromArgb(69, 69, 69);
                //currentBtn.BackColor = Color.FromArgb(105, 105, 105);
                currentBtn.BackColor = Color.FromArgb(75, 75, 75);

                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlDesktop.Controls.Add(childForm);
            pnlDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //lblTitleChildForm.Text = childForm.Text;
            switch (childForm.Text)
            {
                case "frmTongQuan":
                    lblTitleChildForm.Text = "Tổng Quan";
                    break;
                case "frmMatHang":
                    lblTitleChildForm.Text = "Mặt Hàng";
                    break;
                case "frmThongKe":
                    lblTitleChildForm.Text = "Thống Kê";
                    break;
              
            }
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            lblTitleChildForm.Text = "Home";
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }
        //Menu Button_Clicks

        private void btnTongQuan_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new frmTongQuan());

        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new frmThongKe());
        }
        private void btnMatHang_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new frmMatHang());
        }
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            frmSignUp frmSU =new frmSignUp();
            //frmSignUp.FormClosed += new FormClosedEventHandler(FrmSignUp_FormClosed);
            //this.Hide();
            this.Visible = false;
            frmSU.ShowDialog();
            btnHome_Click(sender, e);
            this.Visible = true;
            //this.Show();
        }

        private void FrmSignUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            //OpenChildForm(new frmTaiKhoan());
            this.Hide();
            frmTaiKhoan formTK = new frmTaiKhoan();
            formTK.ShowDialog();
            btnHome_Click(sender, e);
            this.Show();
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangXuat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
       
        //End of Change color of button

    }
}
