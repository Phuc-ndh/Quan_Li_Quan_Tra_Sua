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
    public partial class frmOpenPDF : Form
    {
        public frmOpenPDF()
        {
            InitializeComponent();
        }
        public frmOpenPDF(string path)
        {
            InitializeComponent();
            webBrowser1.Navigate(@path);
        }
    }
}
