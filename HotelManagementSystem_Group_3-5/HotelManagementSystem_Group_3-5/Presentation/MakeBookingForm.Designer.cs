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
            makeBookingPanel = new Panel();
            confirmBookingButton = new Button();
            paymentSelection = new Panel();
            textBox1 = new TextBox();
            cvvLabel = new Label();
            creditCardTextbox = new TextBox();
            creditCardLabel = new Label();
            depositBox = new TextBox();
            depositLable = new Label();
            resNoLable = new Label();
            reservationBox = new TextBox();
            verifyButton = new Button();
            paymentLable = new Label();
            detailSelection = new Panel();
            searchButton = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            makeReservationButton = new Button();
            emailtbox = new TextBox();
            phonetbox = new TextBox();
            nametbox = new TextBox();
            idtbox = new TextBox();
            idNumbertbox = new TextBox();
            label3 = new Label();
            guestDetailsLable = new Label();
            dateSelection = new Panel();
            dataGridView1 = new DataGridView();
            checkButton = new Button();
            label2 = new Label();
            comboBoxRoomType = new ComboBox();
            toDatelbl = new Label();
            fromDatelbl = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            dateSelectionLable = new Label();
            panel1 = new Panel();
            label1 = new Label();
            makeBookingPanel.SuspendLayout();
            paymentSelection.SuspendLayout();
            detailSelection.SuspendLayout();
            dateSelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // makeBookingPanel
            // 
            makeBookingPanel.BorderStyle = BorderStyle.FixedSingle;
            makeBookingPanel.Controls.Add(confirmBookingButton);
            makeBookingPanel.Controls.Add(paymentSelection);
            makeBookingPanel.Controls.Add(detailSelection);
            makeBookingPanel.Controls.Add(dateSelection);
            makeBookingPanel.Location = new Point(145, 77);
            makeBookingPanel.Name = "makeBookingPanel";
            makeBookingPanel.Size = new Size(626, 424);
            makeBookingPanel.TabIndex = 2;
            // 
            // confirmBookingButton
            // 
            confirmBookingButton.BackColor = Color.Plum;
            confirmBookingButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            confirmBookingButton.ForeColor = SystemColors.ButtonHighlight;
            confirmBookingButton.Location = new Point(480, 392);
            confirmBookingButton.Name = "confirmBookingButton";
            confirmBookingButton.Size = new Size(131, 27);
            confirmBookingButton.TabIndex = 7;
            confirmBookingButton.Text = "Confirm Booking";
            confirmBookingButton.UseVisualStyleBackColor = false;
            // 
            // paymentSelection
            // 
            paymentSelection.BorderStyle = BorderStyle.Fixed3D;
            paymentSelection.Controls.Add(textBox1);
            paymentSelection.Controls.Add(cvvLabel);
            paymentSelection.Controls.Add(creditCardTextbox);
            paymentSelection.Controls.Add(creditCardLabel);
            paymentSelection.Controls.Add(depositBox);
            paymentSelection.Controls.Add(depositLable);
            paymentSelection.Controls.Add(resNoLable);
            paymentSelection.Controls.Add(reservationBox);
            paymentSelection.Controls.Add(verifyButton);
            paymentSelection.Controls.Add(paymentLable);
            paymentSelection.Location = new Point(3, 304);
            paymentSelection.Name = "paymentSelection";
            paymentSelection.Size = new Size(613, 89);
            paymentSelection.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(348, 57);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 21;
            // 
            // cvvLabel
            // 
            cvvLabel.AutoSize = true;
            cvvLabel.Location = new Point(253, 58);
            cvvLabel.Name = "cvvLabel";
            cvvLabel.Size = new Size(32, 15);
            cvvLabel.TabIndex = 20;
            cvvLabel.Text = "CVV:";
            // 
            // creditCardTextbox
            // 
            creditCardTextbox.Location = new Point(348, 20);
            creditCardTextbox.Name = "creditCardTextbox";
            creditCardTextbox.Size = new Size(100, 23);
            creditCardTextbox.TabIndex = 19;
            // 
            // creditCardLabel
            // 
            creditCardLabel.AutoSize = true;
            creditCardLabel.Location = new Point(253, 20);
            creditCardLabel.Name = "creditCardLabel";
            creditCardLabel.Size = new Size(89, 15);
            creditCardLabel.TabIndex = 18;
            creditCardLabel.Text = "Credit Card No:";
            // 
            // depositBox
            // 
            depositBox.Location = new Point(90, 50);
            depositBox.Name = "depositBox";
            depositBox.Size = new Size(100, 23);
            depositBox.TabIndex = 17;
            // 
            // depositLable
            // 
            depositLable.AutoSize = true;
            depositLable.Location = new Point(6, 53);
            depositLable.Name = "depositLable";
            depositLable.Size = new Size(50, 15);
            depositLable.TabIndex = 16;
            depositLable.Text = "Deposit:";
            // 
            // resNoLable
            // 
            resNoLable.AutoSize = true;
            resNoLable.Location = new Point(3, 24);
            resNoLable.Name = "resNoLable";
            resNoLable.Size = new Size(90, 15);
            resNoLable.TabIndex = 15;
            resNoLable.Text = "Reservation No:";
            // 
            // reservationBox
            // 
            reservationBox.Location = new Point(90, 21);
            reservationBox.Name = "reservationBox";
            reservationBox.Size = new Size(100, 23);
            reservationBox.TabIndex = 14;
            // 
            // verifyButton
            // 
            verifyButton.BackColor = Color.Plum;
            verifyButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            verifyButton.ForeColor = SystemColors.ButtonHighlight;
            verifyButton.Location = new Point(520, 54);
            verifyButton.Name = "verifyButton";
            verifyButton.Size = new Size(86, 25);
            verifyButton.TabIndex = 6;
            verifyButton.Text = "Verify";
            verifyButton.UseVisualStyleBackColor = false;
            // 
            // paymentLable
            // 
            paymentLable.AutoSize = true;
            paymentLable.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            paymentLable.Location = new Point(3, 5);
            paymentLable.Name = "paymentLable";
            paymentLable.Size = new Size(62, 17);
            paymentLable.TabIndex = 5;
            paymentLable.Text = "Payment";
            // 
            // detailSelection
            // 
            detailSelection.BorderStyle = BorderStyle.Fixed3D;
            detailSelection.Controls.Add(searchButton);
            detailSelection.Controls.Add(label7);
            detailSelection.Controls.Add(label6);
            detailSelection.Controls.Add(label5);
            detailSelection.Controls.Add(label4);
            detailSelection.Controls.Add(makeReservationButton);
            detailSelection.Controls.Add(emailtbox);
            detailSelection.Controls.Add(phonetbox);
            detailSelection.Controls.Add(nametbox);
            detailSelection.Controls.Add(idtbox);
            detailSelection.Controls.Add(idNumbertbox);
            detailSelection.Controls.Add(label3);
            detailSelection.Controls.Add(guestDetailsLable);
            detailSelection.Location = new Point(3, 183);
            detailSelection.Name = "detailSelection";
            detailSelection.Size = new Size(613, 120);
            detailSelection.TabIndex = 5;
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.Plum;
            searchButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchButton.ForeColor = SystemColors.ButtonHighlight;
            searchButton.Location = new Point(266, 22);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(89, 27);
            searchButton.TabIndex = 13;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(266, 87);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 6;
            label7.Text = "Phone:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(266, 62);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 3;
            label6.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 91);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 3;
            label5.Text = "Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 58);
            label4.Name = "label4";
            label4.Size = new Size(21, 15);
            label4.TabIndex = 12;
            label4.Text = "ID:";
            // 
            // makeReservationButton
            // 
            makeReservationButton.BackColor = Color.Plum;
            makeReservationButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            makeReservationButton.ForeColor = SystemColors.ButtonHighlight;
            makeReservationButton.Location = new Point(459, 83);
            makeReservationButton.Name = "makeReservationButton";
            makeReservationButton.Size = new Size(147, 30);
            makeReservationButton.TabIndex = 11;
            makeReservationButton.Text = "Make Reservation";
            makeReservationButton.UseVisualStyleBackColor = false;
            // 
            // emailtbox
            // 
            emailtbox.Location = new Point(310, 54);
            emailtbox.Name = "emailtbox";
            emailtbox.Size = new Size(100, 23);
            emailtbox.TabIndex = 10;
            // 
            // phonetbox
            // 
            phonetbox.Location = new Point(310, 83);
            phonetbox.Name = "phonetbox";
            phonetbox.Size = new Size(100, 23);
            phonetbox.TabIndex = 9;
            // 
            // nametbox
            // 
            nametbox.Location = new Point(85, 84);
            nametbox.Name = "nametbox";
            nametbox.Size = new Size(100, 23);
            nametbox.TabIndex = 8;
            // 
            // idtbox
            // 
            idtbox.Location = new Point(85, 58);
            idtbox.Name = "idtbox";
            idtbox.Size = new Size(105, 23);
            idtbox.TabIndex = 7;
            // 
            // idNumbertbox
            // 
            idNumbertbox.Location = new Point(85, 26);
            idNumbertbox.Name = "idNumbertbox";
            idNumbertbox.Size = new Size(133, 23);
            idNumbertbox.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 26);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 3;
            label3.Text = "ID Number:";
            // 
            // guestDetailsLable
            // 
            guestDetailsLable.AutoSize = true;
            guestDetailsLable.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guestDetailsLable.Location = new Point(3, 3);
            guestDetailsLable.Name = "guestDetailsLable";
            guestDetailsLable.Size = new Size(90, 17);
            guestDetailsLable.TabIndex = 5;
            guestDetailsLable.Text = "Guest Details";
            // 
            // dateSelection
            // 
            dateSelection.BorderStyle = BorderStyle.Fixed3D;
            dateSelection.Controls.Add(dataGridView1);
            dateSelection.Controls.Add(checkButton);
            dateSelection.Controls.Add(label2);
            dateSelection.Controls.Add(comboBoxRoomType);
            dateSelection.Controls.Add(toDatelbl);
            dateSelection.Controls.Add(fromDatelbl);
            dateSelection.Controls.Add(dateTimePicker2);
            dateSelection.Controls.Add(dateTimePicker1);
            dateSelection.Controls.Add(dateSelectionLable);
            dateSelection.Location = new Point(3, 47);
            dateSelection.Name = "dateSelection";
            dateSelection.Size = new Size(613, 133);
            dateSelection.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonShadow;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(8, 54);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(498, 74);
            dataGridView1.TabIndex = 13;
            // 
            // checkButton
            // 
            checkButton.BackColor = Color.Plum;
            checkButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkButton.ForeColor = SystemColors.ButtonHighlight;
            checkButton.Location = new Point(522, 23);
            checkButton.Name = "checkButton";
            checkButton.Size = new Size(84, 26);
            checkButton.TabIndex = 12;
            checkButton.Text = "Check";
            checkButton.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(340, 28);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 11;
            label2.Text = "Room Type:";
            // 
            // comboBoxRoomType
            // 
            comboBoxRoomType.FormattingEnabled = true;
            comboBoxRoomType.Location = new Point(416, 25);
            comboBoxRoomType.Name = "comboBoxRoomType";
            comboBoxRoomType.Size = new Size(90, 23);
            comboBoxRoomType.TabIndex = 10;            // 
            // toDatelbl
            // 
            toDatelbl.AutoSize = true;
            toDatelbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toDatelbl.Location = new Point(188, 27);
            toDatelbl.Name = "toDatelbl";
            toDatelbl.Size = new Size(25, 17);
            toDatelbl.TabIndex = 9;
            toDatelbl.Text = "To:";
            // 
            // fromDatelbl
            // 
            fromDatelbl.AutoSize = true;
            fromDatelbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fromDatelbl.Location = new Point(3, 27);
            fromDatelbl.Name = "fromDatelbl";
            fromDatelbl.Size = new Size(41, 17);
            fromDatelbl.TabIndex = 8;
            fromDatelbl.Text = "From:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(219, 23);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(115, 23);
            dateTimePicker2.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(50, 23);
            dateTimePicker1.MinDate = new DateTime(2025, 9, 23, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(132, 23);
            dateTimePicker1.TabIndex = 6;
            // 
            // dateSelectionLable
            // 
            dateSelectionLable.AutoSize = true;
            dateSelectionLable.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateSelectionLable.Location = new Point(3, 1);
            dateSelectionLable.Name = "dateSelectionLable";
            dateSelectionLable.Size = new Size(97, 17);
            dateSelectionLable.TabIndex = 5;
            dateSelectionLable.Text = "Date Selection";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Thistle;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(145, 77);
            panel1.Name = "panel1";
            panel1.Size = new Size(626, 42);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(250, 9);
            label1.Name = "label1";
            label1.Size = new Size(120, 21);
            label1.TabIndex = 0;
            label1.Text = "Make Booking";
            // 
            // MakeBookingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 504);
            Controls.Add(panel1);
            Controls.Add(makeBookingPanel);
            Name = "MakeBookingForm";
            Text = "makeBooking";
            makeBookingPanel.ResumeLayout(false);
            paymentSelection.ResumeLayout(false);
            paymentSelection.PerformLayout();
            detailSelection.ResumeLayout(false);
            detailSelection.PerformLayout();
            dateSelection.ResumeLayout(false);
            dateSelection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
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