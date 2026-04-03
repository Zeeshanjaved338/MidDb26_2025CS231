namespace MidDb_2025CS231.UI
{
    partial class ProjectManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectManagement));
            this.btn_Back = new System.Windows.Forms.Button();
            this.piclogo_prj = new System.Windows.Forms.PictureBox();
            this.pnl_heading = new System.Windows.Forms.Panel();
            this.lbl_heading = new System.Windows.Forms.Label();
            this.pnl_prjbtn = new System.Windows.Forms.Panel();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.dgv_Project = new System.Windows.Forms.DataGridView();
            this.pnl_prj = new System.Windows.Forms.Panel();
            this.Richtxt_Description = new System.Windows.Forms.RichTextBox();
            this.prj_Description = new System.Windows.Forms.Label();
            this.txt_Title = new System.Windows.Forms.TextBox();
            this.prj_Title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo_prj)).BeginInit();
            this.pnl_heading.SuspendLayout();
            this.pnl_prjbtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Project)).BeginInit();
            this.pnl_prj.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_Back.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(68, 40);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(109, 34);
            this.btn_Back.TabIndex = 8;
            this.btn_Back.Text = " <---  Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // piclogo_prj
            // 
            this.piclogo_prj.BackColor = System.Drawing.Color.White;
            this.piclogo_prj.Image = ((System.Drawing.Image)(resources.GetObject("piclogo_prj.Image")));
            this.piclogo_prj.Location = new System.Drawing.Point(792, 40);
            this.piclogo_prj.Name = "piclogo_prj";
            this.piclogo_prj.Size = new System.Drawing.Size(116, 107);
            this.piclogo_prj.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.piclogo_prj.TabIndex = 10;
            this.piclogo_prj.TabStop = false;
            // 
            // pnl_heading
            // 
            this.pnl_heading.BackColor = System.Drawing.Color.SteelBlue;
            this.pnl_heading.Controls.Add(this.lbl_heading);
            this.pnl_heading.Location = new System.Drawing.Point(362, 39);
            this.pnl_heading.Name = "pnl_heading";
            this.pnl_heading.Size = new System.Drawing.Size(198, 35);
            this.pnl_heading.TabIndex = 11;
            // 
            // lbl_heading
            // 
            this.lbl_heading.AutoSize = true;
            this.lbl_heading.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_heading.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_heading.Location = new System.Drawing.Point(0, 0);
            this.lbl_heading.Name = "lbl_heading";
            this.lbl_heading.Size = new System.Drawing.Size(195, 25);
            this.lbl_heading.TabIndex = 0;
            this.lbl_heading.Text = "Project Management";
            this.lbl_heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_prjbtn
            // 
            this.pnl_prjbtn.Controls.Add(this.btn_Delete);
            this.pnl_prjbtn.Controls.Add(this.btn_Update);
            this.pnl_prjbtn.Controls.Add(this.btn_Add);
            this.pnl_prjbtn.Location = new System.Drawing.Point(719, 177);
            this.pnl_prjbtn.Name = "pnl_prjbtn";
            this.pnl_prjbtn.Size = new System.Drawing.Size(133, 224);
            this.pnl_prjbtn.TabIndex = 12;
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
            // dgv_Project
            // 
            this.dgv_Project.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Project.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Project.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Project.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_Project.Location = new System.Drawing.Point(0, 442);
            this.dgv_Project.Name = "dgv_Project";
            this.dgv_Project.ReadOnly = true;
            this.dgv_Project.RowHeadersVisible = false;
            this.dgv_Project.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Project.Size = new System.Drawing.Size(984, 169);
            this.dgv_Project.TabIndex = 13;
            this.dgv_Project.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Project_CellClick);
            // 
            // pnl_prj
            // 
            this.pnl_prj.Controls.Add(this.Richtxt_Description);
            this.pnl_prj.Controls.Add(this.prj_Description);
            this.pnl_prj.Controls.Add(this.txt_Title);
            this.pnl_prj.Controls.Add(this.prj_Title);
            this.pnl_prj.Location = new System.Drawing.Point(219, 151);
            this.pnl_prj.Name = "pnl_prj";
            this.pnl_prj.Size = new System.Drawing.Size(451, 234);
            this.pnl_prj.TabIndex = 14;
            // 
            // Richtxt_Description
            // 
            this.Richtxt_Description.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Richtxt_Description.Location = new System.Drawing.Point(165, 69);
            this.Richtxt_Description.Name = "Richtxt_Description";
            this.Richtxt_Description.Size = new System.Drawing.Size(248, 122);
            this.Richtxt_Description.TabIndex = 5;
            this.Richtxt_Description.Text = "";
            // 
            // prj_Description
            // 
            this.prj_Description.AutoSize = true;
            this.prj_Description.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prj_Description.Location = new System.Drawing.Point(31, 69);
            this.prj_Description.Name = "prj_Description";
            this.prj_Description.Size = new System.Drawing.Size(76, 17);
            this.prj_Description.TabIndex = 4;
            this.prj_Description.Text = "Description";
            // 
            // txt_Title
            // 
            this.txt_Title.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Title.Location = new System.Drawing.Point(165, 26);
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.Size = new System.Drawing.Size(248, 25);
            this.txt_Title.TabIndex = 3;
            // 
            // prj_Title
            // 
            this.prj_Title.AutoSize = true;
            this.prj_Title.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prj_Title.Location = new System.Drawing.Point(31, 26);
            this.prj_Title.Name = "prj_Title";
            this.prj_Title.Size = new System.Drawing.Size(79, 17);
            this.prj_Title.TabIndex = 2;
            this.prj_Title.Text = "Project Title";
            // 
            // ProjectManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.pnl_prj);
            this.Controls.Add(this.dgv_Project);
            this.Controls.Add(this.pnl_prjbtn);
            this.Controls.Add(this.pnl_heading);
            this.Controls.Add(this.piclogo_prj);
            this.Controls.Add(this.btn_Back);
            this.Name = "ProjectManagement";
            this.Text = "ProjectManagement";
            this.Load += new System.EventHandler(this.ProjectManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.piclogo_prj)).EndInit();
            this.pnl_heading.ResumeLayout(false);
            this.pnl_heading.PerformLayout();
            this.pnl_prjbtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Project)).EndInit();
            this.pnl_prj.ResumeLayout(false);
            this.pnl_prj.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.PictureBox piclogo_prj;
        private System.Windows.Forms.Panel pnl_heading;
        private System.Windows.Forms.Label lbl_heading;
        private System.Windows.Forms.Panel pnl_prjbtn;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.DataGridView dgv_Project;
        private System.Windows.Forms.Panel pnl_prj;
        private System.Windows.Forms.Label prj_Description;
        private System.Windows.Forms.TextBox txt_Title;
        private System.Windows.Forms.Label prj_Title;
        private System.Windows.Forms.RichTextBox Richtxt_Description;
    }
}