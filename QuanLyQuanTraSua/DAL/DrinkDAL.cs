using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DrinkDAL
    {
        public List<Drink> GetDrinkList()
        {
            List<Drink> list = new List<Drink>();
            string query = "SELECT * FROM DRINK";
            DBConnect db = new DBConnect();
            DataTable dt = db.ExecuteQuery(query);
            foreach (DataRow r in dt.Rows)
            {
                list.Add(new Drink(r));
            }
            return list;
        }

        public Drink GetDrinkByID(int idDrink)
        {
            Drink drink = new Drink();
            List<Drink> list = GetDrinkList();
            foreach (Drink d in list)
            {
                if (d.idDrink == idDrink)
                    drink = d;
            }
            return drink;
        }

        public Drink GetDrinkByName(string Name)
        {
            Drink drink = new Drink();
            List<Drink> list = GetDrinkList();
            foreach (Drink d in list)
            {
                if (d.Name == Name)
                    drink = d;
            }
            return drink;
        }

        public List<Drink> GetListByCategory(string idCategory)
        {
            List<Drink> list = new List<Drink>();
            string query = "SELECT * FROM DRINK WHERE IDCATEGORY =" + idCategory;
            DBConnect db = new DBConnect();
            DataTable dt = db.ExecuteQuery(query);
            foreach (DataRow r in dt.Rows)
            {
                    list.Add(new Drink(r));
            }
            return list;
        }
    }
}
