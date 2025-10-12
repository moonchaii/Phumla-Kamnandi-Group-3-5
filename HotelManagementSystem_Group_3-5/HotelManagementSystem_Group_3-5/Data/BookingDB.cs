using HotelManagementSystem_Group_3_5.Business;
using HotelManagementSystem_Group_3_5.Data;
using HotelManagementSystem_Group_3_5.Properties;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem_Group_3_5.Data
{
    public class BookingDB : DB
    {
        #region  Data members        
        private string table = "Booking";
        private string sqlLocal = "SELECT * FROM Booking";

        private Collection<Booking> bookings;

        #endregion

        #region Property Method: Collection
        public Collection<Booking> AllBookings
        {
            get
            {
                return bookings;
            }
        }
        #endregion

        #region Constructor
        public BookingDB() : base()
        {
            bookings = new Collection<Booking>();
            FillDataSet(sqlLocal, table);
            Add2Collection(table);
        }
        #endregion

        #region Utility Methods
        public DataSet GetDataSet()
        {
            return dsMain;
        }
        private void Add2Collection(string table)
        {
            //READ from the table  
            foreach (DataRow row in dsMain.Tables[table].Rows)
            {
                if (!(row.RowState == DataRowState.Deleted))
                {
                    //Instantiate a new Employee object
                    Booking booking = new Booking();
                    
                    booking.ReferenceNumber = row["ReferenceNumber"].ToString();
                    booking.GuestID = row["GuestID"].ToString();
                    booking.RoomID = row["RoomID"].ToString();
                    booking.RoomNumber = Convert.ToInt32(row["RoomNumber"]);
                    booking.TotalAmount = Convert.ToDecimal(row["TotalAmount"]);
                    booking.DepositAmount = Convert.ToDecimal(row["DepositAmount"]);
                    booking.DepositPaid = Convert.ToBoolean(row["DepositPaid"]);
                    booking.ArrivalDate = Convert.ToDateTime(row["ArrivalDate"]);
                    booking.DepartureDate = Convert.ToDateTime(row["DepartureDate"]);
                    booking.DateCreated = Convert.ToDateTime(row["DateCreated"]);

                    bookings.Add(booking);
                }
            }
        }
        private void FillRow(DataRow aRow, Booking booking, DB.DBOperation operation)
        {
            if (operation == DB.DBOperation.Add)
            {
                aRow["ReferenceNumber"] = booking.ReferenceNumber;
            }
            aRow["GuestID"] = booking.GuestID;
            aRow["RoomID"] = booking.RoomID;
            aRow["RoomNumber"] = booking.RoomNumber;
            aRow["TotalAmount"] = booking.TotalAmount;
            aRow["DepositAmount"] = booking.DepositAmount;
            aRow["DepositPaid"] = booking.DepositPaid;
            aRow["ArrivalDate"] = booking.ArrivalDate;
            aRow["DepartureDate"] = booking.DepartureDate;
            aRow["DateCreated"] = booking.DateCreated;
        }

        private int FindRow(Booking booking, string table)
        {
            int rowIndex = 0;

            foreach (DataRow oneRow in dsMain.Tables[table].Rows)
            {
                if (oneRow.RowState != DataRowState.Deleted)
                {
                    if (booking.ReferenceNumber == (string)oneRow["ReferenceNumber"])
                    {
                        return rowIndex;
                    }
                }
                rowIndex++;
            }

            return -1;
        }
        #endregion

        #region Database Operations CRUD
        public void DataSetChange(Booking booking, DB.DBOperation operation)
        {
            DataRow aRow = null;
            string dataTable = table;

            switch (operation)
            {
                case DB.DBOperation.Add:
                    aRow = dsMain.Tables[dataTable].NewRow();
                    FillRow(aRow, booking, operation);
                    dsMain.Tables[dataTable].Rows.Add(aRow);
                    break;

                case DB.DBOperation.Edit:
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(booking, dataTable)];
                    FillRow(aRow, booking, operation);
                    break;

                case DB.DBOperation.Delete:
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(booking, dataTable)];
                    if (aRow != null)
                    {
                        aRow.Delete();
                    }
                    break;
            }

        }
        #endregion

        #region Build Parameters, Create Commands & Update database
        private void Build_INSERT_Parameters(Booking booking)
        {
            SqlParameter param = default(SqlParameter);

            param = new SqlParameter("@ReferenceNumber", SqlDbType.NVarChar, 15, "ReferenceNumber");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@GuestID", SqlDbType.NVarChar, 15, "GuestID");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@RoomID", SqlDbType.NVarChar, 15, "RoomID");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@RoomNumber", SqlDbType.Int, 4, "RoomNumber");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@TotalAmount", SqlDbType.Money, 8, "TotalAmount");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@DepositAmount", SqlDbType.Money, 8, "DepositAmount");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@DepositPaid", SqlDbType.Bit, 1, "DepositPaid");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@ArrivalDate", SqlDbType.Date, 8, "ArrivalDate");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@DepartureDate", SqlDbType.Date, 8, "DepartureDate");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@DateCreated", SqlDbType.Date, 8, "DateCreated");
            daMain.InsertCommand.Parameters.Add(param);
        }

        private void Create_INSERT_Command(Booking booking)
        {
            daMain.InsertCommand = new SqlCommand("INSERT INTO Booking (ReferenceNumber, GuestID, RoomID, RoomNumber, TotalAmount, DepositAmount, DepositPaid, ArrivalDate, DepartureDate, DateCreated) "
                + "VALUES (@ReferenceNumber, @GuestID, @RoomID, @RoomNumber, @TotalAmount, @DepositAmount, @DepositPaid, @ArrivalDate, @DepartureDate, @DateCreated)", cnMain);
            Build_INSERT_Parameters(booking);
        }

        public bool UpdateDataSource(Booking booking)
        {
            bool success = true;

            Create_INSERT_Command(booking);
            Create_UPDATE_Command(booking);
            
            success = UpdateDataSource(sqlLocal, table);
            
            return success;
        }

        private void Build_UPDATE_Parameters(Booking booking)
        {
            SqlParameter param = default(SqlParameter);

            param = new SqlParameter("@ReferenceNumber", SqlDbType.NVarChar, 15, "ReferenceNumber");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@GuestID", SqlDbType.NVarChar, 15, "GuestID");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@RoomID", SqlDbType.NVarChar, 15, "RoomID");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@RoomNumber", SqlDbType.Int, 4, "RoomNumber");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@TotalAmount", SqlDbType.Money, 8, "TotalAmount");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@DepositAmount", SqlDbType.Money, 8, "DepositAmount");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@DepositPaid", SqlDbType.Bit, 1, "DepositPaid");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@ArrivalDate", SqlDbType.Date, 8, "ArrivalDate");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@DepartureDate", SqlDbType.Date, 8, "DepartureDate");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@DateCreated", SqlDbType.Date, 8, "DateCreated");
            daMain.InsertCommand.Parameters.Add(param);
        }

        private void Create_UPDATE_Command(Booking booking)
        {
            daMain.UpdateCommand = new SqlCommand("UPDATE Booking SET GuestID = @GuestID, RoomID = @RoomID, RoomNumber = @RoomNumber, TotalAmount = @TotalAmount, DepositAmount = @DepositAmount, DepositPaid = @DepositPaid, ArrivalDate = @ArrivalDate, DepartureDate = @DepartureDate, DateCreated = @DateCreated WHERE ReferenceNumber = @ReferenceNumber", cnMain);
            Build_UPDATE_Parameters(booking);
        }
        #endregion

        #region Methods
        public DataTable GetAvailableRooms(string roomType, DateTime fromDate, DateTime toDate)
        {
            DataTable dt = new DataTable();
            string sql = @"
                SELECT r.RoomID, r.RoomNumber
                FROM Room r
                WHERE r.RoomType = @roomType
                AND r.RoomID NOT IN (
                    SELECT RoomID
                    FROM Booking
                    WHERE NOT (@checkOut <= ArrivalDate OR @checkIn >= DepartureDate)
                )
                ORDER BY r.RoomNumber";

            using (SqlConnection cn = new SqlConnection(Settings.Default.PhumlaKamnandiDatabaseConnectionString))
            using (SqlCommand cmd = new SqlCommand(sql, cn))
            {
                cmd.Parameters.AddWithValue("@roomType", roomType);
                cmd.Parameters.AddWithValue("@checkIn", fromDate);
                cmd.Parameters.AddWithValue("@checkOut", toDate);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            return dt;
        }

        public bool AddBooking(Booking booking)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Settings.Default.PhumlaKamnandiDatabaseConnectionString))
                {
                    con.Open();
                    string query = @"
                INSERT INTO Booking 
                    (ReferenceNumber, GuestID, RoomID, RoomNumber, TotalAmount, DepositAmount, DepositPaid, ArrivalDate, DepartureDate, DateCreated)
                VALUES 
                    (@ReferenceNumber, @GuestID, @RoomID, @RoomNumber, @TotalAmount, @DepositAmount, @DepositPaid, @ArrivalDate, @DepartureDate, @DateCreated)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ReferenceNumber", booking.ReferenceNumber);
                        cmd.Parameters.AddWithValue("@GuestID", booking.GuestID);
                        cmd.Parameters.AddWithValue("@RoomID", booking.RoomID);
                        cmd.Parameters.AddWithValue("@RoomNumber", booking.RoomNumber);
                        cmd.Parameters.AddWithValue("@TotalAmount", booking.TotalAmount);
                        cmd.Parameters.AddWithValue("@DepositAmount", booking.DepositAmount);
                        cmd.Parameters.AddWithValue("@DepositPaid", booking.DepositPaid);
                        cmd.Parameters.AddWithValue("@ArrivalDate", booking.ArrivalDate);
                        cmd.Parameters.AddWithValue("@DepartureDate", booking.DepartureDate);
                        cmd.Parameters.AddWithValue("@DateCreated", booking.DateCreated);

                        int rows = cmd.ExecuteNonQuery();
                        return rows > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving booking: {ex.Message}");
                return false;
            }
        }


        public double GetSeasonalRate(DateTime checkIn)
        {
            double rate = 0;

            try
            {
                string sql = "SELECT TOP 1 Rate FROM SeasonalRate WHERE @CheckIn BETWEEN StartDate AND EndDate";

                using (SqlCommand cmd = new SqlCommand(sql, cnMain))
                {
                    cmd.Parameters.AddWithValue("@CheckIn", checkIn);
                    cnMain.Open();
                    object rateAmount = cmd.ExecuteScalar();
                    cnMain.Close();

                    if (rateAmount != null)
                        rate = Convert.ToDouble(rateAmount);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            return rate;
        }
        #endregion
    }
}
