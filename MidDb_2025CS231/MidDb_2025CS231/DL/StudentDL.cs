using MidDb_2025CS231.Models;
using MidDb26_2025CS231.Database_Layer;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace MidDb_2025CS231.DL
{
    public class StudentDL
    {
        //Gender Lookup
        public DataTable GetGenderLookup()
        {
            DataTable genderTable = new DataTable();
            string query = "SELECT Id, Value FROM Lookup WHERE Category = 'GENDER'";

            using (MySqlConnection connection = helper.Instance.GetConnection())
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                adapter.Fill(genderTable);
            }

            return genderTable;
        }

        // Get Student List
        public DataTable GetStudentList()
        {
            DataTable studentTable = new DataTable();

            string query = @"SELECT S.Id, S.RegistrationNo, P.FirstName, P.LastName, 
                                    P.Contact, P.Email, P.DateOfBirth, 
                                    (SELECT Value FROM Lookup WHERE Id = P.Gender) as Gender
                             FROM Student S
                             JOIN Person P ON S.Id = P.Id";

            using (MySqlConnection connection = helper.Instance.GetConnection())
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                adapter.Fill(studentTable);
            }

            return studentTable;
        }

        // Add Student
        public bool RegisterNewStudent(Student studentModel)
        {
            using (MySqlConnection connection = helper.Instance.GetConnection())
            {
                connection.Open();
                MySqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    string insertPersonQuery = @"INSERT INTO Person 
                                                (FirstName, LastName, Contact, Email, DateOfBirth, Gender) 
                                                VALUES (@FN, @LN, @C, @E, @DOB, @G);
                                                SELECT LAST_INSERT_ID();";

                    MySqlCommand personCommand = new MySqlCommand(insertPersonQuery, connection, transaction);

                    personCommand.Parameters.AddWithValue("@FN", studentModel.FirstName);
                    personCommand.Parameters.AddWithValue("@LN", studentModel.LastName);
                    personCommand.Parameters.AddWithValue("@C", studentModel.Contact);
                    personCommand.Parameters.AddWithValue("@E", studentModel.Email);
                    personCommand.Parameters.AddWithValue("@DOB", studentModel.DateOfBirth);
                    personCommand.Parameters.AddWithValue("@G", studentModel.Gender);

                    int generatedPersonId = Convert.ToInt32(personCommand.ExecuteScalar());

                    string insertStudentQuery = "INSERT INTO Student (Id, RegistrationNo) VALUES (@Id, @Reg)";
                    MySqlCommand studentCommand = new MySqlCommand(insertStudentQuery, connection, transaction);

                    studentCommand.Parameters.AddWithValue("@Id", generatedPersonId);
                    studentCommand.Parameters.AddWithValue("@Reg", studentModel.RegistrationNo);

                    studentCommand.ExecuteNonQuery();
                    transaction.Commit();

                    return true;
                }
                catch
                {
                    transaction.Rollback();
                    return false;
                }
            }
        }

        // Update Student
        public bool UpdateExistingStudent(Student studentModel)
        {
            using (MySqlConnection connection = helper.Instance.GetConnection())
            {
                connection.Open();
                MySqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    string updatePersonQuery = @"UPDATE Person 
                                                 SET FirstName=@FN, LastName=@LN, Contact=@C, 
                                                     Email=@E, DateOfBirth=@DOB, Gender=@G 
                                                 WHERE Id=@Id";

                    MySqlCommand personCommand = new MySqlCommand(updatePersonQuery, connection, transaction);

                    personCommand.Parameters.AddWithValue("@FN", studentModel.FirstName);
                    personCommand.Parameters.AddWithValue("@LN", studentModel.LastName);
                    personCommand.Parameters.AddWithValue("@C", studentModel.Contact);
                    personCommand.Parameters.AddWithValue("@E", studentModel.Email);
                    personCommand.Parameters.AddWithValue("@DOB", studentModel.DateOfBirth);
                    personCommand.Parameters.AddWithValue("@G", studentModel.Gender);
                    personCommand.Parameters.AddWithValue("@Id", studentModel.Id);

                    personCommand.ExecuteNonQuery();

                    string updateStudentQuery = "UPDATE Student SET RegistrationNo=@Reg WHERE Id=@Id";
                    MySqlCommand studentCommand = new MySqlCommand(updateStudentQuery, connection, transaction);

                    studentCommand.Parameters.AddWithValue("@Reg", studentModel.RegistrationNo);
                    studentCommand.Parameters.AddWithValue("@Id", studentModel.Id);

                    studentCommand.ExecuteNonQuery();
                    transaction.Commit();

                    return true;
                }
                catch
                {
                    transaction.Rollback();
                    return false;
                }
            }
        }

        //Delete Student
        public bool DeleteStudent(int studentId)
        {
            using (MySqlConnection connection = helper.Instance.GetConnection())
            {
                connection.Open();
                MySqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    MySqlCommand deleteStudentCommand = new MySqlCommand(
                        "DELETE FROM Student WHERE Id=@Id", connection, transaction);

                    deleteStudentCommand.Parameters.AddWithValue("@Id", studentId);
                    deleteStudentCommand.ExecuteNonQuery();

                    MySqlCommand deletePersonCommand = new MySqlCommand(
                        "DELETE FROM Person WHERE Id=@Id", connection, transaction);

                    deletePersonCommand.Parameters.AddWithValue("@Id", studentId);
                    deletePersonCommand.ExecuteNonQuery();

                    transaction.Commit();
                    return true;
                }
                catch
                {
                    transaction.Rollback();
                    return false;
                }
            }
        }

        //Get Active Students
        public DataTable GetActiveStudents()
        {
            DataTable activeStudentTable = new DataTable();

            using (MySqlConnection connection = helper.Instance.GetConnection())
            {
                string query = "SELECT Id, RegistrationNo FROM Student";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                adapter.Fill(activeStudentTable);
            }

            return activeStudentTable;
        }
    }
}