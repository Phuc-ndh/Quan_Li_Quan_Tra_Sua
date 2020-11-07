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
        public DataTable GetAllDrinks()
        {
            List<Drink> list = new List<Drink>();
            string query = "SELECT * FROM DRINK";
            DBConnect db = new DBConnect();
            DataTable dt = db.ExecuteQuery(query);
            return dt;
        }

        public Drink GetDrinkByID(int idDrink)
        {
            string query = "SELECT * FROM DRINK WHERE IDDRINK = @IDDRINK";
            object[] value = new object[] { idDrink };
            DBConnect db = new DBConnect();
            DataTable dt = db.ExecuteQuery(query, value);
            Drink drink = new Drink(dt.Rows[0]);
            return drink;
        }

        public Drink GetDrinkByName(int name)
        {
            string query = "SELECT * FROM DRINK WHERE NAME = @NAME";
            object[] value = new object[] { name };
            DBConnect db = new DBConnect();
            DataTable dt = db.ExecuteQuery(query, value);
            Drink drink = new Drink(dt.Rows[0]);
            return drink;
        }

        public DataTable GetDrinksByCategory(string idCategory)
        {
            List<Drink> list = new List<Drink>();
            string query = "SELECT * FROM DRINK WHERE IDCATEGORY =" + idCategory;
            DBConnect db = new DBConnect();
            DataTable dt = db.ExecuteQuery(query);
            return dt;
        }
    }
}
