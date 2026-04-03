using MidDb_2025CS231.DL;
using System;
using System.Data;
using System.Windows.Forms;

namespace MidDb_2025CS231.UI
{
    public partial class AssignAdvisor : Form
    {
        AssignAdvisorDL advLogic = new AssignAdvisorDL();
        ProjectDL projectLogic = new ProjectDL();

        // variables for Upd/Del
        int selectedProjectId = -1;
        int selectedAdvisorId = -1;

        public AssignAdvisor()
        {
            InitializeComponent();
        }

        private void AssignAdvisor_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            RefreshGrid();
        }

        private void LoadComboBoxes()
        {
            // Load Projects for the ComboBox
            Assignadv_CmbProject.DataSource = projectLogic.GetAllProjects();
            Assignadv_CmbProject.DisplayMember = "Title";
            Assignadv_CmbProject.ValueMember = "Id";

            // Load Advisors for the ComboBox
            Assignadv_CmbAdvisor.DataSource = advLogic.GetAdvisors();
            Assignadv_CmbAdvisor.DisplayMember = "Name";
            Assignadv_CmbAdvisor.ValueMember = "Id";

            // Load Roles for the ComboBox
            Assignadv_CmbRole.DataSource = advLogic.GetAdvisorRoles();
            Assignadv_CmbRole.DisplayMember = "Value";
            Assignadv_CmbRole.ValueMember = "Id";
        }

        private void RefreshGrid()
        {
            dgv_AssignAdvisor.DataSource = advLogic.GetAssignments();
            if (dgv_AssignAdvisor.Columns.Contains("ProjectId")) dgv_AssignAdvisor.Columns["ProjectId"].Visible = false;
            if (dgv_AssignAdvisor.Columns.Contains("AdvisorId")) dgv_AssignAdvisor.Columns["AdvisorId"].Visible = false;
        }

        // Assign Adv btn
        private void btn_Assignadv_Click(object sender, EventArgs e)
        {

            int pId = Convert.ToInt32(Assignadv_CmbProject.SelectedValue);
            int aId = Convert.ToInt32(Assignadv_CmbAdvisor.SelectedValue);
            int rId = Convert.ToInt32(Assignadv_CmbRole.SelectedValue);

            if (advLogic.AssignAdvisor(aId, pId, rId, Assignment_DTP.Value))
            {
                MessageBox.Show("Advisor assigned successfully!");
                RefreshGrid();
            }
        }

        // Upd btn for Role Upd only
        private void btn_UpdateRole_Click(object sender, EventArgs e)
        {
            if (selectedProjectId == -1 || selectedAdvisorId == -1)
            {
                MessageBox.Show("Please select an assignment from the table below to update.");
                return;
            }
          
            int newRoleId = Convert.ToInt32(Assignadv_CmbRole.SelectedValue);
            DateTime updateDate = Assignment_DTP.Value;

            if (advLogic.UpdateAdvisorRole(selectedAdvisorId, selectedProjectId, newRoleId))
            {
                MessageBox.Show("Advisor role updated successfully!");
                RefreshGrid();
               
                selectedProjectId = -1;
                selectedAdvisorId = -1;
            }
        }

        //Del Advisor
        private void btn_Deleteadv_Click(object sender, EventArgs e)
        {
            if (selectedProjectId == -1 || selectedAdvisorId == -1)
            {
                MessageBox.Show("Select an assignment to remove.");
                return;
            }

            if (advLogic.DeleteAdvisor(selectedAdvisorId, selectedProjectId))
            {
                MessageBox.Show("Advisor removed.");
                RefreshGrid();
                selectedProjectId = -1; 
            }
        }

        private void dgv_AssignAdvisor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_AssignAdvisor.Rows[e.RowIndex];
                selectedProjectId = Convert.ToInt32(row.Cells["ProjectId"].Value);
                selectedAdvisorId = Convert.ToInt32(row.Cells["AdvisorId"].Value);

                Assignadv_CmbProject.SelectedValue = selectedProjectId;
                Assignadv_CmbAdvisor.SelectedValue = selectedAdvisorId;
                Assignadv_CmbRole.Text = row.Cells["Role"].Value.ToString();
                Assignment_DTP.Value = Convert.ToDateTime(row.Cells["AssignmentDate"].Value);
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}