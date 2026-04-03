namespace MidDb_2025CS231.UI
{
    partial class ResultForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultForm));
            this.btn_Back = new System.Windows.Forms.Button();
            this.pnl_heading = new System.Windows.Forms.Panel();
            this.lbl_heading = new System.Windows.Forms.Label();
            this.piclogo_MarkEvaluation = new System.Windows.Forms.PictureBox();
            this.pnl_Result = new System.Windows.Forms.Panel();
            this.Res_CmbGroupID = new System.Windows.Forms.ComboBox();
            this.lbl_GroupID = new System.Windows.Forms.Label();
            this.pnl_btnResult = new System.Windows.Forms.Panel();
            this.btn_ExportExcel = new System.Windows.Forms.Button();
            this.dgv_Results = new System.Windows.Forms.DataGridView();
            this.dgv_GroupResults = new System.Windows.Forms.DataGridView();
            this.pnl_heading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo_MarkEvaluation)).BeginInit();
            this.pnl_Result.SuspendLayout();
            this.pnl_btnResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Results)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GroupResults)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_Back.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(56, 34);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(109, 34);
            this.btn_Back.TabIndex = 9;
            this.btn_Back.Text = " <---  Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // pnl_heading
            // 
            this.pnl_heading.BackColor = System.Drawing.Color.SteelBlue;
            this.pnl_heading.Controls.Add(this.lbl_heading);
            this.pnl_heading.Location = new System.Drawing.Point(352, 37);
            this.pnl_heading.Name = "pnl_heading";
            this.pnl_heading.Size = new System.Drawing.Size(78, 35);
            this.pnl_heading.TabIndex = 10;
            // 
            // lbl_heading
            // 
            this.lbl_heading.AutoSize = true;
            this.lbl_heading.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_heading.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_heading.Location = new System.Drawing.Point(0, 0);
            this.lbl_heading.Name = "lbl_heading";
            this.lbl_heading.Size = new System.Drawing.Size(74, 25);
            this.lbl_heading.TabIndex = 0;
            this.lbl_heading.Text = "Results";
            this.lbl_heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // piclogo_MarkEvaluation
            // 
            this.piclogo_MarkEvaluation.BackColor = System.Drawing.Color.White;
            this.piclogo_MarkEvaluation.Image = ((System.Drawing.Image)(resources.GetObject("piclogo_MarkEvaluation.Image")));
            this.piclogo_MarkEvaluation.Location = new System.Drawing.Point(804, 37);
            this.piclogo_MarkEvaluation.Name = "piclogo_MarkEvaluation";
            this.piclogo_MarkEvaluation.Size = new System.Drawing.Size(116, 107);
            this.piclogo_MarkEvaluation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.piclogo_MarkEvaluation.TabIndex = 11;
            this.piclogo_MarkEvaluation.TabStop = false;
            // 
            // pnl_Result
            // 
            this.pnl_Result.Controls.Add(this.Res_CmbGroupID);
            this.pnl_Result.Controls.Add(this.lbl_GroupID);
            this.pnl_Result.Location = new System.Drawing.Point(185, 172);
            this.pnl_Result.Name = "pnl_Result";
            this.pnl_Result.Size = new System.Drawing.Size(391, 75);
            this.pnl_Result.TabIndex = 17;
            // 
            // Res_CmbGroupID
            // 
            this.Res_CmbGroupID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Res_CmbGroupID.FormattingEnabled = true;
            this.Res_CmbGroupID.Location = new System.Drawing.Point(204, 26);
            this.Res_CmbGroupID.Name = "Res_CmbGroupID";
            this.Res_CmbGroupID.Size = new System.Drawing.Size(142, 21);
            this.Res_CmbGroupID.TabIndex = 19;
            // 
            // lbl_GroupID
            // 
            this.lbl_GroupID.AutoSize = true;
            this.lbl_GroupID.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GroupID.Location = new System.Drawing.Point(54, 29);
            this.lbl_GroupID.Name = "lbl_GroupID";
            this.lbl_GroupID.Size = new System.Drawing.Size(63, 17);
            this.lbl_GroupID.TabIndex = 17;
            this.lbl_GroupID.Text = "Group ID";
            // 
            // pnl_btnResult
            // 
            this.pnl_btnResult.Controls.Add(this.btn_ExportExcel);
            this.pnl_btnResult.Location = new System.Drawing.Point(628, 155);
            this.pnl_btnResult.Name = "pnl_btnResult";
            this.pnl_btnResult.Size = new System.Drawing.Size(148, 64);
            this.pnl_btnResult.TabIndex = 22;
            // 
            // btn_ExportExcel
            // 
            this.btn_ExportExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_ExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ExportExcel.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExportExcel.Location = new System.Drawing.Point(0, 9);
            this.btn_ExportExcel.Name = "btn_ExportExcel";
            this.btn_ExportExcel.Size = new System.Drawing.Size(144, 44);
            this.btn_ExportExcel.TabIndex = 2;
            this.btn_ExportExcel.Text = "Export Excel";
            this.btn_ExportExcel.UseVisualStyleBackColor = false;
            this.btn_ExportExcel.Click += new System.EventHandler(this.btn_ExportExcel_Click);
            // 
            // dgv_Results
            // 
            this.dgv_Results.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Results.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Results.Location = new System.Drawing.Point(0, 315);
            this.dgv_Results.Name = "dgv_Results";
            this.dgv_Results.ReadOnly = true;
            this.dgv_Results.RowHeadersVisible = false;
            this.dgv_Results.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Results.Size = new System.Drawing.Size(481, 296);
            this.dgv_Results.TabIndex = 23;
            this.dgv_Results.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Results_CellClick);
            // 
            // dgv_GroupResults
            // 
            this.dgv_GroupResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_GroupResults.BackgroundColor = System.Drawing.Color.White;
            this.dgv_GroupResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_GroupResults.Location = new System.Drawing.Point(487, 315);
            this.dgv_GroupResults.Name = "dgv_GroupResults";
            this.dgv_GroupResults.ReadOnly = true;
            this.dgv_GroupResults.RowHeadersVisible = false;
            this.dgv_GroupResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_GroupResults.Size = new System.Drawing.Size(497, 296);
            this.dgv_GroupResults.TabIndex = 24;
            this.dgv_GroupResults.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_GroupResults_CellClick);
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.dgv_GroupResults);
            this.Controls.Add(this.dgv_Results);
            this.Controls.Add(this.pnl_btnResult);
            this.Controls.Add(this.pnl_Result);
            this.Controls.Add(this.piclogo_MarkEvaluation);
            this.Controls.Add(this.pnl_heading);
            this.Controls.Add(this.btn_Back);
            this.Name = "ResultForm";
            this.Text = "Result";
            this.Load += new System.EventHandler(this.ResultForm_Load);
            this.pnl_heading.ResumeLayout(false);
            this.pnl_heading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo_MarkEvaluation)).EndInit();
            this.pnl_Result.ResumeLayout(false);
            this.pnl_Result.PerformLayout();
            this.pnl_btnResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Results)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GroupResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Panel pnl_heading;
        private System.Windows.Forms.Label lbl_heading;
        private System.Windows.Forms.PictureBox piclogo_MarkEvaluation;
        private System.Windows.Forms.Panel pnl_Result;
        private System.Windows.Forms.Label lbl_GroupID;
        private System.Windows.Forms.ComboBox Res_CmbGroupID;
        private System.Windows.Forms.Panel pnl_btnResult;
        private System.Windows.Forms.Button btn_ExportExcel;
        private System.Windows.Forms.DataGridView dgv_Results;
        private System.Windows.Forms.DataGridView dgv_GroupResults;
    }
}