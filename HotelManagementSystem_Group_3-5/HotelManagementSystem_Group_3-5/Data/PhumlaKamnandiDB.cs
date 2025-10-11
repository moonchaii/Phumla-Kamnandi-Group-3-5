using HotelManagementSystem_Group_3_5.Business;
using HotelManagementSystem_Group_3_5.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            //Declare references to a myRow object and an Employee object
            DataRow myRow = null;
            
            //READ from the table  
            foreach (DataRow row in dsMain.Tables[table].Rows)
            {
                myRow = row;
                if (!(myRow.RowState == DataRowState.Deleted))
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

            int returnValue = -1;

            foreach (DataRow oneRow in dsMain.Tables[table].Rows)
            {
                if (oneRow.RowState != DataRowState.Deleted)
                {
                    if (booking.ReferenceNumber == (string)oneRow["ReferenceNumber"])
                    {
                        returnValue = rowIndex;
                        break;
                    }
                }
                rowIndex++;
            }

            return returnValue;
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
                    //Add to the dataset
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

            param = new SqlParameter("@GuestID", SqlDbType.BigInt, 8, "GuestID");
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

            param = new SqlParameter("@ArrivalDate", SqlDbType.NVarChar, 15, "ArrivalDatw");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@DepartureDate", SqlDbType.TinyInt, 1, "DepartureDate");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@DateCreated", SqlDbType.TinyInt, 1, "DateCreated");
            daMain.InsertCommand.Parameters.Add(param);
        }

        private void Create_INSERT_Command(Booking booking)
        {
            //Create the command that must be used to insert values into the Books table..
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

            param = new SqlParameter("@GuestID", SqlDbType.BigInt, 8, "GuestID");
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

            param = new SqlParameter("@ArrivalDate", SqlDbType.NVarChar, 15, "ArrivalDate");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@DepartureDate", SqlDbType.TinyInt, 1, "DepartureDate");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@DateCreated", SqlDbType.TinyInt, 1, "DateCreated");
            daMain.InsertCommand.Parameters.Add(param);
        }

        private void Create_UPDATE_Command(Booking booking)
        {
            daMain.UpdateCommand = new SqlCommand("UPDATE Booking SET GuestID = @GuestID, RoomID = @RoomID, RoomNumber = @RoomNumber, TotalAmount = @TotalAmount, DepositAmount = @DepositAmount, DepositPaid = @DepositPaid, ArrivalDate = @ArrivalDate, DepartureDate = @DepartureDate, DateCreated = @DateCreated WHERE ReferenceNumber = @ReferenceNumber", cnMain);
            Build_UPDATE_Parameters(booking);
        }
        #endregion
    }
}
