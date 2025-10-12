using HotelManagementSystem_Group_3_5.Business;
using HotelManagementSystem_Group_3_5.Data;
using HotelManagementSystem_Group_3_5.Properties;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
// Group 3-5
// Members:
// Shakila Africa : AFRSHA001
// Chai Europa : ERPTEA001
// Lilitha Somana : SMNBON004
// Lindani Xaba : XBXLIN006

namespace HotelManagementSystem_Group_3_5.Presentation
{
    public partial class ChangeBookingForm : Form
    {
        private string strConn = Properties.Settings.Default.PhumlaKamnandiDatabaseConnectionString;

        public ChangeBookingForm()
        {
            InitializeComponent();
        }

        private void ChangeBookingForm_Load(object sender, EventArgs e)
        {
            LoadAllBookings();
        }

        private void LoadAllBookings()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    string query = @"
                        SELECT 
                            b.ReferenceNumber AS [Reference #],
                            g.Name AS [Guest Name],
                            b.RoomNumber AS [Room #],
                            b.ArrivalDate AS [Check-in],
                            b.DepartureDate AS [Check-out],
                            b.TotalAmount AS [Total Amount],
                            b.DepositAmount AS [Deposit]
                        FROM Booking b
                        INNER JOIN Guest g ON b.GuestID = g.GuestID
                        WHERE b.DepartureDate >= GETDATE()
                        ORDER BY b.ArrivalDate ASC;";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading bookings:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchBooking_Click(object sender, EventArgs e)
        {
            string referenceNumber = referencetbox.Text.Trim();

            if (string.IsNullOrEmpty(referenceNumber))
            {
                LoadAllBookings();
                return;
            }

            LoadBookingByReference(referenceNumber);
        }

        private void LoadBookingByReference(string referenceNumber)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    string query = @"
                        SELECT 
                            b.ReferenceNumber AS [Reference #],
                            g.Name AS [Guest Name],
                            b.RoomNumber AS [Room #],
                            b.ArrivalDate AS [Check-in],
                            b.DepartureDate AS [Check-out],
                            b.TotalAmount AS [Total Amount],
                            b.DepositAmount AS [Deposit]
                        FROM Booking b
                        INNER JOIN Guest g ON b.GuestID = g.GuestID
                        WHERE b.ReferenceNumber = @Reference;";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Reference", referenceNumber);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;

                    if (dt.Rows.Count == 0)
                        MessageBox.Show("No booking found for this reference number.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading booking:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a booking to change.", "No Booking Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dataGridView2.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an available room.", "No Room Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string referenceNumber = dataGridView1.SelectedRows[0].Cells["Reference #"].Value.ToString();
            string newRoomID = dataGridView2.SelectedRows[0].Cells["RoomID"].Value.ToString();
            DateTime newCheckIn = dateTimePicker1.Value.Date;
            DateTime newCheckOut = dateTimePicker2.Value.Date;

            DialogResult confirm = MessageBox.Show(
                $"Are you sure you want to update this booking?\n\n" +
                $"Reference: {referenceNumber}\n" +
                $"Room: {newRoomID}\n" +
                $"Check-in: {newCheckIn:dd/MM/yyyy}\n" +
                $"Check-out: {newCheckOut:dd/MM/yyyy}",
                "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                UpdateBooking(referenceNumber, newRoomID, newCheckIn, newCheckOut);
            }
        }

        private void ShowAvailableRooms(DateTime newCheckIn, DateTime newCheckOut, string referenceNumber)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    string getTypeQuery = @"
                        SELECT r.RoomType
                        FROM Booking b
                        INNER JOIN Room r ON b.RoomNumber = r.RoomNumber
                        WHERE b.ReferenceNumber = @Ref";

                    string roomType = "";
                    using (SqlCommand getTypeCmd = new SqlCommand(getTypeQuery, conn))
                    {
                        getTypeCmd.Parameters.AddWithValue("@Ref", referenceNumber);
                        conn.Open();
                        var result = getTypeCmd.ExecuteScalar();
                        conn.Close();

                        if (result == null)
                        {
                            MessageBox.Show("Could not determine the room type for this booking.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        roomType = result.ToString();
                    }

                    string query = @"
                        SELECT r.RoomID, r.RoomNumber, r.RoomType
                        FROM Room r
                        WHERE r.RoomType = @roomType
                        AND r.RoomID NOT IN (
                            SELECT RoomID
                            FROM Booking
                            WHERE NOT(@checkOut <= ArrivalDate OR @checkIn >= DepartureDate)
                        )
                        ORDER BY r.RoomNumber;";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@roomType", roomType);
                        cmd.Parameters.AddWithValue("@checkIn", newCheckIn);
                        cmd.Parameters.AddWithValue("@checkOut", newCheckOut);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView2.DataSource = dt;

                        if (dt.Rows.Count == 0)
                            MessageBox.Show("No rooms available for these dates.", "No Availability", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Select a room from the list below to confirm the change.", "Rooms Available", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking available rooms:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateBooking(string referenceNumber, string roomID, DateTime checkIn, DateTime checkOut)
        {
            string query = @"
                UPDATE Booking
                SET RoomID = @roomID, ArrivalDate = @checkIn, DepartureDate = @checkOut
                WHERE ReferenceNumber = @ref";

            using (SqlConnection conn = new SqlConnection(Settings.Default.PhumlaKamnandiDatabaseConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@roomID", roomID);
                cmd.Parameters.AddWithValue("@checkIn", checkIn);
                cmd.Parameters.AddWithValue("@checkOut", checkOut);
                cmd.Parameters.AddWithValue("@ref", referenceNumber);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            MessageBox.Show("Booking updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a booking first.", "No Booking Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime checkIn = dateTimePicker1.Value.Date;
            DateTime checkOut = dateTimePicker2.Value.Date;

            if (checkOut <= checkIn)
            {
                MessageBox.Show("Check-out date must be after check-in date.", "Invalid Dates", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string referenceNumber = dataGridView1.SelectedRows[0].Cells["Reference #"].Value.ToString();
            ShowAvailableRooms(checkIn, checkOut, referenceNumber);
        }
    }
}
