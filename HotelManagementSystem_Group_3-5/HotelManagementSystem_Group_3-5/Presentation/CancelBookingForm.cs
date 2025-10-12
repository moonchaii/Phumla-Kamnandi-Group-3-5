using HotelManagementSystem_Group_3_5.Business;
using HotelManagementSystem_Group_3_5.Data;
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



namespace HotelManagementSystem_Group_3_5.Presentation
{
    public partial class CancelBookingForm : Form
    {
        public CancelBookingForm()
        {
            InitializeComponent();
            button2.Click += button2_Click;
            button1.Click += button1_Click;
            this.Load += CancelBookingForm_Load;
        }

        private void CancelBookingForm_Load(object sender, EventArgs e)
        {
            LoadAllBookings();
        }

        private void LoadAllBookings()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.PhumlaKamnandiDatabaseConnectionString))
                {
                    string query = @"
                        SELECT 
                            b.ReferenceNumber AS [Reference #],
                            g.Name AS [Guest Name],
                            b.RoomNumber AS [Room #],
                            b.ArrivalDate AS [Arrival Date],
                            b.DepartureDate AS [Departure Date],
                            b.TotalAmount AS [Total Amount],
                            'Confirmed' AS [Booking Status]
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
                MessageBox.Show("Error loading bookings:\n" + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ✅ Search by reference number
        private void button1_Click(object sender, EventArgs e)
        {
            string referenceNumber = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(referenceNumber))
            {
                MessageBox.Show("Please enter a reference number.", "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LoadBookingByReference(referenceNumber);
        }

        private void LoadBookingByReference(string referenceNumber)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.PhumlaKamnandiDatabaseConnectionString))
                {
                    string query = @"
                        SELECT 
                            b.ReferenceNumber AS [Reference #],
                            g.Name AS [Guest Name],
                            b.RoomNumber AS [Room #],
                            b.ArrivalDate AS [Arrival Date],
                            b.DepartureDate AS [Departure Date],
                            b.TotalAmount AS [Total Amount],
                            'Confirmed' AS [Booking Status]
                        FROM Booking b
                        INNER JOIN Guest g ON b.GuestID = g.GuestID
                        WHERE b.ReferenceNumber = @Reference;";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Reference", referenceNumber);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("No booking found with that reference number.",
                                "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            button1.Enabled = false;
                        }
                        else
                        {
                            dataGridView1.DataSource = dt;
                            button1.Enabled = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading booking:\n" + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a booking to cancel.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string referenceNumber = dataGridView1.SelectedRows[0].Cells["Reference #"].Value.ToString();
            string guestName = dataGridView1.SelectedRows[0].Cells["Guest Name"].Value.ToString();
            string roomNumber = dataGridView1.SelectedRows[0].Cells["Room #"].Value.ToString();
            DateTime arrivalDate = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells["Arrival Date"].Value);
            DateTime departureDate = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells["Departure Date"].Value);

            DialogResult confirm = MessageBox.Show(
                $"Are you sure you want to cancel this booking?\n\n" +
                $"Reference: {referenceNumber}\n" +
                $"Guest: {guestName}\n" +
                $"Room: {roomNumber}\n" +
                $"Arrival: {arrivalDate:dd MMM yyyy}\n" +
                $"Departure: {departureDate:dd MMM yyyy}",
                "Confirm Cancellation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                CancelBooking(referenceNumber);
            }
        }

        private void CancelBooking(string referenceNumber)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.PhumlaKamnandiDatabaseConnectionString))
                {
                    string deleteQuery = "DELETE FROM Booking WHERE ReferenceNumber = @Reference";
                    using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Reference", referenceNumber);
                        conn.Open();
                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show($"Booking {referenceNumber} successfully cancelled.",
                                "Cancellation Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadAllBookings();
                        }
                        else
                        {
                            MessageBox.Show("Booking not found or already deleted.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cancelling booking:\n" + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


    
