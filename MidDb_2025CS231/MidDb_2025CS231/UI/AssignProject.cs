using MidDb_2025CS231.DL;
using System;
using System.Data;
using System.Windows.Forms;

namespace MidDb_2025CS231.UI
{
    public partial class AssignProject : Form
    {
        // Data Layer Instances
        GroupDL groupLogic = new GroupDL();
        ProjectDL projectLogic = new ProjectDL();
        AssignProjectDL assignLogic = new AssignProjectDL();

        int currentSelectedGroupId = -1;

        public AssignProject()
        {
            InitializeComponent();
        }

        private void AssignProject_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            RefreshOverviewGrid();
        }

        
        private void LoadComboBoxes()
        {

            //Loading Groups for the ComboBox
            DataTable dtGroups = groupLogic.GetGroups();
            if (dtGroups != null && dtGroups.Rows.Count > 0)
            {
                APrj_CmbGroup.DataSource = null;
                APrj_CmbGroup.DisplayMember = "Id"; // Change this to "GroupId" if your SQL uses that name
                APrj_CmbGroup.ValueMember = "Id";
                APrj_CmbGroup.DataSource = dtGroups;
            }

            // Load Projects for the ComboBox
            DataTable dtProjects = projectLogic.GetAllProjects();
            if (dtProjects != null && dtProjects.Rows.Count > 0)
            {
                APrj_CmbProject.DataSource = null;
                APrj_CmbProject.DisplayMember = "Title"; 
                APrj_CmbProject.ValueMember = "Id";
                APrj_CmbProject.DataSource = dtProjects;
            }
            else
            {
                MessageBox.Show("No projects found! Check if your Project table has data.");
            }
        }

        private void RefreshOverviewGrid()
        {
            dgv_AssignProject.DataSource = assignLogic.GetCurrentAssignments();

            if (dgv_AssignProject.Columns.Contains("GroupId"))
                dgv_AssignProject.Columns["GroupId"].HeaderText = "Group ID";

            dgv_AssignProject.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // Assign Project btn
        private void btn_AssignProject_Click(object sender, EventArgs e)
        {
            if (APrj_CmbGroup.SelectedValue == null || APrj_CmbProject.SelectedValue == null)
            {
                MessageBox.Show("Please select both a Group and a Project.");
                return;
            }

            int groupId = Convert.ToInt32(APrj_CmbGroup.SelectedValue);
            int projectId = Convert.ToInt32(APrj_CmbProject.SelectedValue);
            DateTime assignmentDate = Assignment_DTP.Value;

            
            if (assignLogic.IsGroupAssigned(groupId))
            {
                MessageBox.Show("This group is already assigned to a project. Use 'Update' to change it.");
                return;
            }

            if (assignLogic.AssignProject(groupId, projectId, assignmentDate))
            {
                MessageBox.Show("Project assigned successfully!");
                RefreshOverviewGrid();
            }
        }


        // Update Assignment btn for prj or date
        private void btn_UpdateAssignment_Click(object sender, EventArgs e)
        {
            if (currentSelectedGroupId == -1)
            {
                MessageBox.Show("Please select an assignment from the grid to update.");
                return;
            }

            int newProjectId = Convert.ToInt32(APrj_CmbProject.SelectedValue);
            DateTime newDate = Assignment_DTP.Value;

            if (assignLogic.UpdateProjectAssignment(currentSelectedGroupId, newProjectId, newDate))
            {
                MessageBox.Show("Assignment updated successfully!");
                RefreshOverviewGrid();
                currentSelectedGroupId = -1; 
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_AssignProject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_AssignProject.Rows[e.RowIndex];

                currentSelectedGroupId = Convert.ToInt32(row.Cells["GroupId"].Value);

                APrj_CmbGroup.SelectedValue = currentSelectedGroupId;
              
                APrj_CmbProject.Text = row.Cells["ProjectTitle"].Value.ToString();
              
                Assignment_DTP.Value = Convert.ToDateTime(row.Cells["AssignmentDate"].Value);
            }
        }
    }
}