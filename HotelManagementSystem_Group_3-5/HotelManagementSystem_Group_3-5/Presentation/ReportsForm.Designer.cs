
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
            this.panelSub = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewReports = new System.Windows.Forms.DataGridView();
            this.reportsStartDate = new System.Windows.Forms.DateTimePicker();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panelReport.SuspendLayout();
            this.panelSub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReports)).BeginInit();
            this.SuspendLayout();
            // 
            // panelReport
            // 
            this.panelReport.BackColor = System.Drawing.Color.SteelBlue;
            this.panelReport.Controls.Add(this.label1);
            this.panelReport.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelReport.Location = new System.Drawing.Point(209, 102);
            this.panelReport.Name = "panelReport";
            this.panelReport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelReport.Size = new System.Drawing.Size(540, 41);
            this.panelReport.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reports";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(625, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Report Type :";
            // 
            // comboBoxReportType
            // 
            this.comboBoxReportType.FormattingEnabled = true;
            this.comboBoxReportType.Location = new System.Drawing.Point(628, 168);
            this.comboBoxReportType.Name = "comboBoxReportType";
            this.comboBoxReportType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxReportType.TabIndex = 2;
            // 
            // panelSub
            // 
            this.panelSub.Controls.Add(this.label3);
            this.panelSub.Location = new System.Drawing.Point(209, 202);
            this.panelSub.Name = "panelSub";
            this.panelSub.Size = new System.Drawing.Size(540, 41);
            this.panelSub.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(174, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Occupancy Levels Report";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(206, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Generated By:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(523, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Generation Date:";
            // 
            // dataGridViewReports
            // 
            this.dataGridViewReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReports.Location = new System.Drawing.Point(209, 289);
            this.dataGridViewReports.Name = "dataGridViewReports";
            this.dataGridViewReports.Size = new System.Drawing.Size(540, 163);
            this.dataGridViewReports.TabIndex = 6;
            // 
            // reportsStartDate
            // 
            this.reportsStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.reportsStartDate.Location = new System.Drawing.Point(273, 167);
            this.reportsStartDate.Name = "reportsStartDate";
            this.reportsStartDate.Size = new System.Drawing.Size(114, 20);
            this.reportsStartDate.TabIndex = 7;
            // 
            // endDatePicker
            // 
            this.endDatePicker.CalendarTrailingForeColor = System.Drawing.Color.Transparent;
            this.endDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDatePicker.Location = new System.Drawing.Point(472, 169);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(110, 20);
            this.endDatePicker.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(209, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Start Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(411, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "End Date:";
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 466);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.endDatePicker);
            this.Controls.Add(this.reportsStartDate);
            this.Controls.Add(this.dataGridViewReports);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panelSub);
            this.Controls.Add(this.comboBoxReportType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelReport);
            this.Name = "ReportsForm";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.ReportsForm_Load);
            this.panelReport.ResumeLayout(false);
            this.panelReport.PerformLayout();
            this.panelSub.ResumeLayout(false);
            this.panelSub.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxReportType;
        private System.Windows.Forms.Panel panelSub;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewReports;
        private System.Windows.Forms.DateTimePicker reportsStartDate;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}