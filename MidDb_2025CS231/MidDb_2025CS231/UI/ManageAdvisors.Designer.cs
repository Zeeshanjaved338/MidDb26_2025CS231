namespace MidDb_2025CS231.UI
{
    partial class ManageAdvisors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageAdvisors));
            this.btn_back = new System.Windows.Forms.Button();
            this.pnl_heading = new System.Windows.Forms.Panel();
            this.lbl_heading = new System.Windows.Forms.Label();
            this.piclogo_adv = new System.Windows.Forms.PictureBox();
            this.pnl_adv = new System.Windows.Forms.Panel();
            this.num_Salary = new System.Windows.Forms.NumericUpDown();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.adv_Email = new System.Windows.Forms.Label();
            this.adv_CmbDesignation = new System.Windows.Forms.ComboBox();
            this.adv_CmbGender = new System.Windows.Forms.ComboBox();
            this.adv_Gender = new System.Windows.Forms.Label();
            this.adv_Salary = new System.Windows.Forms.Label();
            this.adv_Designation = new System.Windows.Forms.Label();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.adv_LastName = new System.Windows.Forms.Label();
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.adv_FirstName = new System.Windows.Forms.Label();
            this.pnl_advbtn = new System.Windows.Forms.Panel();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.dgv_Advisor = new System.Windows.Forms.DataGridView();
            this.pnl_heading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo_adv)).BeginInit();
            this.pnl_adv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Salary)).BeginInit();
            this.pnl_advbtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Advisor)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_back.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(61, 35);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(109, 34);
            this.btn_back.TabIndex = 7;
            this.btn_back.Text = " <---  Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // pnl_heading
            // 
            this.pnl_heading.BackColor = System.Drawing.Color.SteelBlue;
            this.pnl_heading.Controls.Add(this.lbl_heading);
            this.pnl_heading.Location = new System.Drawing.Point(345, 48);
            this.pnl_heading.Name = "pnl_heading";
            this.pnl_heading.Size = new System.Drawing.Size(188, 35);
            this.pnl_heading.TabIndex = 8;
            // 
            // lbl_heading
            // 
            this.lbl_heading.AutoSize = true;
            this.lbl_heading.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_heading.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_heading.Location = new System.Drawing.Point(0, 0);
            this.lbl_heading.Name = "lbl_heading";
            this.lbl_heading.Size = new System.Drawing.Size(163, 25);
            this.lbl_heading.TabIndex = 0;
            this.lbl_heading.Text = "Manage Advisors";
            this.lbl_heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // piclogo_adv
            // 
            this.piclogo_adv.BackColor = System.Drawing.Color.White;
            this.piclogo_adv.Image = ((System.Drawing.Image)(resources.GetObject("piclogo_adv.Image")));
            this.piclogo_adv.Location = new System.Drawing.Point(804, 34);
            this.piclogo_adv.Name = "piclogo_adv";
            this.piclogo_adv.Size = new System.Drawing.Size(116, 107);
            this.piclogo_adv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.piclogo_adv.TabIndex = 9;
            this.piclogo_adv.TabStop = false;
            // 
            // pnl_adv
            // 
            this.pnl_adv.Controls.Add(this.num_Salary);
            this.pnl_adv.Controls.Add(this.txt_Email);
            this.pnl_adv.Controls.Add(this.adv_Email);
            this.pnl_adv.Controls.Add(this.adv_CmbDesignation);
            this.pnl_adv.Controls.Add(this.adv_CmbGender);
            this.pnl_adv.Controls.Add(this.adv_Gender);
            this.pnl_adv.Controls.Add(this.adv_Salary);
            this.pnl_adv.Controls.Add(this.adv_Designation);
            this.pnl_adv.Controls.Add(this.txt_LastName);
            this.pnl_adv.Controls.Add(this.adv_LastName);
            this.pnl_adv.Controls.Add(this.txt_FirstName);
            this.pnl_adv.Controls.Add(this.adv_FirstName);
            this.pnl_adv.Location = new System.Drawing.Point(214, 158);
            this.pnl_adv.Name = "pnl_adv";
            this.pnl_adv.Size = new System.Drawing.Size(451, 269);
            this.pnl_adv.TabIndex = 10;
            // 
            // num_Salary
            // 
            this.num_Salary.DecimalPlaces = 2;
            this.num_Salary.Location = new System.Drawing.Point(165, 188);
            this.num_Salary.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.num_Salary.Name = "num_Salary";
            this.num_Salary.Size = new System.Drawing.Size(120, 20);
            this.num_Salary.TabIndex = 18;
            // 
            // txt_Email
            // 
            this.txt_Email.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.Location = new System.Drawing.Point(165, 107);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(176, 25);
            this.txt_Email.TabIndex = 17;
            // 
            // adv_Email
            // 
            this.adv_Email.AutoSize = true;
            this.adv_Email.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adv_Email.Location = new System.Drawing.Point(31, 115);
            this.adv_Email.Name = "adv_Email";
            this.adv_Email.Size = new System.Drawing.Size(40, 17);
            this.adv_Email.TabIndex = 16;
            this.adv_Email.Text = "Email";
            // 
            // adv_CmbDesignation
            // 
            this.adv_CmbDesignation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.adv_CmbDesignation.FormattingEnabled = true;
            this.adv_CmbDesignation.Location = new System.Drawing.Point(165, 147);
            this.adv_CmbDesignation.Name = "adv_CmbDesignation";
            this.adv_CmbDesignation.Size = new System.Drawing.Size(121, 21);
            this.adv_CmbDesignation.TabIndex = 14;
            // 
            // adv_CmbGender
            // 
            this.adv_CmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.adv_CmbGender.FormattingEnabled = true;
            this.adv_CmbGender.Location = new System.Drawing.Point(164, 229);
            this.adv_CmbGender.Name = "adv_CmbGender";
            this.adv_CmbGender.Size = new System.Drawing.Size(121, 21);
            this.adv_CmbGender.TabIndex = 13;
            // 
            // adv_Gender
            // 
            this.adv_Gender.AutoSize = true;
            this.adv_Gender.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adv_Gender.Location = new System.Drawing.Point(31, 233);
            this.adv_Gender.Name = "adv_Gender";
            this.adv_Gender.Size = new System.Drawing.Size(52, 17);
            this.adv_Gender.TabIndex = 12;
            this.adv_Gender.Text = "Gender";
            // 
            // adv_Salary
            // 
            this.adv_Salary.AutoSize = true;
            this.adv_Salary.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adv_Salary.Location = new System.Drawing.Point(31, 191);
            this.adv_Salary.Name = "adv_Salary";
            this.adv_Salary.Size = new System.Drawing.Size(45, 17);
            this.adv_Salary.TabIndex = 8;
            this.adv_Salary.Text = "Salary";
            // 
            // adv_Designation
            // 
            this.adv_Designation.AutoSize = true;
            this.adv_Designation.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adv_Designation.Location = new System.Drawing.Point(31, 151);
            this.adv_Designation.Name = "adv_Designation";
            this.adv_Designation.Size = new System.Drawing.Size(80, 17);
            this.adv_Designation.TabIndex = 6;
            this.adv_Designation.Text = "Designation";
            // 
            // txt_LastName
            // 
            this.txt_LastName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LastName.Location = new System.Drawing.Point(165, 69);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(176, 25);
            this.txt_LastName.TabIndex = 5;
            // 
            // adv_LastName
            // 
            this.adv_LastName.AutoSize = true;
            this.adv_LastName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adv_LastName.Location = new System.Drawing.Point(31, 69);
            this.adv_LastName.Name = "adv_LastName";
            this.adv_LastName.Size = new System.Drawing.Size(72, 17);
            this.adv_LastName.TabIndex = 4;
            this.adv_LastName.Text = "Last Name";
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FirstName.Location = new System.Drawing.Point(165, 26);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(176, 25);
            this.txt_FirstName.TabIndex = 3;
            // 
            // adv_FirstName
            // 
            this.adv_FirstName.AutoSize = true;
            this.adv_FirstName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adv_FirstName.Location = new System.Drawing.Point(31, 26);
            this.adv_FirstName.Name = "adv_FirstName";
            this.adv_FirstName.Size = new System.Drawing.Size(74, 17);
            this.adv_FirstName.TabIndex = 2;
            this.adv_FirstName.Text = "First Name";
            // 
            // pnl_advbtn
            // 
            this.pnl_advbtn.Controls.Add(this.btn_Delete);
            this.pnl_advbtn.Controls.Add(this.btn_Update);
            this.pnl_advbtn.Controls.Add(this.btn_Add);
            this.pnl_advbtn.Location = new System.Drawing.Point(725, 175);
            this.pnl_advbtn.Name = "pnl_advbtn";
            this.pnl_advbtn.Size = new System.Drawing.Size(133, 224);
            this.pnl_advbtn.TabIndex = 11;
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.Red;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(3, 147);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(127, 44);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "Delete ";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(3, 84);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(127, 44);
            this.btn_Update.TabIndex = 1;
            this.btn_Update.Text = "Update ";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(3, 20);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(127, 44);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "Add ";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // dgv_Advisor
            // 
            this.dgv_Advisor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Advisor.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Advisor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Advisor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_Advisor.Location = new System.Drawing.Point(0, 504);
            this.dgv_Advisor.Name = "dgv_Advisor";
            this.dgv_Advisor.ReadOnly = true;
            this.dgv_Advisor.RowHeadersVisible = false;
            this.dgv_Advisor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Advisor.Size = new System.Drawing.Size(984, 107);
            this.dgv_Advisor.TabIndex = 12;
            this.dgv_Advisor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Advisor_CellClick);
            // 
            // ManageAdvisors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.dgv_Advisor);
            this.Controls.Add(this.pnl_advbtn);
            this.Controls.Add(this.pnl_adv);
            this.Controls.Add(this.piclogo_adv);
            this.Controls.Add(this.pnl_heading);
            this.Controls.Add(this.btn_back);
            this.Name = "ManageAdvisors";
            this.Text = "ManageAdvisors";
            this.Load += new System.EventHandler(this.ManageAdvisors_Load);
            this.pnl_heading.ResumeLayout(false);
            this.pnl_heading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo_adv)).EndInit();
            this.pnl_adv.ResumeLayout(false);
            this.pnl_adv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Salary)).EndInit();
            this.pnl_advbtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Advisor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Panel pnl_heading;
        private System.Windows.Forms.Label lbl_heading;
        private System.Windows.Forms.PictureBox piclogo_adv;
        private System.Windows.Forms.Panel pnl_adv;
        private System.Windows.Forms.ComboBox adv_CmbGender;
        private System.Windows.Forms.Label adv_Gender;
        private System.Windows.Forms.Label adv_Salary;
        private System.Windows.Forms.Label adv_Designation;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.Label adv_LastName;
        private System.Windows.Forms.TextBox txt_FirstName;
        private System.Windows.Forms.Label adv_FirstName;
        private System.Windows.Forms.ComboBox adv_CmbDesignation;
        private System.Windows.Forms.Panel pnl_advbtn;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.DataGridView dgv_Advisor;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label adv_Email;
        private System.Windows.Forms.NumericUpDown num_Salary;
    }
}