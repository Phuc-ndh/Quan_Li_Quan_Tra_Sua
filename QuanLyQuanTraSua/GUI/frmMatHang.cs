using BUS;
using DTO;
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
    public partial class frmMatHang : Form
    {
        Image originImage = null;
        DrinkBUS drinkBUS = new DrinkBUS();
        DrinkCategoryBUS drinkCategoryBUS = new DrinkCategoryBUS();
        public frmMatHang()
        {
            InitializeComponent();
        }

        private void frmMatHang_Load(object sender, EventArgs e)
        {
            gDataGridView1.DataSource = drinkBUS.GetAllDrinksDetailed();
            gDataGridView1.Columns["Loại"].Width = 150;
            gDataGridView1.Columns["Giá"].Width = 100;
            gDataGridView1.Columns["idDrink"].Visible = false;
            gDataGridView1.Columns["idCategory"].Visible = false;

            //cbbLoai.DisplayMember = "Name";
            //cbbLoai.DataSource = drinkCategoryBUS.GetDrinkCategories();
            gcbbLoai.DisplayMember = "Name";
            gcbbLoai.DataSource = drinkCategoryBUS.GetDrinkCategories();
            /*
            cbbLoai.DataBindings.Add(new Binding("SelectedIndex", dataGridView1.DataSource, "idCategory"));
            txtTenMatHang.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Tên"));
            txtGia.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Giá"));
            */
            //
            gDataGridView1.DataSource = drinkBUS.GetAllDrinksDetailed();
            gDataGridView1.Columns["Loại"].Width = 150;
            gDataGridView1.Columns["Giá"].Width = 100;
            gDataGridView1.Columns["idDrink"].Visible = false;
            gDataGridView1.Columns["idCategory"].Visible = false;
            gDataGridView1.Columns["Image"].Visible = false;
            
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (gDataGridView1.SelectedRows.Count > 0)
            {
                //txtTenMatHang.Text = gDataGridView1.SelectedRows[0].Cells["Tên"].Value.ToString();
                //txtGia.Text = gDataGridView1.SelectedRows[0].Cells["Giá"].Value.ToString();
                //cbbLoai.SelectedIndex = cbbLoai.FindStringExact(gDataGridView1.SelectedRows[0].Cells["Loại"].Value.ToString());
                gtxtTenMatHang.Text = gDataGridView1.SelectedRows[0].Cells["Tên"].Value.ToString();
                gtxtGia.Text = gDataGridView1.SelectedRows[0].Cells["Giá"].Value.ToString();
                gcbbLoai.SelectedIndex = gcbbLoai.FindStringExact(gDataGridView1.SelectedRows[0].Cells["Loại"].Value.ToString());
                pboxAnh.Image = ImageHelper.ResizeImage(ImageHelper.ByteArrayToImage((byte[])gDataGridView1.SelectedRows[0].Cells["Image"].Value), 95, 95);
                originImage = ImageHelper.ByteArrayToImage((byte[])gDataGridView1.SelectedRows[0].Cells["Image"].Value);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                btnThem.Text = "OK";
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                gDataGridView1.Enabled = false;
                gtxtTenMatHang.Enabled = true;
                gtxtGia.Enabled = true;
                gcbbLoai.Enabled = true;
                btnThemAnh.Enabled = true;

                gtxtTenMatHang.Text = "";
                gtxtGia.Text = "";
                gcbbLoai.SelectedIndex = 0;
                gtxtTenMatHang.Focus();
            }
            else
            {
                if (gtxtTenMatHang.Text == "" || gtxtGia.Text == "")
                {
                    MessageBox.Show("Điền đủ thông tin trước khi thêm món");
                }
                if (DrinkExisted(gtxtTenMatHang.Text))
                {
                    MessageBox.Show("Món đã tồn tại");
                }
                else
                {
                    if (originImage != null)
                    {
                        if (drinkBUS.InsertDrink(gtxtTenMatHang.Text, gtxtGia.Text, (gcbbLoai.SelectedItem as DrinkCategory).idCategory, ImageHelper.ImageToByteArray(originImage)))
                        {
                            MessageBox.Show("Đã thêm thành công");
                            btnThem.Text = "Thêm";
                            btnSua.Enabled = true;
                            btnXoa.Enabled = true;
                            gDataGridView1.Enabled = true;
                            gtxtTenMatHang.Enabled = false;
                            gtxtGia.Enabled = false;
                            gcbbLoai.Enabled = false;
                            btnThemAnh.Enabled = false;
                            gDataGridView1.DataSource = drinkBUS.GetAllDrinksDetailed();
                        }
                    }
                    else
                    {
                        if (drinkBUS.InsertDrink(gtxtTenMatHang.Text, gtxtGia.Text, (gcbbLoai.SelectedItem as DrinkCategory).idCategory))
                        {
                            MessageBox.Show("Đã thêm thành công");
                            btnThem.Text = "Thêm";
                            btnSua.Enabled = true;
                            btnXoa.Enabled = true;
                            gDataGridView1.Enabled = true;
                            gtxtTenMatHang.Enabled = false;
                            gtxtGia.Enabled = false;
                            gcbbLoai.Enabled = false;
                            btnThemAnh.Enabled = false;
                            gDataGridView1.DataSource = drinkBUS.GetAllDrinksDetailed();
                        }
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (gDataGridView1.SelectedRows.Count > 0)
                {
                    if (drinkBUS.DeleteDrink(Convert.ToInt32(gDataGridView1.SelectedRows[0].Cells["idDrink"].Value)))
                    {
                        MessageBox.Show("Đã xóa thành công");
                        gDataGridView1.DataSource = drinkBUS.GetAllDrinksDetailed();
                    }
                }
                else
                    MessageBox.Show("Chọn một món để xóa");
            }
            catch (NullReferenceException)
            {

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (gDataGridView1.SelectedRows.Count > 0)
                {
                    if (btnSua.Text == "Sửa")
                    {
                        btnSua.Text = "OK";
                        btnThem.Enabled = false;
                        btnXoa.Enabled = false;
                        gDataGridView1.Enabled = false;
                        gtxtTenMatHang.Enabled = true;
                        gtxtGia.Enabled = true;
                        gcbbLoai.Enabled = true;
                        btnThemAnh.Enabled = true;
                    }
                    else
                    {
                        if (drinkBUS.UpdateDrink(Convert.ToInt32(gDataGridView1.SelectedRows[0].Cells["idDrink"].Value), gtxtTenMatHang.Text, gtxtGia.Text, (gcbbLoai.SelectedItem as DrinkCategory).idCategory, ImageHelper.ImageToByteArray(originImage)))
                        {
                            MessageBox.Show("Đã sửa thành công");
                            btnSua.Text = "Sửa";
                            btnThem.Enabled = true;
                            btnXoa.Enabled = true;
                            gDataGridView1.Enabled = true;
                            gtxtTenMatHang.Enabled = false;
                            gtxtGia.Enabled = false;
                            gcbbLoai.Enabled = false;
                            btnThemAnh.Enabled = false;
                            gDataGridView1.DataSource = drinkBUS.GetAllDrinksDetailed();
                        }
                        else
                        {
                            MessageBox.Show("Sửa thất bại");
                        }
                    }
                }
                else
                    MessageBox.Show("Chọn một món để sửa");
            }
            catch (NullReferenceException)
            {

            }
        }

        private void frmMatHang_SizeChanged(object sender, EventArgs e)
        {
            if (panelFull.Width == 0)
                return;
            if (WindowState == FormWindowState.Minimized)
                return;
                //MessageBox.Show("hello");
            //panelThongTinMH.Size = new Size(panelFull.Width*38/100, panelFull.Height *50/100);
            gunaGroupBoxThongTinMH.Size = new Size(panelThongTinMH.Width * 70 / 100, panelThongTinMH.Height * 50 / 100);
            //panelButton.Size = new Size(gunaGroupBoxThongTinMH.Width, panelThongTinMH.Height * 125 / 1000);
            panelButton.Size = new Size(gunaGroupBoxThongTinMH.Width * 90/100, panelThongTinMH.Height * 110 / 1000);
            //btnSua.Size = new Size(panelButton.Width * 8610 / 10000 / 3, panelButton.Height);
            btnSua.Size = new Size(panelButton.Width * 7610 / 10000 / 3, panelButton.Height);
            btnThem.Size = new Size(panelButton.Width * 7999 / 10000 / 3, panelButton.Height);
            btnXoa.Size = new Size(panelButton.Width * 7610 / 10000 / 3, panelButton.Height);
            //
            var fontsiz = 1F;
            int x = panelButton.Width / 41;
            //MessageBox.Show(typeof(splitContainer2.Panel1.Width)+"");
            for (int j = 0; j < x; j++)
                fontsiz += 1;
            btnSua.Font = new Font("Microsoft Sans Serif", fontsiz);
            btnThem.Font = new Font("Microsoft Sans Serif", fontsiz);
            btnXoa.Font = new Font("Microsoft Sans Serif", fontsiz);
            //
            btnThem.Location = new Point(0, 0);
            //btnSua.Location = new Point(btnThem.Width + panelButton.Width * 695 / 10000, 0);
            btnSua.Location = new Point((panelButton.Width-btnSua.Width)/2, 0);
            btnXoa.Location = new Point(btnSua.Width*2 + panelButton.Width *2* 695 / 10000, 0);
            gunaGroupBoxThongTinMH.Location = new Point((panelThongTinMH.Width - gunaGroupBoxThongTinMH.Width) / 2, panelThongTinMH.Height*1444/10000);
            //panelButton.Location = gunaGroupBoxThongTinMH.Location;
            //panelButton.Location = new Point(gunaGroupBoxThongTinMH.Location.X, gunaGroupBoxThongTinMH.Location.Y + gunaGroupBoxThongTinMH.Height);
            panelButton.Location = new Point(gunaGroupBoxThongTinMH.Location.X + (gunaGroupBoxThongTinMH.Width -panelButton.Width)/2, gunaGroupBoxThongTinMH.Location.Y
                + gunaGroupBoxThongTinMH.Height + panelThongTinMH.Height * 7222 / 100000);

            //in guna group box
            gtxtTenMatHang.Size = new Size(gunaGroupBoxThongTinMH.Width / 2, gunaGroupBoxThongTinMH.Height * 32 / 211);
            gcbbLoai.Size = new Size(gunaGroupBoxThongTinMH.Width *1 / 3, gunaGroupBoxThongTinMH.Height * 32 / 211);
            gtxtGia.Size = gcbbLoai.Size;

            //MessageBox.Show((gunaGroupBoxThongTinMH.Width / 2  - lblTenMatHang.Width) / 2+", "+ (gunaGroupBoxThongTinMH.Height ) * 4 / 18 + "");
            lblTenMatHang.Location = new Point((gunaGroupBoxThongTinMH.Width / 2 - 20 - lblTenMatHang.Width) / 2, (gunaGroupBoxThongTinMH.Height) * 4 / 18 + 15);// gunaGroupBoxThongTinMH.Location.Y);// 25 la uoc chung height cua cai thanh tieu deu tren
            lblLoai.Location = new Point(lblTenMatHang.Location.X, lblTenMatHang.Location.Y + (gunaGroupBoxThongTinMH.Height) * 2 / 18 +lblLoai.Height);
            lblGia.Location = new Point(lblTenMatHang.Location.X, lblLoai.Location.Y + (gunaGroupBoxThongTinMH.Height) * 2 / 18 + lblGia.Height);


            gtxtTenMatHang.Location = new Point(lblTenMatHang.Location.X + lblTenMatHang.Width + 20, lblTenMatHang.Location.Y         -gtxtTenMatHang.Height/2 + lblTenMatHang.Height/2);
            gcbbLoai.Location = new Point(gtxtTenMatHang.Location.X, gtxtTenMatHang.Location.Y + (gunaGroupBoxThongTinMH.Height) * 2 / 18 + lblTenMatHang.Height);
            gtxtGia.Location = new Point(gtxtTenMatHang.Location.X, gcbbLoai.Location.Y + (gunaGroupBoxThongTinMH.Height) * 2 / 18 + lblLoai.Height);

            //if (splitContainer1.Width >= 1718)
            //if (splitContainer1.Width >= 1700)
            //{

            //}

            /////
            //if (panelFull.Width == 0)
            //    return;
            //if (WindowState == FormWindowState.Minimized)
            //    return;
            //    //MessageBox.Show("hello");
            //panelThongTinMH.Size = new Size(panelFull.Width*38/100, panelFull.Height *50/100);
            //gunaGroupBoxThongTinMH.Size = new Size(panelThongTinMH.Width * 80 / 100, panelThongTinMH.Height * 50 / 100);
            ////panelButton.Size = new Size(gunaGroupBoxThongTinMH.Width, panelThongTinMH.Height * 125 / 1000);
            //panelButton.Size = new Size(gunaGroupBoxThongTinMH.Width, panelThongTinMH.Height * 095 / 1000);
            ////btnSua.Size = new Size(panelButton.Width * 8610 / 10000 / 3, panelButton.Height);
            //btnSua.Size = new Size(panelButton.Width * 8610 / 10000 / 3, panelButton.Height);
            //btnThem.Size = new Size(panelButton.Width * 8610 / 10000 / 3, panelButton.Height);
            //btnXoa.Size = new Size(panelButton.Width * 8610 / 10000 / 3, panelButton.Height);
            ////
            //var fontsiz = 1F;
            //int x = panelButton.Width / 41;
            ////MessageBox.Show(typeof(splitContainer2.Panel1.Width)+"");
            //for (int j = 0; j < x; j++)
            //    fontsiz += 1;
            //btnSua.Font = new Font("Microsoft Sans Serif", fontsiz);
            ////
            //btnThem.Location = new Point(0, 0);
            //btnSua.Location = new Point(btnThem.Width + panelButton.Width * 695 / 10000, 0);
            //btnXoa.Location = new Point(btnSua.Width*2 + panelButton.Width *2* 695 / 10000, 0);
            //gunaGroupBoxThongTinMH.Location = new Point((panelThongTinMH.Width - gunaGroupBoxThongTinMH.Width) / 2, panelThongTinMH.Height*1444/10000);
            ////panelButton.Location = gunaGroupBoxThongTinMH.Location;
            ////panelButton.Location = new Point(gunaGroupBoxThongTinMH.Location.X, gunaGroupBoxThongTinMH.Location.Y + gunaGroupBoxThongTinMH.Height);
            //panelButton.Location = new Point(gunaGroupBoxThongTinMH.Location.X, gunaGroupBoxThongTinMH.Location.Y
            //    + gunaGroupBoxThongTinMH.Height + panelThongTinMH.Height * 7222 / 100000);
        }
        private void btnThemAnh_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                originImage = Image.FromFile(ofd.FileName);
                pboxAnh.Image = ImageHelper.ResizeImage(originImage, 95, 95);
            }
        }

        private void gtxtGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private bool DrinkExisted(string drinkName)
        {
            foreach (DataGridViewRow row in gDataGridView1.Rows)
            {
                if (drinkName == row.Cells["Tên"].Value.ToString())
                    return true;
            }
            return false;
        }
    }
}
