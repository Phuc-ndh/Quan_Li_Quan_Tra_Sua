using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class OrderDetail
    {
        private int _idOrder;

        public int idOrder
        {
            get { return _idOrder; }
            set { _idOrder = value; }
        }

        private int _idDrink;

        public int idDrink
        {
            get { return _idDrink; }
            set { _idDrink = value; }
        }

        private int _Quantity;

        public int Quantity
        {
            get { return _Quantity; }
            set { _Quantity = value; }
        }
        public OrderDetail()
        { }

        public OrderDetail(int idOrder, int idDrink, int Quantity)
        {
            this._idOrder = idOrder;
            this._idDrink = idDrink;
            this._Quantity = Quantity;
        }

        public OrderDetail(DataRow r)
        {
            this._idOrder = (int)r["idOrder"];
            this._idDrink = (int)r["idDrink"];
            this._Quantity = (int)r["Quantity"];
        }
    }
}
