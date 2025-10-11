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
        private GuestDB guestDB;

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
            comboBoxRoomType.SelectedIndex = 0; // get index of currently selected item in combobox
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

        private void saveButton_Click(object sender, EventArgs e)
        {
            Guest newGuest = new Guest
            {
                Id = idtbox.Text.Trim(),
                Name = nametbox.Text.Trim(),
                Email = emailtbox.Text.Trim(),
                PhoneNum = phonetbox.Text.Trim(),
                Address = addresstbox.Text.Trim(),
            };

            // Add to dataset and database
            guestDB.UpdateDataSource(newGuest, DB.DBOperation.Add);

            MessageBox.Show("Guest details confirmed", "Guest added successfully", MessageBoxButtons.OK);

            HideAddGuestPanel();
            IdNobox.Text = idtbox.Text;
            searchButton_Click(null, null);
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

            double rate = bookingDB.GetSeasonalRate(checkIn);
            int nights = (checkOut - checkIn).Days;
            double total = rate * nights;
            double deposit = total * 0.10;

            var booking = new Booking
            {
                ReferenceNumber = Booking.GenerateReferenceNumber(),
                GuestID = guestID,
                RoomID = roomID,
                RoomNumber = 0,
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
