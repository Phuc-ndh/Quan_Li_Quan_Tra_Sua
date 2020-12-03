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
            int dayC = day;

            int monthB = month;
            int monthC = month;

            int yearB = year;
            int yearC = year;

            string query = "SELECT SUM(T1.Quantity) * 1000.00 / (select sum(A.Quantity) from BillInfo A " +
                                                                    "where A.idBill in (select B.idBill from Bill B where (DAY(B.Date) = @day) and MONTH(B.Date) = @month and YEAR(B.Date) = @year) ) AS PERCENTAGE_DRINK, " +
                                "SUM(T1.Quantity)* T2.Price * 1000.00 / (select SUM(C.TotalPrice) from Bill C " +
                                                                    "where DAY(C.Date) = @dayB and MONTH(C.Date) = @monthB and YEAR(C.Date) = @yearB) AS PERCENTAGE_MONEY, " +
                                "SUM(T1.Quantity)* T2.Price AS MONEY, " +
                                "SUM(T1.Quantity) AS SO_LUONG, " +
                                "T2.Name, T1.idDrink " +
                           "FROM BillInfo T1 " +
                           "INNER JOIN Drink T2 " +
                                "ON T1.idDrink = T2.idDrink" +
                           " WHERE T1.idBill in (select T3.idBill from Bill T3 where (DAY(T3.Date) = @dayC  and MONTH(T3.Date) = @monthC and YEAR(T3.Date) = @yearC)) " +
                           "GROUP BY T1.idDrink, T2.Name, T2.Price";
            object[] value = new object[] { day, month, year, dayB, monthB, yearB, dayC, monthC, yearC };
            DBConnect db = new DBConnect();
            DataTable dt = db.ExecuteQuery(query, value);
            return dt;
        }

        public DataTable reportByMonth(int month)
        {
            int year = DateTime.Now.Year;

            int monthB = month;
            int monthC = month;

            int yearB = year;
            int yearC = year;

            string query = "SELECT SUM(T1.Quantity) * 1000.00 / (select sum(A.Quantity) from BillInfo A " +
                                                                    "where A.idBill in (select B.idBill from Bill B where MONTH(B.Date) = @month and YEAR(B.Date) = @year) ) AS PERCENTAGE_DRINK, " +
                                "SUM(T1.Quantity)* T2.Price * 1000.00 / (select SUM(C.TotalPrice) from Bill C " +
                                                                    "where MONTH(C.Date) = @monthB and YEAR(C.Date) = @yearB) AS PERCENTAGE_MONEY, " +
                                "SUM(T1.Quantity)* T2.Price AS MONEY, " +
                                "SUM(T1.Quantity) AS SO_LUONG, " +
                                "T2.Name, T1.idDrink " +
                           "FROM BillInfo T1 " +
                           "INNER JOIN Drink T2 " +
                                "ON T1.idDrink = T2.idDrink" +
                           " WHERE T1.idBill in (select T3.idBill from Bill T3 where and MONTH(T3.Date) = @monthC and YEAR(T3.Date) = @yearC)) " +
                           "GROUP BY T1.idDrink, T2.Name, T2.Price";
            object[] value = new object[] { month, year, monthB, yearB, monthC, yearC };
            DBConnect db = new DBConnect();
            DataTable dt = db.ExecuteQuery(query, value);
            return dt;
        }

        // lay id
        public int _id;

        // them bill
        public object insertBill(string date, int totalprice)
        {
            string query = "insert into Bill(Date, TotalPrice) values (@date, @totalprice); select SCOPE_IDENTITY() ";
            object[] value = new object[] { date, totalprice };
            DBConnect db = new DBConnect();
            //_id = (int)(db.ExecuteScalar(query, value));
            _id = Int32.Parse(db.ExecuteScalar(query, value).ToString());
            return _id;
            //return (db.ExecuteNonQuery(query, value) > 0);
        }

        // them BillInfo theo _id
        public bool insertBillInfo(int idDrink,int quantity)
        {
            int id = this._id;
            string query = "insert into BillInfo(idBill, idDrink, quantity) values (@id, @idDrink, @quantity)";
            object[] value = new object[] { id, idDrink, quantity };
            DBConnect db = new DBConnect();
            return (db.ExecuteNonQuery(query, value) > 0);
        }
    }
}
