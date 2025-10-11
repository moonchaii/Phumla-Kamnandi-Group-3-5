using HotelManagementSystem_Group_3_5.Business;
using HotelManagementSystem_Group_3_5.Data;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem_Group_3_5.Presentation
{
    public partial class MakeBookingForm : Form
    {
        private BookingDB bookingDB;

        public MakeBookingForm()
        {
            InitializeComponent();
        }

        private void MakeBookingForm_Load(object sender, EventArgs e)
        {
            bookingDB = new BookingDB();
            comboBoxRoomType.Items.Clear();
            comboBoxRoomType.Items.Add("Single");
            comboBoxRoomType.SelectedIndex = 0; // get index of currently selected item in combobox
        }

        private string DataConnection = @"Server=(localdb)\MSSQLLocalDB;
Database=PKDB;
Trusted_Connection=True;
MultipleActiveResultSets=true;"; // must change the connection link here
        private int roomSelection = -1; // where the receptionists room selection will be stored


        private void checkButton_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime checkIn = dateTimePicker1.Value.Date;
                DateTime checkOut = dateTimePicker2.Value.Date;
                string roomType = comboBoxRoomType.SelectedItem?.ToString();

                if (checkOut <= checkIn)
                {
                    MessageBox.Show("Check-out must be after check-in.");
                    return;
                }

                var availableRooms = bookingDB.GetAvailableRooms(roomType, checkIn, checkOut);
                dataGridView1.DataSource = availableRooms;

                if (availableRooms.Rows.Count == 0)
                {
                    MessageBox.Show("No rooms available for the selected period.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void makeBookingPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void ShowAddGuestPanel(string idNo)
        {
            idtbox.Text = idNo;  //copies the id to display
            addGuestPanel.Visible = true;
            addGuestPanel.BringToFront();
        }


        private void HideAddGuestPanel()
        {
            addGuestPanel.Visible = false;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string idNo = IdNobox.Text.Trim(); // receptionist enters ID number

            // Create or use your existing GuestDB object
            GuestDB guestDB = new GuestDB();

            // Try find existing guest
            Guest existingGuest = guestDB.FindGuestByIdNumber(idNo);

            if (existingGuest != null)
            {
                // Guest found — populate textboxes
                idtbox.Text = existingGuest.GuestID.ToString();
                emailtbox.Text = existingGuest.Email;
                nametbox.Text = $"{existingGuest.FName} {existingGuest.LName}".Trim();
                phonetbox.Text = existingGuest.PhoneNum;
                addressbox.Text = existingGuest.Address;
            }
            else
            {
                // Guest not found — prompt user
                DialogResult guestNotFound = MessageBox.Show(
                    "Guest not found",
                    "Add new guest?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (guestNotFound == DialogResult.Yes)
                {
                    ShowAddGuestPanel(idNo);
                }
            }

        }

        private void dateSelection_Paint(object sender, PaintEventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(DataConnection))
            {
                string query = "insert into guest (IdNo, Name, Email, Phone, Address) values (@IdNo, @Name, @Email, @Phone, @Address)";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@IdNo", idtbox.Text.Trim());
                command.Parameters.AddWithValue("@Name", nametbox.Text.Trim());
                command.Parameters.AddWithValue("@Email", emailtbox.Text.Trim());
                command.Parameters.AddWithValue("@Phone", phonetbox.Text.Trim());
                command.Parameters.AddWithValue("@Address", addresstbox.Text.Trim());

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

            MessageBox.Show("Guest details confirmed", "Guest added successfully", MessageBoxButtons.OK);

            HideAddGuestPanel();
            IdNobox.Text = idtbox.Text;
            searchButton_Click(null, null);



        }



        private void adrtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            HideAddGuestPanel();
        }

        private void makeReservationButton_Click(object sender, EventArgs e)
        {
            DateTime checkIn = dateTimePicker1.Value.Date;
            DateTime checkOut = dateTimePicker2.Value.Date;
            string roomID = dataGridView1.SelectedRows[0].Cells["RoomID"].Value.ToString();
            string guestID = idtbox.Text;

            double rate = bookingDB.GetSeasonalRate(checkIn);
            int nights = (checkOut - checkIn).Days;
            double total = rate * nights;
            double deposit = total * 0.10;

            var booking = new Booking
            {
                ReferenceNumber = Booking.GenerateReferenceNumber(),
                GuestID = guestID,
                RoomID = roomID,
                RoomNumber = 0, // or get from room table if available
                TotalAmount = (decimal)total,
                DepositAmount = (decimal)deposit,
                DepositPaid = false,
                ArrivalDate = checkIn,
                DepartureDate = checkOut,
                DateCreated = DateTime.Now
            };

            if (bookingDB.AddBooking(booking))
            {
                MessageBox.Show($"Booking confirmed!\nReference: {booking.ReferenceNumber}\nDeposit: R{deposit:F2}");
            }
            else
            {
                MessageBox.Show("Booking failed. Please try again.");
            }

        }

        private double getRate(DateTime checkIn)
        {
            double rate = 0;
            using (SqlConnection connection = new SqlConnection(DataConnection))
            {
                connection.Open();
                string query = "SELECT TOP 1 Rate FROM SeasonalRate WHERE @CheckIn BETWEEN StartDate AND EndDate";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CheckIn", checkIn);

                object rateAmount = command.ExecuteScalar();
                rate = Convert.ToDouble(rateAmount);
       
            }
            return rate;
        }
    }
}
