namespace MidDb_2025CS231.UI
{
    partial class AssignProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignProject));
            this.pnl_AssignProjects = new System.Windows.Forms.Panel();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.Assignment_DTP = new System.Windows.Forms.DateTimePicker();
            this.APrj_CmbProject = new System.Windows.Forms.ComboBox();
            this.lbl_SelectPrj = new System.Windows.Forms.Label();
            this.APrj_CmbGroup = new System.Windows.Forms.ComboBox();
            this.lbl_SelectGrp = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.piclogo_APrj = new System.Windows.Forms.PictureBox();
            this.pnl_APrjbtn = new System.Windows.Forms.Panel();
            this.btn_AssignProject = new System.Windows.Forms.Button();
            this.btn_UpdateAssignment = new System.Windows.Forms.Button();
            this.pnl_heading = new System.Windows.Forms.Panel();
            this.lbl_heading = new System.Windows.Forms.Label();
            this.dgv_AssignProject = new System.Windows.Forms.DataGridView();
            this.pnl_AssignProjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo_APrj)).BeginInit();
            this.pnl_APrjbtn.SuspendLayout();
            this.pnl_heading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AssignProject)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_AssignProjects
            // 
            this.pnl_AssignProjects.Controls.Add(this.lbl_Date);
            this.pnl_AssignProjects.Controls.Add(this.Assignment_DTP);
            this.pnl_AssignProjects.Controls.Add(this.APrj_CmbProject);
            this.pnl_AssignProjects.Controls.Add(this.lbl_SelectPrj);
            this.pnl_AssignProjects.Controls.Add(this.APrj_CmbGroup);
            this.pnl_AssignProjects.Controls.Add(this.lbl_SelectGrp);
            this.pnl_AssignProjects.Location = new System.Drawing.Point(186, 165);
            this.pnl_AssignProjects.Name = "pnl_AssignProjects";
            this.pnl_AssignProjects.Size = new System.Drawing.Size(450, 174);
            this.pnl_AssignProjects.TabIndex = 15;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(57, 137);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(112, 17);
            this.lbl_Date.TabIndex = 18;
            this.lbl_Date.Text = "Assignment Date";
            // 
            // Assignment_DTP
            // 
            this.Assignment_DTP.Location = new System.Drawing.Point(201, 137);
            this.Assignment_DTP.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.Assignment_DTP.MinDate = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            this.Assignment_DTP.Name = "Assignment_DTP";
            this.Assignment_DTP.Size = new System.Drawing.Size(200, 20);
            this.Assignment_DTP.TabIndex = 17;
            // 
            // APrj_CmbProject
            // 
            this.APrj_CmbProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.APrj_CmbProject.FormattingEnabled = true;
            this.APrj_CmbProject.Location = new System.Drawing.Point(202, 84);
            this.APrj_CmbProject.Name = "APrj_CmbProject";
            this.APrj_CmbProject.Size = new System.Drawing.Size(142, 21);
            this.APrj_CmbProject.TabIndex = 16;
            // 
            // lbl_SelectPrj
            // 
            this.lbl_SelectPrj.AutoSize = true;
            this.lbl_SelectPrj.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SelectPrj.Location = new System.Drawing.Point(57, 87);
            this.lbl_SelectPrj.Name = "lbl_SelectPrj";
            this.lbl_SelectPrj.Size = new System.Drawing.Size(89, 17);
            this.lbl_SelectPrj.TabIndex = 15;
            this.lbl_SelectPrj.Text = "Select Project";
            // 
            // APrj_CmbGroup
            // 
            this.APrj_CmbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.APrj_CmbGroup.FormattingEnabled = true;
            this.APrj_CmbGroup.Location = new System.Drawing.Point(201, 22);
            this.APrj_CmbGroup.Name = "APrj_CmbGroup";
            this.APrj_CmbGroup.Size = new System.Drawing.Size(142, 21);
            this.APrj_CmbGroup.TabIndex = 14;
            // 
            // lbl_SelectGrp
            // 
            this.lbl_SelectGrp.AutoSize = true;
            this.lbl_SelectGrp.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SelectGrp.Location = new System.Drawing.Point(54, 26);
            this.lbl_SelectGrp.Name = "lbl_SelectGrp";
            this.lbl_SelectGrp.Size = new System.Drawing.Size(85, 17);
            this.lbl_SelectGrp.TabIndex = 2;
            this.lbl_SelectGrp.Text = "Select Group";
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_Back.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(66, 22);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(109, 34);
            this.btn_Back.TabIndex = 16;
            this.btn_Back.Text = " <---  Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // piclogo_APrj
            // 
            this.piclogo_APrj.BackColor = System.Drawing.Color.White;
            this.piclogo_APrj.Image = ((System.Drawing.Image)(resources.GetObject("piclogo_APrj.Image")));
            this.piclogo_APrj.Location = new System.Drawing.Point(801, 22);
            this.piclogo_APrj.Name = "piclogo_APrj";
            this.piclogo_APrj.Size = new System.Drawing.Size(116, 107);
            this.piclogo_APrj.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.piclogo_APrj.TabIndex = 19;
            this.piclogo_APrj.TabStop = false;
            // 
            // pnl_APrjbtn
            // 
            this.pnl_APrjbtn.Controls.Add(this.btn_AssignProject);
            this.pnl_APrjbtn.Controls.Add(this.btn_UpdateAssignment);
            this.pnl_APrjbtn.Location = new System.Drawing.Point(728, 202);
            this.pnl_APrjbtn.Name = "pnl_APrjbtn";
            this.pnl_APrjbtn.Size = new System.Drawing.Size(148, 158);
            this.pnl_APrjbtn.TabIndex = 20;
            // 
            // btn_AssignProject
            // 
            this.btn_AssignProject.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_AssignProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AssignProject.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AssignProject.Location = new System.Drawing.Point(2, 20);
            this.btn_AssignProject.Name = "btn_AssignProject";
            this.btn_AssignProject.Size = new System.Drawing.Size(144, 44);
            this.btn_AssignProject.TabIndex = 15;
            this.btn_AssignProject.Text = "Assign Project";
            this.btn_AssignProject.UseVisualStyleBackColor = false;
            this.btn_AssignProject.Click += new System.EventHandler(this.btn_AssignProject_Click);
            // 
            // btn_UpdateAssignment
            // 
            this.btn_UpdateAssignment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_UpdateAssignment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UpdateAssignment.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UpdateAssignment.Location = new System.Drawing.Point(2, 93);
            this.btn_UpdateAssignment.Name = "btn_UpdateAssignment";
            this.btn_UpdateAssignment.Size = new System.Drawing.Size(144, 44);
            this.btn_UpdateAssignment.TabIndex = 2;
            this.btn_UpdateAssignment.Text = "Update Assignment";
            this.btn_UpdateAssignment.UseVisualStyleBackColor = false;
            this.btn_UpdateAssignment.Click += new System.EventHandler(this.btn_UpdateAssignment_Click);
            // 
            // pnl_heading
            // 
            this.pnl_heading.BackColor = System.Drawing.Color.SteelBlue;
            this.pnl_heading.Controls.Add(this.lbl_heading);
            this.pnl_heading.Location = new System.Drawing.Point(368, 40);
            this.pnl_heading.Name = "pnl_heading";
            this.pnl_heading.Size = new System.Drawing.Size(147, 35);
            this.pnl_heading.TabIndex = 16;
            // 
            // lbl_heading
            // 
            this.lbl_heading.AutoSize = true;
            this.lbl_heading.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_heading.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_heading.Location = new System.Drawing.Point(0, 0);
            this.lbl_heading.Name = "lbl_heading";
            this.lbl_heading.Size = new System.Drawing.Size(144, 25);
            this.lbl_heading.TabIndex = 0;
            this.lbl_heading.Text = "Assign Projects";
            this.lbl_heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_AssignProject
            // 
            this.dgv_AssignProject.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_AssignProject.BackgroundColor = System.Drawing.Color.White;
            this.dgv_AssignProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AssignProject.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_AssignProject.Location = new System.Drawing.Point(0, 418);
            this.dgv_AssignProject.Name = "dgv_AssignProject";
            this.dgv_AssignProject.ReadOnly = true;
            this.dgv_AssignProject.RowHeadersVisible = false;
            this.dgv_AssignProject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_AssignProject.Size = new System.Drawing.Size(984, 193);
            this.dgv_AssignProject.TabIndex = 19;
            this.dgv_AssignProject.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_AssignProject_CellClick);
            // 
            // AssignProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.dgv_AssignProject);
            this.Controls.Add(this.pnl_heading);
            this.Controls.Add(this.pnl_APrjbtn);
            this.Controls.Add(this.piclogo_APrj);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.pnl_AssignProjects);
            this.Name = "AssignProject";
            this.Text = "AssignProject";
            this.Load += new System.EventHandler(this.AssignProject_Load);
            this.pnl_AssignProjects.ResumeLayout(false);
            this.pnl_AssignProjects.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo_APrj)).EndInit();
            this.pnl_APrjbtn.ResumeLayout(false);
            this.pnl_heading.ResumeLayout(false);
            this.pnl_heading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AssignProject)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_AssignProjects;
        private System.Windows.Forms.ComboBox APrj_CmbProject;
        private System.Windows.Forms.Label lbl_SelectPrj;
        private System.Windows.Forms.ComboBox APrj_CmbGroup;
        private System.Windows.Forms.Label lbl_SelectGrp;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.DateTimePicker Assignment_DTP;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.PictureBox piclogo_APrj;
        private System.Windows.Forms.Panel pnl_APrjbtn;
        private System.Windows.Forms.Button btn_AssignProject;
        private System.Windows.Forms.Button btn_UpdateAssignment;
        private System.Windows.Forms.Panel pnl_heading;
        private System.Windows.Forms.Label lbl_heading;
        private System.Windows.Forms.DataGridView dgv_AssignProject;
    }
}