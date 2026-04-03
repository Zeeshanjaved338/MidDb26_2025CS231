using System;
using System.Data;
using System.Windows.Forms;
using MidDb_2025CS231.DL;
using MidDb_2025CS231.Models;

namespace MidDb_2025CS231.UI
{
    public partial class ManageStudents : Form
    {
        private int selectedStudentId = -1;
        StudentDL studentService = new StudentDL();

        public ManageStudents()
        {
            InitializeComponent();
        }

        private void ManageStudents_Load(object sender, EventArgs e)
        {
            LoadGenderData();
            RefreshGrid();
        }

        private void LoadGenderData()
        {
            DataTable genderTable = studentService.GetGenderLookup();
            std_CmbGender.DataSource = genderTable;

            std_CmbGender.DisplayMember = "Value";
            std_CmbGender.ValueMember = "Id";

            std_CmbGender.SelectedIndex = -1;
        }

        private void RefreshGrid()
        {
            try
            {
                dgv_Student.DataSource = studentService.GetStudentList();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error refreshing grid: " + exception.Message);
            }
        }

        private void ClearForm()
        {
            txt_RegNo.Clear();
            txt_FirstName.Clear();
            txt_LastName.Clear();
            txt_Contact.Clear();
            txt_Email.Clear();
            std_DTP.Value = DateTime.Now;
            std_CmbGender.SelectedIndex = -1;

            selectedStudentId = -1;
            btn_AddStudent.Enabled = true;
        }

        // Add Student 
        private void btn_AddStudent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_RegNo.Text) || string.IsNullOrWhiteSpace(txt_FirstName.Text))
            {
                MessageBox.Show("Registration Number and First Name are required!", "Validation Error");
                return;
            }

            if (std_CmbGender.SelectedValue == null)
            {
                MessageBox.Show("Please select a Gender from the list.", "Validation Error");
                return;
            }

            Student newStudent = new Student
            {
                RegistrationNo = txt_RegNo.Text,
                FirstName = txt_FirstName.Text,
                LastName = txt_LastName.Text,
                Contact = txt_Contact.Text,
                Email = txt_Email.Text,
                DateOfBirth = std_DTP.Value,
                Gender = Convert.ToInt32(std_CmbGender.SelectedValue)
            };

            if (studentService.RegisterNewStudent(newStudent))
            {
                MessageBox.Show("Student registered successfully!", "Success");
                ClearForm();
                RefreshGrid();
            }
            else
            {
                MessageBox.Show("Failed to add student. Ensure Reg# is unique.", "Error");
            }
        }

        // Update Student
        private void btn_UpdateStudent_Click(object sender, EventArgs e)
        {
            if (selectedStudentId == -1)
            {
                MessageBox.Show("Please select a student first.");
                return;
            }

            if (std_CmbGender.SelectedValue == null)
            {
                MessageBox.Show("Please select a Gender.");
                return;
            }

            Student updatedStudent = new Student
            {
                Id = selectedStudentId,
                RegistrationNo = txt_RegNo.Text,
                FirstName = txt_FirstName.Text,
                LastName = txt_LastName.Text,
                Contact = txt_Contact.Text,
                Email = txt_Email.Text,
                DateOfBirth = std_DTP.Value,
                Gender = Convert.ToInt32(std_CmbGender.SelectedValue)
            };

            if (studentService.UpdateExistingStudent(updatedStudent))
            {
                MessageBox.Show("Student updated successfully!", "Updated");
                ClearForm();
                RefreshGrid();
            }
        }

        // Delete Student
        private void btn_DeleteStudent_Click(object sender, EventArgs e)
        {
            if (selectedStudentId == -1)
            {
                MessageBox.Show("Please select a student first.");
                return;
            }

            var confirmation = MessageBox.Show(
                "Are you sure you want to delete this student permanently?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmation == DialogResult.Yes)
            {
                if (studentService.DeleteStudent(selectedStudentId))
                {
                    MessageBox.Show("Student deleted successfully.");
                    ClearForm();
                    RefreshGrid();
                }
            }
        }

        // Griid Click
        private void dgv_Student_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgv_Student.Rows[e.RowIndex];

                selectedStudentId = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                txt_RegNo.Text = selectedRow.Cells["RegistrationNo"].Value?.ToString();
                txt_FirstName.Text = selectedRow.Cells["FirstName"].Value?.ToString();
                txt_LastName.Text = selectedRow.Cells["LastName"].Value?.ToString();
                txt_Contact.Text = selectedRow.Cells["Contact"].Value?.ToString();
                txt_Email.Text = selectedRow.Cells["Email"].Value?.ToString();

                if (selectedRow.Cells["DateOfBirth"].Value != DBNull.Value)
                    std_DTP.Value = Convert.ToDateTime(selectedRow.Cells["DateOfBirth"].Value);

                string genderText = selectedRow.Cells["Gender"].Value?.ToString();
                std_CmbGender.SelectedIndex = std_CmbGender.FindStringExact(genderText);

                btn_AddStudent.Enabled = false;
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}