using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidDb_2025CS231.UI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            // Simple check for now (you can connect this to your DB later)
            if (txtUsername_login.Text == "admin" && txtPassword_login.Text == "1234")
            {
                this.Hide(); // Hide the Login Page
                MainDahboard dash = new MainDahboard();
                dash.Show(); // Open the Dashboard
            }
            else
            {
                // Show that red error message you have in your picture
                lblerror_login.Visible = true;
                txtPassword_login.Clear();
            }
        }
    }
}
