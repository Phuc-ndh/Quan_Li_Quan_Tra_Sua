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
        private double totalPrice;
        private int valueDiscount;
        private string customerMoney;
        private string changeMoney;

        // lay datagridview tu fromTongQuan
        public printReceipt(DataGridView _dtgv, double _totalPrice, int _valueDiscount, string _customerMoney, string _changeMoney):this()
        {
            this.dtgv = _dtgv;
            this.totalPrice = _totalPrice;
            this.valueDiscount = _valueDiscount;
            this.customerMoney = _customerMoney;
            this.changeMoney = _changeMoney;

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
                
                // in dia chi tren hoa don
                point = point + 50;
                g.DrawString("Linh Trung   Thu Duc", font_regular, XBrushes.Black, new XRect(40, point, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                // in ten nhan vien
                point = point + 40;
                g.DrawString("Nhan vien: " + "MaNV", font_regular, XBrushes.Black, new XRect(40, point, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                // in ten id hoa don
                point = point + 20;
                g.DrawString("Hoa don: " + "idHoaDon", font_regular, XBrushes.Black, new XRect(40, point, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                // in ngay tren hoa don
                point = point + 40;
                g.DrawString(DateTime.Now.ToString(), font_regular, XBrushes.Black, new XRect(40, point, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

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

                g.DrawString("----------------------------------------------------------------------------",
                        font_regular, XBrushes.Black, new XRect(40, point, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
                point = point + 50;

                // in tong tien
                g.DrawString("Tong tien:", font_regular, XBrushes.Black,
                        new XRect(40, point, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
                g.DrawString(this.totalPrice.ToString(), font_regular, XBrushes.Black,
                        new XRect(-40, point, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopRight);
                point = point + 30;

                // in tien khach dua
                g.DrawString("Tien dua: ", font_bold, XBrushes.Black,
                        new XRect(40, point, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
                g.DrawString(this.customerMoney, font_regular, XBrushes.Black,
                        new XRect(-40, point, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopRight);
                point = point + 30;

                // in gia tri % code giam gia
                g.DrawString("Da giam gia: ", font_regular, XBrushes.Black,
                        new XRect(40, point, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
                g.DrawString(this.valueDiscount.ToString() + "%", font_regular, XBrushes.Black,
                        new XRect(-40, point, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopRight);
                point = point + 30;

                // in tien tra lai
                g.DrawString("Tien tra lai: ", font_regular, XBrushes.Black,
                        new XRect(40, point, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
                g.DrawString(this.changeMoney, font_regular, XBrushes.Black,
                        new XRect(-40, point, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopRight);
                point = point + 30;

                g.DrawString("----------------------------------------------------------------------------",
                        font_regular, XBrushes.Black, new XRect(40, point, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
                point = point + 30;

                g.DrawString("Xin cam on", font_regular, XBrushes.Black,
                        new XRect(40, point, pdfPage.Width.Point, pdfPage.Width.Point), XStringFormats.TopCenter);

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
