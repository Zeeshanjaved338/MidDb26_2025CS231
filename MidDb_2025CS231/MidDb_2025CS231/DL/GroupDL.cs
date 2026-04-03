using MidDb26_2025CS231.Database_Layer;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace MidDb_2025CS231.DL
{
    public class GroupDL
    {
        
        public DataTable GetGroups()
        {
            DataTable groupTable = new DataTable();
            try
            {
                using (MySqlConnection connection = helper.Instance.GetConnection())
                {
                    string query = "SELECT Id, Created_On FROM `Group` ORDER BY Id DESC";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    adapter.Fill(groupTable);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error loading groups: " + exception.Message);
            }
            return groupTable;
        }

        //Create a new Group
        public int CreateGroup(DateTime createdDate)
        {
            using (MySqlConnection connection = helper.Instance.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO `Group` (Created_On) VALUES (@createdDate); SELECT LAST_INSERT_ID();";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@createdDate", createdDate);

                    return Convert.ToInt32(command.ExecuteScalar());
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Error creating group: " + exception.Message);
                    return -1;
                }
            }
        }

        public bool DeleteGroup(int groupId)
        {
            using (MySqlConnection connection = helper.Instance.GetConnection())
            {
                try
                {
                    connection.Open();

                    //Remove students from grp
                    string deleteStudentsQuery = "DELETE FROM GroupStudent WHERE GroupId = @groupId";
                    MySqlCommand deleteStudentsCommand = new MySqlCommand(deleteStudentsQuery, connection);
                    deleteStudentsCommand.Parameters.AddWithValue("@groupId", groupId);
                    deleteStudentsCommand.ExecuteNonQuery();

                    //Delete group
                    string deleteGroupQuery = "DELETE FROM `Group` WHERE Id = @groupId";
                    MySqlCommand deleteGroupCommand = new MySqlCommand(deleteGroupQuery, connection);
                    deleteGroupCommand.Parameters.AddWithValue("@groupId", groupId);

                    int affectedRows = deleteGroupCommand.ExecuteNonQuery();
                    return affectedRows > 0;
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Database Error: " + exception.Message);
                    return false;
                }
            }
        }

        //Add Student to Group
        public bool AddStudentToGroup(int groupId, int studentId, int statusId, DateTime assignmentDate)
        {
            using (MySqlConnection connection = helper.Instance.GetConnection())
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO GroupStudent (GroupId, StudentId, Status, AssignmentDate) " +
                                   "VALUES (@groupId, @studentId, @statusId, @assignmentDate)";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@groupId", groupId);
                    command.Parameters.AddWithValue("@studentId", studentId);
                    command.Parameters.AddWithValue("@statusId", statusId);
                    command.Parameters.AddWithValue("@assignmentDate", assignmentDate);

                    return command.ExecuteNonQuery() > 0;
                }
                catch (Exception exception)
                {
                    MessageBox.Show("This student might already be in a group or another error occurred: " + exception.Message);
                    return false;
                }
            }
        }

        //Get Group Members
        public DataTable GetGroupMembers(int groupId)
        {
            DataTable memberTable = new DataTable();
            using (MySqlConnection connection = helper.Instance.GetConnection())
            {
                string query = @"SELECT groupStudent.StudentId, 
                                        student.RegistrationNo, 
                                        CONCAT(person.FirstName, ' ', person.LastName) AS StudentName, 
                                        lookup.Value AS Status, 
                                        groupStudent.AssignmentDate
                                 FROM GroupStudent groupStudent
                                 JOIN Student student ON groupStudent.StudentId = student.Id
                                 JOIN Person person ON student.Id = person.Id
                                 JOIN Lookup lookup ON groupStudent.Status = lookup.Id
                                 WHERE groupStudent.GroupId = @groupId";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@groupId", groupId);

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(memberTable);
            }
            return memberTable;
        }

        //Remove Student from Group
        public bool RemoveStudentFromGroup(int groupId, int studentId)
        {
            using (MySqlConnection connection = helper.Instance.GetConnection())
            {
                try
                {
                    connection.Open();

                    string query = "DELETE FROM GroupStudent WHERE GroupId = @groupId AND StudentId = @studentId";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@groupId", groupId);
                    command.Parameters.AddWithValue("@studentId", studentId);

                    return command.ExecuteNonQuery() > 0;
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Error removing member: " + exception.Message);
                    return false;
                }
            }
        }
    }
}