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
    public partial class frmDiscount : Form
    {
        public frmDiscount()
        {
            InitializeComponent();
        }

        BillBUS billBus = new BillBUS();

        private void frmDiscount_SizeChanged(object sender, EventArgs e)
        {
            if (splitContainer1.Width == 0)
                return;
            if (WindowState == FormWindowState.Minimized)
                return;
            ////panelThongTinMH.Size = new Size(panelFull.Width*38/100, panelFull.Height *50/100);
            gunaGroupBoxThongTinGG.Size = new Size(panelThongTinGG.Width * 68 / 100, panelThongTinGG.Height * 45 / 100);
            ////panelButton.Size = new Size(gunaGroupBoxThongTinMH.Width, panelThongTinMH.Height * 125 / 1000);
            panelButton.Size = new Size(gunaGroupBoxThongTinGG.Width * 90 / 100, panelThongTinGG.Height * 110 / 1000);
            ////btnSua.Size = new Size(panelButton.Width * 8610 / 10000 / 3, panelButton.Height);
            btnSua.Size = new Size(panelButton.Width * 7610 / 10000 / 3, panelButton.Height);
            btnThem.Size = new Size(panelButton.Width * 7999 / 10000 / 3, panelButton.Height);
            btnXoa.Size = new Size(panelButton.Width * 7610 / 10000 / 3, panelButton.Height);
            ////
            var fontsiz = 1F;
            int x = panelButton.Width / 41;
            ////MessageBox.Show(typeof(splitContainer2.Panel1.Width)+"");
            for (int j = 0; j < x; j++)
                fontsiz += 1;
            btnSua.Font = new Font("Microsoft Sans Serif", fontsiz);
            btnThem.Font = new Font("Microsoft Sans Serif", fontsiz);
            btnXoa.Font = new Font("Microsoft Sans Serif", fontsiz);
            ////
            btnThem.Location = new Point(0, 0);
            ////btnSua.Location = new Point(btnThem.Width + panelButton.Width * 695 / 10000, 0);
            btnSua.Location = new Point((panelButton.Width - btnSua.Width) / 2, 0);
            btnXoa.Location = new Point(btnSua.Width * 2 + panelButton.Width * 2 * 695 / 10000, 0);
            gunaGroupBoxThongTinGG.Location = new Point((panelThongTinGG.Width - gunaGroupBoxThongTinGG.Width) / 2, panelThongTinGG.Height * 1444 / 10000);
            ////panelButton.Location = gunaGroupBoxThongTinMH.Location;
            ////panelButton.Location = new Point(gunaGroupBoxThongTinMH.Location.X, gunaGroupBoxThongTinMH.Location.Y + gunaGroupBoxThongTinMH.Height);
            panelButton.Location = new Point(gunaGroupBoxThongTinGG.Location.X + (gunaGroupBoxThongTinGG.Width - panelButton.Width) / 2, gunaGroupBoxThongTinGG.Location.Y
                + gunaGroupBoxThongTinGG.Height + panelThongTinGG.Height * 7222 / 100000);

            ////in guna group box
            gtxtMaGiamGia.Size = new Size(gunaGroupBoxThongTinGG.Width / 5 * 2, gunaGroupBoxThongTinGG.Height * 32 / 211);
            //gcbbLoai.Size = new Size(gunaGroupBoxThongTinMH.Width * 1 / 3, gunaGroupBoxThongTinMH.Height * 32 / 211);
            gtxtGiaTriGiam.Size = new Size(gunaGroupBoxThongTinGG.Width * 1 / 3 *3 /5 * 2, gunaGroupBoxThongTinGG.Height * 32 / 211);

            ////MessageBox.Show((gunaGroupBoxThongTinMH.Width / 2  - lblTenMatHang.Width) / 2+", "+ (gunaGroupBoxThongTinMH.Height ) * 4 / 18 + "");
            lblMaGiamGia.Location = new Point((gunaGroupBoxThongTinGG.Width / 2 - 10 - lblMaGiamGia.Width) / 2 - 5, (gunaGroupBoxThongTinGG.Height) * 4 / 18 + 15 + 10);// gunaGroupBoxThongTinMH.Location.Y);// 25 la uoc chung height cua cai thanh tieu deu tren
            //lblLoai.Location = new Point(lblTenMatHang.Location.X, lblTenMatHang.Location.Y + (gunaGroupBoxThongTinMH.Height) * 2 / 18 +lblLoai.Height);
            lblGiaTriGiam.Location = new Point(lblMaGiamGia.Location.X, lblMaGiamGia.Location.Y + (gunaGroupBoxThongTinGG.Height) * 2 / 18 + lblGiaTriGiam.Height + 5);


            gtxtMaGiamGia.Location = new Point(lblMaGiamGia.Location.X + lblMaGiamGia.Width + 60, lblMaGiamGia.Location.Y - gtxtMaGiamGia.Height / 2 + lblMaGiamGia.Height / 2);
            //gcbbLoai.Location = new Point(gtxtTenMatHang.Location.X, gtxtTenMatHang.Location.Y + (gunaGroupBoxThongTinMH.Height) * 2 / 18 + lblTenMatHang.Height);
            gtxtGiaTriGiam.Location = new Point(gtxtMaGiamGia.Location.X, gtxtMaGiamGia.Location.Y + (gunaGroupBoxThongTinGG.Height) * 2 / 18 + lblMaGiamGia.Height +5);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (billBus.insertIdDiscount(gtxtMaGiamGia.Text, Convert.ToInt32(gtxtGiaTriGiam.Text)))
            {
                MessageBox.Show("Thêm mã giảm giá thành công");
                updateDataGridView();
            } else
            {
                MessageBox.Show("Không thêm được vì mã đã trùng hoặc giá trị giảm không hợp lệ");
            }
        }

        private void frmDiscount_Load(object sender, EventArgs e)
        {
            updateDataGridView();
            gDataGridView1.Columns["Mã"].Width = 250;
        }

        private void updateDataGridView()
        {
            gDataGridView1.DataSource = billBus.getDiscountList();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (gDataGridView1.SelectedRows.Count > 0)
                {
                    if (billBus.deleteIdDiscount(gDataGridView1.SelectedRows[0].Cells["Mã"].Value.ToString()))
                    {
                        MessageBox.Show("Đã xóa thành công");
                        updateDataGridView();
                    }
                } else
                {
                    MessageBox.Show("Chọn một món để xóa");
                }
            }
            catch (NullReferenceException)
            {

            }
        }

        private void gtxtGiaTriGiam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (!Char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
