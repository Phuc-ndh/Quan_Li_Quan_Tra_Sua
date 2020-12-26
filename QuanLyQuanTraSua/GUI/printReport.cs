using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Parsing;
using Syncfusion.Pdf.Graphics;
using Syncfusion.GridHelperClasses;
using System.Drawing.Imaging;
using System.Drawing;
using System.IO;


namespace QuanLyQuanTraSua
{
    public class  printReport
    {
        private int day = 0;
        private int month = 0;
        private int year = 0;
        private int i;
        private string income;
        private string number;


        public printReport(int _day, int _month, int _year, int _i, string _income, string _number)
        {
            this.day = _day;
            this.month = _month;
            this.year = _year;
            this.i = _i;
            this.income = _income;
            this.number = _number;
        }

        
        public printReport(int _month, int _year, int _i, string _income, string _number)
        {
            this.month = _month;
            this.year = _year;
            this.i = _i;
            this.income = _income;
            this.number = _number;
        }
        

        public void exportReport()
        {
            
            PdfDocument pdfDocument = new PdfDocument();
            
            Bitmap bmSell = new Bitmap("tmp/sell_percent_tmp" + i.ToString() + ".jpg");
            Bitmap bmMoney = new Bitmap("tmp/money_percent_tmp" + i.ToString() + ".jpg");
            Bitmap bmSellMoney = new Bitmap("tmp/sell_money_tmp" + i.ToString() + ".jpg");

            ImageCodecInfo jpgEncoder = getEncoder(ImageFormat.Jpeg);

            System.Drawing.Imaging.Encoder myEncoder =
                System.Drawing.Imaging.Encoder.Quality;

            EncoderParameters myEncoderParameters = new EncoderParameters(1);

            EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder,
                 100L);
            myEncoderParameters.Param[0] = myEncoderParameter;

            bmSell.Save("tmp/sell_percent"+ i.ToString() + ".jpg", jpgEncoder, myEncoderParameters);
            bmMoney.Save("tmp/money_percent" + i.ToString() + ".jpg", jpgEncoder, myEncoderParameters);
            bmSellMoney.Save("tmp/sell_money"+ i.ToString() + ".jpg", jpgEncoder, myEncoderParameters);
            

            PdfImage imgSell = new PdfBitmap("tmp/sell_percent"+ i.ToString() + ".jpg");
            PdfImage imgMoney = new PdfBitmap("tmp/money_percent"+ i.ToString() + ".jpg");
            PdfImage imgSellMoney = new PdfBitmap("tmp/sell_money"+ i.ToString() + ".jpg");
            
            PdfPage page1 = pdfDocument.Pages.Add();
            page1.Graphics.DrawImage(imgSell, 100, 100, 400, 300 );

            PdfPage page2 = pdfDocument.Pages.Add();
            page2.Graphics.DrawImage(imgMoney, 100, 100, 400, 300);

            PdfPage page3 = pdfDocument.Pages.Add();
            page3.Graphics.DrawImage(imgSellMoney, 0, 100, 600, 500);

            PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 15, PdfFontStyle.Regular);
            page3.Graphics.DrawString(income, font, PdfBrushes.Black, new PointF(100, 650));
            page3.Graphics.DrawString(number, font, PdfBrushes.Black, new PointF(100, 680));

            if (day != 0)
            {
                pdfDocument.Save("bao cao nam " + this.year.ToString() + "/" + "thang " + this.month.ToString() + "/" + "ngay" + this.day.ToString() + ".pdf");
            } else
            {
                if (month != 0)
                {
                    pdfDocument.Save("bao cao nam " + this.year.ToString() + "/" + "thang" + this.month.ToString() + ".pdf");

                }
            }
            
            pdfDocument.Clone();
        }

        private ImageCodecInfo getEncoder(ImageFormat format)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }
    }
}
