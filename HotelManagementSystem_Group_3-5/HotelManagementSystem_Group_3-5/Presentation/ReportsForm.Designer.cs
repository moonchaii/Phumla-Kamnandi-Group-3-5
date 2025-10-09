namespace HotelManagementSystem_Group_3_5.Presentation
{
    partial class ReportsForm
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
            this.panelReport = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxReportType = new System.Windows.Forms.ComboBox();
            this.panelOccupancy = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewReports = new System.Windows.Forms.DataGridView();
            this.panelReport.SuspendLayout();
            this.panelOccupancy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReports)).BeginInit();
            this.SuspendLayout();
            // 
            // panelReport
            // 
            this.panelReport.BackColor = System.Drawing.Color.Thistle;
            this.panelReport.Controls.Add(this.label1);
            this.panelReport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.panelReport.Location = new System.Drawing.Point(165, 82);
            this.panelReport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelReport.Name = "panelReport";
            this.panelReport.Size = new System.Drawing.Size(720, 50);
            this.panelReport.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(273, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reports";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(180, 165);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Report Type";
            // 
            // comboBoxReportType
            // 
            this.comboBoxReportType.FormattingEnabled = true;
            this.comboBoxReportType.Location = new System.Drawing.Point(184, 185);
            this.comboBoxReportType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxReportType.Name = "comboBoxReportType";
            this.comboBoxReportType.Size = new System.Drawing.Size(160, 24);
            this.comboBoxReportType.TabIndex = 2;
            // 
            // panelOccupancy
            // 
            this.panelOccupancy.Controls.Add(this.label3);
            this.panelOccupancy.Location = new System.Drawing.Point(165, 218);
            this.panelOccupancy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelOccupancy.Name = "panelOccupancy";
            this.panelOccupancy.Size = new System.Drawing.Size(720, 50);
            this.panelOccupancy.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(219, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Daily Occupancy Levels Report";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 289);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Generated By:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(633, 289);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Generation Date:";
            // 
            // dataGridViewReports
            // 
            this.dataGridViewReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReports.Location = new System.Drawing.Point(165, 338);
            this.dataGridViewReports.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewReports.Name = "dataGridViewReports";
            this.dataGridViewReports.RowHeadersWidth = 51;
            this.dataGridViewReports.Size = new System.Drawing.Size(720, 201);
            this.dataGridViewReports.TabIndex = 6;
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dataGridViewReports);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panelOccupancy);
            this.Controls.Add(this.comboBoxReportType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelReport);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ReportsForm";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.ReportsForm_Load);
            this.panelReport.ResumeLayout(false);
            this.panelReport.PerformLayout();
            this.panelOccupancy.ResumeLayout(false);
            this.panelOccupancy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxReportType;
        private System.Windows.Forms.Panel panelOccupancy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewReports;
    }
}