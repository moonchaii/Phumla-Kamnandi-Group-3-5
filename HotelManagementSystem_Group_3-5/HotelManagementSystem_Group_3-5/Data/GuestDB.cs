using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections.ObjectModel;
using HotelManagementSystem_Group_3_5.Business;
using HotelManagementSystem_Group_3_5.Properties;


namespace HotelManagementSystem_Group_3_5.Data
{
    public class GuestDB : DB
    {
        #region Data Members

        private string table = "Guests";
        private string sqlLocal = "SELECT * FROM Guests";
        private Collection<Guest> guests;

        #endregion

        #region Properties

        public Collection<Guest> AllGuests
        {
            get { return guests; }
        }

        #endregion

        #region Constructor

        public GuestDB() : base()
        {
            guests = new Collection<Guest>();
            FillDataSet(sqlLocal, table);
            Add2Collection(table);
        }

        #endregion

        #region Methods

        public DataSet GetDataSet()
        {
            return dsMain;
        }

        private void Add2Collection(string table)
        {
            DataRow myRow = null;
            Guest guest;
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;

                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    guest = new Guest();
                    guest.GuestID = Convert.ToString(myRow["GuestID"]).TrimEnd();
                    guest.Name = Convert.ToString(myRow["Name"]).TrimEnd();
                    guest.Email = Convert.ToString(myRow["Email"]).TrimEnd();
                    guest.PhoneNum = Convert.ToString(myRow["Phone"]).TrimEnd();
                    guest.Address = Convert.ToString(myRow["Address"]).TrimEnd();
                    guest.Id = Convert.ToString(myRow["IdNo"]).TrimEnd();
                    guests.Add(guest);
                }
            }
        }

        private void FillRow(DataRow aRow, Guest guest, DB.DBOperation operation)
        {
            if (operation == DB.DBOperation.Add)
            {
                aRow["IdNo"] = guest.Id;
                aRow["GuestID"] = guest.GuestID;
            }
            aRow["IdNo"] = guest.Id;
            aRow["GuestID"] = guest.GuestID;
            aRow["Name"] = guest.Name;
            aRow["Email"] = guest.Email;
            aRow["Phone"] = guest.PhoneNum;
            aRow["Address"] = guest.Address;
        }

        private int FindRow(Guest guest, string table)
        {
            int rowIndex = 0;
            DataRow myRow;
            int returnValue = -1;

            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (myRow.RowState != DataRowState.Deleted)
                {
                    if (guest.Id == Convert.ToString(dsMain.Tables[table].Rows[rowIndex]["IdNo"]))
                    {
                        returnValue = rowIndex;
                    }
                }
                rowIndex++;
            }
            return returnValue;
        }

        #endregion

        #region CRUD operations

        public void DataSetChange(Guest guest, DB.DBOperation operation)
        {
            DataRow aRow = null;
            switch (operation)
            {
                case DB.DBOperation.Add:
                    aRow = dsMain.Tables[table].NewRow();
                    FillRow(aRow, guest, operation);
                    dsMain.Tables[table].Rows.Add(aRow);
                    break;
                case DB.DBOperation.Edit:
                    int rowIndex = FindRow(guest, table);
                    if (rowIndex != -1)
                    {
                        aRow = dsMain.Tables[table].Rows[rowIndex];
                        FillRow(aRow, guest, operation);
                    }
                    break;
                case DB.DBOperation.Delete:
                    int deleteIndex = FindRow(guest, table);
                    if (deleteIndex != -1)
                    {
                        dsMain.Tables[table].Rows[deleteIndex].Delete();
                    }
                    break;
            }
        }

        public bool UpdateDataSource(Guest guest, DB.DBOperation operation)
        {
            bool success = true;
            switch (operation)
            {
                case DB.DBOperation.Add: Create_INSERT_Command(guest); break;
                case DB.DBOperation.Edit: Create_UPDATE_Command(guest); break;
                case DB.DBOperation.Delete: Create_DELETE_Command(guest); break;
            }
            DataSetChange(guest, operation);
            success = UpdateDataSource(sqlLocal, table);
            return success;
        }

        #endregion

        #region Guest Methods

        public Guest FindGuestByIdNumber(string idNumber)
        {
            foreach (Guest guest in guests)
            {
                if (guest.Id == idNumber)
                    return guest;
            }
            return null;
        }

        public bool GuestExists(string idNumber)
        {
            return FindGuestByIdNumber(idNumber) != null;
        }

        #endregion

        #region Build Parameters, Create Commands & Update database

        private void Build_INSERT_Parameters(Guest guest)
        {
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@GuestID", SqlDbType.Int, 50, "GuestID"); daMain.InsertCommand.Parameters.Add(param);
            param = new SqlParameter("@IdNo", SqlDbType.VarChar, 255, "IdNo"); daMain.InsertCommand.Parameters.Add(param);
            param = new SqlParameter("@Name", SqlDbType.VarChar, 255, "Name"); daMain.InsertCommand.Parameters.Add(param);
            //param = new SqlParameter("@LastName", SqlDbType.VarChar, 255, "LastName"); daMain.InsertCommand.Parameters.Add(param);
            param = new SqlParameter("@Email", SqlDbType.VarChar, 255, "Email"); daMain.InsertCommand.Parameters.Add(param);
            param = new SqlParameter("@Phone", SqlDbType.VarChar, 255, "Phone"); daMain.InsertCommand.Parameters.Add(param);
            param = new SqlParameter("@Address", SqlDbType.VarChar, 255, "Address"); daMain.InsertCommand.Parameters.Add(param);
        }

        private void Create_INSERT_Command(Guest guest)
        {
            daMain.InsertCommand = new SqlCommand(
                @"INSERT INTO Guests (GuestID, IdNo, Name, Email, Phone, Address)
                VALUES (@GuestID, @IdNo, @Name, @Email, @Phone, @Address)",
                cnMain);
            Build_INSERT_Parameters(guest);
        }

        private void Build_UPDATE_Parameters(Guest guest)
        {
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@Name", SqlDbType.VarChar, 255, "Name"); param.SourceVersion = DataRowVersion.Current; daMain.UpdateCommand.Parameters.Add(param);
            //param = new SqlParameter("@LastName", SqlDbType.VarChar, 255, "LastName"); param.SourceVersion = DataRowVersion.Current; daMain.UpdateCommand.Parameters.Add(param);
            param = new SqlParameter("@Email", SqlDbType.VarChar, 255, "Email"); param.SourceVersion = DataRowVersion.Current; daMain.UpdateCommand.Parameters.Add(param);
            param = new SqlParameter("@Phone", SqlDbType.VarChar, 255, "Phone"); param.SourceVersion = DataRowVersion.Current; daMain.UpdateCommand.Parameters.Add(param);
            param = new SqlParameter("@Address", SqlDbType.VarChar, 255, "Address"); param.SourceVersion = DataRowVersion.Current; daMain.UpdateCommand.Parameters.Add(param);
            param = new SqlParameter("@GuestID", SqlDbType.Int, 50, "GuestID"); param.SourceVersion = DataRowVersion.Current; daMain.UpdateCommand.Parameters.Add(param);
            param = new SqlParameter("@IdNo", SqlDbType.VarChar, 255, "IdNo"); param.SourceVersion = DataRowVersion.Current; daMain.UpdateCommand.Parameters.Add(param);
        }

        public void Create_UPDATE_Command(Guest guest)
        {
            daMain.UpdateCommand = new SqlCommand(
                @"UPDATE Guests SET Name = @Name, Email = @Email, Phone = @Phone, Address = @Address, 
                GuestID = @GuestID 
                WHERE IdNo = @IdNo", cnMain);
            Build_UPDATE_Parameters(guest);
        }

        private void Build_DELETE_Parameters(Guest guest)
        {
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@IdNo", SqlDbType.VarChar, 255, "IdNo"); param.SourceVersion = DataRowVersion.Original; daMain.DeleteCommand.Parameters.Add(param);
        }

        private void Create_DELETE_Command(Guest guest)
        {
            daMain.DeleteCommand = new SqlCommand("DELETE FROM Guests WHERE IdNo = @IdNo", cnMain);
            Build_DELETE_Parameters(guest);
        }

        #endregion
    }
}
