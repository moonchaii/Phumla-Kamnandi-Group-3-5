using HotelManagementSystem_Group_3_5.Properties;
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
    public partial class ReportsForm : Form
    {

        private string strConn = Settings.Default.PhumlaKamnandiDatabaseConnectionString;

        public ReportsForm()
        {
            InitializeComponent();

            
            this.Load += ReportsForm_Load;
            comboBoxReportType.SelectedIndexChanged += comboBoxReportType_SelectedIndexChanged;
        }

        // Form Load
        private void ReportsForm_Load(object sender, EventArgs e)
        {
            
            dataGridViewReports.Visible = false;
            panelSub.Visible = false;
            label4.Visible = false;
            label5.Visible = false;

            // Load combo box options
            comboBoxReportType.Items.Clear();
            comboBoxReportType.Items.Add("Occupancy");
            comboBoxReportType.Items.Add("Booking");
            comboBoxReportType.SelectedIndex = -1; // No item selected
        }

        // ComboBox selection changed
        private void comboBoxReportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxReportType.SelectedItem == null)
                return;

            string selectedReport = comboBoxReportType.SelectedItem.ToString();

            if (selectedReport == "Booking")
            {
                LoadBookingReport();
            }
            else if (selectedReport == "Occupancy")
            {
                LoadOccupancyReport();
            }
        }

        // Load Booking Report
        private void LoadBookingReport()
        {
            // Hide occupancy panel/labels
           
            panelSub.Visible = true;
            label3.Text = "Bookings Report";
            label4.Visible = false;
            label5.Visible = false;

            
            dataGridViewReports.Visible = true;
            dataGridViewReports.DataSource = null;
            dataGridViewReports.Columns.Clear();
            dataGridViewReports.Rows.Clear();

            string query = @"
                SELECT 
                    g.Name AS [Guest Name],
                    CONVERT(varchar, b.CheckIn, 106) AS [Check-in],
                    CONVERT(varchar, b.CheckOut, 106) AS [Check-out],
                    DATEDIFF(DAY, b.CheckIn, b.CheckOut) AS [Nights],
                    CONCAT('R', s.Rate, '.00') AS [Rate],
                    CONCAT('R', b.Payment, '.00') AS [Total Charge],
                    CONCAT('R', b.Deposit, '.00') AS [Deposit],
                    CONCAT('R', (b.Payment - b.Deposit), '.00') AS [Balance]
                FROM Booking b
                JOIN Guest g ON b.GuestID = g.GuestID
                JOIN SeasonalRate s ON b.SeasonID = s.SeasonID
                ORDER BY b.CheckIn;
            ";

            try
            {
                using (SqlConnection con = new SqlConnection(strConn))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridViewReports.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading booking report: " + ex.Message);
            }
        }

        // Load Occupancy Report
        private void LoadOccupancyReport()
        {
            // Show occupancy panel/labels
            
            panelSub.Visible = true;
            label3.Text = "Occupancy Report Levels";
            label4.Visible = true;
            label5.Visible = true;

            // Show DataGridView and clear previous data safely
            dataGridViewReports.Visible = true;
            dataGridViewReports.DataSource = null;
            dataGridViewReports.Columns.Clear();
            dataGridViewReports.Rows.Clear();

            string query = @"
        -- Generate report for dates 2025-12-24 to 2025-12-28
        SELECT
            d.DateValue AS [Date],
            r.TotalRooms,
            ISNULL(COUNT(b.RoomID),0) AS [Confirmed Bookings],
            (r.TotalRooms - ISNULL(COUNT(b.RoomID),0)) AS [Rooms Available],
            CONCAT(CAST(ISNULL(COUNT(b.RoomID),0) * 100.0 / r.TotalRooms AS decimal(5,2)), '%') AS [Occupancy Rate]
        FROM
        (
            -- Generate each date in the range
            SELECT CAST('2025-12-24' AS DATE) AS DateValue
            UNION ALL SELECT CAST('2025-12-25' AS DATE)
            UNION ALL SELECT CAST('2025-12-26' AS DATE)
            UNION ALL SELECT CAST('2025-12-27' AS DATE)
            UNION ALL SELECT CAST('2025-12-28' AS DATE)
        ) d
        CROSS APPLY
        (
            SELECT COUNT(*) AS TotalRooms FROM Room
        ) r
        LEFT JOIN Booking b
            ON d.DateValue >= b.CheckIn AND d.DateValue < b.CheckOut
            AND b.BookingStatus = 'Confirmed'
        GROUP BY d.DateValue, r.TotalRooms
        ORDER BY d.DateValue;
    ";

            try
            {
                using (SqlConnection con = new SqlConnection(strConn))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridViewReports.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading occupancy report: " + ex.Message);
            }
        }

        
    }
}

