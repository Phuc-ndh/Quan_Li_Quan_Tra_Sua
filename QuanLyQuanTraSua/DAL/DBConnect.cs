using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class DBConnect
    {
        private SqlConnection connection;
        public DBConnect()
        {
            connection = new SqlConnection(@"Data Source=DESKTOP-JSEKHS1;Initial Catalog=QuanLyTraSua;Integrated Security=True");
        }
        public DataTable ExecuteQuery(string query)
        {
            Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Close();
            return dt;
        }
        public void Open()
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
        }
        public void Close()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }
    }
}
