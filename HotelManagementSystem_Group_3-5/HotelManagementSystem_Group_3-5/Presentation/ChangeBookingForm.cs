using HotelManagementSystem_Group_3_5.Business;
using HotelManagementSystem_Group_3_5.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelManagementSystem_Group_3_5.Presentation
{
    public partial class ChangeBookingForm : Form
    {

        private Booking booking;
        private BookingDB bookingDB;
        private BookingHandler bookingHandler;

        private Collection<Booking> bookings;

        public ChangeBookingForm()
        {
            InitializeComponent();
            bookingDB = new BookingDB();
            bookingHandler = new BookingHandler();
            bookings = new Collection<Booking>();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ChangeBookingForm_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Today;
            dateTimePicker2.MinDate = DateTime.Today.AddDays(1);
        }

        private void searchBooking_Click(object sender, EventArgs e)
        {
            SearchBooking();
        }

        #region Methods
        public void SearchBooking()
        {
            string referenceNumber = referencetbox.Text.Trim();

            if (string.IsNullOrEmpty(referenceNumber))
            {
                MessageBox.Show("Please enter a reference number to search.",
                    "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                referencetbox.Focus();
                return;
            }



            try
            {
                booking = bookingDB.FindBookingByReference(referenceNumber);


                if (booking == null)
                {
                    MessageBox.Show($"No booking found with reference number: {referenceNumber}",
                        "Booking Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = null;
                    button1.Enabled = false;
                    return;
                }
                bookings.Clear();
                bookings.Add(booking);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = bookings;
                button1.Enabled = true;

            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error searching for booking: {ex.Message}",
                    "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataGridView1.DataSource = null;
                button1.Enabled = false;
            }

        }

        private void UpdateBookingDates()
        {
            if (booking == null)
            {
                MessageBox.Show("No booking selected to modify.",
                    "No Booking", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (ConfirmDateChange())
                    //return;

                // Process the date change - UPDATE THE DATABASE
                ProcessDateChange();
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error changing booking dates: {ex.Message}",
                    "Change Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ConfirmDateChange()
        {
            DateTime newArrival = dateTimePicker1.Value;
            DateTime newDeparture = dateTimePicker2.Value;
            int NumberOfNights = (newDeparture - newArrival).Days;

            string message = "CONFIRM DATE CHANGE\n\n" +
                           "Current Booking:\n" +
                           $"• Arrival: {booking.ArrivalDate:dd/MM/yyyy}\n" +
                           $"• Departure: {booking.DepartureDate:dd/MM/yyyy}\n" +
                           "New Booking:\n" +
                           $"• Arrival: {newArrival:dd/MM/yyyy}\n" +
                           $"• Departure: {newDeparture:dd/MM/yyyy}\n" ;

            message += "\nAre you sure you want to update the booking with these new dates?";

            DialogResult result = MessageBox.Show(message, "Confirm Date Change",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            return result == DialogResult.Yes;

        }

        private void ProcessDateChange()
        {

            try
            { 
                DateTime oldArrival = booking.ArrivalDate;
                DateTime oldDeparture = booking.DepartureDate;

                // UPDATE THE BOOKING WITH NEW DATES FROM DATETIMEPICKERS
                booking.ArrivalDate = dateTimePicker1.Value;
                booking.DepartureDate = dateTimePicker2.Value;

                bool success = bookingDB.UpdateDataSource(booking, DB.DBOperation.Edit);

                if (success)
                {
                    int newNights = (booking.DepartureDate - booking.ArrivalDate).Days;

                    string successMessage = " BOOKING DATES UPDATED SUCCESSFULLY!\n\n" +
                                          "Before Changes:\n" +
                                          $"• Dates: {oldArrival:dd/MM/yyyy} to {oldDeparture:dd/MM/yyyy}\n" +
                                          "After Changes:\n" +
                                          $"• Dates: {booking.ArrivalDate:dd/MM/yyyy} to {booking.DepartureDate:dd/MM/yyyy}\n" +
                                          $"• Nights: {newNights}\n";

                    successMessage += $"\n\nBooking reference: {booking.ReferenceNumber}";
                    successMessage += $"\nRoom: {booking.RoomID}";

                    MessageBox.Show(successMessage, "Date Change Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show(" Failed to update booking dates in the database.\n\nPlease try again or contact system administrator.",
                        "Database Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error updating booking in database: {ex.Message}\n\nPlease contact system administrator.",
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateBookingDates();
        }
    }
}
