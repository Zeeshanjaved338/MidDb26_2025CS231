using MidDb_2025CS231.DL;
using System;
using System.Data;
using System.Windows.Forms;

namespace MidDb_2025CS231.UI
{
    public partial class MarkEvaluation : Form
    {
        EvaluationDL evaluationService = new EvaluationDL();

       
        int selectedEvaluationId = -1;

        public MarkEvaluation()
        {
            InitializeComponent();
        }

        private void MarkEvaluation_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            RefreshGrids();
        }

        private void LoadComboBoxes()
        {
            try
            {
                //Fill Evaluation Types
                DataTable evaluationTable = evaluationService.GetAllEvaluations();
                if (evaluationTable != null && evaluationTable.Rows.Count > 0)
                {
                    Eva_CmbSelectEvaluation.DataSource = evaluationTable;
                    Eva_CmbSelectEvaluation.DisplayMember = "Name";
                    Eva_CmbSelectEvaluation.ValueMember = "Id";
                }

                //Fill Group IDs
                DataTable groupTable = evaluationService.GetAllGroupIds();
                if (groupTable != null && groupTable.Rows.Count > 0)
                {
                    Eva_CmbMarkGroup.DataSource = groupTable;
                    Eva_CmbMarkGroup.DisplayMember = "Id";
                    Eva_CmbMarkGroup.ValueMember = "Id";
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("ComboBox Error: " + exception.Message);
            }
        }

        private void RefreshGrids()
        {
            DataTable resultsTable = evaluationService.GetGroupResults();
            if (resultsTable != null)
            {
                dgv_ManageEvaluations.DataSource = resultsTable;
                dgv_ManageEvaluations.AutoGenerateColumns = true;
                dgv_ManageEvaluations.Refresh();
            }
        }

        //MANAGE EVALUATION TYPES 

        private void btn_AddEval_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_EvaluationType.Text))
            {
                MessageBox.Show("Please enter an Evaluation Name (e.g., Quiz 1) before adding.",
                                "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_EvaluationType.Focus();
                return;
            }

            if (num_TotalMarks.Value <= 0 || num_Weightage.Value <= 0)
            {
                MessageBox.Show("Total Marks and Weightage must be greater than 0.",
                                "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (evaluationService.AddEvaluation(
                    txt_EvaluationType.Text,
                    (int)num_TotalMarks.Value,
                    (int)num_Weightage.Value))
            {
                MessageBox.Show("Evaluation Type Created Successfully!");
                ClearInputs();
                LoadComboBoxes();
                RefreshGrids();
            }
        }

        private void btn_UpdateEval_Click(object sender, EventArgs e)
        {
            if (selectedEvaluationId != -1)
            {
                if (evaluationService.UpdateEvaluation(
                        selectedEvaluationId,
                        txt_EvaluationType.Text,
                        (int)num_TotalMarks.Value,
                        (int)num_Weightage.Value))
                {
                    MessageBox.Show("Evaluation Updated Successfully!");
                    LoadComboBoxes();
                    RefreshGrids();
                    ClearInputs();
                }
            }
            else
            {
                MessageBox.Show("Please select an Evaluation from the table to update.");
            }
        }

        private void btn_DeleteEval_Click(object sender, EventArgs e)
        {
            if (selectedEvaluationId == -1)
            {
                MessageBox.Show("Please click a row in the grid first to select an evaluation.");
                return;
            }

            var confirmation = MessageBox.Show(
                "Delete this Evaluation Type? This will fail if groups are already graded.",
                "Confirm", MessageBoxButtons.YesNo);

            if (confirmation == DialogResult.Yes)
            {
                if (evaluationService.DeleteEvaluation(selectedEvaluationId))
                {
                    MessageBox.Show("Deleted Successfully!");
                    selectedEvaluationId = -1;
                    txt_EvaluationType.Clear();
                    LoadComboBoxes();
                    RefreshGrids();
                }
            }
        }

        //MARKING GROUPS 

        private void btn_AssignMarks_Click(object sender, EventArgs e)
        {
            if (Eva_CmbMarkGroup.SelectedValue != null && Eva_CmbMarkGroup.SelectedValue != null)
            {
                int groupId = Convert.ToInt32(Eva_CmbMarkGroup.SelectedValue);
                int evaluationId = Convert.ToInt32(Eva_CmbSelectEvaluation.SelectedValue);

                int obtainedMarks = (int)num_OMarks.Value;

                if (evaluationService.MarkGroup(groupId, evaluationId, obtainedMarks, Evaluation_DTP.Value))
                {
                    MessageBox.Show("Group " + groupId + " Graded Successfully!");
                    RefreshGrids();
                }
            }
        }

        private void btn_DeleteMark_Click(object sender, EventArgs e)
        {
            if (dgv_ManageEvaluations.SelectedRows.Count == 0 && dgv_ManageEvaluations.CurrentRow == null)
            {
                MessageBox.Show("Please select a specific row in the grid to delete those marks.");
                return;
            }

            DataGridViewRow selectedRow = dgv_ManageEvaluations.CurrentRow;

            int groupId = Convert.ToInt32(selectedRow.Cells["GroupId"].Value);
            int evaluationId = Convert.ToInt32(selectedRow.Cells["EvalId"].Value);

            var confirmation = MessageBox.Show(
                $"Are you sure you want to delete the marks for Group {groupId}?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmation == DialogResult.Yes)
            {
                if (evaluationService.DeleteGroupMark(groupId, evaluationId))
                {
                    MessageBox.Show("Marks deleted successfully.");
                    RefreshGrids();
                }
            }
        }

        // --- GRID INTERACTION ---

        private void dgv_ManageEvaluations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgv_ManageEvaluations.Rows[e.RowIndex];

                selectedEvaluationId = Convert.ToInt32(selectedRow.Cells["EvalId"].Value);

                txt_EvaluationType.Text = selectedRow.Cells["Evaluation"].Value.ToString();
                num_TotalMarks.Value = Convert.ToDecimal(selectedRow.Cells["TotalMarks"].Value);

                Eva_CmbMarkGroup.Text = selectedRow.Cells["GroupId"].Value.ToString();
                Eva_CmbSelectEvaluation.Text = selectedRow.Cells["Evaluation"].Value.ToString();
            }
        }

        private void ClearInputs()
        {
            txt_EvaluationType.Clear();
            num_TotalMarks.Value = 0;
            num_Weightage.Value = 0;
            selectedEvaluationId = -1;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}