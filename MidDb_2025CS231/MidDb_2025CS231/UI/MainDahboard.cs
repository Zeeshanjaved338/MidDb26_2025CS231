using MidDb_2025CS231.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidDb_2025CS231.UI
{
    public partial class MainDahboard : Form
    {
        public MainDahboard()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm)
        {
            childForm.StartPosition = FormStartPosition.CenterScreen;

            childForm.FormClosed += (s, args) => this.Show();

            this.Hide(); 
            childForm.Show(); 
        }

        private void btnsidebar_ManageStudent_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ManageStudents());
        }

        private void btnsidebar_ManageAdvisors_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ManageAdvisors());
        }

        private void btnsidebar_ManageProjects_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ProjectManagement());
        }

        private void btnsidebar_ManageGroups_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ManageGroups());
        }

        private void btnsidebar_AssignProject_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AssignProject());
        }

        private void btnsidebar_AssignAdvisor_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AssignAdvisor());
        }

        private void btnsidebar_ManageEvaluations_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MarkEvaluation());
        }

        private void btnsidebar_Results_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ResultForm());
        }

        private void btnsidebar_logout_Click(object sender, EventArgs e)
        {
            LoginForm loginWindow = new LoginForm();
            loginWindow.StartPosition = FormStartPosition.CenterScreen;
            loginWindow.Show();
            this.Close();
        }

        private void btnReport1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Report_1Form());
        }

        private void btnReport2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Report_2Form());
        }
    }
}