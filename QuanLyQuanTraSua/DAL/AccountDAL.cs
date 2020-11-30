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
        public DataTable GetAllAccounts()
        {
            string query = "SELECT * FROM ACCOUNT";
            DBConnect db = new DBConnect();
            DataTable dt = db.ExecuteQuery(query);
            return dt;
        }

        public Account getAccountByUsername(string username)
        {
            string query = "select * from ACCOUNT where username = @username";
            object[] value = new object[] { username };
            DBConnect db = new DBConnect();
            DataTable dt = db.ExecuteQuery(query, value);
            Account account = new Account(dt.Rows[0]);
            return account;
        }
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

        public bool deleteAccount(string username)
        {
            string query = "delete from Account where Username = @username";
            object[] value = new object[] { username };
            DBConnect db = new DBConnect();
            return ((db.ExecuteNonQuery(query, value)) > 0);
        }

        public bool updateAccount(string username, string name, string phone, string email)
        {
            string query = "update Account set RealName = @name, PhoneNumber = @phone, Email = @email where Username = @username";
            object[] value = new object[] { name, phone, email, username };
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

        // bao cao kinh doanh theo ngay
        public DataTable reportByDate(int day, int month, int year)
        {
            int dayB = day;
            int monthB = month;
            int yearB = year;
            string query = "SELECT SUM(T1.Quantity) * 1000.00 / (select sum(A.Quantity) from BillInfo A " +
                "where A.idBill in (select B.idBill from Bill B where (DAY(B.Date) = @day) and MONTH(B.Date) = @month and YEAR(B.Date) = @year) ) AS PERCENTAGE, SUM(T1.Quantity)* T2.Price AS MONEY, SUM(T1.Quantity) AS SO_LUONG, T2.Name, T1.idDrink " +
                "FROM BillInfo T1 " +
                "INNER JOIN Drink T2 " +
                "ON T1.idDrink = T2.idDrink" +
                " WHERE T1.idBill in (select T3.idOrder from Bill T3 where (DAY(T3.Date) = @dayB  and MONTH(T3.Date) = @monthB and YEAR(T3.Date) = @yearB)) " +
                "GROUP BY T1.idDrink, T2.Name, T2.Price";
            object[] value = new object[] { day, month, year, dayB, monthB, yearB };
            DBConnect db = new DBConnect();
            DataTable dt = db.ExecuteQuery(query, value);
            return dt;
        }

        public bool insertBill(string date, int totalprice)
        {
            string query = "insert into Bill(Date, TotalPrice) values (@date, @totalprice) ";
            object[] value = new object[] { date, totalprice };
            DBConnect db = new DBConnect();
            return (db.ExecuteNonQuery(query, value) > 0);
        }

        //public bool insertBillInfo()
    }
}
