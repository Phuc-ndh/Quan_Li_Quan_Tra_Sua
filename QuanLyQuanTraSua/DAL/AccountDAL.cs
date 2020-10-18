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
            string query = "select * from ACCOUNT where username = @username and password = @password";
            object[] value = new object[] { username, password };
            DBConnect db = new DBConnect();
            DataTable dt = db.ExecuteQuery(query, value);
            return dt;
        }

        public void InsertAccount(string username, string name, string password, string phone, string email)
        {
            string query = "insert into ACCOUNT(username,realname,password,phonenumber,email) values(@email, @realname, @password, @phonenumber, @email)";        
            object[] value = new object[] { username, name, password, phone, email };
            DBConnect db = new DBConnect();            
            db.ExecuteNonQuery(query, value);
        }
    }
}
