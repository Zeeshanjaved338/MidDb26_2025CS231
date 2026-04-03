namespace MidDb_2025CS231.UI
{
    partial class MarkEvaluation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarkEvaluation));
            this.btn_Back = new System.Windows.Forms.Button();
            this.pnl_heading = new System.Windows.Forms.Panel();
            this.lbl_heading = new System.Windows.Forms.Label();
            this.piclogo_MarkEvaluation = new System.Windows.Forms.PictureBox();
            this.pnl_Evaluation = new System.Windows.Forms.Panel();
            this.lbl_Weightage = new System.Windows.Forms.Label();
            this.lbl_TotalMarks = new System.Windows.Forms.Label();
            this.lbl_EvaluationType = new System.Windows.Forms.Label();
            this.txt_EvaluationType = new System.Windows.Forms.TextBox();
            this.pnl_MarkEvaluation = new System.Windows.Forms.Panel();
            this.lbl_MarkGroup = new System.Windows.Forms.Label();
            this.Eva_CmbSelectEvaluation = new System.Windows.Forms.ComboBox();
            this.lbl_OMark = new System.Windows.Forms.Label();
            this.Eva_CmbMarkGroup = new System.Windows.Forms.ComboBox();
            this.lbl_SelectEvaluation = new System.Windows.Forms.Label();
            this.num_OMarks = new System.Windows.Forms.NumericUpDown();
            this.num_TotalMarks = new System.Windows.Forms.NumericUpDown();
            this.num_Weightage = new System.Windows.Forms.NumericUpDown();
            this.pnl_btnEvaluation = new System.Windows.Forms.Panel();
            this.btn_AddEvaluation = new System.Windows.Forms.Button();
            this.btn_UpdateEvaluation = new System.Windows.Forms.Button();
            this.dgv_ManageEvaluations = new System.Windows.Forms.DataGridView();
            this.btn_DeleteEvaluation = new System.Windows.Forms.Button();
            this.lbl_AssignDate = new System.Windows.Forms.Label();
            this.Evaluation_DTP = new System.Windows.Forms.DateTimePicker();
            this.btn_AssignMark = new System.Windows.Forms.Button();
            this.btn_DeleteMark = new System.Windows.Forms.Button();
            this.pnl_heading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo_MarkEvaluation)).BeginInit();
            this.pnl_Evaluation.SuspendLayout();
            this.pnl_MarkEvaluation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_OMarks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_TotalMarks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Weightage)).BeginInit();
            this.pnl_btnEvaluation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ManageEvaluations)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_Back.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(71, 30);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(109, 34);
            this.btn_Back.TabIndex = 8;
            this.btn_Back.Text = " <---  Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // pnl_heading
            // 
            this.pnl_heading.BackColor = System.Drawing.Color.SteelBlue;
            this.pnl_heading.Controls.Add(this.lbl_heading);
            this.pnl_heading.Location = new System.Drawing.Point(346, 40);
            this.pnl_heading.Name = "pnl_heading";
            this.pnl_heading.Size = new System.Drawing.Size(169, 35);
            this.pnl_heading.TabIndex = 9;
            // 
            // lbl_heading
            // 
            this.lbl_heading.AutoSize = true;
            this.lbl_heading.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_heading.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_heading.Location = new System.Drawing.Point(0, 0);
            this.lbl_heading.Name = "lbl_heading";
            this.lbl_heading.Size = new System.Drawing.Size(166, 25);
            this.lbl_heading.TabIndex = 0;
            this.lbl_heading.Text = "Mark Evaluations";
            this.lbl_heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // piclogo_MarkEvaluation
            // 
            this.piclogo_MarkEvaluation.BackColor = System.Drawing.Color.White;
            this.piclogo_MarkEvaluation.Image = ((System.Drawing.Image)(resources.GetObject("piclogo_MarkEvaluation.Image")));
            this.piclogo_MarkEvaluation.Location = new System.Drawing.Point(803, 40);
            this.piclogo_MarkEvaluation.Name = "piclogo_MarkEvaluation";
            this.piclogo_MarkEvaluation.Size = new System.Drawing.Size(116, 107);
            this.piclogo_MarkEvaluation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.piclogo_MarkEvaluation.TabIndex = 10;
            this.piclogo_MarkEvaluation.TabStop = false;
            // 
            // pnl_Evaluation
            // 
            this.pnl_Evaluation.Controls.Add(this.num_Weightage);
            this.pnl_Evaluation.Controls.Add(this.num_TotalMarks);
            this.pnl_Evaluation.Controls.Add(this.txt_EvaluationType);
            this.pnl_Evaluation.Controls.Add(this.lbl_EvaluationType);
            this.pnl_Evaluation.Controls.Add(this.lbl_Weightage);
            this.pnl_Evaluation.Controls.Add(this.lbl_TotalMarks);
            this.pnl_Evaluation.Location = new System.Drawing.Point(351, 132);
            this.pnl_Evaluation.Name = "pnl_Evaluation";
            this.pnl_Evaluation.Size = new System.Drawing.Size(391, 162);
            this.pnl_Evaluation.TabIndex = 16;
            // 
            // lbl_Weightage
            // 
            this.lbl_Weightage.AutoSize = true;
            this.lbl_Weightage.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Weightage.Location = new System.Drawing.Point(57, 131);
            this.lbl_Weightage.Name = "lbl_Weightage";
            this.lbl_Weightage.Size = new System.Drawing.Size(89, 17);
            this.lbl_Weightage.TabIndex = 15;
            this.lbl_Weightage.Text = "Weightage %";
            // 
            // lbl_TotalMarks
            // 
            this.lbl_TotalMarks.AutoSize = true;
            this.lbl_TotalMarks.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalMarks.Location = new System.Drawing.Point(54, 74);
            this.lbl_TotalMarks.Name = "lbl_TotalMarks";
            this.lbl_TotalMarks.Size = new System.Drawing.Size(78, 17);
            this.lbl_TotalMarks.TabIndex = 2;
            this.lbl_TotalMarks.Text = "Total Marks";
            // 
            // lbl_EvaluationType
            // 
            this.lbl_EvaluationType.AutoSize = true;
            this.lbl_EvaluationType.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EvaluationType.Location = new System.Drawing.Point(54, 29);
            this.lbl_EvaluationType.Name = "lbl_EvaluationType";
            this.lbl_EvaluationType.Size = new System.Drawing.Size(103, 17);
            this.lbl_EvaluationType.TabIndex = 17;
            this.lbl_EvaluationType.Text = "Evaluation Type";
            // 
            // txt_EvaluationType
            // 
            this.txt_EvaluationType.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EvaluationType.Location = new System.Drawing.Point(202, 21);
            this.txt_EvaluationType.Name = "txt_EvaluationType";
            this.txt_EvaluationType.Size = new System.Drawing.Size(176, 25);
            this.txt_EvaluationType.TabIndex = 18;
            // 
            // pnl_MarkEvaluation
            // 
            this.pnl_MarkEvaluation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnl_MarkEvaluation.Controls.Add(this.Evaluation_DTP);
            this.pnl_MarkEvaluation.Controls.Add(this.lbl_AssignDate);
            this.pnl_MarkEvaluation.Controls.Add(this.num_OMarks);
            this.pnl_MarkEvaluation.Controls.Add(this.lbl_MarkGroup);
            this.pnl_MarkEvaluation.Controls.Add(this.Eva_CmbSelectEvaluation);
            this.pnl_MarkEvaluation.Controls.Add(this.lbl_OMark);
            this.pnl_MarkEvaluation.Controls.Add(this.Eva_CmbMarkGroup);
            this.pnl_MarkEvaluation.Controls.Add(this.lbl_SelectEvaluation);
            this.pnl_MarkEvaluation.Location = new System.Drawing.Point(28, 307);
            this.pnl_MarkEvaluation.Name = "pnl_MarkEvaluation";
            this.pnl_MarkEvaluation.Size = new System.Drawing.Size(379, 182);
            this.pnl_MarkEvaluation.TabIndex = 19;
            // 
            // lbl_MarkGroup
            // 
            this.lbl_MarkGroup.AutoSize = true;
            this.lbl_MarkGroup.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MarkGroup.Location = new System.Drawing.Point(54, 29);
            this.lbl_MarkGroup.Name = "lbl_MarkGroup";
            this.lbl_MarkGroup.Size = new System.Drawing.Size(81, 17);
            this.lbl_MarkGroup.TabIndex = 17;
            this.lbl_MarkGroup.Text = "Mark Group";
            // 
            // Eva_CmbSelectEvaluation
            // 
            this.Eva_CmbSelectEvaluation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Eva_CmbSelectEvaluation.FormattingEnabled = true;
            this.Eva_CmbSelectEvaluation.Location = new System.Drawing.Point(202, 70);
            this.Eva_CmbSelectEvaluation.Name = "Eva_CmbSelectEvaluation";
            this.Eva_CmbSelectEvaluation.Size = new System.Drawing.Size(142, 21);
            this.Eva_CmbSelectEvaluation.TabIndex = 16;
            // 
            // lbl_OMark
            // 
            this.lbl_OMark.AutoSize = true;
            this.lbl_OMark.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OMark.Location = new System.Drawing.Point(55, 119);
            this.lbl_OMark.Name = "lbl_OMark";
            this.lbl_OMark.Size = new System.Drawing.Size(109, 17);
            this.lbl_OMark.TabIndex = 15;
            this.lbl_OMark.Text = "Obtained Marks ";
            // 
            // Eva_CmbMarkGroup
            // 
            this.Eva_CmbMarkGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Eva_CmbMarkGroup.FormattingEnabled = true;
            this.Eva_CmbMarkGroup.Location = new System.Drawing.Point(201, 23);
            this.Eva_CmbMarkGroup.Name = "Eva_CmbMarkGroup";
            this.Eva_CmbMarkGroup.Size = new System.Drawing.Size(142, 21);
            this.Eva_CmbMarkGroup.TabIndex = 14;
            // 
            // lbl_SelectEvaluation
            // 
            this.lbl_SelectEvaluation.AutoSize = true;
            this.lbl_SelectEvaluation.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SelectEvaluation.Location = new System.Drawing.Point(54, 74);
            this.lbl_SelectEvaluation.Name = "lbl_SelectEvaluation";
            this.lbl_SelectEvaluation.Size = new System.Drawing.Size(110, 17);
            this.lbl_SelectEvaluation.TabIndex = 2;
            this.lbl_SelectEvaluation.Text = "Select Evaluation";
            // 
            // num_OMarks
            // 
            this.num_OMarks.DecimalPlaces = 2;
            this.num_OMarks.Location = new System.Drawing.Point(202, 114);
            this.num_OMarks.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.num_OMarks.Name = "num_OMarks";
            this.num_OMarks.Size = new System.Drawing.Size(120, 20);
            this.num_OMarks.TabIndex = 18;
            this.num_OMarks.ThousandsSeparator = true;
            // 
            // num_TotalMarks
            // 
            this.num_TotalMarks.DecimalPlaces = 2;
            this.num_TotalMarks.Location = new System.Drawing.Point(202, 77);
            this.num_TotalMarks.Name = "num_TotalMarks";
            this.num_TotalMarks.Size = new System.Drawing.Size(120, 20);
            this.num_TotalMarks.TabIndex = 19;
            this.num_TotalMarks.ThousandsSeparator = true;
            // 
            // num_Weightage
            // 
            this.num_Weightage.DecimalPlaces = 2;
            this.num_Weightage.Location = new System.Drawing.Point(202, 127);
            this.num_Weightage.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.num_Weightage.Name = "num_Weightage";
            this.num_Weightage.Size = new System.Drawing.Size(120, 20);
            this.num_Weightage.TabIndex = 20;
            this.num_Weightage.ThousandsSeparator = true;
            // 
            // pnl_btnEvaluation
            // 
            this.pnl_btnEvaluation.Controls.Add(this.btn_DeleteEvaluation);
            this.pnl_btnEvaluation.Controls.Add(this.btn_AddEvaluation);
            this.pnl_btnEvaluation.Controls.Add(this.btn_UpdateEvaluation);
            this.pnl_btnEvaluation.Location = new System.Drawing.Point(793, 230);
            this.pnl_btnEvaluation.Name = "pnl_btnEvaluation";
            this.pnl_btnEvaluation.Size = new System.Drawing.Size(148, 222);
            this.pnl_btnEvaluation.TabIndex = 21;
            // 
            // btn_AddEvaluation
            // 
            this.btn_AddEvaluation.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_AddEvaluation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddEvaluation.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddEvaluation.Location = new System.Drawing.Point(2, 20);
            this.btn_AddEvaluation.Name = "btn_AddEvaluation";
            this.btn_AddEvaluation.Size = new System.Drawing.Size(144, 44);
            this.btn_AddEvaluation.TabIndex = 15;
            this.btn_AddEvaluation.Text = "Add Evaluation";
            this.btn_AddEvaluation.UseVisualStyleBackColor = false;
            this.btn_AddEvaluation.Click += new System.EventHandler(this.btn_AddEval_Click);
            // 
            // btn_UpdateEvaluation
            // 
            this.btn_UpdateEvaluation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_UpdateEvaluation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UpdateEvaluation.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UpdateEvaluation.Location = new System.Drawing.Point(2, 93);
            this.btn_UpdateEvaluation.Name = "btn_UpdateEvaluation";
            this.btn_UpdateEvaluation.Size = new System.Drawing.Size(144, 44);
            this.btn_UpdateEvaluation.TabIndex = 2;
            this.btn_UpdateEvaluation.Text = "Update Evaluation";
            this.btn_UpdateEvaluation.UseVisualStyleBackColor = false;
            this.btn_UpdateEvaluation.Click += new System.EventHandler(this.btn_UpdateEval_Click);
            // 
            // dgv_ManageEvaluations
            // 
            this.dgv_ManageEvaluations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ManageEvaluations.BackgroundColor = System.Drawing.Color.White;
            this.dgv_ManageEvaluations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ManageEvaluations.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_ManageEvaluations.Location = new System.Drawing.Point(0, 506);
            this.dgv_ManageEvaluations.Name = "dgv_ManageEvaluations";
            this.dgv_ManageEvaluations.ReadOnly = true;
            this.dgv_ManageEvaluations.RowHeadersVisible = false;
            this.dgv_ManageEvaluations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ManageEvaluations.Size = new System.Drawing.Size(984, 105);
            this.dgv_ManageEvaluations.TabIndex = 22;
            this.dgv_ManageEvaluations.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ManageEvaluations_CellClick);
            // 
            // btn_DeleteEvaluation
            // 
            this.btn_DeleteEvaluation.BackColor = System.Drawing.Color.Red;
            this.btn_DeleteEvaluation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeleteEvaluation.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteEvaluation.Location = new System.Drawing.Point(2, 161);
            this.btn_DeleteEvaluation.Name = "btn_DeleteEvaluation";
            this.btn_DeleteEvaluation.Size = new System.Drawing.Size(144, 44);
            this.btn_DeleteEvaluation.TabIndex = 16;
            this.btn_DeleteEvaluation.Text = "DeleteEvaluation";
            this.btn_DeleteEvaluation.UseVisualStyleBackColor = false;
            this.btn_DeleteEvaluation.Click += new System.EventHandler(this.btn_DeleteEval_Click);
            // 
            // lbl_AssignDate
            // 
            this.lbl_AssignDate.AutoSize = true;
            this.lbl_AssignDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AssignDate.Location = new System.Drawing.Point(55, 150);
            this.lbl_AssignDate.Name = "lbl_AssignDate";
            this.lbl_AssignDate.Size = new System.Drawing.Size(36, 17);
            this.lbl_AssignDate.TabIndex = 19;
            this.lbl_AssignDate.Text = "Date";
            // 
            // Evaluation_DTP
            // 
            this.Evaluation_DTP.Location = new System.Drawing.Point(160, 150);
            this.Evaluation_DTP.Name = "Evaluation_DTP";
            this.Evaluation_DTP.Size = new System.Drawing.Size(200, 20);
            this.Evaluation_DTP.TabIndex = 20;
            // 
            // btn_AssignMark
            // 
            this.btn_AssignMark.BackColor = System.Drawing.Color.Green;
            this.btn_AssignMark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AssignMark.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AssignMark.Location = new System.Drawing.Point(430, 346);
            this.btn_AssignMark.Name = "btn_AssignMark";
            this.btn_AssignMark.Size = new System.Drawing.Size(144, 44);
            this.btn_AssignMark.TabIndex = 17;
            this.btn_AssignMark.Text = "Assign Marks";
            this.btn_AssignMark.UseVisualStyleBackColor = false;
            this.btn_AssignMark.Click += new System.EventHandler(this.btn_AssignMarks_Click);
            // 
            // btn_DeleteMark
            // 
            this.btn_DeleteMark.BackColor = System.Drawing.Color.Fuchsia;
            this.btn_DeleteMark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeleteMark.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteMark.Location = new System.Drawing.Point(430, 408);
            this.btn_DeleteMark.Name = "btn_DeleteMark";
            this.btn_DeleteMark.Size = new System.Drawing.Size(144, 44);
            this.btn_DeleteMark.TabIndex = 23;
            this.btn_DeleteMark.Text = "Delete Marks";
            this.btn_DeleteMark.UseVisualStyleBackColor = false;
            this.btn_DeleteMark.Click += new System.EventHandler(this.btn_DeleteMark_Click);
            // 
            // MarkEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.btn_DeleteMark);
            this.Controls.Add(this.btn_AssignMark);
            this.Controls.Add(this.dgv_ManageEvaluations);
            this.Controls.Add(this.pnl_btnEvaluation);
            this.Controls.Add(this.pnl_MarkEvaluation);
            this.Controls.Add(this.pnl_Evaluation);
            this.Controls.Add(this.piclogo_MarkEvaluation);
            this.Controls.Add(this.pnl_heading);
            this.Controls.Add(this.btn_Back);
            this.Name = "MarkEvaluation";
            this.Text = "MarkEvaluation";
            this.Load += new System.EventHandler(this.MarkEvaluation_Load);
            this.Click += new System.EventHandler(this.MarkEvaluation_Load);
            this.pnl_heading.ResumeLayout(false);
            this.pnl_heading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo_MarkEvaluation)).EndInit();
            this.pnl_Evaluation.ResumeLayout(false);
            this.pnl_Evaluation.PerformLayout();
            this.pnl_MarkEvaluation.ResumeLayout(false);
            this.pnl_MarkEvaluation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_OMarks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_TotalMarks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Weightage)).EndInit();
            this.pnl_btnEvaluation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ManageEvaluations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Panel pnl_heading;
        private System.Windows.Forms.Label lbl_heading;
        private System.Windows.Forms.PictureBox piclogo_MarkEvaluation;
        private System.Windows.Forms.Panel pnl_Evaluation;
        private System.Windows.Forms.Label lbl_EvaluationType;
        private System.Windows.Forms.Label lbl_Weightage;
        private System.Windows.Forms.Label lbl_TotalMarks;
        private System.Windows.Forms.TextBox txt_EvaluationType;
        private System.Windows.Forms.Panel pnl_MarkEvaluation;
        private System.Windows.Forms.Label lbl_MarkGroup;
        private System.Windows.Forms.ComboBox Eva_CmbSelectEvaluation;
        private System.Windows.Forms.Label lbl_OMark;
        private System.Windows.Forms.ComboBox Eva_CmbMarkGroup;
        private System.Windows.Forms.Label lbl_SelectEvaluation;
        private System.Windows.Forms.NumericUpDown num_Weightage;
        private System.Windows.Forms.NumericUpDown num_TotalMarks;
        private System.Windows.Forms.NumericUpDown num_OMarks;
        private System.Windows.Forms.Panel pnl_btnEvaluation;
        private System.Windows.Forms.Button btn_AddEvaluation;
        private System.Windows.Forms.Button btn_UpdateEvaluation;
        private System.Windows.Forms.DataGridView dgv_ManageEvaluations;
        private System.Windows.Forms.Button btn_DeleteEvaluation;
        private System.Windows.Forms.DateTimePicker Evaluation_DTP;
        private System.Windows.Forms.Label lbl_AssignDate;
        private System.Windows.Forms.Button btn_AssignMark;
        private System.Windows.Forms.Button btn_DeleteMark;
    }
}