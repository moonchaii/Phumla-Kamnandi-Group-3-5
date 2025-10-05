using System.Drawing;
using System.Windows.Forms;

namespace HotelManagementSystem_Group_3_5.Presentation
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.makeBookingButton = new System.Windows.Forms.Button();
            this.changeBookingButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.enquiryButton = new System.Windows.Forms.Button();
            this.reportButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.header = new System.Windows.Forms.Panel();
            this.headerName = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.header.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 428);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // makeBookingButton
            // 
            this.makeBookingButton.BackColor = System.Drawing.Color.Thistle;
            this.makeBookingButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeBookingButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.makeBookingButton.Location = new System.Drawing.Point(0, 0);
            this.makeBookingButton.Name = "makeBookingButton";
            this.makeBookingButton.Size = new System.Drawing.Size(118, 34);
            this.makeBookingButton.TabIndex = 1;
            this.makeBookingButton.Text = "Make Booking";
            this.makeBookingButton.UseVisualStyleBackColor = false;
            this.makeBookingButton.Click += new System.EventHandler(this.makeBookingButton_Click);
            // 
            // changeBookingButton
            // 
            this.changeBookingButton.BackColor = System.Drawing.Color.Thistle;
            this.changeBookingButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeBookingButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.changeBookingButton.Location = new System.Drawing.Point(0, 29);
            this.changeBookingButton.Name = "changeBookingButton";
            this.changeBookingButton.Size = new System.Drawing.Size(118, 37);
            this.changeBookingButton.TabIndex = 2;
            this.changeBookingButton.Text = "Change Booking";
            this.changeBookingButton.UseVisualStyleBackColor = false;
            this.changeBookingButton.Click += new System.EventHandler(this.changeBookingButton_Click_1);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Thistle;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancelButton.Location = new System.Drawing.Point(0, 62);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(118, 39);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancellations";
            this.cancelButton.UseVisualStyleBackColor = false;
            // 
            // enquiryButton
            // 
            this.enquiryButton.BackColor = System.Drawing.Color.Thistle;
            this.enquiryButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enquiryButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.enquiryButton.Location = new System.Drawing.Point(0, 97);
            this.enquiryButton.Name = "enquiryButton";
            this.enquiryButton.Size = new System.Drawing.Size(118, 37);
            this.enquiryButton.TabIndex = 4;
            this.enquiryButton.Text = "Enquiries";
            this.enquiryButton.UseVisualStyleBackColor = false;
            // 
            // reportButton
            // 
            this.reportButton.BackColor = System.Drawing.Color.Thistle;
            this.reportButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reportButton.Location = new System.Drawing.Point(0, 131);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(118, 37);
            this.reportButton.TabIndex = 5;
            this.reportButton.Text = "Reports";
            this.reportButton.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.Thistle;
            this.header.Controls.Add(this.headerName);
            this.header.Controls.Add(this.panel3);
            this.header.Controls.Add(this.pictureBox1);
            this.header.Controls.Add(this.panel2);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(667, 65);
            this.header.TabIndex = 7;
            // 
            // headerName
            // 
            this.headerName.AutoSize = true;
            this.headerName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.headerName.Location = new System.Drawing.Point(207, 22);
            this.headerName.Name = "headerName";
            this.headerName.Size = new System.Drawing.Size(390, 30);
            this.headerName.TabIndex = 9;
            this.headerName.Text = "Phumla Kamnandi Reservation System";
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(130, 363);
            this.panel3.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(118, 366);
            this.panel2.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Thistle;
            this.panel4.Controls.Add(this.reportButton);
            this.panel4.Controls.Add(this.changeBookingButton);
            this.panel4.Controls.Add(this.enquiryButton);
            this.panel4.Controls.Add(this.cancelButton);
            this.panel4.Controls.Add(this.makeBookingButton);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 65);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(118, 363);
            this.panel4.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 428);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.header);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button makeBookingButton;
        private Button changeBookingButton;
        private Button cancelButton;
        private Button enquiryButton;
        private Button reportButton;
        private PictureBox pictureBox1;
        private Panel header;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label headerName;
    }
}