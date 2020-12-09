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
    public partial class frmTongQuan : Form
    {
        DrinkBUS drinkBUS = new DrinkBUS();
        BillBUS billBUS = new BillBUS();
        public frmTongQuan()
        {
            InitializeComponent();
        }

        private void frmTongQuan_Load(object sender, EventArgs e)
        {
            splitContainer1.SplitterDistance = panel3.Width + 110;
            List<Drink> listDrink = drinkBUS.GetDrinkList();
            foreach (Drink drink in listDrink)
            {
                //Button btn = new Button() { Width = 100, Height = 100, Text = drink.Name, Tag = drink, ForeColor = Color.Black, BackColor = Color.FromArgb(150, 150, 150) };
                Button btn = new Button() { Width = 100, Height = 100, Text = drink.Name, Tag = drink, ForeColor = Color.Black, BackColor = Color.FromArgb(157, 177, 186) };
                Button btn2 = new Button() { Width = 100, Height = 100, Text = drink.Name, Tag = drink, ForeColor = Color.Black, BackColor = Color.FromArgb(150, 150, 150) };
                btn.MouseDown += Btn_MouseDown;
                btn2.MouseDown += Btn_MouseDown;
                btn.Click += Btn_Click;
                btn2.Click += Btn_Click;
                flpTatCa.Controls.Add(btn);
                switch (drink.idCategory)
                {
                    case 0:
                        flpTraSua.Controls.Add(btn2);
                        break;
                    case 1:
                        flpHongTra.Controls.Add(btn2);
                        break;
                    case 2:
                        flpSinhTo.Controls.Add(btn2);
                        break;
                    case 3:
                        flpNuocEp.Controls.Add(btn2);
                        break;
                    default:
                        break;
                }
            }
        }

        private void Btn_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Btn_Click(sender, e);
                btnThem_Click(sender, e);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            txtTenMatHang.Text = ((sender as Button).Tag as Drink).Name;
            txtGia.Text = ((sender as Button).Tag as Drink).Price.ToString();
            //txtID.Text = ((sender as Button).Tag as Drink).idDrink.ToString();
            gtxtTenMatHang.Text = ((sender as Button).Tag as Drink).Name;
            gtxtGia.Text = ((sender as Button).Tag as Drink).Price.ToString();
            txtID.Text = ((sender as Button).Tag as Drink).idDrink.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //foreach (DataGridViewRow row in dataGridView1.Rows)
            foreach (DataGridViewRow row in gunaDataGridView1.Rows)
            {
                //row.Cells[0].Value = "hello";
            //gunaDataGridView1.Rows.Add(txtID.Text, txtTenMatHang.Text, txtGia.Text, numericUpDown1.Value, Convert.ToInt32(txtGia.Text) * (int)numericUpDown1.Value);
                //return;
                if (row.Cells[0].Value.ToString() == txtID.Text)
                {
                    row.Cells["columnSoLuong"].Value = Convert.ToInt32(row.Cells["columnSoLuong"].Value) + Convert.ToInt32(gunaNumeric1.Value);
                    row.Cells["columnThanhTien"].Value = Convert.ToInt32(row.Cells["columnSoLuong"].Value) * Convert.ToInt32(row.Cells["columnGia"].Value);
                    return;
                }
            }
            //gunaDataGridView1.Rows.Add(txtID.Text, txtTenMatHang.Text, txtGia.Text, numericUpDown1.Value, Convert.ToInt32(txtGia.Text) * (int)numericUpDown1.Value);
            gunaDataGridView1.Rows.Add(txtID.Text, txtTenMatHang.Text, txtGia.Text, gunaNumeric1.Value, Convert.ToInt32(txtGia.Text) * (int)gunaNumeric1.Value);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (gunaDataGridView1.SelectedRows.Count > 0)
            {
                //txtTenMatHang.Text = gunaDataGridView1.SelectedRows[0].Cells["columnTen"].Value.ToString();
                //txtGia.Text = gunaDataGridView1.SelectedRows[0].Cells["columnGia"].Value.ToString();
                //txtID.Text = gunaDataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                gtxtTenMatHang.Text = gunaDataGridView1.SelectedRows[0].Cells["columnTen"].Value.ToString();
                gtxtGia.Text = gunaDataGridView1.SelectedRows[0].Cells["columnGia"].Value.ToString();
                txtID.Text = gunaDataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void btnGiam_Click(object sender, EventArgs e)
        {
            if (gunaDataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in gunaDataGridView1.SelectedRows)
                {
                    gunaDataGridView1.Rows.Remove(row);
                }
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            gunaDataGridView1.Rows.Clear();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {          
            string date = (DateTime.Now.Month + "/" +DateTime.Now.Day  + "/" + DateTime.Now.Year).ToString();
            int totalprice = 0;
            foreach( DataGridViewRow row in gunaDataGridView1.Rows)
            {
                totalprice += Convert.ToInt32(row.Cells["columnThanhTien"].Value);
            }

            billBUS.insertBill(date, totalprice);

            foreach(DataGridViewRow row in gunaDataGridView1.Rows)
            {
                billBUS.insertBillInfo( Convert.ToInt32(row.Cells["columnID"].Value), Convert.ToInt32(row.Cells["columnSoLuong"].Value));
                //gunaDataGridView1.Rows.Remove(row);
            }
            gunaDataGridView1.Rows.Clear();

        }

    
        private void gtxtSearch_Click(object sender, EventArgs e)
        {
            if ((gtxtSearch.Text == "Tìm kiếm"))
                gtxtSearch.Text = "";
        }

        private void fabtnGoTo1_Click(object sender, EventArgs e)
        {
            gunaNumeric1.Value = 1;
        }

        private void panelChiTiet_SizeChanged(object sender, EventArgs e)
        {

            groupBox1.Visible = true;
            gtxtSearch.Visible = true;
            fabtnSearch.Visible = true;
            if (splitContainer1.Width < 1718)
            {
                groupBox1.Visible = false;
                gtxtSearch.Visible = false;
                fabtnSearch.Visible = false;

                //panel3.Location = new Point((panel1.Width-panel3.Width)/2, 20);

            }
                //MessageBox.Show(splitContainer1.Width+"");
            if (WindowState == FormWindowState.Maximized)
            {
                //groupBox1.Visible = false;
                //gtxtSearch.Visible = false;
                //fabtnSearch.Visible = false;
                //panelChiTiet.Location = new Point(1370,777);

            }

            //panel2.Visible = false;
            //MessageBox.Show("");
        }

        private void gunaContextMenuStrip1_Click(object sender, EventArgs e)
        {
            gunaDataGridView1.Rows.Clear();
        }
    }
}
