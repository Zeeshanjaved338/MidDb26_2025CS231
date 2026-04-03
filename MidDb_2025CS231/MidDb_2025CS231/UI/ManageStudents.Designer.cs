namespace MidDb_2025CS231.UI
{
    partial class ManageStudents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageStudents));
            this.lbl_heading = new System.Windows.Forms.Label();
            this.pnl_heading = new System.Windows.Forms.Panel();
            this.piclogo_std = new System.Windows.Forms.PictureBox();
            this.pnl_std = new System.Windows.Forms.Panel();
            this.std_CmbGender = new System.Windows.Forms.ComboBox();
            this.std_Gender = new System.Windows.Forms.Label();
            this.std_DTP = new System.Windows.Forms.DateTimePicker();
            this.std_DateofBirth = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.std_Email = new System.Windows.Forms.Label();
            this.txt_Contact = new System.Windows.Forms.TextBox();
            this.std_Contact = new System.Windows.Forms.Label();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.std_LastName = new System.Windows.Forms.Label();
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.std_FirstName = new System.Windows.Forms.Label();
            this.txt_RegNo = new System.Windows.Forms.TextBox();
            this.std_RegNo = new System.Windows.Forms.Label();
            this.pnl_stdbtn = new System.Windows.Forms.Panel();
            this.btn_DeleteStudent = new System.Windows.Forms.Button();
            this.btn_UpdateStudent = new System.Windows.Forms.Button();
            this.btn_AddStudent = new System.Windows.Forms.Button();
            this.dgv_Student = new System.Windows.Forms.DataGridView();
            this.btn_back = new System.Windows.Forms.Button();
            this.pnl_heading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo_std)).BeginInit();
            this.pnl_std.SuspendLayout();
            this.pnl_stdbtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Student)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_heading
            // 
            this.lbl_heading.AutoSize = true;
            this.lbl_heading.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_heading.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_heading.Location = new System.Drawing.Point(0, 0);
            this.lbl_heading.Name = "lbl_heading";
            this.lbl_heading.Size = new System.Drawing.Size(200, 25);
            this.lbl_heading.TabIndex = 0;
            this.lbl_heading.Text = "Student Management";
            // 
            // pnl_heading
            // 
            this.pnl_heading.BackColor = System.Drawing.Color.SteelBlue;
            this.pnl_heading.Controls.Add(this.lbl_heading);
            this.pnl_heading.Location = new System.Drawing.Point(287, 12);
            this.pnl_heading.Name = "pnl_heading";
            this.pnl_heading.Size = new System.Drawing.Size(210, 35);
            this.pnl_heading.TabIndex = 1;
            // 
            // piclogo_std
            // 
            this.piclogo_std.BackColor = System.Drawing.Color.White;
            this.piclogo_std.Image = ((System.Drawing.Image)(resources.GetObject("piclogo_std.Image")));
            this.piclogo_std.Location = new System.Drawing.Point(752, 12);
            this.piclogo_std.Name = "piclogo_std";
            this.piclogo_std.Size = new System.Drawing.Size(116, 107);
            this.piclogo_std.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.piclogo_std.TabIndex = 2;
            this.piclogo_std.TabStop = false;
            // 
            // pnl_std
            // 
            this.pnl_std.Controls.Add(this.std_CmbGender);
            this.pnl_std.Controls.Add(this.std_Gender);
            this.pnl_std.Controls.Add(this.std_DTP);
            this.pnl_std.Controls.Add(this.std_DateofBirth);
            this.pnl_std.Controls.Add(this.txt_Email);
            this.pnl_std.Controls.Add(this.std_Email);
            this.pnl_std.Controls.Add(this.txt_Contact);
            this.pnl_std.Controls.Add(this.std_Contact);
            this.pnl_std.Controls.Add(this.txt_LastName);
            this.pnl_std.Controls.Add(this.std_LastName);
            this.pnl_std.Controls.Add(this.txt_FirstName);
            this.pnl_std.Controls.Add(this.std_FirstName);
            this.pnl_std.Controls.Add(this.txt_RegNo);
            this.pnl_std.Controls.Add(this.std_RegNo);
            this.pnl_std.Location = new System.Drawing.Point(156, 89);
            this.pnl_std.Name = "pnl_std";
            this.pnl_std.Size = new System.Drawing.Size(451, 318);
            this.pnl_std.TabIndex = 3;
            // 
            // std_CmbGender
            // 
            this.std_CmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.std_CmbGender.FormattingEnabled = true;
            this.std_CmbGender.Location = new System.Drawing.Point(165, 243);
            this.std_CmbGender.Name = "std_CmbGender";
            this.std_CmbGender.Size = new System.Drawing.Size(121, 21);
            this.std_CmbGender.TabIndex = 13;
            // 
            // std_Gender
            // 
            this.std_Gender.AutoSize = true;
            this.std_Gender.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.std_Gender.Location = new System.Drawing.Point(31, 243);
            this.std_Gender.Name = "std_Gender";
            this.std_Gender.Size = new System.Drawing.Size(52, 17);
            this.std_Gender.TabIndex = 12;
            this.std_Gender.Text = "Gender";
            // 
            // std_DTP
            // 
            this.std_DTP.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.std_DTP.Location = new System.Drawing.Point(165, 206);
            this.std_DTP.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.std_DTP.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.std_DTP.Name = "std_DTP";
            this.std_DTP.Size = new System.Drawing.Size(212, 23);
            this.std_DTP.TabIndex = 11;
            // 
            // std_DateofBirth
            // 
            this.std_DateofBirth.AutoSize = true;
            this.std_DateofBirth.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.std_DateofBirth.Location = new System.Drawing.Point(31, 206);
            this.std_DateofBirth.Name = "std_DateofBirth";
            this.std_DateofBirth.Size = new System.Drawing.Size(85, 17);
            this.std_DateofBirth.TabIndex = 10;
            this.std_DateofBirth.Text = "Date of Birth";
            // 
            // txt_Email
            // 
            this.txt_Email.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.Location = new System.Drawing.Point(165, 171);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(176, 25);
            this.txt_Email.TabIndex = 9;
            // 
            // std_Email
            // 
            this.std_Email.AutoSize = true;
            this.std_Email.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.std_Email.Location = new System.Drawing.Point(31, 171);
            this.std_Email.Name = "std_Email";
            this.std_Email.Size = new System.Drawing.Size(40, 17);
            this.std_Email.TabIndex = 8;
            this.std_Email.Text = "Email";
            // 
            // txt_Contact
            // 
            this.txt_Contact.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Contact.Location = new System.Drawing.Point(165, 134);
            this.txt_Contact.MaxLength = 20;
            this.txt_Contact.Name = "txt_Contact";
            this.txt_Contact.Size = new System.Drawing.Size(176, 25);
            this.txt_Contact.TabIndex = 7;
            // 
            // std_Contact
            // 
            this.std_Contact.AutoSize = true;
            this.std_Contact.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.std_Contact.Location = new System.Drawing.Point(31, 134);
            this.std_Contact.Name = "std_Contact";
            this.std_Contact.Size = new System.Drawing.Size(55, 17);
            this.std_Contact.TabIndex = 6;
            this.std_Contact.Text = "Contact";
            // 
            // txt_LastName
            // 
            this.txt_LastName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LastName.Location = new System.Drawing.Point(165, 92);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(176, 25);
            this.txt_LastName.TabIndex = 5;
            // 
            // std_LastName
            // 
            this.std_LastName.AutoSize = true;
            this.std_LastName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.std_LastName.Location = new System.Drawing.Point(31, 92);
            this.std_LastName.Name = "std_LastName";
            this.std_LastName.Size = new System.Drawing.Size(72, 17);
            this.std_LastName.TabIndex = 4;
            this.std_LastName.Text = "Last Name";
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FirstName.Location = new System.Drawing.Point(165, 54);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(176, 25);
            this.txt_FirstName.TabIndex = 3;
            // 
            // std_FirstName
            // 
            this.std_FirstName.AutoSize = true;
            this.std_FirstName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.std_FirstName.Location = new System.Drawing.Point(31, 54);
            this.std_FirstName.Name = "std_FirstName";
            this.std_FirstName.Size = new System.Drawing.Size(74, 17);
            this.std_FirstName.TabIndex = 2;
            this.std_FirstName.Text = "First Name";
            // 
            // txt_RegNo
            // 
            this.txt_RegNo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_RegNo.Location = new System.Drawing.Point(165, 19);
            this.txt_RegNo.Name = "txt_RegNo";
            this.txt_RegNo.Size = new System.Drawing.Size(176, 25);
            this.txt_RegNo.TabIndex = 1;
            // 
            // std_RegNo
            // 
            this.std_RegNo.AutoSize = true;
            this.std_RegNo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.std_RegNo.Location = new System.Drawing.Point(31, 22);
            this.std_RegNo.Name = "std_RegNo";
            this.std_RegNo.Size = new System.Drawing.Size(99, 17);
            this.std_RegNo.TabIndex = 0;
            this.std_RegNo.Text = "RegistrationNo";
            // 
            // pnl_stdbtn
            // 
            this.pnl_stdbtn.Controls.Add(this.btn_DeleteStudent);
            this.pnl_stdbtn.Controls.Add(this.btn_UpdateStudent);
            this.pnl_stdbtn.Controls.Add(this.btn_AddStudent);
            this.pnl_stdbtn.Location = new System.Drawing.Point(670, 143);
            this.pnl_stdbtn.Name = "pnl_stdbtn";
            this.pnl_stdbtn.Size = new System.Drawing.Size(133, 224);
            this.pnl_stdbtn.TabIndex = 4;
            // 
            // btn_DeleteStudent
            // 
            this.btn_DeleteStudent.BackColor = System.Drawing.Color.Red;
            this.btn_DeleteStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeleteStudent.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteStudent.Location = new System.Drawing.Point(3, 147);
            this.btn_DeleteStudent.Name = "btn_DeleteStudent";
            this.btn_DeleteStudent.Size = new System.Drawing.Size(127, 44);
            this.btn_DeleteStudent.TabIndex = 2;
            this.btn_DeleteStudent.Text = "Delete Student";
            this.btn_DeleteStudent.UseVisualStyleBackColor = false;
            this.btn_DeleteStudent.Click += new System.EventHandler(this.btn_DeleteStudent_Click);
            // 
            // btn_UpdateStudent
            // 
            this.btn_UpdateStudent.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_UpdateStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UpdateStudent.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UpdateStudent.Location = new System.Drawing.Point(3, 84);
            this.btn_UpdateStudent.Name = "btn_UpdateStudent";
            this.btn_UpdateStudent.Size = new System.Drawing.Size(127, 44);
            this.btn_UpdateStudent.TabIndex = 1;
            this.btn_UpdateStudent.Text = "Update Student";
            this.btn_UpdateStudent.UseVisualStyleBackColor = false;
            this.btn_UpdateStudent.Click += new System.EventHandler(this.btn_UpdateStudent_Click);
            // 
            // btn_AddStudent
            // 
            this.btn_AddStudent.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_AddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddStudent.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddStudent.Location = new System.Drawing.Point(3, 20);
            this.btn_AddStudent.Name = "btn_AddStudent";
            this.btn_AddStudent.Size = new System.Drawing.Size(127, 44);
            this.btn_AddStudent.TabIndex = 0;
            this.btn_AddStudent.Text = "Add Student";
            this.btn_AddStudent.UseVisualStyleBackColor = false;
            this.btn_AddStudent.Click += new System.EventHandler(this.btn_AddStudent_Click);
            // 
            // dgv_Student
            // 
            this.dgv_Student.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Student.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Student.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_Student.Location = new System.Drawing.Point(0, 429);
            this.dgv_Student.Name = "dgv_Student";
            this.dgv_Student.ReadOnly = true;
            this.dgv_Student.RowHeadersVisible = false;
            this.dgv_Student.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Student.Size = new System.Drawing.Size(984, 182);
            this.dgv_Student.TabIndex = 5;
            this.dgv_Student.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Student_CellClick);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_back.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(33, 13);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(109, 34);
            this.btn_back.TabIndex = 6;
            this.btn_back.Text = " <---  Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // ManageStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.dgv_Student);
            this.Controls.Add(this.pnl_stdbtn);
            this.Controls.Add(this.pnl_std);
            this.Controls.Add(this.piclogo_std);
            this.Controls.Add(this.pnl_heading);
            this.Name = "ManageStudents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Students";
            this.Load += new System.EventHandler(this.ManageStudents_Load);
            this.pnl_heading.ResumeLayout(false);
            this.pnl_heading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo_std)).EndInit();
            this.pnl_std.ResumeLayout(false);
            this.pnl_std.PerformLayout();
            this.pnl_stdbtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Student)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_heading;
        private System.Windows.Forms.Panel pnl_heading;
        private System.Windows.Forms.PictureBox piclogo_std;
        private System.Windows.Forms.Panel pnl_std;
        private System.Windows.Forms.TextBox txt_RegNo;
        private System.Windows.Forms.Label std_RegNo;
        private System.Windows.Forms.Label std_FirstName;
        private System.Windows.Forms.TextBox txt_FirstName;
        private System.Windows.Forms.TextBox txt_Contact;
        private System.Windows.Forms.Label std_Contact;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.Label std_LastName;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label std_Email;
        public System.Windows.Forms.DateTimePicker std_DTP;
        private System.Windows.Forms.Label std_DateofBirth;
        private System.Windows.Forms.ComboBox std_CmbGender;
        private System.Windows.Forms.Label std_Gender;
        private System.Windows.Forms.Panel pnl_stdbtn;
        private System.Windows.Forms.Button btn_DeleteStudent;
        private System.Windows.Forms.Button btn_UpdateStudent;
        private System.Windows.Forms.Button btn_AddStudent;
        private System.Windows.Forms.DataGridView dgv_Student;
        private System.Windows.Forms.Button btn_back;
    }
}