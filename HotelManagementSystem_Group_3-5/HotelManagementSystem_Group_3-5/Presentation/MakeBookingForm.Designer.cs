using System;
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
            this.makeBookingPanel.Controls.Add(this.confirmBookingButton);
            this.makeBookingPanel.Controls.Add(this.panel1);
            this.makeBookingPanel.Controls.Add(this.paymentSelection);
            this.makeBookingPanel.Controls.Add(this.dateSelection);
            this.makeBookingPanel.Controls.Add(this.detailSelection);
            this.makeBookingPanel.Controls.Add(this.addGuestPanel);
            this.makeBookingPanel.Location = new System.Drawing.Point(161, 90);
            this.makeBookingPanel.Name = "makeBookingPanel";
            this.makeBookingPanel.Size = new System.Drawing.Size(699, 422);
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
            this.detailSelection.Location = new System.Drawing.Point(3, 189);
            this.detailSelection.Name = "detailSelection";
            this.detailSelection.Size = new System.Drawing.Size(686, 105);
            this.detailSelection.TabIndex = 5;
            // 
            // addressbox
            // 
            this.addressbox.Location = new System.Drawing.Point(448, 31);
            this.addressbox.Name = "addressbox";
            this.addressbox.ReadOnly = true;
            this.addressbox.Size = new System.Drawing.Size(143, 27);
            this.addressbox.TabIndex = 15;
            this.addressbox.Text = "";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(383, 37);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(59, 17);
            this.addressLabel.TabIndex = 14;
            this.addressLabel.Text = "Address:";
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Transparent;
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.searchButton.Location = new System.Drawing.Point(220, 17);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(95, 32);
            this.searchButton.TabIndex = 13;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(228, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Phone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(228, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "ID:";
            // 
            // makeReservationButton
            // 
            this.makeReservationButton.BackColor = System.Drawing.Color.Transparent;
            this.makeReservationButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeReservationButton.ForeColor = System.Drawing.Color.SkyBlue;
            this.makeReservationButton.Location = new System.Drawing.Point(512, 69);
            this.makeReservationButton.Name = "makeReservationButton";
            this.makeReservationButton.Size = new System.Drawing.Size(163, 31);
            this.makeReservationButton.TabIndex = 11;
            this.makeReservationButton.Text = "Make Reservation";
            this.makeReservationButton.UseVisualStyleBackColor = false;
            this.makeReservationButton.Click += new System.EventHandler(this.makeReservationButton_Click);
            // 
            // emailtbox
            // 
            this.emailtbox.Location = new System.Drawing.Point(274, 55);
            this.emailtbox.Name = "emailtbox";
            this.emailtbox.ReadOnly = true;
            this.emailtbox.Size = new System.Drawing.Size(108, 20);
            this.emailtbox.TabIndex = 10;
            // 
            // phonetbox
            // 
            this.phonetbox.Location = new System.Drawing.Point(274, 76);
            this.phonetbox.Name = "phonetbox";
            this.phonetbox.ReadOnly = true;
            this.phonetbox.Size = new System.Drawing.Size(104, 20);
            this.phonetbox.TabIndex = 9;
            // 
            // nametbox
            // 
            this.nametbox.Location = new System.Drawing.Point(83, 76);
            this.nametbox.Name = "nametbox";
            this.nametbox.ReadOnly = true;
            this.nametbox.Size = new System.Drawing.Size(129, 20);
            this.nametbox.TabIndex = 8;
            // 
            // idtbox
            // 
            this.idtbox.Location = new System.Drawing.Point(83, 51);
            this.idtbox.Name = "idtbox";
            this.idtbox.ReadOnly = true;
            this.idtbox.Size = new System.Drawing.Size(129, 20);
            this.idtbox.TabIndex = 7;
            // 
            // IdNobox
            // 
            this.IdNobox.Location = new System.Drawing.Point(83, 24);
            this.IdNobox.Name = "IdNobox";
            this.IdNobox.Size = new System.Drawing.Size(129, 20);
            this.IdNobox.TabIndex = 6;
            this.IdNobox.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID Number:";
            // 
            // guestDetailsLable
            // 
            this.guestDetailsLable.AutoSize = true;
            this.guestDetailsLable.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestDetailsLable.Location = new System.Drawing.Point(3, 3);
            this.guestDetailsLable.Name = "guestDetailsLable";
            this.guestDetailsLable.Size = new System.Drawing.Size(90, 17);
            this.guestDetailsLable.TabIndex = 5;
            this.guestDetailsLable.Text = "Guest Details";
            // 
            // confirmBookingButton
            // 
            this.confirmBookingButton.BackColor = System.Drawing.Color.Transparent;
            this.confirmBookingButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmBookingButton.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.confirmBookingButton.Location = new System.Drawing.Point(521, 388);
            this.confirmBookingButton.Name = "confirmBookingButton";
            this.confirmBookingButton.Size = new System.Drawing.Size(99, 29);
            this.confirmBookingButton.TabIndex = 7;
            this.confirmBookingButton.Text = "Confirm Booking";
            this.confirmBookingButton.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(697, 62);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(4, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 32);
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
            this.paymentSelection.Location = new System.Drawing.Point(3, 295);
            this.paymentSelection.Name = "paymentSelection";
            this.paymentSelection.Size = new System.Drawing.Size(686, 87);
            this.paymentSelection.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(298, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(86, 20);
            this.textBox1.TabIndex = 21;
            // 
            // cvvLabel
            // 
            this.cvvLabel.AutoSize = true;
            this.cvvLabel.Location = new System.Drawing.Point(217, 50);
            this.cvvLabel.Name = "cvvLabel";
            this.cvvLabel.Size = new System.Drawing.Size(31, 13);
            this.cvvLabel.TabIndex = 20;
            this.cvvLabel.Text = "CVV:";
            // 
            // creditCardTextbox
            // 
            this.creditCardTextbox.Location = new System.Drawing.Point(298, 17);
            this.creditCardTextbox.Name = "creditCardTextbox";
            this.creditCardTextbox.Size = new System.Drawing.Size(86, 20);
            this.creditCardTextbox.TabIndex = 19;
            // 
            // creditCardLabel
            // 
            this.creditCardLabel.AutoSize = true;
            this.creditCardLabel.Location = new System.Drawing.Point(217, 17);
            this.creditCardLabel.Name = "creditCardLabel";
            this.creditCardLabel.Size = new System.Drawing.Size(79, 13);
            this.creditCardLabel.TabIndex = 18;
            this.creditCardLabel.Text = "Credit Card No:";
            // 
            // depositBox
            // 
            this.depositBox.Location = new System.Drawing.Point(93, 43);
            this.depositBox.Name = "depositBox";
            this.depositBox.ReadOnly = true;
            this.depositBox.Size = new System.Drawing.Size(86, 20);
            this.depositBox.TabIndex = 17;
            // 
            // depositLable
            // 
            this.depositLable.AutoSize = true;
            this.depositLable.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositLable.Location = new System.Drawing.Point(5, 46);
            this.depositLable.Name = "depositLable";
            this.depositLable.Size = new System.Drawing.Size(56, 17);
            this.depositLable.TabIndex = 16;
            this.depositLable.Text = "Deposit:";
            // 
            // resNoLable
            // 
            this.resNoLable.AutoSize = true;
            this.resNoLable.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resNoLable.Location = new System.Drawing.Point(3, 21);
            this.resNoLable.Name = "resNoLable";
            this.resNoLable.Size = new System.Drawing.Size(91, 17);
            this.resNoLable.TabIndex = 15;
            this.resNoLable.Text = "Reference No:";
            // 
            // reservationBox
            // 
            this.reservationBox.Location = new System.Drawing.Point(93, 18);
            this.reservationBox.Name = "reservationBox";
            this.reservationBox.ReadOnly = true;
            this.reservationBox.Size = new System.Drawing.Size(86, 20);
            this.reservationBox.TabIndex = 14;
            // 
            // verifyButton
            // 
            this.verifyButton.BackColor = System.Drawing.Color.Transparent;
            this.verifyButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verifyButton.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.verifyButton.Location = new System.Drawing.Point(516, 47);
            this.verifyButton.Name = "verifyButton";
            this.verifyButton.Size = new System.Drawing.Size(73, 29);
            this.verifyButton.TabIndex = 6;
            this.verifyButton.Text = "Verify";
            this.verifyButton.UseVisualStyleBackColor = false;
            // 
            // paymentLable
            // 
            this.paymentLable.AutoSize = true;
            this.paymentLable.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentLable.Location = new System.Drawing.Point(3, 4);
            this.paymentLable.Name = "paymentLable";
            this.paymentLable.Size = new System.Drawing.Size(62, 17);
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
            this.dateSelection.Location = new System.Drawing.Point(3, 68);
            this.dateSelection.Name = "dateSelection";
            this.dateSelection.Size = new System.Drawing.Size(686, 120);
            this.dateSelection.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 47);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(512, 66);
            this.dataGridView1.TabIndex = 13;
            // 
            // checkButton
            // 
            this.checkButton.BackColor = System.Drawing.Color.Transparent;
            this.checkButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkButton.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.checkButton.Location = new System.Drawing.Point(462, 16);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(93, 29);
            this.checkButton.TabIndex = 12;
            this.checkButton.Text = "Check";
            this.checkButton.UseVisualStyleBackColor = false;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(297, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Room Type:";
            // 
            // comboBoxRoomType
            // 
            this.comboBoxRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRoomType.FormattingEnabled = true;
            this.comboBoxRoomType.Location = new System.Drawing.Point(374, 24);
            this.comboBoxRoomType.Name = "comboBoxRoomType";
            this.comboBoxRoomType.Size = new System.Drawing.Size(78, 21);
            this.comboBoxRoomType.TabIndex = 10;
            // 
            // toDatelbl
            // 
            this.toDatelbl.AutoSize = true;
            this.toDatelbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDatelbl.Location = new System.Drawing.Point(161, 23);
            this.toDatelbl.Name = "toDatelbl";
            this.toDatelbl.Size = new System.Drawing.Size(25, 17);
            this.toDatelbl.TabIndex = 9;
            this.toDatelbl.Text = "To:";
            // 
            // fromDatelbl
            // 
            this.fromDatelbl.AutoSize = true;
            this.fromDatelbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromDatelbl.Location = new System.Drawing.Point(3, 23);
            this.fromDatelbl.Name = "fromDatelbl";
            this.fromDatelbl.Size = new System.Drawing.Size(41, 17);
            this.fromDatelbl.TabIndex = 8;
            this.fromDatelbl.Text = "From:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(192, 24);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(99, 20);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(47, 24);
            this.dateTimePicker1.MinDate = new System.DateTime(2025, 9, 23, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(114, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // dateSelectionLable
            // 
            this.dateSelectionLable.AutoSize = true;
            this.dateSelectionLable.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateSelectionLable.Location = new System.Drawing.Point(3, 1);
            this.dateSelectionLable.Name = "dateSelectionLable";
            this.dateSelectionLable.Size = new System.Drawing.Size(97, 17);
            this.dateSelectionLable.TabIndex = 5;
            this.dateSelectionLable.Text = "Date Selection";
            // 
            // addGuestPanel
            // 
            this.addGuestPanel.BackColor = System.Drawing.Color.LightSkyBlue;
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
            this.addGuestPanel.Location = new System.Drawing.Point(3, 189);
            this.addGuestPanel.Name = "addGuestPanel";
            this.addGuestPanel.Size = new System.Drawing.Size(681, 109);
            this.addGuestPanel.TabIndex = 14;
            this.addGuestPanel.Visible = false;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Transparent;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.cancelButton.Location = new System.Drawing.Point(592, 69);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(84, 30);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Transparent;
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.saveButton.Location = new System.Drawing.Point(492, 69);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(84, 30);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // addresstbox
            // 
            this.addresstbox.Location = new System.Drawing.Point(397, 28);
            this.addresstbox.Name = "addresstbox";
            this.addresstbox.Size = new System.Drawing.Size(140, 36);
            this.addresstbox.TabIndex = 10;
            this.addresstbox.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(332, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 17);
            this.label12.TabIndex = 9;
            this.label12.Text = "Address:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(162, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 17);
            this.label11.TabIndex = 8;
            this.label11.Text = "Phone:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(162, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 17);
            this.label10.TabIndex = 7;
            this.label10.Text = "Email:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "ID:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(214, 58);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(214, 29);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(52, 58);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(52, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // panelName
            // 
            this.panelName.AutoSize = true;
            this.panelName.BackColor = System.Drawing.Color.Transparent;
            this.panelName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelName.Location = new System.Drawing.Point(3, 4);
            this.panelName.Name = "panelName";
            this.panelName.Size = new System.Drawing.Size(103, 17);
            this.panelName.TabIndex = 0;
            this.panelName.Text = "Add New Guest";
            // 
            // MakeBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 550);
            this.Controls.Add(this.makeBookingPanel);
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