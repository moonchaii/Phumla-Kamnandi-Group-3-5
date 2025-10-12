using System.Drawing;
using System.Windows.Forms;
// Group 3-5
// Members:
// Shakila Africa : AFRSHA001
// Chai Europa : ERPTEA001
// Lilitha Somana : SMNBON004
// Lindani Xaba : XBXLIN006
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
            this.header = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.headerName = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(864, 518);
            this.panel1.TabIndex = 0;
            // 
            // makeBookingButton
            // 
            this.makeBookingButton.BackColor = System.Drawing.Color.Transparent;
            this.makeBookingButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeBookingButton.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.makeBookingButton.Location = new System.Drawing.Point(3, 6);
            this.makeBookingButton.Name = "makeBookingButton";
            this.makeBookingButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.makeBookingButton.Size = new System.Drawing.Size(153, 46);
            this.makeBookingButton.TabIndex = 1;
            this.makeBookingButton.Text = "Add Booking";
            this.makeBookingButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.makeBookingButton.UseVisualStyleBackColor = false;
            this.makeBookingButton.Click += new System.EventHandler(this.makeBookingButton_Click);
            // 
            // changeBookingButton
            // 
            this.changeBookingButton.BackColor = System.Drawing.Color.Transparent;
            this.changeBookingButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeBookingButton.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.changeBookingButton.Location = new System.Drawing.Point(0, 55);
            this.changeBookingButton.Name = "changeBookingButton";
            this.changeBookingButton.Size = new System.Drawing.Size(156, 49);
            this.changeBookingButton.TabIndex = 2;
            this.changeBookingButton.Text = "Edit Booking";
            this.changeBookingButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.changeBookingButton.UseVisualStyleBackColor = false;
            this.changeBookingButton.Click += new System.EventHandler(this.changeBookingButton_Click_1);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Transparent;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.cancelButton.Location = new System.Drawing.Point(3, 110);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(153, 49);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancellations";
            this.cancelButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // enquiryButton
            // 
            this.enquiryButton.BackColor = System.Drawing.Color.Transparent;
            this.enquiryButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enquiryButton.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.enquiryButton.Location = new System.Drawing.Point(3, 165);
            this.enquiryButton.Name = "enquiryButton";
            this.enquiryButton.Size = new System.Drawing.Size(153, 49);
            this.enquiryButton.TabIndex = 4;
            this.enquiryButton.Text = "Enquiries";
            this.enquiryButton.UseVisualStyleBackColor = false;
            this.enquiryButton.Click += new System.EventHandler(this.enquiryButton_Click);
            // 
            // reportButton
            // 
            this.reportButton.BackColor = System.Drawing.Color.Transparent;
            this.reportButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportButton.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.reportButton.Location = new System.Drawing.Point(3, 220);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(153, 49);
            this.reportButton.TabIndex = 5;
            this.reportButton.Text = "Reports";
            this.reportButton.UseVisualStyleBackColor = false;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.LightSkyBlue;
            this.header.Controls.Add(this.pictureBox1);
            this.header.Controls.Add(this.headerName);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(864, 88);
            this.header.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::HotelManagementSystem_Group_3_5.Properties.Resources.hotel_icon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::HotelManagementSystem_Group_3_5.Properties.Resources.hotel_icon2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // headerName
            // 
            this.headerName.AutoSize = true;
            this.headerName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.headerName.Location = new System.Drawing.Point(157, 21);
            this.headerName.Name = "headerName";
            this.headerName.Size = new System.Drawing.Size(510, 37);
            this.headerName.TabIndex = 9;
            this.headerName.Text = "Phumla Kamnandi Reservation System";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.pictureBox6);
            this.panel4.Controls.Add(this.pictureBox5);
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.reportButton);
            this.panel4.Controls.Add(this.changeBookingButton);
            this.panel4.Controls.Add(this.enquiryButton);
            this.panel4.Controls.Add(this.cancelButton);
            this.panel4.Controls.Add(this.makeBookingButton);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 88);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(159, 430);
            this.panel4.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox7);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 371);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(159, 59);
            this.panel2.TabIndex = 10;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::HotelManagementSystem_Group_3_5.Properties.Resources.sign_in1;
            this.pictureBox7.Location = new System.Drawing.Point(58, 3);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(38, 31);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 2;
            this.pictureBox7.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(29, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sarah Parker";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox2.Image = global::HotelManagementSystem_Group_3_5.Properties.Resources.reservation_icon_17;
            this.pictureBox2.Location = new System.Drawing.Point(12, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.Image = global::HotelManagementSystem_Group_3_5.Properties.Resources.report_icon;
            this.pictureBox6.Location = new System.Drawing.Point(12, 233);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(25, 22);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 9;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.Image = global::HotelManagementSystem_Group_3_5.Properties.Resources.enquiry;
            this.pictureBox5.Location = new System.Drawing.Point(12, 179);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(25, 22);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Image = global::HotelManagementSystem_Group_3_5.Properties.Resources.cancel_booking;
            this.pictureBox4.Location = new System.Drawing.Point(12, 121);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 22);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = global::HotelManagementSystem_Group_3_5.Properties.Resources.change_booking;
            this.pictureBox3.Location = new System.Drawing.Point(12, 67);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 23);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 518);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.header);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private Panel panel4;
        private Label headerName;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Panel panel2;
        private PictureBox pictureBox7;
        private Label label2;
        private Label label1;
    }
}