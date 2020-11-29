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
        public frmTongQuan()
        {
            InitializeComponent();
        }

        private void frmTongQuan_Load(object sender, EventArgs e)
        {
            splitContainer1.SplitterDistance = panel3.Width + 100;
            List<Drink> listDrink = drinkBUS.GetDrinkList();
            foreach (Drink drink in listDrink)
            {
                Button btn = new Button() { Width = 100, Height = 100, Text = drink.Name, Tag = drink };
                Button btn2 = new Button() { Width = 100, Height = 100, Text = drink.Name, Tag = drink };
                btn.Click += Btn_Click;
                btn2.Click += Btn_Click;
                flpTatCa.Controls.Add(btn);
                switch (drink.idCategory)
                {
                    case 1:
                        flpTraSua.Controls.Add(btn2);
                        break;
                    case 2:
                        flpHongTra.Controls.Add(btn2);
                        break;
                    case 3:
                        flpSinhTo.Controls.Add(btn2);
                        break;
                    case 4:
                        flpNuocEp.Controls.Add(btn2);
                        break;
                    default:
                        break;
                }
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            txtTenMatHang.Text = ((sender as Button).Tag as Drink).Name;
            txtGia.Text = ((sender as Button).Tag as Drink).Price.ToString();
        }
    }
}
