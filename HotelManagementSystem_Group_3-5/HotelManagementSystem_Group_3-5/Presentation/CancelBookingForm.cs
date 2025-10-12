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



namespace HotelManagementSystem_Group_3_5.Presentation
{
    public partial class CancelBookingForm : Form
    {
        private Booking booking;
        private BookingDB bookingDB;
        private RoomDB roomDB;
        private BookingHandler bookingHandler;

        private Collection<Booking> bookings;


        public CancelBookingForm()
        {
            InitializeComponent();
            bookingDB = new BookingDB();
            roomDB = new RoomDB();
            bookingHandler = new BookingHandler();
            bookings = new Collection<Booking>();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            CancelSelectedBooking();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchBooking();
        }

        private void CancelBookingForm_Load(object sender, EventArgs e)
        {
            //bookingDB = new BookingDB();
            roomDB.UpdateRoomAvailability(booking.RoomID, true);
        }

        #region Methods
        private void SearchBooking()
        {
            string referenceNumber = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(referenceNumber))
            {
                MessageBox.Show("Please enter a reference number to search.",
                    "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }



            try
            {
                booking = bookingDB.FindBookingByReference(referenceNumber);

                //List<Booking> bookings = new List<Booking>() ;

                if (booking == null)
                {
                    MessageBox.Show($"No booking found with reference number: {referenceNumber}",
                        "Booking Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = null;
                    button2.Enabled = false;
                    return;
                }
                bookings.Clear();
                bookings.Add(booking);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = bookings;
                button2.Enabled = true;

            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error searching for booking: {ex.Message}",
                    "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataGridView1.DataSource = null;
                button2.Enabled = false;
            }

        }

        private void CancelSelectedBooking()
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a booking to cancel.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (booking == null)
            {
                MessageBox.Show("No booking selected to cancel.",
                    "No Booking", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //decimal refundAmount = CalculateRefundAmount(Booking);

            string message = $"Are you sure you want to cancel and delete this booking?\n\n" +
                           $"Reference: {booking.ReferenceNumber}\n" +
                           $"Guest: {booking.GuestID}\n" +
                           $"Room: {booking.RoomID}\n" +
                           $"Dates: {booking.ArrivalDate:dd/MM/yyyy} to {booking.DepartureDate:dd/MM/yyyy}\n" +
                           $"Total Amount: R {booking.TotalAmount:0.00}";

            DialogResult result = MessageBox.Show(message, "Confirm Booking Cancellation and Deletion",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                ProcessCancellation();
            }
        }

        private void ProcessCancellation()
        {
            try
            {
                string referenceNumber = booking.ReferenceNumber;
                string roomNumber = booking.RoomID;
                //decimal refundAmount = CalculateRefundAmount(booking);

                //bool roomReleased = Room.ReleaseRoom(booking.RoomID);

                bool bookingDeleted = bookingDB.UpdateDataSource(booking, DB.DBOperation.Delete);

                if (bookingDeleted)
                {
                    string successMessage = $"Booking successfully cancelled and removed from system.\n\n" +
                                          $"Reference: {referenceNumber}\n" +
                                          $"Room: {roomNumber} has been released";

                    ClearForm();
                }

                else
                {
                    MessageBox.Show("Failed to delete booking from database. Please try again.",
                        "Cancellation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error cancelling booking: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ClearForm()
        {
            // Clear all fields
            textBox1.Clear();
            dataGridView1.DataSource = null;
            bookings.Clear();
            booking = null;
            button2.Enabled = false;
            textBox1.Focus();
        }
    }
}


        #endregion


    
