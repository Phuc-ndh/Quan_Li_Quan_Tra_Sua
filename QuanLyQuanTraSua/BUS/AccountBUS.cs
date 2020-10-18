using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class AccountBUS
    {
        AccountDAL accountDAL = new AccountDAL();
        public bool Login(string username, string password)
        {
            string Username = "";
            DataTable dt = accountDAL.getLoginAccount(username, getHashMD5(password).ToString());
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Username = row["Username"].ToString();
                }
            }
            if (Username != "")
                return true;
            return false;
        }

        public bool SignUp(string username, string name, string password, string phone, string email)
        {
            try
            {
                accountDAL.InsertAccount(username, name, password, phone, email);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public StringBuilder getHashMD5(string pass)
        {
            MD5 hash = MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(pass);
            byte[] outputBytes = hash.ComputeHash(inputBytes);
            StringBuilder hash_str = new StringBuilder();
            for (int i = 0; i < outputBytes.Length; i++)
            {
                hash_str.Append(outputBytes[i].ToString("x2"));
            }
            return hash_str;
        }
    }
}
