namespace MidDb_2025CS231.UI
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.piclogo_login = new System.Windows.Forms.PictureBox();
            this.lbl_heading = new System.Windows.Forms.Label();
            this.pnl_login = new System.Windows.Forms.Panel();
            this.btn_login = new System.Windows.Forms.Button();
            this.txtPassword_login = new System.Windows.Forms.TextBox();
            this.txtUsername_login = new System.Windows.Forms.TextBox();
            this.lblPassword_login = new System.Windows.Forms.Label();
            this.lblUsername_login = new System.Windows.Forms.Label();
            this.lblerror_login = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo_login)).BeginInit();
            this.pnl_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // piclogo_login
            // 
            this.piclogo_login.Image = ((System.Drawing.Image)(resources.GetObject("piclogo_login.Image")));
            this.piclogo_login.Location = new System.Drawing.Point(279, 22);
            this.piclogo_login.Name = "piclogo_login";
            this.piclogo_login.Size = new System.Drawing.Size(203, 159);
            this.piclogo_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.piclogo_login.TabIndex = 0;
            this.piclogo_login.TabStop = false;
            // 
            // lbl_heading
            // 
            this.lbl_heading.AutoSize = true;
            this.lbl_heading.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_heading.Location = new System.Drawing.Point(305, 197);
            this.lbl_heading.Name = "lbl_heading";
            this.lbl_heading.Size = new System.Drawing.Size(156, 22);
            this.lbl_heading.TabIndex = 1;
            this.lbl_heading.Text = "Department Login";
            // 
            // pnl_login
            // 
            this.pnl_login.Controls.Add(this.btn_login);
            this.pnl_login.Controls.Add(this.txtPassword_login);
            this.pnl_login.Controls.Add(this.txtUsername_login);
            this.pnl_login.Controls.Add(this.lblPassword_login);
            this.pnl_login.Controls.Add(this.lblUsername_login);
            this.pnl_login.Location = new System.Drawing.Point(251, 241);
            this.pnl_login.Name = "pnl_login";
            this.pnl_login.Size = new System.Drawing.Size(280, 153);
            this.pnl_login.TabIndex = 2;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_login.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_login.Location = new System.Drawing.Point(89, 109);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(98, 33);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txtPassword_login
            // 
            this.txtPassword_login.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword_login.Location = new System.Drawing.Point(106, 68);
            this.txtPassword_login.Name = "txtPassword_login";
            this.txtPassword_login.Size = new System.Drawing.Size(156, 25);
            this.txtPassword_login.TabIndex = 3;
            this.txtPassword_login.UseSystemPasswordChar = true;
            // 
            // txtUsername_login
            // 
            this.txtUsername_login.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername_login.Location = new System.Drawing.Point(106, 24);
            this.txtUsername_login.Name = "txtUsername_login";
            this.txtUsername_login.Size = new System.Drawing.Size(156, 25);
            this.txtUsername_login.TabIndex = 2;
            // 
            // lblPassword_login
            // 
            this.lblPassword_login.AutoSize = true;
            this.lblPassword_login.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword_login.Location = new System.Drawing.Point(18, 71);
            this.lblPassword_login.Name = "lblPassword_login";
            this.lblPassword_login.Size = new System.Drawing.Size(66, 17);
            this.lblPassword_login.TabIndex = 1;
            this.lblPassword_login.Text = "Password";
            this.lblPassword_login.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUsername_login
            // 
            this.lblUsername_login.AutoSize = true;
            this.lblUsername_login.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername_login.Location = new System.Drawing.Point(18, 27);
            this.lblUsername_login.Name = "lblUsername_login";
            this.lblUsername_login.Size = new System.Drawing.Size(71, 17);
            this.lblUsername_login.TabIndex = 0;
            this.lblUsername_login.Text = "UserName";
            // 
            // lblerror_login
            // 
            this.lblerror_login.AutoSize = true;
            this.lblerror_login.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerror_login.ForeColor = System.Drawing.Color.Red;
            this.lblerror_login.Location = new System.Drawing.Point(278, 407);
            this.lblerror_login.Name = "lblerror_login";
            this.lblerror_login.Size = new System.Drawing.Size(204, 17);
            this.lblerror_login.TabIndex = 3;
            this.lblerror_login.Text = "Invalid Username and Password";
            this.lblerror_login.Visible = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblerror_login);
            this.Controls.Add(this.pnl_login);
            this.Controls.Add(this.lbl_heading);
            this.Controls.Add(this.piclogo_login);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.piclogo_login)).EndInit();
            this.pnl_login.ResumeLayout(false);
            this.pnl_login.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox piclogo_login;
        private System.Windows.Forms.Label lbl_heading;
        private System.Windows.Forms.Panel pnl_login;
        private System.Windows.Forms.Label lblPassword_login;
        private System.Windows.Forms.Label lblUsername_login;
        private System.Windows.Forms.TextBox txtPassword_login;
        private System.Windows.Forms.TextBox txtUsername_login;
        private System.Windows.Forms.Label lblerror_login;
        private System.Windows.Forms.Button btn_login;
    }
}