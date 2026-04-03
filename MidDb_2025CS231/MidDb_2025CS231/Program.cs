using MidDb_2025CS231.UI; 
using MidDb26_2025CS231.Database_Layer;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace MidDb_2025CS231
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
           /* try
            {
                MySqlConnection conn = helper.Instance.GetConnection();
                conn.Open();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Connection Failed: " + ex.Message);
            } */

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}