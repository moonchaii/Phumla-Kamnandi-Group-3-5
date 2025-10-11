using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.ComponentModel.Design;
using HotelManagementSystem_Group_3_5.Data;

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
                DateTime checkIn = dateTimePicker1.Value.Date;  // get the check in and check out dates
                DateTime checkOut = dateTimePicker2.Value.Date;
                string roomType = comboBoxRoomType.SelectedItem?.ToString();

                if (checkOut <= checkIn)
                {
                    MessageBox.Show("Check-in date cannot be after check-out .");
                    return;
                }

                using (SqlConnection connection = new SqlConnection(DataConnection))
                {
                    connection.Open();

                    string query = @"SELECT room.RoomID, room.RoomType FROM Room room WHERE room.RoomType = @RoomType AND room.RoomID NOT IN (SELECT booking.RoomID FROM Booking booking WHERE (@FromDate < booking.CheckOut) AND (@ToDate > booking.CheckIn) )";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@RoomType", roomType);
                        cmd.Parameters.AddWithValue("@FromDate", checkIn);
                        cmd.Parameters.AddWithValue("@ToDate", checkOut);

                        DataTable dataTable = new DataTable();
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                        dataAdapter.Fill(dataTable);

                        dataGridView1.DataSource = dataTable;

                        if (dataTable.Rows.Count == 0)
                        {
                            MessageBox.Show("No rooms available for the selected time period.");
                        }

                    }
                }
                roomSelection = -1; // selection back to clear
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error in database");
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
            string idNo = IdNobox.Text.Trim(); // the receptionist types this in

            using (SqlConnection connection = new SqlConnection(DataConnection))
            {
                string query = "select * from guest where IdNo = @IdNo";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdNo", idNo);

                connection.Open();

                SqlDataReader dataReader = command.ExecuteReader();

                if (dataReader.Read())
                {
                    idtbox.Text = dataReader["GuestID"].ToString();
                    emailtbox.Text = dataReader["Email"].ToString();
                    nametbox.Text = dataReader["Name"].ToString();
                    phonetbox.Text = dataReader["Phone"].ToString();
                    adrtbox.Text = dataReader["Address"].ToString();

                }

                else
                {
                    dataReader.Close();
                    DialogResult guestNotFound = MessageBox.Show("Guest not found", "Add new guest?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (guestNotFound == DialogResult.Yes)
                    {
                        ShowAddGuestPanel(idNo);
                    }



                }
                connection.Close();
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
            int room_id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["RoomID"].Value);
            
            double seasonRate = getRate(checkIn);
            int totalNights = (checkOut - checkIn).Days;
            double totalAmount = totalNights * seasonRate;

            double deposit = totalAmount * 0.10;

            string resNo = HotelManagementSystem_Group_3_5.Business.Booking.GenerateReferenceNumber();

            string message = $"Guest Account Created.\n" + $"Reservation No: {resNo}\n" + $"Deposit (10%): R{deposit:F2}";

            MessageBox.Show(message, "Reservation Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            reservationBox.Text = resNo;
            depositBox.Text = deposit.ToString("F2");

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
