using System;
using System.Collections.Generic;
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

namespace HotelManagementSystem_Group_3_5.Presentation
{
    public partial class MakeBookingForm : Form
    {
        public MakeBookingForm()
        {
            InitializeComponent();
        }

        private void MakeBookingForm_Load(object sender, EventArgs e)
        {

            comboBoxRoomType.Items.Clear();
            comboBoxRoomType.Items.Add("Single");
            comboBoxRoomType.SelectedIndex = 0; // get index of currently selected item in combobox
        }

        private string DataConnection = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PKDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"; // must change the connection link here
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
                            MessageBox.Show("Error - no data");
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
    }
}

