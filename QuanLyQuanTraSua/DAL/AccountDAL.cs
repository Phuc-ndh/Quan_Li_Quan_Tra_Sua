using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class AccountDAL
    {
        public DataTable getLoginAccount(string username, string password)
        {
            string query = "SELECT * FROM ACCOUNT WHERE USERNAME ='" + username + "'AND PASSWORD = '" + password + "'";
            DBConnect db = new DBConnect();
            DataTable dt = db.ExecuteQuery(query);
            return dt;
        }

        public void createAccout(string username, string name, string password, string phone, string email)
        {
            string query = "INSERT INTO ACCOUNT(USERNAME,REALNAME,PASSWORD,PHONENUMBER,EMAIL) VALUES '" + username +"', '" + name +"', '" 
                + password + "', '" + phone +"', '" + email +"'; ";           
            DBConnect db = new DBConnect();            
            db.ExecuteQuery(query);
            
        }
    }
}
