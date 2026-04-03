using MidDb_2025CS231.DL;
using MidDb_2025CS231.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace MidDb_2025CS231.UI
{
    public partial class ProjectManagement : Form
    {
        private int selectedProjectId = -1;
        ProjectDL projectService = new ProjectDL();

        public ProjectManagement()
        {
            InitializeComponent();
        }

        // Load Event
        private void ProjectManagement_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            DataTable projectTable = projectService.GetProjectList();

            dgv_Project.DataSource = null;

            if (projectTable != null && projectTable.Rows.Count > 0)
            {
                dgv_Project.DataSource = projectTable;
            }
        }

        // Add Project
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Title.Text))
            {
                MessageBox.Show("Project Title is required!");
                return;
            }

            Project newProject = new Project
            {
                Title = txt_Title.Text,
                Description = Richtxt_Description.Text
            };

            if (projectService.AddProject(newProject))
            {
                MessageBox.Show("Project Added!");
                RefreshGrid();
                ClearForm();
            }
        }

        // Update Project
        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (selectedProjectId == -1)
            {
                MessageBox.Show("Please select a project first!");
                return;
            }

            Project updatedProject = new Project
            {
                Id = selectedProjectId,
                Title = txt_Title.Text,
                Description = Richtxt_Description.Text
            };

            if (projectService.UpdateProject(updatedProject))
            {
                MessageBox.Show("Project Updated!");
                RefreshGrid();
                ClearForm();
            }
        }

        // Delete Project
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (selectedProjectId == -1)
                return;

            var confirmation = MessageBox.Show(
                "Delete this project?",
                "Confirm",
                MessageBoxButtons.YesNo
            );

            if (confirmation == DialogResult.Yes)
            {
                if (projectService.DeleteProject(selectedProjectId))
                {
                    RefreshGrid();
                    ClearForm();
                }
            }
        }

        // Grid Click
        private void dgv_Project_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgv_Project.Rows[e.RowIndex];

                selectedProjectId = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                txt_Title.Text = selectedRow.Cells["Title"].Value.ToString();
                Richtxt_Description.Text = selectedRow.Cells["Description"].Value.ToString();
            }
        }



        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearForm()
        {
            txt_Title.Clear();
            Richtxt_Description.Clear();
            selectedProjectId = -1;
        }
    }
}