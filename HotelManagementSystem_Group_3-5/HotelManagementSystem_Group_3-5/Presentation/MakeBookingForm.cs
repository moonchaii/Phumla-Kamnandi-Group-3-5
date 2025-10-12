using HotelManagementSystem_Group_3_5.Business;
using HotelManagementSystem_Group_3_5.Data;
using HotelManagementSystem_Group_3_5.Properties;
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
// Group 3-5
// Members:
// Shakila Africa : AFRSHA001
// Chai Europa : ERPTEA001
// Lilitha Somana : SMNBON004
// Lindani Xaba : XBXLIN006
namespace HotelManagementSystem_Group_3_5.Presentation
{
    public partial class MakeBookingForm : Form
    {
        private BookingDB bookingDB;
        private GuestDB guestDB;
        private bool paymentVerified = false;
        public event EventHandler BookingConfirmed;

        public MakeBookingForm()
        {
            InitializeComponent();
        }

        private void MakeBookingForm_Load(object sender, EventArgs e)
        {
            bookingDB = new BookingDB();
            guestDB = new GuestDB();
            comboBoxRoomType.Items.Clear();
            comboBoxRoomType.Items.Add("Single");
            comboBoxRoomType.SelectedIndex = 0;
        }

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

        private void ShowAddGuestPanel(string idNo)
        {
            idtbox.Text = idNo;
            addGuestPanel.Visible = true;
            addGuestPanel.BringToFront();
        }


        private void HideAddGuestPanel()
        {
            addGuestPanel.Visible = false;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string idNo = IdNobox.Text.Trim();

            Guest existingGuest = guestDB.FindGuestByIdNumber(idNo);

            if (existingGuest != null)
            {
                idtbox.Text = existingGuest.GuestID.ToString();
                emailtbox.Text = existingGuest.Email;
                nametbox.Text = $"{existingGuest.Name}".Trim();
                phonetbox.Text = existingGuest.PhoneNum;
                addressbox.Text = existingGuest.Address;
            }
            else
            {
                DialogResult guestNotFound = MessageBox.Show(
                    "Add new guest?",
                    "Guest not found",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (guestNotFound == DialogResult.Yes)
                {
                    ShowAddGuestPanel(idNo);
                }
            }

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string newGuestId = Guest.GenerateGuestID();
                Guest newGuest = new Guest
                {
                    GuestID = newGuestId,
                    Id = textBox2.Text.Trim(),
                    Name = textBox3.Text.Trim(),
                    Email = textBox4.Text.Trim(),
                    PhoneNum = textBox5.Text.Trim(),
                    Address = addresstbox.Text.Trim()
                };

                guestDB.UpdateDataSource(newGuest, DB.DBOperation.Add);
                MessageBox.Show("Guest added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                HideAddGuestPanel();

                idtbox.Text = newGuest.GuestID;
                nametbox.Text = newGuest.Name;
                emailtbox.Text = newGuest.Email;
                phonetbox.Text = newGuest.PhoneNum;
                addressbox.Text = newGuest.Address;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving guest: {ex.Message}");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            HideAddGuestPanel();
        }

        private void makeReservationButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a room first.");
                return;
            }

            DateTime checkIn = dateTimePicker1.Value.Date;
            DateTime checkOut = dateTimePicker2.Value.Date;
            string roomID = dataGridView1.SelectedRows[0].Cells["RoomID"].Value.ToString();
            string guestID = idtbox.Text;

            int roomNumber = 0;
            string sql = "SELECT RoomNumber FROM Room WHERE RoomID = @RoomID";

            using (SqlConnection con = new SqlConnection(Settings.Default.PhumlaKamnandiDatabaseConnectionString))
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@RoomID", roomID);
                con.Open();
                object result = cmd.ExecuteScalar();
                con.Close();

                if (result != null)
                {
                    roomNumber = Convert.ToInt32(result);
                }
                else
                {
                    MessageBox.Show("Failed to get room number for the selected room.");
                    return;
                }
            }

            double rate = bookingDB.GetSeasonalRate(checkIn);
            int nights = (checkOut - checkIn).Days;
            double total = rate * nights;
            double deposit = total * 0.10;

            var booking = new Booking
            {
                ReferenceNumber = Booking.GenerateReferenceNumber(),
                GuestID = guestID,
                RoomID = roomID,
                RoomNumber = roomNumber,
                TotalAmount = (decimal)total,
                DepositAmount = (decimal)deposit,
                DepositPaid = true,
                ArrivalDate = checkIn,
                DepartureDate = checkOut,
                DateCreated = DateTime.Now
            };

            if (bookingDB.AddBooking(booking))
            {
                MessageBox.Show($"Booking confirmed!\nReference: {booking.ReferenceNumber}\nDeposit: R{deposit:F2}");
                reservationBox.Text = booking.ReferenceNumber;
                depositBox.Text = $"R{booking.DepositAmount:0,00}";
            }
            else
            {
                MessageBox.Show("Booking failed. Please try again.");
            }
        }

        private void verifyButton_Click_1(object sender, EventArgs e)
        {
            string cardNumber = creditCardTextbox.Text.Trim();
            string cvv = textBox1.Text.Trim();

            if (cardNumber.Length != 16 || !cardNumber.All(char.IsDigit))
            {
                MessageBox.Show("Credit card number must be 16 digits.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cvv.Length != 3 || !cvv.All(char.IsDigit))
            {
                MessageBox.Show("CVV must be exactly 3 digits.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Payment verified successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            paymentVerified = true;
            confirmBookingButton.Enabled = true;
        }

        private void confirmBookingButton_Click_1(object sender, EventArgs e)
        {
            string email = emailtbox.Text.Trim();
            string reference = reservationBox.Text;

            if (string.IsNullOrWhiteSpace(reference))
            {
                MessageBox.Show("No booking reference found. Please make a reservation first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!paymentVerified)
            {
                MessageBox.Show("Please verify payment first.", "Payment Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show($"Booking {reference} confirmed and email sent to {email}.", "Booking Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            BookingConfirmed?.Invoke(this, EventArgs.Empty);

            this.Dispose();
        }
    }
}
