using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
<<<<<<< Updated upstream
=======
//using DTO;
>>>>>>> Stashed changes

namespace DAL
{
    public class AccountDAL
    {
        public DataTable getLoginID(string username, string password)
        {
            string query = "SELECT * FROM USERS WHERE ID ='" + username + "'AND PASS = '" + password + "'";
            DBConnect db = new DBConnect();
            DataTable dt = db.ExecuteQuery(query);
            return dt;
        }
    }
}
