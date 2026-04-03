namespace MidDb_2025CS231.Reports
{
    partial class Report_1Form
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnload = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MidDb_2025CS231.Reports.Report_1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(75, 110);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(551, 324);
            this.reportViewer1.TabIndex = 0;
            // 
            // btnload
            // 
            this.btnload.BackColor = System.Drawing.Color.Orange;
            this.btnload.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnload.Location = new System.Drawing.Point(670, 212);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(110, 43);
            this.btnload.TabIndex = 1;
            this.btnload.Text = "Load";
            this.btnload.UseVisualStyleBackColor = false;
            this.btnload.Click += new System.EventHandler(this.btnload_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Green;
            this.btnback.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(29, 22);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(110, 40);
            this.btnback.TabIndex = 2;
            this.btnback.Text = "<--Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // Report_1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 462);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnload);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Report_1Form";
            this.Text = "Report_1Form";
            this.Load += new System.EventHandler(this.Report_1Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnload;
        private System.Windows.Forms.Button btnback;
    }
}