﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
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
    }
}
