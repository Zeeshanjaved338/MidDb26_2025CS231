using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace MidDb26_2025CS231.Database_Layer
{
    public class helper
    {
        private string connString = "server=localhost;user id=root;password=1018;database=dbproject;";
        private static helper instance;

        public static helper Instance
        {
            get
            {
                if (instance == null)
                    instance = new helper();
                return instance;
            }
        }

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connString);
        }



        public DataTable ExecuteDataTable(string query)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = GetConnection()) 
            {
                try
                {
                    conn.Open();
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message);
                }
            }
            return dt;
        }
    }
}