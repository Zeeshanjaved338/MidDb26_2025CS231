namespace MidDb_2025CS231.UI
{
    partial class AssignAdvisor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignAdvisor));
            this.btn_Back = new System.Windows.Forms.Button();
            this.pnl_heading = new System.Windows.Forms.Panel();
            this.lbl_heading = new System.Windows.Forms.Label();
            this.pnl_AssignProjects = new System.Windows.Forms.Panel();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.Assignment_DTP = new System.Windows.Forms.DateTimePicker();
            this.Assignadv_CmbAdvisor = new System.Windows.Forms.ComboBox();
            this.lbl_SelectAdvisor = new System.Windows.Forms.Label();
            this.Assignadv_CmbProject = new System.Windows.Forms.ComboBox();
            this.lbl_SelectProject = new System.Windows.Forms.Label();
            this.pnl_AssignProject = new System.Windows.Forms.Panel();
            this.btn_Assignadv = new System.Windows.Forms.Button();
            this.btn_UpdateRole = new System.Windows.Forms.Button();
            this.piclogo_Assignadv = new System.Windows.Forms.PictureBox();
            this.dgv_AssignAdvisor = new System.Windows.Forms.DataGridView();
            this.lbl_Role = new System.Windows.Forms.Label();
            this.Assignadv_CmbRole = new System.Windows.Forms.ComboBox();
            this.btn_Deleteadv = new System.Windows.Forms.Button();
            this.pnl_heading.SuspendLayout();
            this.pnl_AssignProjects.SuspendLayout();
            this.pnl_AssignProject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo_Assignadv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AssignAdvisor)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_Back.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(48, 28);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(109, 34);
            this.btn_Back.TabIndex = 17;
            this.btn_Back.Text = " <---  Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // pnl_heading
            // 
            this.pnl_heading.BackColor = System.Drawing.Color.SteelBlue;
            this.pnl_heading.Controls.Add(this.lbl_heading);
            this.pnl_heading.Location = new System.Drawing.Point(389, 37);
            this.pnl_heading.Name = "pnl_heading";
            this.pnl_heading.Size = new System.Drawing.Size(147, 35);
            this.pnl_heading.TabIndex = 18;
            // 
            // lbl_heading
            // 
            this.lbl_heading.AutoSize = true;
            this.lbl_heading.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_heading.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_heading.Location = new System.Drawing.Point(0, 0);
            this.lbl_heading.Name = "lbl_heading";
            this.lbl_heading.Size = new System.Drawing.Size(149, 25);
            this.lbl_heading.TabIndex = 0;
            this.lbl_heading.Text = "Assign Advisors";
            this.lbl_heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_AssignProjects
            // 
            this.pnl_AssignProjects.Controls.Add(this.Assignadv_CmbRole);
            this.pnl_AssignProjects.Controls.Add(this.lbl_Role);
            this.pnl_AssignProjects.Controls.Add(this.lbl_Date);
            this.pnl_AssignProjects.Controls.Add(this.Assignment_DTP);
            this.pnl_AssignProjects.Controls.Add(this.Assignadv_CmbAdvisor);
            this.pnl_AssignProjects.Controls.Add(this.lbl_SelectAdvisor);
            this.pnl_AssignProjects.Controls.Add(this.Assignadv_CmbProject);
            this.pnl_AssignProjects.Controls.Add(this.lbl_SelectProject);
            this.pnl_AssignProjects.Location = new System.Drawing.Point(217, 134);
            this.pnl_AssignProjects.Name = "pnl_AssignProjects";
            this.pnl_AssignProjects.Size = new System.Drawing.Size(450, 242);
            this.pnl_AssignProjects.TabIndex = 19;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(54, 192);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(112, 17);
            this.lbl_Date.TabIndex = 18;
            this.lbl_Date.Text = "Assignment Date";
            // 
            // Assignment_DTP
            // 
            this.Assignment_DTP.Location = new System.Drawing.Point(201, 190);
            this.Assignment_DTP.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.Assignment_DTP.MinDate = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            this.Assignment_DTP.Name = "Assignment_DTP";
            this.Assignment_DTP.Size = new System.Drawing.Size(200, 20);
            this.Assignment_DTP.TabIndex = 17;
            // 
            // Assignadv_CmbAdvisor
            // 
            this.Assignadv_CmbAdvisor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Assignadv_CmbAdvisor.FormattingEnabled = true;
            this.Assignadv_CmbAdvisor.Location = new System.Drawing.Point(202, 84);
            this.Assignadv_CmbAdvisor.Name = "Assignadv_CmbAdvisor";
            this.Assignadv_CmbAdvisor.Size = new System.Drawing.Size(142, 21);
            this.Assignadv_CmbAdvisor.TabIndex = 16;
            // 
            // lbl_SelectAdvisor
            // 
            this.lbl_SelectAdvisor.AutoSize = true;
            this.lbl_SelectAdvisor.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SelectAdvisor.Location = new System.Drawing.Point(55, 87);
            this.lbl_SelectAdvisor.Name = "lbl_SelectAdvisor";
            this.lbl_SelectAdvisor.Size = new System.Drawing.Size(93, 17);
            this.lbl_SelectAdvisor.TabIndex = 15;
            this.lbl_SelectAdvisor.Text = "Select Advisor";
            // 
            // Assignadv_CmbProject
            // 
            this.Assignadv_CmbProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Assignadv_CmbProject.FormattingEnabled = true;
            this.Assignadv_CmbProject.Location = new System.Drawing.Point(201, 22);
            this.Assignadv_CmbProject.Name = "Assignadv_CmbProject";
            this.Assignadv_CmbProject.Size = new System.Drawing.Size(142, 21);
            this.Assignadv_CmbProject.TabIndex = 14;
            // 
            // lbl_SelectProject
            // 
            this.lbl_SelectProject.AutoSize = true;
            this.lbl_SelectProject.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SelectProject.Location = new System.Drawing.Point(54, 26);
            this.lbl_SelectProject.Name = "lbl_SelectProject";
            this.lbl_SelectProject.Size = new System.Drawing.Size(89, 17);
            this.lbl_SelectProject.TabIndex = 2;
            this.lbl_SelectProject.Text = "Select Project";
            // 
            // pnl_AssignProject
            // 
            this.pnl_AssignProject.Controls.Add(this.btn_Deleteadv);
            this.pnl_AssignProject.Controls.Add(this.btn_Assignadv);
            this.pnl_AssignProject.Controls.Add(this.btn_UpdateRole);
            this.pnl_AssignProject.Location = new System.Drawing.Point(748, 201);
            this.pnl_AssignProject.Name = "pnl_AssignProject";
            this.pnl_AssignProject.Size = new System.Drawing.Size(148, 202);
            this.pnl_AssignProject.TabIndex = 21;
            // 
            // btn_Assignadv
            // 
            this.btn_Assignadv.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Assignadv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Assignadv.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Assignadv.Location = new System.Drawing.Point(2, 14);
            this.btn_Assignadv.Name = "btn_Assignadv";
            this.btn_Assignadv.Size = new System.Drawing.Size(144, 44);
            this.btn_Assignadv.TabIndex = 15;
            this.btn_Assignadv.Text = "Assign Advisor";
            this.btn_Assignadv.UseVisualStyleBackColor = false;
            this.btn_Assignadv.Click += new System.EventHandler(this.btn_Assignadv_Click);
            // 
            // btn_UpdateRole
            // 
            this.btn_UpdateRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_UpdateRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UpdateRole.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UpdateRole.Location = new System.Drawing.Point(2, 75);
            this.btn_UpdateRole.Name = "btn_UpdateRole";
            this.btn_UpdateRole.Size = new System.Drawing.Size(144, 44);
            this.btn_UpdateRole.TabIndex = 2;
            this.btn_UpdateRole.Text = "Update Role";
            this.btn_UpdateRole.UseVisualStyleBackColor = false;
            this.btn_UpdateRole.Click += new System.EventHandler(this.btn_UpdateRole_Click);
            // 
            // piclogo_Assignadv
            // 
            this.piclogo_Assignadv.BackColor = System.Drawing.Color.White;
            this.piclogo_Assignadv.Image = ((System.Drawing.Image)(resources.GetObject("piclogo_Assignadv.Image")));
            this.piclogo_Assignadv.Location = new System.Drawing.Point(804, 28);
            this.piclogo_Assignadv.Name = "piclogo_Assignadv";
            this.piclogo_Assignadv.Size = new System.Drawing.Size(116, 107);
            this.piclogo_Assignadv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.piclogo_Assignadv.TabIndex = 20;
            this.piclogo_Assignadv.TabStop = false;
            // 
            // dgv_AssignAdvisor
            // 
            this.dgv_AssignAdvisor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_AssignAdvisor.BackgroundColor = System.Drawing.Color.White;
            this.dgv_AssignAdvisor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AssignAdvisor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_AssignAdvisor.Location = new System.Drawing.Point(0, 418);
            this.dgv_AssignAdvisor.Name = "dgv_AssignAdvisor";
            this.dgv_AssignAdvisor.ReadOnly = true;
            this.dgv_AssignAdvisor.RowHeadersVisible = false;
            this.dgv_AssignAdvisor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_AssignAdvisor.Size = new System.Drawing.Size(984, 193);
            this.dgv_AssignAdvisor.TabIndex = 22;
            this.dgv_AssignAdvisor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_AssignAdvisor_CellClick);
            // 
            // lbl_Role
            // 
            this.lbl_Role.AutoSize = true;
            this.lbl_Role.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Role.Location = new System.Drawing.Point(55, 143);
            this.lbl_Role.Name = "lbl_Role";
            this.lbl_Role.Size = new System.Drawing.Size(84, 17);
            this.lbl_Role.TabIndex = 19;
            this.lbl_Role.Text = "Advisor Role";
            // 
            // Assignadv_CmbRole
            // 
            this.Assignadv_CmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Assignadv_CmbRole.FormattingEnabled = true;
            this.Assignadv_CmbRole.Location = new System.Drawing.Point(202, 139);
            this.Assignadv_CmbRole.Name = "Assignadv_CmbRole";
            this.Assignadv_CmbRole.Size = new System.Drawing.Size(142, 21);
            this.Assignadv_CmbRole.TabIndex = 20;
            // 
            // btn_Deleteadv
            // 
            this.btn_Deleteadv.BackColor = System.Drawing.Color.Red;
            this.btn_Deleteadv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Deleteadv.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Deleteadv.Location = new System.Drawing.Point(2, 142);
            this.btn_Deleteadv.Name = "btn_Deleteadv";
            this.btn_Deleteadv.Size = new System.Drawing.Size(144, 44);
            this.btn_Deleteadv.TabIndex = 16;
            this.btn_Deleteadv.Text = "Delete Advisor";
            this.btn_Deleteadv.UseVisualStyleBackColor = false;
            this.btn_Deleteadv.Click += new System.EventHandler(this.btn_Deleteadv_Click);
            // 
            // AssignAdvisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.dgv_AssignAdvisor);
            this.Controls.Add(this.piclogo_Assignadv);
            this.Controls.Add(this.pnl_AssignProject);
            this.Controls.Add(this.pnl_AssignProjects);
            this.Controls.Add(this.pnl_heading);
            this.Controls.Add(this.btn_Back);
            this.Name = "AssignAdvisor";
            this.Text = "AssignAdvisor";
            this.Load += new System.EventHandler(this.AssignAdvisor_Load);
            this.pnl_heading.ResumeLayout(false);
            this.pnl_heading.PerformLayout();
            this.pnl_AssignProjects.ResumeLayout(false);
            this.pnl_AssignProjects.PerformLayout();
            this.pnl_AssignProject.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.piclogo_Assignadv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AssignAdvisor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Panel pnl_heading;
        private System.Windows.Forms.Label lbl_heading;
        private System.Windows.Forms.Panel pnl_AssignProjects;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.DateTimePicker Assignment_DTP;
        private System.Windows.Forms.ComboBox Assignadv_CmbAdvisor;
        private System.Windows.Forms.Label lbl_SelectAdvisor;
        private System.Windows.Forms.ComboBox Assignadv_CmbProject;
        private System.Windows.Forms.Label lbl_SelectProject;
        private System.Windows.Forms.Panel pnl_AssignProject;
        private System.Windows.Forms.Button btn_Assignadv;
        private System.Windows.Forms.Button btn_UpdateRole;
        private System.Windows.Forms.PictureBox piclogo_Assignadv;
        private System.Windows.Forms.DataGridView dgv_AssignAdvisor;
        private System.Windows.Forms.ComboBox Assignadv_CmbRole;
        private System.Windows.Forms.Label lbl_Role;
        private System.Windows.Forms.Button btn_Deleteadv;
    }
}