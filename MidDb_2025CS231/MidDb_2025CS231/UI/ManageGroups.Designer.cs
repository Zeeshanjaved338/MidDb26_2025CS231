namespace MidDb_2025CS231.UI
{
    partial class ManageGroups
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageGroups));
            this.btn_back = new System.Windows.Forms.Button();
            this.pnl_heading = new System.Windows.Forms.Panel();
            this.lbl_heading = new System.Windows.Forms.Label();
            this.piclogo_Group = new System.Windows.Forms.PictureBox();
            this.pnl_Group = new System.Windows.Forms.Panel();
            this.DTP_Group = new System.Windows.Forms.DateTimePicker();
            this.Grp_CreatedOn = new System.Windows.Forms.Label();
            this.pnl_ManageGrpbtn = new System.Windows.Forms.Panel();
            this.btn_AddStudent = new System.Windows.Forms.Button();
            this.btn_RemoveMember = new System.Windows.Forms.Button();
            this.btn_CreateGroup = new System.Windows.Forms.Button();
            this.dgv_Groups = new System.Windows.Forms.DataGridView();
            this.pnl2_Group = new System.Windows.Forms.Panel();
            this.grp_CmbStatus = new System.Windows.Forms.ComboBox();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.grp_CmbStudent = new System.Windows.Forms.ComboBox();
            this.lbl_Student = new System.Windows.Forms.Label();
            this.dgv_GroupMembers = new System.Windows.Forms.DataGridView();
            this.btn_DeleteGroup = new System.Windows.Forms.Button();
            this.pnl_heading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo_Group)).BeginInit();
            this.pnl_Group.SuspendLayout();
            this.pnl_ManageGrpbtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Groups)).BeginInit();
            this.pnl2_Group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GroupMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_back.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(56, 34);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(109, 34);
            this.btn_back.TabIndex = 8;
            this.btn_back.Text = " <---  Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // pnl_heading
            // 
            this.pnl_heading.BackColor = System.Drawing.Color.SteelBlue;
            this.pnl_heading.Controls.Add(this.lbl_heading);
            this.pnl_heading.Location = new System.Drawing.Point(334, 50);
            this.pnl_heading.Name = "pnl_heading";
            this.pnl_heading.Size = new System.Drawing.Size(160, 35);
            this.pnl_heading.TabIndex = 9;
            // 
            // lbl_heading
            // 
            this.lbl_heading.AutoSize = true;
            this.lbl_heading.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_heading.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_heading.Location = new System.Drawing.Point(0, 0);
            this.lbl_heading.Name = "lbl_heading";
            this.lbl_heading.Size = new System.Drawing.Size(150, 25);
            this.lbl_heading.TabIndex = 0;
            this.lbl_heading.Text = "Manage Groups";
            this.lbl_heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // piclogo_Group
            // 
            this.piclogo_Group.BackColor = System.Drawing.Color.White;
            this.piclogo_Group.Image = ((System.Drawing.Image)(resources.GetObject("piclogo_Group.Image")));
            this.piclogo_Group.Location = new System.Drawing.Point(794, 34);
            this.piclogo_Group.Name = "piclogo_Group";
            this.piclogo_Group.Size = new System.Drawing.Size(116, 107);
            this.piclogo_Group.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.piclogo_Group.TabIndex = 10;
            this.piclogo_Group.TabStop = false;
            // 
            // pnl_Group
            // 
            this.pnl_Group.Controls.Add(this.DTP_Group);
            this.pnl_Group.Controls.Add(this.Grp_CreatedOn);
            this.pnl_Group.Location = new System.Drawing.Point(12, 125);
            this.pnl_Group.Name = "pnl_Group";
            this.pnl_Group.Size = new System.Drawing.Size(416, 58);
            this.pnl_Group.TabIndex = 11;
            // 
            // DTP_Group
            // 
            this.DTP_Group.Location = new System.Drawing.Point(183, 26);
            this.DTP_Group.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.DTP_Group.MinDate = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            this.DTP_Group.Name = "DTP_Group";
            this.DTP_Group.Size = new System.Drawing.Size(200, 20);
            this.DTP_Group.TabIndex = 3;
            // 
            // Grp_CreatedOn
            // 
            this.Grp_CreatedOn.AutoSize = true;
            this.Grp_CreatedOn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grp_CreatedOn.Location = new System.Drawing.Point(54, 26);
            this.Grp_CreatedOn.Name = "Grp_CreatedOn";
            this.Grp_CreatedOn.Size = new System.Drawing.Size(73, 17);
            this.Grp_CreatedOn.TabIndex = 2;
            this.Grp_CreatedOn.Text = "CreatedOn";
            // 
            // pnl_ManageGrpbtn
            // 
            this.pnl_ManageGrpbtn.Controls.Add(this.btn_AddStudent);
            this.pnl_ManageGrpbtn.Controls.Add(this.btn_RemoveMember);
            this.pnl_ManageGrpbtn.Location = new System.Drawing.Point(825, 203);
            this.pnl_ManageGrpbtn.Name = "pnl_ManageGrpbtn";
            this.pnl_ManageGrpbtn.Size = new System.Drawing.Size(133, 158);
            this.pnl_ManageGrpbtn.TabIndex = 12;
            // 
            // btn_AddStudent
            // 
            this.btn_AddStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_AddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddStudent.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddStudent.Location = new System.Drawing.Point(2, 20);
            this.btn_AddStudent.Name = "btn_AddStudent";
            this.btn_AddStudent.Size = new System.Drawing.Size(130, 44);
            this.btn_AddStudent.TabIndex = 15;
            this.btn_AddStudent.Text = "Add to Group";
            this.btn_AddStudent.UseVisualStyleBackColor = false;
            this.btn_AddStudent.Click += new System.EventHandler(this.btn_AddStudent_Click);
            // 
            // btn_RemoveMember
            // 
            this.btn_RemoveMember.BackColor = System.Drawing.Color.Red;
            this.btn_RemoveMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RemoveMember.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RemoveMember.Location = new System.Drawing.Point(2, 93);
            this.btn_RemoveMember.Name = "btn_RemoveMember";
            this.btn_RemoveMember.Size = new System.Drawing.Size(131, 44);
            this.btn_RemoveMember.TabIndex = 2;
            this.btn_RemoveMember.Text = "Remove Member";
            this.btn_RemoveMember.UseVisualStyleBackColor = false;
            this.btn_RemoveMember.Click += new System.EventHandler(this.btn_DeleteMember_Click);
            // 
            // btn_CreateGroup
            // 
            this.btn_CreateGroup.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_CreateGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CreateGroup.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CreateGroup.Location = new System.Drawing.Point(444, 121);
            this.btn_CreateGroup.Name = "btn_CreateGroup";
            this.btn_CreateGroup.Size = new System.Drawing.Size(117, 29);
            this.btn_CreateGroup.TabIndex = 0;
            this.btn_CreateGroup.Text = "Create Group";
            this.btn_CreateGroup.UseVisualStyleBackColor = false;
            this.btn_CreateGroup.Click += new System.EventHandler(this.btn_CreateGroup_Click);
            // 
            // dgv_Groups
            // 
            this.dgv_Groups.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Groups.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Groups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Groups.Location = new System.Drawing.Point(12, 224);
            this.dgv_Groups.Name = "dgv_Groups";
            this.dgv_Groups.ReadOnly = true;
            this.dgv_Groups.RowHeadersVisible = false;
            this.dgv_Groups.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Groups.Size = new System.Drawing.Size(416, 137);
            this.dgv_Groups.TabIndex = 13;
            this.dgv_Groups.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Groups_CellClick);
            // 
            // pnl2_Group
            // 
            this.pnl2_Group.Controls.Add(this.grp_CmbStatus);
            this.pnl2_Group.Controls.Add(this.lbl_Status);
            this.pnl2_Group.Controls.Add(this.grp_CmbStudent);
            this.pnl2_Group.Controls.Add(this.lbl_Student);
            this.pnl2_Group.Location = new System.Drawing.Point(487, 224);
            this.pnl2_Group.Name = "pnl2_Group";
            this.pnl2_Group.Size = new System.Drawing.Size(317, 109);
            this.pnl2_Group.TabIndex = 14;
            // 
            // grp_CmbStatus
            // 
            this.grp_CmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.grp_CmbStatus.FormattingEnabled = true;
            this.grp_CmbStatus.Location = new System.Drawing.Point(148, 66);
            this.grp_CmbStatus.Name = "grp_CmbStatus";
            this.grp_CmbStatus.Size = new System.Drawing.Size(121, 21);
            this.grp_CmbStatus.TabIndex = 16;
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Status.Location = new System.Drawing.Point(57, 66);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(46, 17);
            this.lbl_Status.TabIndex = 15;
            this.lbl_Status.Text = "Status";
            // 
            // grp_CmbStudent
            // 
            this.grp_CmbStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.grp_CmbStudent.FormattingEnabled = true;
            this.grp_CmbStudent.Location = new System.Drawing.Point(146, 22);
            this.grp_CmbStudent.Name = "grp_CmbStudent";
            this.grp_CmbStudent.Size = new System.Drawing.Size(121, 21);
            this.grp_CmbStudent.TabIndex = 14;
            // 
            // lbl_Student
            // 
            this.lbl_Student.AutoSize = true;
            this.lbl_Student.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Student.Location = new System.Drawing.Point(54, 26);
            this.lbl_Student.Name = "lbl_Student";
            this.lbl_Student.Size = new System.Drawing.Size(56, 17);
            this.lbl_Student.TabIndex = 2;
            this.lbl_Student.Text = "Student";
            // 
            // dgv_GroupMembers
            // 
            this.dgv_GroupMembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_GroupMembers.BackgroundColor = System.Drawing.Color.White;
            this.dgv_GroupMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_GroupMembers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_GroupMembers.Location = new System.Drawing.Point(0, 418);
            this.dgv_GroupMembers.Name = "dgv_GroupMembers";
            this.dgv_GroupMembers.ReadOnly = true;
            this.dgv_GroupMembers.RowHeadersVisible = false;
            this.dgv_GroupMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_GroupMembers.Size = new System.Drawing.Size(984, 193);
            this.dgv_GroupMembers.TabIndex = 15;
            // 
            // btn_DeleteGroup
            // 
            this.btn_DeleteGroup.BackColor = System.Drawing.Color.Red;
            this.btn_DeleteGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeleteGroup.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteGroup.Location = new System.Drawing.Point(446, 166);
            this.btn_DeleteGroup.Name = "btn_DeleteGroup";
            this.btn_DeleteGroup.Size = new System.Drawing.Size(115, 32);
            this.btn_DeleteGroup.TabIndex = 16;
            this.btn_DeleteGroup.Text = "Delete Group";
            this.btn_DeleteGroup.UseVisualStyleBackColor = false;
            this.btn_DeleteGroup.Click += new System.EventHandler(this.btn_DeleteGroup_Click_1);
            // 
            // ManageGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.btn_DeleteGroup);
            this.Controls.Add(this.dgv_GroupMembers);
            this.Controls.Add(this.pnl2_Group);
            this.Controls.Add(this.dgv_Groups);
            this.Controls.Add(this.btn_CreateGroup);
            this.Controls.Add(this.pnl_ManageGrpbtn);
            this.Controls.Add(this.pnl_Group);
            this.Controls.Add(this.piclogo_Group);
            this.Controls.Add(this.pnl_heading);
            this.Controls.Add(this.btn_back);
            this.Name = "ManageGroups";
            this.Text = "GroupFormation";
            this.Load += new System.EventHandler(this.ManageGroups_Load);
            this.pnl_heading.ResumeLayout(false);
            this.pnl_heading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo_Group)).EndInit();
            this.pnl_Group.ResumeLayout(false);
            this.pnl_Group.PerformLayout();
            this.pnl_ManageGrpbtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Groups)).EndInit();
            this.pnl2_Group.ResumeLayout(false);
            this.pnl2_Group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GroupMembers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Panel pnl_heading;
        private System.Windows.Forms.Label lbl_heading;
        private System.Windows.Forms.PictureBox piclogo_Group;
        private System.Windows.Forms.Panel pnl_Group;
        private System.Windows.Forms.Label Grp_CreatedOn;
        private System.Windows.Forms.Panel pnl_ManageGrpbtn;
        private System.Windows.Forms.Button btn_RemoveMember;
        private System.Windows.Forms.Button btn_CreateGroup;
        private System.Windows.Forms.DataGridView dgv_Groups;
        private System.Windows.Forms.DateTimePicker DTP_Group;
        private System.Windows.Forms.Panel pnl2_Group;
        private System.Windows.Forms.Label lbl_Student;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.ComboBox grp_CmbStudent;
        private System.Windows.Forms.ComboBox grp_CmbStatus;
        private System.Windows.Forms.Button btn_AddStudent;
        private System.Windows.Forms.DataGridView dgv_GroupMembers;
        private System.Windows.Forms.Button btn_DeleteGroup;
    }
}