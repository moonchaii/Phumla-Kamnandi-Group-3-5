using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem_Group_3_5.Presentation
{
    public partial class EnquiryForm : Form
    {
        public EnquiryForm()
        {
            InitializeComponent();
            buttonSearch.Click += buttonSearch_Click;
            this.Load += EnquiryForm_Load;
        }

      

        private void EnquiryForm_Load(object sender, EventArgs e)
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
                            b.TotalAmount AS [Total Amount],
                            b.ArrivalDate AS [Arrival Date],
                            b.DepartureDate AS [Departure Date],
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
                MessageBox.Show("Error loading bookings:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string referenceNumber = textBoxReferenceSpace.Text.Trim();
            if (string.IsNullOrEmpty(referenceNumber))
            {
                MessageBox.Show("Please enter a reference number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            loadBookingByReference(referenceNumber);
        }

        private void loadBookingByReference(string referenceNumber)
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
                            b.TotalAmount AS [Total Amount],
                            b.ArrivalDate AS [Arrival Date],
                            b.DepartureDate AS [Departure Date],
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
                            MessageBox.Show("No booking found with the provided reference number.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        dataGridView1.DataSource = dt;
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error loading booking:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
