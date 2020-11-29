using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DrinkCategoryDAL
    {
        public DataTable getDrinkCategories()
        {
            List<string> names = new List<string>();
            string query = "SELECT Name FROM DrinkCategory";
            DBConnect db = new DBConnect();
            DataTable dt = db.ExecuteQuery(query);
            foreach (DataRow row in dt.Rows)
            {
                names.Add(row["Name"].ToString());
            }
            return dt;
        }
    }
}
