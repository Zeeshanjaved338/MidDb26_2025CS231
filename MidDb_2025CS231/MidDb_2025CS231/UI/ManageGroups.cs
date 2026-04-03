using MidDb_2025CS231.DL;
using System;
using System.Data;
using System.Windows.Forms;

namespace MidDb_2025CS231.UI
{
    public partial class ManageGroups : Form
    {
        GroupDL groupService = new GroupDL();
        StudentDL studentService = new StudentDL();
        LookupDL lookupService = new LookupDL();

        int selectedGroupId = -1;

        public ManageGroups()
        {
            InitializeComponent();
        }

        private void ManageGroups_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            RefreshGroupsGrid();
        }

        private void LoadComboBoxes()
        {
            //Students
            DataTable studentTable = studentService.GetActiveStudents();
            if (studentTable != null && studentTable.Rows.Count > 0)
            {
                grp_CmbStudent.DataSource = null;
                grp_CmbStudent.DisplayMember = "RegistrationNo";
                grp_CmbStudent.ValueMember = "Id";
                grp_CmbStudent.DataSource = studentTable;
            }

            // Status
            DataTable statusTable = lookupService.GetLookupByCategory("STATUS");
            if (statusTable != null && statusTable.Rows.Count > 0)
            {
                grp_CmbStatus.DataSource = null;
                grp_CmbStatus.DisplayMember = "Value";
                grp_CmbStatus.ValueMember = "Id";
                grp_CmbStatus.DataSource = statusTable;
            }
        }

        private void RefreshGroupsGrid()
        {
            dgv_Groups.DataSource = groupService.GetGroups();

            if (dgv_Groups.Columns.Contains("Id"))
                dgv_Groups.Columns["Id"].HeaderText = "Group ID";
        }

        // Create Group
        private void btn_CreateGroup_Click(object sender, EventArgs e)
        {
            int newGroupId = groupService.CreateGroup(DTP_Group.Value);

            if (newGroupId > 0)
            {
                MessageBox.Show($"Group {newGroupId} Created Successfully!");
                RefreshGroupsGrid();
            }
        }

        // Delete Group
        private void btn_DeleteGroup_Click_1(object sender, EventArgs e)
        {
            if (selectedGroupId == -1)
            {
                MessageBox.Show("Please select a group from the grid first.");
                return;
            }

            var confirmation = MessageBox.Show(
                "Are you sure you want to delete this group and all its members?",
                "Confirm Delete", MessageBoxButtons.YesNo);

            if (confirmation == DialogResult.Yes)
            {
                if (groupService.DeleteGroup(selectedGroupId))
                {
                    MessageBox.Show("Group deleted successfully.");
                    selectedGroupId = -1;
                    RefreshGroupsGrid();
                    dgv_GroupMembers.DataSource = null;
                }
            }
        }

        // When a group so grid selected, load its members to show in right grid of form
        private void dgv_Groups_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedGroupId = Convert.ToInt32(
                    dgv_Groups.Rows[e.RowIndex].Cells["Id"].Value
                );

                RefreshMembersGrid();
            }
        }

        private void RefreshMembersGrid()
        {
            if (selectedGroupId != -1)
            {
                dgv_GroupMembers.DataSource = groupService.GetGroupMembers(selectedGroupId);

                if (dgv_GroupMembers.Columns.Contains("StudentId"))
                    dgv_GroupMembers.Columns["StudentId"].Visible = false;
            }
        }

        private void btn_AddStudent_Click(object sender, EventArgs e)
        {
            if (selectedGroupId == -1)
            {
                MessageBox.Show("Please select a Group from the list on the left first!");
                return;
            }

            int studentId = Convert.ToInt32(grp_CmbStudent.SelectedValue);
            int statusId = Convert.ToInt32(grp_CmbStatus.SelectedValue);
            DateTime assignmentDate = DateTime.Now;

            if (groupService.AddStudentToGroup(selectedGroupId, studentId, statusId, assignmentDate))
            {
                MessageBox.Show("Student added to group successfully!");
                RefreshMembersGrid();
            }
        }

        // Remove student from group
        private void btn_DeleteMember_Click(object sender, EventArgs e)
        {
            if (dgv_GroupMembers.CurrentRow == null || selectedGroupId == -1) return;

            int studentId = Convert.ToInt32(
                dgv_GroupMembers.CurrentRow.Cells["StudentId"].Value
            );

            if (groupService.RemoveStudentFromGroup(selectedGroupId, studentId))
            {
                MessageBox.Show("Member Removed.");
                RefreshMembersGrid();
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}