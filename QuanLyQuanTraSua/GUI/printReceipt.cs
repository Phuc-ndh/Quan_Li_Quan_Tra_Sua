using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.Drawing;

namespace QuanLyQuanTraSua
{
    public partial class printReceipt : Form
    {
        public printReceipt()
        {
            InitializeComponent();
        }

        private DataGridView dtgv;

        // lay datagridview tu fromTongQuan
        public printReceipt(DataGridView _dtgv):this()
        {
            this.dtgv = _dtgv;
            printPdfReceipt();
        }

        private void printPdfReceipt()
        {   
            int point = 0;
            try
            {
                PdfDocument pdf = new PdfDocument();
                pdf.Info.Title = "receipt bill";
                PdfPage pdfPage = pdf.AddPage();
                XGraphics g = XGraphics.FromPdfPage(pdfPage);
                XFont font_regular = new XFont("Verdana", 15, XFontStyle.Regular);
                XFont font_bold = new XFont("Verdana", 17, XFontStyle.Bold);

                point = point + 100;
                g.DrawString("HOA DON BAN HANG", font_bold, XBrushes.Black, new XRect(0, point, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopCenter);
                point = point + 50;
                g.DrawString("Linh Trung   Thu Duc", font_regular, XBrushes.Black, new XRect(40, point, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
                point = point + 20;
                g.DrawString("----------------------------------------------------------------------------",
                    font_regular, XBrushes.Black, new XRect(40, point, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                point = point + 20;
                g.DrawString("Ten", font_regular, XBrushes.Black, new XRect(80, point, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
                g.DrawString("So luong", font_regular, XBrushes.Black, new XRect(250, point, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
                g.DrawString("Don gia", font_regular, XBrushes.Black, new XRect(370, point, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
                g.DrawString("Thanh tien", font_regular, XBrushes.Black, new XRect(480, point, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                point = point + 30;
                string nameDrink;
                string numberDrink;
                string priceDrink;
                string moneyDrink;
                foreach (DataGridViewRow row in dtgv.Rows)
                {
                    nameDrink = Convert.ToString(row.Cells["columnTen"].Value);
                    numberDrink = Convert.ToString(row.Cells["columnSoLuong"].Value);
                    priceDrink = Convert.ToString(row.Cells["columnGia"].Value);
                    moneyDrink = Convert.ToString(row.Cells["columnThanhTien"].Value);

                    g.DrawString(nameDrink, font_regular, XBrushes.Black,
                        new XRect(40, point, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
                    g.DrawString(numberDrink, font_regular, XBrushes.Black,
                        new XRect(-300, point, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopRight);
                    g.DrawString(priceDrink, font_regular, XBrushes.Black,
                        new XRect(-170, point, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopRight);
                    g.DrawString(moneyDrink, font_regular, XBrushes.Black,
                        new XRect(-40, point, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopRight);

                    point = point + 20;
                }
                string pathPdf = "receipt.pdf";
                pdf.Save(pathPdf);
                Process.Start(pathPdf);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
