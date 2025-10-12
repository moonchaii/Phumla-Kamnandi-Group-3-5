using System;
using System.Drawing;
using System.Windows.Forms;

namespace HotelManagementSystem_Group_3_5.Presentation
{
    partial class MakeBookingForm
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
            this.makeBookingPanel = new System.Windows.Forms.Panel();
            this.detailSelection = new System.Windows.Forms.Panel();
            this.addressbox = new System.Windows.Forms.RichTextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.makeReservationButton = new System.Windows.Forms.Button();
            this.emailtbox = new System.Windows.Forms.TextBox();
            this.phonetbox = new System.Windows.Forms.TextBox();
            this.nametbox = new System.Windows.Forms.TextBox();
            this.idtbox = new System.Windows.Forms.TextBox();
            this.IdNobox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.guestDetailsLable = new System.Windows.Forms.Label();
            this.confirmBookingButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.paymentSelection = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cvvLabel = new System.Windows.Forms.Label();
            this.creditCardTextbox = new System.Windows.Forms.TextBox();
            this.creditCardLabel = new System.Windows.Forms.Label();
            this.depositBox = new System.Windows.Forms.TextBox();
            this.depositLable = new System.Windows.Forms.Label();
            this.resNoLable = new System.Windows.Forms.Label();
            this.reservationBox = new System.Windows.Forms.TextBox();
            this.verifyButton = new System.Windows.Forms.Button();
            this.paymentLable = new System.Windows.Forms.Label();
            this.dateSelection = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checkButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxRoomType = new System.Windows.Forms.ComboBox();
            this.toDatelbl = new System.Windows.Forms.Label();
            this.fromDatelbl = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateSelectionLable = new System.Windows.Forms.Label();
            this.addGuestPanel = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.addresstbox = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panelName = new System.Windows.Forms.Label();
            this.makeBookingPanel.SuspendLayout();
            this.detailSelection.SuspendLayout();
            this.panel1.SuspendLayout();
            this.paymentSelection.SuspendLayout();
            this.dateSelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.addGuestPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // makeBookingPanel
            // 
            this.makeBookingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.makeBookingPanel.Controls.Add(this.detailSelection);
            this.makeBookingPanel.Controls.Add(this.confirmBookingButton);
            this.makeBookingPanel.Controls.Add(this.panel1);
            this.makeBookingPanel.Controls.Add(this.paymentSelection);
            this.makeBookingPanel.Controls.Add(this.dateSelection);
            this.makeBookingPanel.Controls.Add(this.addGuestPanel);
            this.makeBookingPanel.Location = new System.Drawing.Point(215, 111);
            this.makeBookingPanel.Margin = new System.Windows.Forms.Padding(4);
            this.makeBookingPanel.Name = "makeBookingPanel";
            this.makeBookingPanel.Size = new System.Drawing.Size(931, 519);
            this.makeBookingPanel.TabIndex = 2;
            // 
            // detailSelection
            // 
            this.detailSelection.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.detailSelection.Controls.Add(this.addressbox);
            this.detailSelection.Controls.Add(this.addressLabel);
            this.detailSelection.Controls.Add(this.searchButton);
            this.detailSelection.Controls.Add(this.label7);
            this.detailSelection.Controls.Add(this.label6);
            this.detailSelection.Controls.Add(this.label5);
            this.detailSelection.Controls.Add(this.label4);
            this.detailSelection.Controls.Add(this.makeReservationButton);
            this.detailSelection.Controls.Add(this.emailtbox);
            this.detailSelection.Controls.Add(this.phonetbox);
            this.detailSelection.Controls.Add(this.nametbox);
            this.detailSelection.Controls.Add(this.idtbox);
            this.detailSelection.Controls.Add(this.IdNobox);
            this.detailSelection.Controls.Add(this.label3);
            this.detailSelection.Controls.Add(this.guestDetailsLable);
            this.detailSelection.Location = new System.Drawing.Point(4, 233);
            this.detailSelection.Margin = new System.Windows.Forms.Padding(4);
            this.detailSelection.Name = "detailSelection";
            this.detailSelection.Size = new System.Drawing.Size(913, 128);
            this.detailSelection.TabIndex = 5;
            // 
            // addressbox
            // 
            this.addressbox.Location = new System.Drawing.Point(597, 38);
            this.addressbox.Margin = new System.Windows.Forms.Padding(4);
            this.addressbox.Name = "addressbox";
            this.addressbox.ReadOnly = true;
            this.addressbox.Size = new System.Drawing.Size(189, 32);
            this.addressbox.TabIndex = 15;
            this.addressbox.Text = "";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(511, 46);
            this.addressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(74, 23);
            this.addressLabel.TabIndex = 14;
            this.addressLabel.Text = "Address:";
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Transparent;
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.searchButton.Location = new System.Drawing.Point(293, 21);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(127, 39);
            this.searchButton.TabIndex = 13;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(304, 92);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Phone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(304, 66);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 97);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "ID:";
            // 
            // makeReservationButton
            // 
            this.makeReservationButton.BackColor = System.Drawing.Color.Transparent;
            this.makeReservationButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeReservationButton.ForeColor = System.Drawing.Color.SkyBlue;
            this.makeReservationButton.Location = new System.Drawing.Point(683, 85);
            this.makeReservationButton.Margin = new System.Windows.Forms.Padding(4);
            this.makeReservationButton.Name = "makeReservationButton";
            this.makeReservationButton.Size = new System.Drawing.Size(217, 38);
            this.makeReservationButton.TabIndex = 11;
            this.makeReservationButton.Text = "Make Reservation";
            this.makeReservationButton.UseVisualStyleBackColor = false;
            this.makeReservationButton.Click += new System.EventHandler(this.makeReservationButton_Click);
            // 
            // emailtbox
            // 
            this.emailtbox.Location = new System.Drawing.Point(365, 68);
            this.emailtbox.Margin = new System.Windows.Forms.Padding(4);
            this.emailtbox.Name = "emailtbox";
            this.emailtbox.ReadOnly = true;
            this.emailtbox.Size = new System.Drawing.Size(143, 22);
            this.emailtbox.TabIndex = 10;
            // 
            // phonetbox
            // 
            this.phonetbox.Location = new System.Drawing.Point(365, 94);
            this.phonetbox.Margin = new System.Windows.Forms.Padding(4);
            this.phonetbox.Name = "phonetbox";
            this.phonetbox.ReadOnly = true;
            this.phonetbox.Size = new System.Drawing.Size(137, 22);
            this.phonetbox.TabIndex = 9;
            // 
            // nametbox
            // 
            this.nametbox.Location = new System.Drawing.Point(111, 94);
            this.nametbox.Margin = new System.Windows.Forms.Padding(4);
            this.nametbox.Name = "nametbox";
            this.nametbox.ReadOnly = true;
            this.nametbox.Size = new System.Drawing.Size(171, 22);
            this.nametbox.TabIndex = 8;
            // 
            // idtbox
            // 
            this.idtbox.Location = new System.Drawing.Point(111, 63);
            this.idtbox.Margin = new System.Windows.Forms.Padding(4);
            this.idtbox.Name = "idtbox";
            this.idtbox.ReadOnly = true;
            this.idtbox.Size = new System.Drawing.Size(171, 22);
            this.idtbox.TabIndex = 7;
            // 
            // IdNobox
            // 
            this.IdNobox.Location = new System.Drawing.Point(111, 30);
            this.IdNobox.Margin = new System.Windows.Forms.Padding(4);
            this.IdNobox.Name = "IdNobox";
            this.IdNobox.Size = new System.Drawing.Size(171, 22);
            this.IdNobox.TabIndex = 6;
            this.IdNobox.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID Number:";
            // 
            // guestDetailsLable
            // 
            this.guestDetailsLable.AutoSize = true;
            this.guestDetailsLable.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestDetailsLable.Location = new System.Drawing.Point(4, 4);
            this.guestDetailsLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.guestDetailsLable.Name = "guestDetailsLable";
            this.guestDetailsLable.Size = new System.Drawing.Size(115, 23);
            this.guestDetailsLable.TabIndex = 5;
            this.guestDetailsLable.Text = "Guest Details";
            // 
            // confirmBookingButton
            // 
            this.confirmBookingButton.BackColor = System.Drawing.Color.Transparent;
            this.confirmBookingButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmBookingButton.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.confirmBookingButton.Location = new System.Drawing.Point(695, 478);
            this.confirmBookingButton.Margin = new System.Windows.Forms.Padding(4);
            this.confirmBookingButton.Name = "confirmBookingButton";
            this.confirmBookingButton.Size = new System.Drawing.Size(132, 36);
            this.confirmBookingButton.TabIndex = 7;
            this.confirmBookingButton.Text = "Confirm Booking";
            this.confirmBookingButton.UseVisualStyleBackColor = false;
            this.confirmBookingButton.Click += new System.EventHandler(this.confirmBookingButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 76);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(5, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make Booking";
            // 
            // paymentSelection
            // 
            this.paymentSelection.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.paymentSelection.Controls.Add(this.textBox1);
            this.paymentSelection.Controls.Add(this.cvvLabel);
            this.paymentSelection.Controls.Add(this.creditCardTextbox);
            this.paymentSelection.Controls.Add(this.creditCardLabel);
            this.paymentSelection.Controls.Add(this.depositBox);
            this.paymentSelection.Controls.Add(this.depositLable);
            this.paymentSelection.Controls.Add(this.resNoLable);
            this.paymentSelection.Controls.Add(this.reservationBox);
            this.paymentSelection.Controls.Add(this.verifyButton);
            this.paymentSelection.Controls.Add(this.paymentLable);
            this.paymentSelection.Location = new System.Drawing.Point(4, 363);
            this.paymentSelection.Margin = new System.Windows.Forms.Padding(4);
            this.paymentSelection.Name = "paymentSelection";
            this.paymentSelection.Size = new System.Drawing.Size(913, 106);
            this.paymentSelection.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(397, 60);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 22);
            this.textBox1.TabIndex = 21;
            // 
            // cvvLabel
            // 
            this.cvvLabel.AutoSize = true;
            this.cvvLabel.Location = new System.Drawing.Point(289, 62);
            this.cvvLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cvvLabel.Name = "cvvLabel";
            this.cvvLabel.Size = new System.Drawing.Size(37, 16);
            this.cvvLabel.TabIndex = 20;
            this.cvvLabel.Text = "CVV:";
            // 
            // creditCardTextbox
            // 
            this.creditCardTextbox.Location = new System.Drawing.Point(397, 21);
            this.creditCardTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.creditCardTextbox.Name = "creditCardTextbox";
            this.creditCardTextbox.Size = new System.Drawing.Size(113, 22);
            this.creditCardTextbox.TabIndex = 19;
            // 
            // creditCardLabel
            // 
            this.creditCardLabel.AutoSize = true;
            this.creditCardLabel.Location = new System.Drawing.Point(289, 21);
            this.creditCardLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.creditCardLabel.Name = "creditCardLabel";
            this.creditCardLabel.Size = new System.Drawing.Size(98, 16);
            this.creditCardLabel.TabIndex = 18;
            this.creditCardLabel.Text = "Credit Card No:";
            // 
            // depositBox
            // 
            this.depositBox.Location = new System.Drawing.Point(124, 53);
            this.depositBox.Margin = new System.Windows.Forms.Padding(4);
            this.depositBox.Name = "depositBox";
            this.depositBox.ReadOnly = true;
            this.depositBox.Size = new System.Drawing.Size(113, 22);
            this.depositBox.TabIndex = 17;
            // 
            // depositLable
            // 
            this.depositLable.AutoSize = true;
            this.depositLable.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositLable.Location = new System.Drawing.Point(7, 57);
            this.depositLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.depositLable.Name = "depositLable";
            this.depositLable.Size = new System.Drawing.Size(72, 23);
            this.depositLable.TabIndex = 16;
            this.depositLable.Text = "Deposit:";
            // 
            // resNoLable
            // 
            this.resNoLable.AutoSize = true;
            this.resNoLable.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resNoLable.Location = new System.Drawing.Point(4, 26);
            this.resNoLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resNoLable.Name = "resNoLable";
            this.resNoLable.Size = new System.Drawing.Size(117, 23);
            this.resNoLable.TabIndex = 15;
            this.resNoLable.Text = "Reference No:";
            // 
            // reservationBox
            // 
            this.reservationBox.Location = new System.Drawing.Point(124, 22);
            this.reservationBox.Margin = new System.Windows.Forms.Padding(4);
            this.reservationBox.Name = "reservationBox";
            this.reservationBox.ReadOnly = true;
            this.reservationBox.Size = new System.Drawing.Size(113, 22);
            this.reservationBox.TabIndex = 14;
            // 
            // verifyButton
            // 
            this.verifyButton.BackColor = System.Drawing.Color.Transparent;
            this.verifyButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verifyButton.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.verifyButton.Location = new System.Drawing.Point(688, 58);
            this.verifyButton.Margin = new System.Windows.Forms.Padding(4);
            this.verifyButton.Name = "verifyButton";
            this.verifyButton.Size = new System.Drawing.Size(97, 36);
            this.verifyButton.TabIndex = 6;
            this.verifyButton.Text = "Verify";
            this.verifyButton.UseVisualStyleBackColor = false;
            this.verifyButton.Click += new System.EventHandler(this.verifyButton_Click);
            // 
            // paymentLable
            // 
            this.paymentLable.AutoSize = true;
            this.paymentLable.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentLable.Location = new System.Drawing.Point(4, 5);
            this.paymentLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.paymentLable.Name = "paymentLable";
            this.paymentLable.Size = new System.Drawing.Size(80, 23);
            this.paymentLable.TabIndex = 5;
            this.paymentLable.Text = "Payment";
            // 
            // dateSelection
            // 
            this.dateSelection.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dateSelection.Controls.Add(this.dataGridView1);
            this.dateSelection.Controls.Add(this.checkButton);
            this.dateSelection.Controls.Add(this.label2);
            this.dateSelection.Controls.Add(this.comboBoxRoomType);
            this.dateSelection.Controls.Add(this.toDatelbl);
            this.dateSelection.Controls.Add(this.fromDatelbl);
            this.dateSelection.Controls.Add(this.dateTimePicker2);
            this.dateSelection.Controls.Add(this.dateTimePicker1);
            this.dateSelection.Controls.Add(this.dateSelectionLable);
            this.dateSelection.Location = new System.Drawing.Point(4, 84);
            this.dateSelection.Margin = new System.Windows.Forms.Padding(4);
            this.dateSelection.Name = "dateSelection";
            this.dateSelection.Size = new System.Drawing.Size(913, 147);
            this.dateSelection.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 58);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(683, 81);
            this.dataGridView1.TabIndex = 13;
            // 
            // checkButton
            // 
            this.checkButton.BackColor = System.Drawing.Color.Transparent;
            this.checkButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkButton.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.checkButton.Location = new System.Drawing.Point(616, 20);
            this.checkButton.Margin = new System.Windows.Forms.Padding(4);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(124, 36);
            this.checkButton.TabIndex = 12;
            this.checkButton.Text = "Check";
            this.checkButton.UseVisualStyleBackColor = false;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(396, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Room Type:";
            // 
            // comboBoxRoomType
            // 
            this.comboBoxRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRoomType.FormattingEnabled = true;
            this.comboBoxRoomType.Location = new System.Drawing.Point(499, 30);
            this.comboBoxRoomType.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxRoomType.Name = "comboBoxRoomType";
            this.comboBoxRoomType.Size = new System.Drawing.Size(103, 24);
            this.comboBoxRoomType.TabIndex = 10;
            // 
            // toDatelbl
            // 
            this.toDatelbl.AutoSize = true;
            this.toDatelbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDatelbl.Location = new System.Drawing.Point(215, 28);
            this.toDatelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.toDatelbl.Name = "toDatelbl";
            this.toDatelbl.Size = new System.Drawing.Size(31, 23);
            this.toDatelbl.TabIndex = 9;
            this.toDatelbl.Text = "To:";
            // 
            // fromDatelbl
            // 
            this.fromDatelbl.AutoSize = true;
            this.fromDatelbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromDatelbl.Location = new System.Drawing.Point(4, 28);
            this.fromDatelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fromDatelbl.Name = "fromDatelbl";
            this.fromDatelbl.Size = new System.Drawing.Size(53, 23);
            this.fromDatelbl.TabIndex = 8;
            this.fromDatelbl.Text = "From:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(256, 30);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(131, 22);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(63, 30);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.MinDate = new System.DateTime(2025, 9, 23, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 22);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // dateSelectionLable
            // 
            this.dateSelectionLable.AutoSize = true;
            this.dateSelectionLable.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateSelectionLable.Location = new System.Drawing.Point(4, 1);
            this.dateSelectionLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateSelectionLable.Name = "dateSelectionLable";
            this.dateSelectionLable.Size = new System.Drawing.Size(126, 23);
            this.dateSelectionLable.TabIndex = 5;
            this.dateSelectionLable.Text = "Date Selection";
            // 
            // addGuestPanel
            // 
            this.addGuestPanel.BackColor = System.Drawing.Color.Thistle;
            this.addGuestPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addGuestPanel.Controls.Add(this.cancelButton);
            this.addGuestPanel.Controls.Add(this.saveButton);
            this.addGuestPanel.Controls.Add(this.addresstbox);
            this.addGuestPanel.Controls.Add(this.label12);
            this.addGuestPanel.Controls.Add(this.label11);
            this.addGuestPanel.Controls.Add(this.label10);
            this.addGuestPanel.Controls.Add(this.label9);
            this.addGuestPanel.Controls.Add(this.label8);
            this.addGuestPanel.Controls.Add(this.textBox5);
            this.addGuestPanel.Controls.Add(this.textBox4);
            this.addGuestPanel.Controls.Add(this.textBox3);
            this.addGuestPanel.Controls.Add(this.textBox2);
            this.addGuestPanel.Controls.Add(this.panelName);
            this.addGuestPanel.Location = new System.Drawing.Point(4, 233);
            this.addGuestPanel.Margin = new System.Windows.Forms.Padding(4);
            this.addGuestPanel.Name = "addGuestPanel";
            this.addGuestPanel.Size = new System.Drawing.Size(907, 134);
            this.addGuestPanel.TabIndex = 14;
            this.addGuestPanel.Visible = false;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Plum;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancelButton.Location = new System.Drawing.Point(789, 85);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(112, 37);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Plum;
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveButton.Location = new System.Drawing.Point(656, 85);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(112, 37);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // addresstbox
            // 
            this.addresstbox.Location = new System.Drawing.Point(529, 34);
            this.addresstbox.Margin = new System.Windows.Forms.Padding(4);
            this.addresstbox.Name = "addresstbox";
            this.addresstbox.Size = new System.Drawing.Size(185, 43);
            this.addresstbox.TabIndex = 10;
            this.addresstbox.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(443, 39);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 23);
            this.label12.TabIndex = 9;
            this.label12.Text = "Address:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(216, 75);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 23);
            this.label11.TabIndex = 8;
            this.label11.Text = "Phone:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(216, 39);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 23);
            this.label10.TabIndex = 7;
            this.label10.Text = "Email:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 78);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 23);
            this.label9.TabIndex = 6;
            this.label9.Text = "Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 39);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 23);
            this.label8.TabIndex = 5;
            this.label8.Text = "ID:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(285, 71);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(132, 22);
            this.textBox5.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(285, 36);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(132, 22);
            this.textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(69, 71);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(132, 22);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(69, 39);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 22);
            this.textBox2.TabIndex = 1;
            // 
            // panelName
            // 
            this.panelName.AutoSize = true;
            this.panelName.BackColor = System.Drawing.Color.Transparent;
            this.panelName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelName.Location = new System.Drawing.Point(4, 5);
            this.panelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.panelName.Name = "panelName";
            this.panelName.Size = new System.Drawing.Size(135, 23);
            this.panelName.TabIndex = 0;
            this.panelName.Text = "Add New Guest";
            // 
            // MakeBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 677);
            this.Controls.Add(this.makeBookingPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MakeBookingForm";
            this.Text = "makeBooking";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MakeBookingForm_Load);
            this.makeBookingPanel.ResumeLayout(false);
            this.detailSelection.ResumeLayout(false);
            this.detailSelection.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.paymentSelection.ResumeLayout(false);
            this.paymentSelection.PerformLayout();
            this.dateSelection.ResumeLayout(false);
            this.dateSelection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.addGuestPanel.ResumeLayout(false);
            this.addGuestPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel makeBookingPanel;
        private Panel panel1;
        private Label label1;
        private Panel dateSelection;
        private Panel paymentSelection;
        private Panel detailSelection;
        private Label paymentLable;
        private Label guestDetailsLable;
        private Label dateSelectionLable;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label toDatelbl;
        private Label fromDatelbl;
        private ComboBox comboBoxRoomType;
        private Button checkButton;
        private Label label2;
        private DataGridView dataGridView1;
        private TextBox IdNobox;
        private Label label3;
        private TextBox emailtbox;
        private TextBox phonetbox;
        private TextBox nametbox;
        private TextBox idtbox;
        private Label label4;
        private Button makeReservationButton;
        private Label label5;
        private Label label6;
        private Button searchButton;
        private Label label7;
        private Button confirmBookingButton;
        private Button verifyButton;
        private TextBox reservationBox;
        private Label depositLable;
        private Label resNoLable;
        private Label creditCardLabel;
        private TextBox depositBox;
        private TextBox textBox1;
        private Label cvvLabel;
        private TextBox creditCardTextbox;
        private Panel addGuestPanel;
        private Label panelName;
        private Label label8;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private RichTextBox addresstbox;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Button cancelButton;
        private Button saveButton;
        private Label addressLabel;
        private RichTextBox addressbox;
    }
}