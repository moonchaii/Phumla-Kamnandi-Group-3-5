using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem_Group_3_5.Presentation
{
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
        }

     
  
        private void ReportsForm_Load(object sender, EventArgs e)
        {
            comboBoxReportType.Items.Clear();
            comboBoxReportType.Items.Add("Occupancy");
            comboBoxReportType.Items.Add("Booking");

            comboBoxReportType.SelectedIndexChanged += comboBoxReportType_SelectedIndexChanged;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxReportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedReport = comboBoxReportType.SelectedItem.ToString();

            if (selectedReport == "Occupancy")
            {
                // Example: Show Occupancy report in DataGridView
                dataGridViewReport.Visible = true;

                // Clear old data
                dataGridViewReport.Columns.Clear();
                dataGridViewReport.Rows.Clear();

                // Add columns
                dataGridViewReport.Columns.Add("Date", "Date");
                dataGridViewReport.Columns.Add("TotalRooms", "Total Rooms");
                dataGridViewReport.Columns.Add("ConfirmedBookings", "Confirmed Bookings");
                dataGridViewReport.Columns.Add("RoomsAvailable", "Rooms Available");
                dataGridViewReport.Columns.Add("OccupancyRate", "Occupancy Rate");

                // Add sample data (in real case, load from DB)
                dataGridViewReport.Rows.Add("Dec 25, 2025", 5, 5, 0, "100%");
                dataGridViewReport.Rows.Add("Dec 26, 2025", 5, 5, 0, "100%");
                dataGridViewReport.Rows.Add("Dec 27, 2025", 5, 4, 1, "80%");
                dataGridViewReport.Rows.Add("Dec 28, 2025", 5, 4, 1, "80%");
                dataGridViewReport.Rows.Add("Total/Avg", 5, "-", "-", "90%");
            }
            else if (selectedReport == "Booking")
            {
                
                MessageBox.Show("Generating Booking Report...");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
