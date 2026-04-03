using MidDb26_2025CS231.Database_Layer;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace MidDb_2025CS231.DL
{
    public class AssignProjectDL
    {
        //(Groups + Projects + Student Names)
        public DataTable GetCurrentAssignments()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = helper.Instance.GetConnection())
            {
                try
                {
                    string query = @"SELECT 
                                        GrpPrj.GroupId, 
                                        Prj.Title AS ProjectTitle, 
                                        GROUP_CONCAT(CONCAT(Pers.FirstName, ' ', Pers.LastName) SEPARATOR ', ') AS GroupMembers,
                                        GrpPrj.AssignmentDate
                                     FROM GroupProject GrpPrj
                                     JOIN Project Prj ON GrpPrj.ProjectId = Prj.Id
                                     JOIN GroupStudent GrpStd ON GrpPrj.GroupId = GrpStd.GroupId
                                     JOIN Person Pers ON GrpStd.StudentId = Pers.Id
                                     GROUP BY GrpPrj.GroupId, Prj.Title, GrpPrj.AssignmentDate";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    adapter.Fill(dt);
                }
                catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            }
            return dt;
        }

        // 2. Assign the project
        public bool AssignProject(int groupId, int projectId, DateTime date)
        {
            using (MySqlConnection conn = helper.Instance.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO GroupProject (ProjectId, GroupId, AssignmentDate) VALUES (@prjid, @grpid, @date)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@prjid", projectId);
                    cmd.Parameters.AddWithValue("@grpid", groupId);
                    cmd.Parameters.AddWithValue("@date", date);
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Assignment failed. Group may already have a project: " + ex.Message);
                    return false;
                }
            }
        }


        public bool UpdateProjectAssignment(int groupId, int projectId, DateTime date)
        {
            using (MySqlConnection conn = helper.Instance.GetConnection())
            {
                try
                {
                    conn.Open();
                    // This SQL query finds the existing assignment for the group and changes the project
                    string query = "UPDATE GroupProject SET ProjectId = @prjid, AssignmentDate = @date WHERE GroupId = @grpid";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@prjid", projectId);
                    cmd.Parameters.AddWithValue("@grpid", groupId);
                    cmd.Parameters.AddWithValue("@date", date);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Update failed in Database: " + ex.Message);
                    return false;
                }
            }
        }


        public bool IsGroupAssigned(int groupId)
        {
            using (MySqlConnection conn = helper.Instance.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM GroupProject WHERE GroupId = @grpid";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@grpid", groupId);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Validation Error: " + ex.Message);
                    return false;
                }
            }
        }
    }
}