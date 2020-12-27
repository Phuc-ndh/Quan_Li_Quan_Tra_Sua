using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.Diagnostics;
using System.Reflection;
using System.IO;
using System.ComponentModel;


namespace BUS
{
    public class BillBUS
    {
        BillDAL billDAL = new BillDAL();
        public object insertBill(string date, int price, int valueDiscount)
        {
            try
            {
                return billDAL.insertBill(date, price, valueDiscount);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool insertBillInfo(string nameDrink, string idDrink, int quantity, int totalPrice)
        {
            try
            {
                if (billDAL.insertBillInfo(nameDrink, idDrink,quantity, totalPrice))
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public DataTable getReportByDate(int day, int month, int year)
        {
            return billDAL.reportByDate(day, month, year);
        }

        public DataTable getReportByMonth(int month)
        {
            
            return billDAL.reportByMonth(month);
            
            
        }

        public DataTable getIdDiscount(string id)
        {
            return billDAL.getIdDiscount(id);
        }

        public bool insertIdDiscount(string id, int value)
        {
            
            if (billDAL.insertIdDiscount(id, value, 0))
            {
                return true;
            } else
            {
                return false;
            }
            
        }

        public bool deleteIdDiscount(string id)
        {
            try
            {
                if (billDAL.deleteIdDiscount(id))
                {
                    return true;
                } else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public DataTable getDiscountList()
        {
            return billDAL.getDiscountList();
        }

        public int getIdBill()
        {
            return billDAL._id;
        }
    }
}
