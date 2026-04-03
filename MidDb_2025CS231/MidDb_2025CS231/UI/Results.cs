using System;
using System.Data;
using System.Windows.Forms;
using MidDb_2025CS231.DL;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System.IO;

namespace MidDb_2025CS231.UI
{
    public partial class ResultForm : Form
    {
        
        private EvaluationDL evaluationDataLogic = new EvaluationDL();

        public ResultForm()
        {
            InitializeComponent();
            SetupUI();
        }

        private void SetupUI()
        {
            
            dgv_Results.ReadOnly = true;
            dgv_GroupResults.ReadOnly = true;

            dgv_Results.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Results.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_GroupResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable overallResultsTable = evaluationDataLogic.GetOverallResults();

                dgv_Results.DataSource = overallResultsTable;

                
                Res_CmbGroupID.DataSource = overallResultsTable;
                Res_CmbGroupID.DisplayMember = "GroupId";
                Res_CmbGroupID.ValueMember = "GroupId";
                Res_CmbGroupID.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Initialization Error: " + ex.Message);
            }
        }

        private void dgv_Results_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                
                int selectedGroupId =
                    Convert.ToInt32(dgv_Results.Rows[e.RowIndex].Cells["GroupId"].Value);

                Res_CmbGroupID.Text = selectedGroupId.ToString();

                dgv_GroupResults.DataSource =
                    evaluationDataLogic.GetSpecificGroupDetails(selectedGroupId);
            }
        }

        // Export Group Details to CSV
        private void btn_ExportExcel_Click(object sender, EventArgs e)
        {
            if (dgv_GroupResults.Rows.Count > 0)
            {
                using (SaveFileDialog saveDialog = new SaveFileDialog()
                {
                    Filter = "CSV|*.csv",
                    FileName = "Report.csv"
                })
                {
                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (System.IO.StreamWriter writer =
                            new System.IO.StreamWriter(saveDialog.FileName))
                        {
                            
                            writer.WriteLine("Evaluation,Obtained,Total,Weightage");

                            foreach (DataGridViewRow gridRow in dgv_GroupResults.Rows)
                            {
                                if (!gridRow.IsNewRow)
                                {
                                    writer.WriteLine(
                                        $"{gridRow.Cells[0].Value}," +
                                        $"{gridRow.Cells[1].Value}," +
                                        $"{gridRow.Cells[2].Value}," +
                                        $"{gridRow.Cells[3].Value}");
                                }
                            }
                        }

                        MessageBox.Show("Exported to CSV successfully!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Select a group in the grid first to export its data.");
            }
        }

        private void dgv_GroupResults_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // No action required (read-only report)
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}