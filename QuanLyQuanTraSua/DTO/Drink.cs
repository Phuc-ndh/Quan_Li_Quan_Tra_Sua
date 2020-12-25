using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Drink
    {
        private int _idDrink;

        public int idDrink
        {
            get { return _idDrink; }
            set { _idDrink = value; }
        }

        private string _Name;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        private int _Price;

        public int Price
        {
            get { return _Price; }
            set { _Price = value; }
        }
        private int _idCategory;

        public int idCategory
        {
            get { return _idCategory; }
            set { _idCategory = value; }
        }

        private byte[] _image;

        public byte[] image
        {
            get { return _image; }
            set { _image = value; }
        }

        public Drink()
        { }

        public Drink(int idDrink, string Name, int Price, int idCategory, byte[] image)
        {
            this._idDrink = idDrink;
            this._Name = Name;
            this._Price = Price;
            this._idCategory = idCategory;
            this._image = image;
        }

        public Drink(DataRow r)
        {
            this._idDrink = (int)r["idDrink"];
            this._Name = r["Name"].ToString();
            this._Price = (int)r["Price"];
            this._idCategory = (int)r["idCategory"];
            if (r["Image"] is DBNull)
            {
                this._image = new byte[0];
            }
            else
            this._image = (byte[])r["Image"];
        }
    }
}
