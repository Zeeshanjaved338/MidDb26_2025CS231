using MidDb26_2025CS231.Database_Layer;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace MidDb_2025CS231.DL
{
    public class EvaluationDL
    {
        public bool AddEvaluation(string evaluationName, int totalMarks, int totalWeightage)
        {
            using (MySqlConnection connection = helper.Instance.GetConnection())
            {
                string query = "INSERT INTO Evaluation (Name, TotalMarks, TotalWeightage) VALUES (@evaluationName, @totalMarks, @totalWeightage)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@evaluationName", evaluationName);
                command.Parameters.AddWithValue("@totalMarks", totalMarks);
                command.Parameters.AddWithValue("@totalWeightage", totalWeightage);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool UpdateEvaluation(int evaluationId, string evaluationName, int totalMarks, int totalWeightage)
        {
            using (MySqlConnection connection = helper.Instance.GetConnection())
            {
                string query = "UPDATE Evaluation SET Name=@evaluationName, TotalMarks=@totalMarks, TotalWeightage=@totalWeightage WHERE Id=@evaluationId";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@evaluationName", evaluationName);
                command.Parameters.AddWithValue("@totalMarks", totalMarks);
                command.Parameters.AddWithValue("@totalWeightage", totalWeightage);
                command.Parameters.AddWithValue("@evaluationId", evaluationId);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool DeleteEvaluation(int evaluationId)
        {
            using (MySqlConnection connection = helper.Instance.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM Evaluation WHERE Id = @evaluationId";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@evaluationId", evaluationId);

                    int affectedRows = command.ExecuteNonQuery();
                    return affectedRows > 0;
                }
                catch (MySqlException exception)
                {
                    if (exception.Number == 1451)
                    {
                        MessageBox.Show("Cannot delete: This evaluation is linked to group marks. Delete the marks in the grid first!");
                    }
                    else
                    {
                        MessageBox.Show("Database Error: " + exception.Message);
                    }
                    return false;
                }
            }
        }

        public DataTable GetAllEvaluations()
        {
            DataTable evaluationTable = new DataTable();
            using (MySqlConnection connection = helper.Instance.GetConnection())
            {
                string query = "SELECT Id, Name, TotalMarks, TotalWeightage FROM Evaluation";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                adapter.Fill(evaluationTable);
            }
            return evaluationTable;
        }

        // GROUP GRADING
        public bool MarkGroup(int groupId, int evaluationId, int obtainedMarks, DateTime evaluationDate)
        {
            using (MySqlConnection connection = helper.Instance.GetConnection())
            {
                string query = @"INSERT INTO GroupEvaluation (GroupId, EvaluationId, ObtainedMarks, EvaluationDate) 
                                 VALUES (@groupId, @evaluationId, @obtainedMarks, @evaluationDate)
                                 ON DUPLICATE KEY UPDATE ObtainedMarks = @obtainedMarks, EvaluationDate = @evaluationDate";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@groupId", groupId);
                command.Parameters.AddWithValue("@evaluationId", evaluationId);
                command.Parameters.AddWithValue("@obtainedMarks", obtainedMarks);
                command.Parameters.AddWithValue("@evaluationDate", evaluationDate);

                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public DataTable GetGroupResults()
        {
            DataTable resultsTable = new DataTable();
            using (MySqlConnection connection = helper.Instance.GetConnection())
            {
                string query = @"SELECT evaluation.Id AS EvaluationId, 
                                        groupEvaluation.GroupId, 
                                        evaluation.Name AS EvaluationName, 
                                        evaluation.TotalMarks, 
                                        groupEvaluation.ObtainedMarks, 
                                        groupEvaluation.EvaluationDate 
                                 FROM GroupEvaluation groupEvaluation
                                 JOIN Evaluation evaluation 
                                 ON groupEvaluation.EvaluationId = evaluation.Id";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                adapter.Fill(resultsTable);
            }
            return resultsTable;
        }

        public DataTable GetAllGroupIds()
        {
            DataTable groupTable = new DataTable();
            using (MySqlConnection connection = helper.Instance.GetConnection())
            {
                string query = "SELECT Id FROM `Group` ORDER BY Id ASC";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                adapter.Fill(groupTable);
            }
            return groupTable;
        }

        public bool DeleteGroupMark(int groupId, int evaluationId)
        {
            using (MySqlConnection connection = helper.Instance.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM GroupEvaluation WHERE GroupId = @groupId AND EvaluationId = @evaluationId";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@groupId", groupId);
                    command.Parameters.AddWithValue("@evaluationId", evaluationId);

                    return command.ExecuteNonQuery() > 0;
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Error deleting mark: " + exception.Message);
                    return false;
                }
            }
        }

        public DataTable GetOverallResults()
        {
            string query = @"SELECT groupTable.Id AS GroupId, 
                            ROUND(SUM((groupEvaluation.ObtainedMarks / evaluation.TotalMarks) * evaluation.TotalWeightage), 2) AS FinalScorePercentage
                     FROM `Group` groupTable
                     JOIN GroupEvaluation groupEvaluation ON groupTable.Id = groupEvaluation.GroupId
                     JOIN Evaluation evaluation ON groupEvaluation.EvaluationId = evaluation.Id
                     GROUP BY groupTable.Id";

            return helper.Instance.ExecuteDataTable(query);
        }

        public DataTable GetSpecificGroupDetails(int groupId)
        {
            string query = $@"SELECT evaluation.Name AS EvaluationName, 
                            groupEvaluation.ObtainedMarks AS ObtainedMarks, 
                            evaluation.TotalMarks AS TotalMarks, 
                            evaluation.TotalWeightage AS WeightagePercentage
                     FROM GroupEvaluation groupEvaluation
                     JOIN Evaluation evaluation ON groupEvaluation.EvaluationId = evaluation.Id
                     WHERE groupEvaluation.GroupId = {groupId}";

            return helper.Instance.ExecuteDataTable(query);
        }
    }
}