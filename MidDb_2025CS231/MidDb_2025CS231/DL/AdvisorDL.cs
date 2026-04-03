using MidDb_2025CS231.Models;
using MidDb26_2025CS231.Database_Layer;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace MidDb_2025CS231.DL
{
    public class AdvisorDL
    {
        public DataTable GetAdvisorList()
        {
            DataTable dt = new DataTable();
            MySqlConnection conn = helper.Instance.GetConnection();
            try
            {
                conn.Open();
                string query = @"
                    SELECT  per.Id,
                            per.FirstName,
                            per.LastName,
                            per.Email,
                            gen.Value  AS Gender,
                            des.Value  AS Designation,
                            adv.Salary
                    FROM    person   per
                    INNER JOIN advisor  adv ON per.Id        = adv.Id
                    LEFT  JOIN lookup   gen ON per.Gender    = gen.Id
                    LEFT  JOIN lookup   des ON adv.Designation = des.Id";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fetch Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public DataTable GetLookupByCategory(string category)
        {
            DataTable dt = new DataTable();
            MySqlConnection conn = helper.Instance.GetConnection();
            try
            {
                conn.Open();
                string query = "SELECT Id, Value FROM lookup WHERE Category = @cat";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@cat", category);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lookup Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public bool AddAdvisor(Advisor adv)
        {
            MySqlConnection conn = helper.Instance.GetConnection();
            MySqlTransaction trans = null;
            try
            {
                conn.Open();
                trans = conn.BeginTransaction();

                string q1 = @"INSERT INTO person 
                                (FirstName, LastName, Contact, Email, DateOfBirth, Gender)
                              VALUES 
                                (@fn, @ln, @contact, @email, @dob, @gen)";

                MySqlCommand cmd1 = new MySqlCommand(q1, conn, trans);
                cmd1.Parameters.AddWithValue("@fn", adv.FirstName);
                cmd1.Parameters.AddWithValue("@ln", adv.LastName);
                cmd1.Parameters.AddWithValue("@contact", DBNull.Value);
                cmd1.Parameters.AddWithValue("@email", adv.Email);
                cmd1.Parameters.AddWithValue("@dob", DBNull.Value);
                cmd1.Parameters.AddWithValue("@gen", adv.Gender);
                cmd1.ExecuteNonQuery();

                MySqlCommand cmdId = new MySqlCommand("SELECT LAST_INSERT_ID()", conn, trans);
                int personId = Convert.ToInt32(cmdId.ExecuteScalar());

                string q2 = @"INSERT INTO advisor 
                                (Id, Designation, Salary)
                              VALUES 
                                (@id, @desig, @sal)";

                MySqlCommand cmd2 = new MySqlCommand(q2, conn, trans);
                cmd2.Parameters.AddWithValue("@id", personId);
                cmd2.Parameters.AddWithValue("@desig", adv.Designation);
                cmd2.Parameters.AddWithValue("@sal", adv.Salary);
                cmd2.ExecuteNonQuery();

                trans.Commit();
                return true;
            }
            catch (Exception ex)
            {
                trans?.Rollback();
                MessageBox.Show("Add Error: " + ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool UpdateAdvisor(Advisor adv)
        {
            MySqlConnection conn = helper.Instance.GetConnection();
            MySqlTransaction trans = null;
            try
            {
                conn.Open();
                trans = conn.BeginTransaction();

                string q1 = @"UPDATE person 
                              SET FirstName = @fn,
                                  LastName  = @ln,
                                  Email     = @email,
                                  Gender    = @gen
                              WHERE Id = @id";

                MySqlCommand cmd1 = new MySqlCommand(q1, conn, trans);
                cmd1.Parameters.AddWithValue("@fn", adv.FirstName);
                cmd1.Parameters.AddWithValue("@ln", adv.LastName);
                cmd1.Parameters.AddWithValue("@email", adv.Email);
                cmd1.Parameters.AddWithValue("@gen", adv.Gender);
                cmd1.Parameters.AddWithValue("@id", adv.Id);
                cmd1.ExecuteNonQuery();

                string q2 = @"UPDATE advisor 
                              SET Designation = @desig,
                                  Salary      = @sal
                              WHERE Id = @id";

                MySqlCommand cmd2 = new MySqlCommand(q2, conn, trans);
                cmd2.Parameters.AddWithValue("@desig", adv.Designation);
                cmd2.Parameters.AddWithValue("@sal", adv.Salary);
                cmd2.Parameters.AddWithValue("@id", adv.Id);
                cmd2.ExecuteNonQuery();

                trans.Commit();
                return true;
            }
            catch (Exception ex)
            {
                trans?.Rollback();
                MessageBox.Show("Update Error: " + ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool DeleteAdvisor(int id)
        {
            MySqlConnection conn = helper.Instance.GetConnection();
            MySqlTransaction trans = null;
            try
            {
                conn.Open();
                trans = conn.BeginTransaction();

                string q1 = "DELETE FROM advisor WHERE Id = @id";
                MySqlCommand cmd1 = new MySqlCommand(q1, conn, trans);
                cmd1.Parameters.AddWithValue("@id", id);
                cmd1.ExecuteNonQuery();

                string q2 = "DELETE FROM person WHERE Id = @id";
                MySqlCommand cmd2 = new MySqlCommand(q2, conn, trans);
                cmd2.Parameters.AddWithValue("@id", id);
                cmd2.ExecuteNonQuery();

                trans.Commit();
                return true;
            }
            catch (Exception ex)
            {
                trans?.Rollback();
                MessageBox.Show("Delete Error: " + ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}