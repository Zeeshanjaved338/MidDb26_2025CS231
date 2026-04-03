using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using MidDb26_2025CS231.Database_Layer;

namespace MidDb_2025CS231.Reports
{
    public partial class Report_2Form : Form
    {
        public Report_2Form()
        {
            InitializeComponent();
        }

        private void Report_2Form_Load(object sender, EventArgs e)
        {
            // Optional: Ensure the second RDLC is assigned
            // this.reportViewer1.LocalReport.ReportPath = "Report2.rdlc";
            this.reportViewer1.RefreshReport();
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            LoadReportData();
        }

        private void LoadReportData()
        {
            try
            {
                string query = "SELECT * FROM `REPORT_2` ";
                DataTable dt = helper.Instance.ExecuteDataTable(query);

                if (dt != null && dt.Rows.Count > 0)
                {
                    reportViewer1.LocalReport.DataSources.Clear();
                    ReportDataSource rds = new ReportDataSource("DataSet2", dt);

                    reportViewer1.LocalReport.DataSources.Add(rds);
                    reportViewer1.RefreshReport();
                }
                else
                {
                    MessageBox.Show("No data found for Report 2.", "Empty Result");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Execution Error");
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}