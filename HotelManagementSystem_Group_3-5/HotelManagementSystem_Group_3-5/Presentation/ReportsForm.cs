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
            panelSub.Visible = true;
            label3.Text = "Bookings Report";
            label4.Visible = false;
            label5.Visible = false;

            dataGridViewReports.Visible = true;
            dataGridViewReports.DataSource = null;
            dataGridViewReports.Columns.Clear();
            dataGridViewReports.Rows.Clear();

            // Use ArrivalDate / DepartureDate, TotalAmount, DepositAmount, Guest.Name
            string query = @"
                SELECT 
                    g.Name AS [Guest Name],
                    CONVERT(VARCHAR(10), b.ArrivalDate, 103) AS [Arrival Date],
                    CONVERT(VARCHAR(10), b.DepartureDate, 103) AS [Departure Date],
                    DATEDIFF(DAY, b.ArrivalDate, b.DepartureDate) AS [Nights],
                    -- Get seasonal rate for the booking's arrival date (if any)
                    sr.Rate AS [Rate],
                    -- Totals and deposit from Booking table
                    b.TotalAmount AS [Total Charge],
                    b.DepositAmount AS [Deposit],
                    (b.TotalAmount - b.DepositAmount) AS [Balance]
                FROM Booking b
                LEFT JOIN Guest g ON b.GuestID = g.GuestID
                LEFT JOIN SeasonalRate sr ON b.ArrivalDate BETWEEN sr.StartDate AND sr.EndDate
                ORDER BY b.ArrivalDate;";

            try
            {
                using (SqlConnection con = new SqlConnection(strConn))
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    // Format numeric columns client-side if you want nicer output:
                    // e.g. convert decimal to "R{0:N2}" in the grid's CellFormatting event (optional)

                    dataGridViewReports.DataSource = table;

                    // Optional: set column headers widths / formats
                    if (dataGridViewReports.Columns["Rate"] != null)
                        dataGridViewReports.Columns["Rate"].HeaderText = "Rate (R)";
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
            panelSub.Visible = true;
            label3.Text = "Occupancy Report Levels";
            label4.Visible = true;
            label5.Visible = true;

            dataGridViewReports.Visible = true;
            dataGridViewReports.DataSource = null;
            dataGridViewReports.Columns.Clear();
            dataGridViewReports.Rows.Clear();

            // IMPORTANT: you can replace the hard-coded date list below with dynamic input (date pickers) if desired.
            // This query uses ArrivalDate/DepartureDate and counts bookings where DepositPaid = 1 (confirmed).
            string query = @"
                -- Example date range; replace or parameterize as needed
                WITH Dates AS (
                    SELECT CAST('2025-12-24' AS DATE) AS ReportDate
                    UNION ALL SELECT CAST('2025-12-25' AS DATE)
                    UNION ALL SELECT CAST('2025-12-26' AS DATE)
                    UNION ALL SELECT CAST('2025-12-27' AS DATE)
                    UNION ALL SELECT CAST('2025-12-28' AS DATE)
                ),
                RoomCount AS (
                    SELECT COUNT(*) AS TotalRooms FROM Room
                )
                SELECT
                    d.ReportDate AS [Date],
                    r.TotalRooms AS [Total Rooms],
                    ISNULL(COUNT(b.RoomID), 0) AS [Confirmed Bookings],
                    (r.TotalRooms - ISNULL(COUNT(b.RoomID), 0)) AS [Rooms Available],
                    CONCAT( CAST( ISNULL(COUNT(b.RoomID),0) * 100.0 / r.TotalRooms AS DECIMAL(5,2) ), '%' ) AS [Occupancy Rate]
                FROM Dates d
                CROSS JOIN RoomCount r
                LEFT JOIN Booking b
                    ON d.ReportDate >= CAST(b.ArrivalDate AS DATE)
                    AND d.ReportDate < CAST(b.DepartureDate AS DATE)  -- occupancy on night-based model
                    AND b.DepositPaid = 1                             -- only confirmed bookings contribute to occupancy
                GROUP BY d.ReportDate, r.TotalRooms
                ORDER BY d.ReportDate;
            ";

            try
            {
                using (SqlConnection con = new SqlConnection(strConn))
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                {
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

