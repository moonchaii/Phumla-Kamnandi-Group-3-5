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
            this.confirmBookingButton = new System.Windows.Forms.Button();
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
            this.detailSelection = new System.Windows.Forms.Panel();
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
            this.idNumbertbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.guestDetailsLable = new System.Windows.Forms.Label();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.makeBookingPanel.SuspendLayout();
            this.paymentSelection.SuspendLayout();
            this.detailSelection.SuspendLayout();
            this.dateSelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // makeBookingPanel
            // 
            this.makeBookingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.makeBookingPanel.Controls.Add(this.confirmBookingButton);
            this.makeBookingPanel.Controls.Add(this.paymentSelection);
            this.makeBookingPanel.Controls.Add(this.detailSelection);
            this.makeBookingPanel.Controls.Add(this.dateSelection);
            this.makeBookingPanel.Location = new System.Drawing.Point(124, 67);
            this.makeBookingPanel.Name = "makeBookingPanel";
            this.makeBookingPanel.Size = new System.Drawing.Size(537, 368);
            this.makeBookingPanel.TabIndex = 2;
            this.makeBookingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.makeBookingPanel_Paint);
            // 
            // confirmBookingButton
            // 
            this.confirmBookingButton.BackColor = System.Drawing.Color.Plum;
            this.confirmBookingButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmBookingButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.confirmBookingButton.Location = new System.Drawing.Point(411, 340);
            this.confirmBookingButton.Name = "confirmBookingButton";
            this.confirmBookingButton.Size = new System.Drawing.Size(114, 27);
            this.confirmBookingButton.TabIndex = 7;
            this.confirmBookingButton.Text = "Confirm Booking";
            this.confirmBookingButton.UseVisualStyleBackColor = false;
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
            this.paymentSelection.Location = new System.Drawing.Point(3, 263);
            this.paymentSelection.Name = "paymentSelection";
            this.paymentSelection.Size = new System.Drawing.Size(526, 78);
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
            this.depositBox.Location = new System.Drawing.Point(77, 43);
            this.depositBox.Name = "depositBox";
            this.depositBox.Size = new System.Drawing.Size(86, 20);
            this.depositBox.TabIndex = 17;
            // 
            // depositLable
            // 
            this.depositLable.AutoSize = true;
            this.depositLable.Location = new System.Drawing.Point(5, 46);
            this.depositLable.Name = "depositLable";
            this.depositLable.Size = new System.Drawing.Size(46, 13);
            this.depositLable.TabIndex = 16;
            this.depositLable.Text = "Deposit:";
            // 
            // resNoLable
            // 
            this.resNoLable.AutoSize = true;
            this.resNoLable.Location = new System.Drawing.Point(3, 21);
            this.resNoLable.Name = "resNoLable";
            this.resNoLable.Size = new System.Drawing.Size(84, 13);
            this.resNoLable.TabIndex = 15;
            this.resNoLable.Text = "Reservation No:";
            // 
            // reservationBox
            // 
            this.reservationBox.Location = new System.Drawing.Point(77, 18);
            this.reservationBox.Name = "reservationBox";
            this.reservationBox.Size = new System.Drawing.Size(86, 20);
            this.reservationBox.TabIndex = 14;
            // 
            // verifyButton
            // 
            this.verifyButton.BackColor = System.Drawing.Color.Plum;
            this.verifyButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verifyButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.verifyButton.Location = new System.Drawing.Point(446, 47);
            this.verifyButton.Name = "verifyButton";
            this.verifyButton.Size = new System.Drawing.Size(73, 24);
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
            // detailSelection
            // 
            this.detailSelection.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            this.detailSelection.Controls.Add(this.idNumbertbox);
            this.detailSelection.Controls.Add(this.label3);
            this.detailSelection.Controls.Add(this.guestDetailsLable);
            this.detailSelection.Location = new System.Drawing.Point(3, 159);
            this.detailSelection.Name = "detailSelection";
            this.detailSelection.Size = new System.Drawing.Size(526, 105);
            this.detailSelection.TabIndex = 5;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Plum;
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchButton.Location = new System.Drawing.Point(228, 19);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(76, 23);
            this.searchButton.TabIndex = 13;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(228, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Phone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(228, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "ID:";
            // 
            // makeReservationButton
            // 
            this.makeReservationButton.BackColor = System.Drawing.Color.Plum;
            this.makeReservationButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeReservationButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.makeReservationButton.Location = new System.Drawing.Point(393, 72);
            this.makeReservationButton.Name = "makeReservationButton";
            this.makeReservationButton.Size = new System.Drawing.Size(126, 26);
            this.makeReservationButton.TabIndex = 11;
            this.makeReservationButton.Text = "Make Reservation";
            this.makeReservationButton.UseVisualStyleBackColor = false;
            // 
            // emailtbox
            // 
            this.emailtbox.Location = new System.Drawing.Point(266, 47);
            this.emailtbox.Name = "emailtbox";
            this.emailtbox.Size = new System.Drawing.Size(86, 20);
            this.emailtbox.TabIndex = 10;
            // 
            // phonetbox
            // 
            this.phonetbox.Location = new System.Drawing.Point(266, 72);
            this.phonetbox.Name = "phonetbox";
            this.phonetbox.Size = new System.Drawing.Size(86, 20);
            this.phonetbox.TabIndex = 9;
            // 
            // nametbox
            // 
            this.nametbox.Location = new System.Drawing.Point(73, 73);
            this.nametbox.Name = "nametbox";
            this.nametbox.Size = new System.Drawing.Size(86, 20);
            this.nametbox.TabIndex = 8;
            // 
            // idtbox
            // 
            this.idtbox.Location = new System.Drawing.Point(73, 50);
            this.idtbox.Name = "idtbox";
            this.idtbox.Size = new System.Drawing.Size(91, 20);
            this.idtbox.TabIndex = 7;
            // 
            // idNumbertbox
            // 
            this.idNumbertbox.Location = new System.Drawing.Point(73, 23);
            this.idNumbertbox.Name = "idNumbertbox";
            this.idNumbertbox.Size = new System.Drawing.Size(115, 20);
            this.idNumbertbox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
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
            this.dateSelection.Location = new System.Drawing.Point(3, 41);
            this.dateSelection.Name = "dateSelection";
            this.dateSelection.Size = new System.Drawing.Size(526, 116);
            this.dateSelection.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(427, 64);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // checkButton
            // 
            this.checkButton.BackColor = System.Drawing.Color.Plum;
            this.checkButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkButton.Location = new System.Drawing.Point(447, 20);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(72, 23);
            this.checkButton.TabIndex = 12;
            this.checkButton.Text = "Check";
            this.checkButton.UseVisualStyleBackColor = false;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Room Type:";
            // 
            // comboBoxRoomType
            // 
            this.comboBoxRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRoomType.FormattingEnabled = true;
            this.comboBoxRoomType.Location = new System.Drawing.Point(357, 22);
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
            this.dateTimePicker2.Location = new System.Drawing.Point(188, 20);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(99, 20);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(43, 20);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Thistle;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(124, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(537, 37);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(214, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make Booking";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MakeBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 455);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.makeBookingPanel);
            this.Name = "MakeBookingForm";
            this.Text = "makeBooking";
            this.Load += new System.EventHandler(this.MakeBookingForm_Load);
            this.makeBookingPanel.ResumeLayout(false);
            this.paymentSelection.ResumeLayout(false);
            this.paymentSelection.PerformLayout();
            this.detailSelection.ResumeLayout(false);
            this.detailSelection.PerformLayout();
            this.dateSelection.ResumeLayout(false);
            this.dateSelection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private TextBox idNumbertbox;
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
    }
}