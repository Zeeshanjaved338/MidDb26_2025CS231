using MidDb26_2025CS231.Database_Layer;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace MidDb_2025CS231.DL
{
    public class AssignAdvisorDL
    {
        
        public DataTable GetAdvisors()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = helper.Instance.GetConnection())
            {
                string query = @"SELECT Adv.Id, CONCAT(Per.FirstName, ' ', Per.LastName) AS Name 
                                 FROM Advisor Adv 
                                 JOIN Person Per ON Adv.Id = Per.Id";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                da.Fill(dt);
            }
            return dt;
        }

        
        public DataTable GetAdvisorRoles()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = helper.Instance.GetConnection())
            {
                string query = "SELECT Id, Value FROM Lookup WHERE Category = 'ADVISOR_ROLE'";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                da.Fill(dt);
            }
            return dt;
        }

        
        public bool AssignAdvisor(int advisorId, int projectId, int roleId, DateTime date)
        {
            using (MySqlConnection conn = helper.Instance.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = @"INSERT INTO ProjectAdvisor (AdvisorId, ProjectId, AdvisorRole, AssignmentDate) 
                                     VALUES (@aid, @pid, @rid, @date)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@aid", advisorId);
                    cmd.Parameters.AddWithValue("@pid", projectId);
                    cmd.Parameters.AddWithValue("@rid", roleId);
                    cmd.Parameters.AddWithValue("@date", date);
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
            }
        }

        
        public bool UpdateAdvisorRole(int advisorId, int projectId, int newRoleId)
        {
            using (MySqlConnection conn = helper.Instance.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE ProjectAdvisor SET AdvisorRole = @rid WHERE AdvisorId = @aid AND ProjectId = @pid";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@rid", newRoleId);
                    cmd.Parameters.AddWithValue("@aid", advisorId);
                    cmd.Parameters.AddWithValue("@pid", projectId);
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); return false; }
            }
        }

    
        public bool DeleteAdvisor(int advisorId, int projectId)
        {
            using (MySqlConnection conn = helper.Instance.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM ProjectAdvisor WHERE AdvisorId = @aid AND ProjectId = @pid";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@aid", advisorId);
                    cmd.Parameters.AddWithValue("@pid", projectId);
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); return false; }
            }
        }


        public DataTable GetAssignments()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = helper.Instance.GetConnection())
            {
                // Added ORDER BY P.Title to group advisors of the same project together
                string query = @"SELECT PA.ProjectId, P.Title AS ProjectTitle, PA.AdvisorId, 
                         CONCAT(Pers.FirstName, ' ', Pers.LastName) AS AdvisorName, 
                         L.Value AS Role, PA.AssignmentDate
                         FROM ProjectAdvisor PA
                         JOIN Project P ON PA.ProjectId = P.Id
                         JOIN Person Pers ON PA.AdvisorId = Pers.Id
                         JOIN Lookup L ON PA.AdvisorRole = L.Id
                         ORDER BY P.Title, Role ASC";

                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                da.Fill(dt);
            }
            return dt;
        }


        public bool IsAdvisorAlreadyAssigned(int advisorId, int projectId)
        {
            using (MySqlConnection conn = helper.Instance.GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM ProjectAdvisor WHERE AdvisorId = @aid AND ProjectId = @pid";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@aid", advisorId);
                cmd.Parameters.AddWithValue("@pid", projectId);
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }
    }
}