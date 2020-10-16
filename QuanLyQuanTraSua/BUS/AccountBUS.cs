﻿using System;
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
        AccountDAL accountDAL;
        public bool Login(string username, string password)
        {
            string id = "";
            DataTable dt = accountDAL.getLoginID(username, getHashMD5(password).ToString());
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    id = row["ID"].ToString();
                }
            }
            if (id != "")
                return true;
            return false;
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