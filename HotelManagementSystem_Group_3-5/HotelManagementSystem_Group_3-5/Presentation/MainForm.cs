using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Group 3-5
// Members:
// Shakila Africa : AFRSHA001
// Chai Europa : ERPTEA001
// Lilitha Somana : SMNBON004
// Lindani Xaba : XBXLIN006
namespace HotelManagementSystem_Group_3_5.Presentation
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void makeBookingButton_Click(object sender, EventArgs e)
        {
            var bookingForm = new MakeBookingForm();
            bookingForm.BookingConfirmed += BookingForm_BookingConfirmed;
            LoadForm(bookingForm);
        }

        private void BookingForm_BookingConfirmed(object sender, EventArgs e)
        {
            LoadForm(new MainForm());
        }

        private void LoadForm(Form form)
        {

            panel1.Controls.Clear();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
            form.Show();
        }

       

        private void cancelButton_Click(object sender, EventArgs e)
        {
            LoadForm(new CancelBookingForm());

        }

        private void enquiryButton_Click(object sender, EventArgs e)
        {
            LoadForm(new EnquiryForm());

        }

        private void reportButton_Click(object sender, EventArgs e)
        {
           LoadForm(new ReportsForm());

        }

        private void changeBookingButton_Click_1(object sender, EventArgs e)
        {
            LoadForm(new ChangeBookingForm());

        }
    }
}
