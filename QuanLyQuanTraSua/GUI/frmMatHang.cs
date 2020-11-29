using BUS;
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
        DrinkBUS drinkBUS = new DrinkBUS();
        DrinkCategoryBUS drinkCategoryBUS = new DrinkCategoryBUS();
        public frmMatHang()
        {
            InitializeComponent();
        }

        private void frmMatHang_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = drinkBUS.GetAllDrinksDetailed();
            dataGridView1.Columns["Loại"].Width = 150;
            dataGridView1.Columns["Giá"].Width = 100;
            dataGridView1.Columns["idCategory"].Visible = false;

            cbbLoai.DisplayMember = "Name";
            cbbLoai.DataSource = drinkCategoryBUS.getDrinkCategoryNames();
            /*
            cbbLoai.DataBindings.Add(new Binding("SelectedIndex", dataGridView1.DataSource, "idCategory"));
            txtTenMatHang.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Tên"));
            txtGia.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Giá"));
            */
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txtTenMatHang.Text = dataGridView1.SelectedRows[0].Cells["Tên"].Value.ToString();
                txtGia.Text = dataGridView1.SelectedRows[0].Cells["Giá"].Value.ToString();
                cbbLoai.SelectedIndex = cbbLoai.FindStringExact(dataGridView1.SelectedRows[0].Cells["Loại"].Value.ToString());
            }
        }
    }
}
