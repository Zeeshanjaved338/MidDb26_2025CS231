using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using MidDb26_2025CS231.Database_Layer;

namespace MidDb_2025CS231.Reports
{
    public partial class Report_1Form : Form
    {
        public Report_1Form()
        {
            InitializeComponent();
        }

        private void Report_1Form_Load(object sender, EventArgs e)
        {
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
                string query = "SELECT * FROM `REPORT_1`";
                DataTable dt = helper.Instance.ExecuteDataTable(query);

                if (dt != null && dt.Rows.Count > 0)
                {
                    reportViewer1.LocalReport.DataSources.Clear();
                    ReportDataSource rds = new ReportDataSource("DataSet1", dt);

                    reportViewer1.LocalReport.DataSources.Add(rds);
                    reportViewer1.RefreshReport();
                }
                else
                {
                    MessageBox.Show("The query returned no data. Check your REPORT_1 table in the database.", "No Data Found");
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