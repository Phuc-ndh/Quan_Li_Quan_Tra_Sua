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
            string query = "SELECT * FROM DRINK WHERE IDCATEGORY = @IDCATEGORY";
            DBConnect db = new DBConnect();
            object[] value = new object[] { idCategory };
            DataTable dt = db.ExecuteQuery(query, value);
            return dt;
        }

        public DataTable GetAllDrinksDetailed()
        {
            string query = "SELECT DrinkCategory.Name as Loại, Drink.Name as Tên, Drink.Price as Giá, Drink.idCategory FROM Drink inner join DrinkCategory on Drink.idCategory = DrinkCategory.idCategory order by Drink.idCategory";
            DBConnect db = new DBConnect();
            DataTable dt = db.ExecuteQuery(query);
            return dt;
        }
    }
}
