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
            panel1 = new Panel();
            makeBookingButton = new Button();
            changeBookingButton = new Button();
            cancelButton = new Button();
            enquiryButton = new Button();
            reportButton = new Button();
            pictureBox1 = new PictureBox();
            header = new Panel();
            headerName = new Label();
            panel3 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            header.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(778, 494);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // makeBookingButton
            // 
            makeBookingButton.BackColor = Color.Thistle;
            makeBookingButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            makeBookingButton.ForeColor = SystemColors.ButtonHighlight;
            makeBookingButton.Location = new Point(0, 0);
            makeBookingButton.Name = "makeBookingButton";
            makeBookingButton.Size = new Size(138, 39);
            makeBookingButton.TabIndex = 1;
            makeBookingButton.Text = "Make Booking";
            makeBookingButton.UseVisualStyleBackColor = false;
            makeBookingButton.Click += button1_Click;
            // 
            // changeBookingButton
            // 
            changeBookingButton.BackColor = Color.Thistle;
            changeBookingButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            changeBookingButton.ForeColor = SystemColors.ButtonHighlight;
            changeBookingButton.Location = new Point(0, 33);
            changeBookingButton.Name = "changeBookingButton";
            changeBookingButton.Size = new Size(138, 43);
            changeBookingButton.TabIndex = 2;
            changeBookingButton.Text = "Change Booking";
            changeBookingButton.UseVisualStyleBackColor = false;
            changeBookingButton.Click += changeBookingButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.Thistle;
            cancelButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelButton.ForeColor = SystemColors.ButtonHighlight;
            cancelButton.Location = new Point(0, 72);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(138, 45);
            cancelButton.TabIndex = 3;
            cancelButton.Text = "Cancellations";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // enquiryButton
            // 
            enquiryButton.BackColor = Color.Thistle;
            enquiryButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            enquiryButton.ForeColor = SystemColors.ButtonHighlight;
            enquiryButton.Location = new Point(0, 113);
            enquiryButton.Name = "enquiryButton";
            enquiryButton.Size = new Size(138, 43);
            enquiryButton.TabIndex = 4;
            enquiryButton.Text = "Enquiries";
            enquiryButton.UseVisualStyleBackColor = false;
            enquiryButton.Click += enquiryButton_Click;
            // 
            // reportButton
            // 
            reportButton.BackColor = Color.Thistle;
            reportButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reportButton.ForeColor = SystemColors.ButtonHighlight;
            reportButton.Location = new Point(0, 151);
            reportButton.Name = "reportButton";
            reportButton.Size = new Size(138, 43);
            reportButton.TabIndex = 5;
            reportButton.Text = "Reports";
            reportButton.UseVisualStyleBackColor = false;
            reportButton.Click += reportButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.hotel_icon;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(138, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // header
            // 
            header.BackColor = Color.Thistle;
            header.Controls.Add(headerName);
            header.Controls.Add(panel3);
            header.Controls.Add(pictureBox1);
            header.Controls.Add(panel2);
            header.Dock = DockStyle.Top;
            header.Location = new Point(0, 0);
            header.Name = "header";
            header.Size = new Size(778, 75);
            header.TabIndex = 7;
            header.Paint += header_Paint;
            // 
            // headerName
            // 
            headerName.AutoSize = true;
            headerName.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            headerName.ForeColor = SystemColors.ButtonHighlight;
            headerName.Location = new Point(241, 25);
            headerName.Name = "headerName";
            headerName.Size = new Size(390, 30);
            headerName.TabIndex = 9;
            headerName.Text = "Phumla Kamnandi Reservation System";
            // 
            // panel3
            // 
            panel3.Location = new Point(0, 75);
            panel3.Name = "panel3";
            panel3.Size = new Size(152, 419);
            panel3.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.Location = new Point(3, 75);
            panel2.Name = "panel2";
            panel2.Size = new Size(138, 422);
            panel2.TabIndex = 8;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Thistle;
            panel4.Controls.Add(reportButton);
            panel4.Controls.Add(changeBookingButton);
            panel4.Controls.Add(enquiryButton);
            panel4.Controls.Add(cancelButton);
            panel4.Controls.Add(makeBookingButton);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 75);
            panel4.Name = "panel4";
            panel4.Size = new Size(138, 419);
            panel4.TabIndex = 8;
            panel4.Paint += panel4_Paint;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 494);
            Controls.Add(panel4);
            Controls.Add(header);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            header.ResumeLayout(false);
            header.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
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