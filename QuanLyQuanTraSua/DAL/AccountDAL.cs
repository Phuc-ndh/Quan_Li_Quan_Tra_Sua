﻿using System;
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

        public bool insertAccount(string username, string name, string password, string phone, string email)
        {
            string query = "insert into ACCOUNT(username,realname,password,phonenumber,email) values(@username, @realname, @password, @phonenumber, @email)";
            object[] value = new object[] { username, name, password, phone, email };
            DBConnect db = new DBConnect();
            return ((db.ExecuteNonQuery(query, value)) > 0);
        }

        // truy van toi username trong table Accout
        public string getPasswordByUsername(string username)
        {
            string password;
            string query = "select Password from Account where Username = @username";
            object[] value = new object[] { username };
            DBConnect db = new DBConnect();
            DataTable dt = db.ExecuteQuery(query, value);
            password = dt.Rows[0]["password"].ToString();
            return password;
        }

        // doi password tai khoan
        public bool updatePassword(string username, string new_password)
        {
            string query = "update ACCOUNT set Password = @password where Username = @username";
            object[] value = new object[] { new_password, username };
            DBConnect db = new DBConnect();
            return ((db.ExecuteNonQuery(query, value)) > 0);
        }

        public bool updateInfo(string username, string realname, string phonenumber, string email)
        {
            string query = "update ACCOUNT set RealName = @realname, PhoneNumber = @phonenumber, Email = @email where Username = @username;";
            object[] value = new object[] { realname, phonenumber, email, username };
            DBConnect db = new DBConnect();
            return ((db.ExecuteNonQuery(query, value)) > 0);
        }
    }
}
