using MidDb_2025CS231.Models;
using MidDb26_2025CS231.Database_Layer;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace MidDb_2025CS231.DL
{
    public class ProjectDL
    {
        public DataTable GetProjectList()
        {
            DataTable projectTable = new DataTable();

            using (MySqlConnection connection = helper.Instance.GetConnection())
            {
                string query = "SELECT Id, Title, Description FROM Project";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                adapter.Fill(projectTable);
            }

            return projectTable;
        }

        // Add new project
        public bool AddProject(Project projectModel)
        {
            using (MySqlConnection connection = helper.Instance.GetConnection())
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO Project (Title, Description) VALUES (@title, @desc)";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    command.Parameters.AddWithValue("@title", projectModel.Title);
                    command.Parameters.AddWithValue("@desc", projectModel.Description);

                    command.ExecuteNonQuery();
                    return true;
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Error adding project: " + exception.Message);
                    return false;
                }
            }
        }

        // Updtae project details
        public bool UpdateProject(Project projectModel)
        {
            using (MySqlConnection connection = helper.Instance.GetConnection())
            {
                try
                {
                    connection.Open();

                    string query = "UPDATE Project SET Title=@title, Description=@desc WHERE Id=@id";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    command.Parameters.AddWithValue("@title", projectModel.Title);
                    command.Parameters.AddWithValue("@desc", projectModel.Description);
                    command.Parameters.AddWithValue("@id", projectModel.Id);

                    command.ExecuteNonQuery();
                    return true;
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Update Error: " + exception.Message);
                    return false;
                }
            }
        }

        
        public bool DeleteProject(int projectId)
        {
            using (MySqlConnection connection = helper.Instance.GetConnection())
            {
                try
                {
                    connection.Open();

                    string query = "DELETE FROM Project WHERE Id=@id";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    command.Parameters.AddWithValue("@id", projectId);
                    command.ExecuteNonQuery();

                    return true;
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Delete Error: " + exception.Message);
                    return false;
                }
            }
        }

        // using to populate the project combo box in assign project form
        public DataTable GetAllProjects()
        {
            DataTable projectTable = new DataTable();

            try
            {
                using (MySqlConnection connection = helper.Instance.GetConnection())
                {
                    string query = "SELECT Id, Title FROM Project ORDER BY Title ASC";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    adapter.Fill(projectTable);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error loading projects: " + exception.Message);
            }

            return projectTable;
        }
    }
}