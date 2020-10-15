using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace logIn
{
    public partial class logIn : Form
    {
        public logIn()
        {
            InitializeComponent();
        }

        // lay chuoi connect sql
        private string connectString = @"Data Source=DESKTOP-JSEKHS1;Initial Catalog=QUANLYTRASUA;Integrated Security=True";

        // ham lay chuoi connect
        public string getConnectString()
        {
            string connect_str = connectString;
            return connect_str;
        }

        SqlConnection connection;


        // ham ma hoa pass MD5
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

        private static string USER_ID = "";

        // lay user va password nhap tu textbox
        private string getId(string user, string pass)
        {
            string id = "";
            try
            {
                connection = new SqlConnection(connectString);
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT* FROM USERS WHERE ID ='" + user + "'AND PASS = '" + getHashMD5(pass) + "'", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                if (table != null)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        id = row["ID"].ToString();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không kết nối đến server được !");
            }
            finally
            {
                connection.Close();
            }
            return id;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            USER_ID = getId(txtID.Text, txtPassword.Text);
            if (USER_ID != "")
            {
                // goi ham form main ra
                MessageBox.Show("Form Main sẽ hiện ra");
            }
            else
            {
                MessageBox.Show("Sai mật khẩu hoặc tài khoảng");
                txtPassword.Text = "";
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            
             if (e.KeyChar == Convert.ToChar(Keys.Enter))
             {
                    btnLogin_Click(sender, e);
             }          
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
