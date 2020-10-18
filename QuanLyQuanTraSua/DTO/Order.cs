using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class Order
    {
        private int _idOrder;

        public int idOrder
        {
            get { return idOrder; }
            set { idOrder = value; }
        }

        private string _Date;

        public string Date
        {
            get { return _Date; }
            set { _Date = value; }
        }

        private int _TotalPrice;

        public int TotalPrice
        {
            get { return _TotalPrice; }
            set { _TotalPrice = value; }
        }

        private int _idTable;

        public int idTable
        {
            get { return _idTable; }
            set { _idTable = value; }
        }
        public Order()
        { }

        public Order(int idOrder, string Date, int TotalPrice, int idTable)
        {
            this._idOrder = idOrder;
            this._Date = Date;
            this._TotalPrice = TotalPrice;
            this._idTable = idTable;
        }

        public Order(DataRow r)
        {
            this._idOrder = (int)r["idOrder"];
            this._Date = r["Date"].ToString();
            this._TotalPrice = (int)r["TotalPrice"];
            this._idTable = (int)r["idTable"];
        }
    }
}
