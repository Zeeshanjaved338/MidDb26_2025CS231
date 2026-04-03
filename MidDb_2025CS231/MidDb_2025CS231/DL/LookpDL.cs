using MidDb26_2025CS231.Database_Layer;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace MidDb_2025CS231.DL
{
    public class LookupDL
    {
        // Fetch lookup values by category (e.g., STATUS, DESIGNATION)
        public DataTable GetLookupByCategory(string categoryName)
        {
            DataTable lookupTable = new DataTable();

            try
            {
                using (MySqlConnection connection = helper.Instance.GetConnection())
                {
                    string query = "SELECT Id, Value FROM Lookup WHERE Category = @category";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@category", categoryName);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(lookupTable);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error loading lookup data: " + exception.Message);
            }

            return lookupTable;
        }
    }
}