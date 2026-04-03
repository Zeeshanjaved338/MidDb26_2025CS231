using MidDb_2025CS231.DL;
using MidDb_2025CS231.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace MidDb_2025CS231.UI
{
    public partial class ManageAdvisors : Form
    {
        private int selectedAdvisorId = -1;
        AdvisorDL advLogic = new AdvisorDL();

        public ManageAdvisors()
        {
            InitializeComponent();
        }

        private void ManageAdvisors_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable genderDt = advLogic.GetLookupByCategory("GENDER");
                adv_CmbGender.DataSource = genderDt;
                adv_CmbGender.DisplayMember = "Value";
                adv_CmbGender.ValueMember = "Id";
                adv_CmbGender.SelectedIndex = -1;

                DataTable desDt = advLogic.GetLookupByCategory("DESIGNATION");
                adv_CmbDesignation.DataSource = desDt;
                adv_CmbDesignation.DisplayMember = "Value";
                adv_CmbDesignation.ValueMember = "Id";
                adv_CmbDesignation.SelectedIndex = -1;

                RefreshGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load Error: " + ex.Message);
            }
        }

        private void RefreshGrid()
        {
            try
            {
                dgv_Advisor.DataSource = null;
                dgv_Advisor.Rows.Clear();
                DataTable dt = advLogic.GetAdvisorList();
                if (dt != null && dt.Rows.Count > 0)
                    dgv_Advisor.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Grid Refresh Error: " + ex.Message);
            }
        }

        private void dgv_Advisor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            try
            {
                DataGridViewRow row = dgv_Advisor.Rows[e.RowIndex];
                selectedAdvisorId = Convert.ToInt32(row.Cells["Id"].Value);
                txt_FirstName.Text = row.Cells["FirstName"].Value?.ToString() ?? "";
                txt_LastName.Text = row.Cells["LastName"].Value?.ToString() ?? "";
                txt_Email.Text = row.Cells["Email"].Value?.ToString() ?? "";

                object salaryVal = row.Cells["Salary"].Value;
                num_Salary.Value = (salaryVal != null && salaryVal != DBNull.Value)
                    ? Convert.ToDecimal(salaryVal) : 0;

                adv_CmbGender.SelectedIndex =
                    adv_CmbGender.FindStringExact(
                        row.Cells["Gender"].Value?.ToString() ?? "");

                adv_CmbDesignation.SelectedIndex =
                    adv_CmbDesignation.FindStringExact(
                        row.Cells["Designation"].Value?.ToString() ?? "");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Row Select Error: " + ex.Message);
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_FirstName.Text) ||
                string.IsNullOrWhiteSpace(txt_Email.Text))
            {
                MessageBox.Show("First Name and Email are mandatory!");
                return;
            }

            if (adv_CmbGender.SelectedIndex == -1 ||
                adv_CmbDesignation.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Gender and Designation!");
                return;
            }

            int genderId = Convert.ToInt32(
                (adv_CmbGender.SelectedItem as DataRowView)["Id"]);
            int designationId = Convert.ToInt32(
                (adv_CmbDesignation.SelectedItem as DataRowView)["Id"]);

            Advisor newAdv = new Advisor
            {
                FirstName = txt_FirstName.Text.Trim(),
                LastName = txt_LastName.Text.Trim(),
                Email = txt_Email.Text.Trim(),
                Gender = genderId,
                Designation = designationId,
                Salary = num_Salary.Value
            };

            if (advLogic.AddAdvisor(newAdv))
            {
                MessageBox.Show("Advisor Added Successfully!");
                ClearForm();
                RefreshGrid();
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (selectedAdvisorId == -1)
            {
                MessageBox.Show("Please select an advisor from the grid first!");
                return;
            }

            if (adv_CmbGender.SelectedIndex == -1 ||
                adv_CmbDesignation.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Gender and Designation!");
                return;
            }

            int genderId = Convert.ToInt32(
                (adv_CmbGender.SelectedItem as DataRowView)["Id"]);
            int designationId = Convert.ToInt32(
                (adv_CmbDesignation.SelectedItem as DataRowView)["Id"]);

            Advisor updatedAdv = new Advisor
            {
                Id = selectedAdvisorId,
                FirstName = txt_FirstName.Text.Trim(),
                LastName = txt_LastName.Text.Trim(),
                Email = txt_Email.Text.Trim(),
                Gender = genderId,
                Designation = designationId,
                Salary = num_Salary.Value
            };

            if (advLogic.UpdateAdvisor(updatedAdv))
            {
                MessageBox.Show("Updated Successfully!");
                ClearForm();
                RefreshGrid();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (selectedAdvisorId == -1)
            {
                MessageBox.Show("Please select an advisor from the grid first!");
                return;
            }

            if (MessageBox.Show("Delete this advisor permanently?", "Confirm",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (advLogic.DeleteAdvisor(selectedAdvisorId))
                {
                    MessageBox.Show("Deleted Successfully!");
                    RefreshGrid();
                    ClearForm();
                }
            }
        }

        private void ClearForm()
        {
            txt_FirstName.Clear();
            txt_LastName.Clear();
            txt_Email.Clear();
            num_Salary.Value = 0;

            adv_CmbGender.DataSource = null;
            adv_CmbDesignation.DataSource = null;

            adv_CmbGender.DataSource = advLogic.GetLookupByCategory("GENDER");
            adv_CmbGender.DisplayMember = "Value";
            adv_CmbGender.ValueMember = "Id";
            adv_CmbGender.SelectedIndex = -1;

            adv_CmbDesignation.DataSource = advLogic.GetLookupByCategory("DESIGNATION");
            adv_CmbDesignation.DisplayMember = "Value";
            adv_CmbDesignation.ValueMember = "Id";
            adv_CmbDesignation.SelectedIndex = -1;

            selectedAdvisorId = -1;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}