using HotelManagementSystem_Group_3_5.Business;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HotelManagementSystem_Group_3_5.Data
{
    public class RoomDB : DB
    {
        #region Data Members
        private string table = "Rooms";
        private string sqlLocal = "SELECT * FROM Rooms";
        private Collection<Room> rooms;
        #endregion

        #region Property Method: Collection
        public Collection<Room> AllRooms
        {
            get { return rooms; }
        }
        #endregion

        #region Constructor
        public RoomDB() : base()
        {
            rooms = new Collection<Room>();
            FillDataSet(sqlLocal, table);
            Add2Collection(table);
        }
        #endregion

        #region Utility Methods
        private void Add2Collection(string table)
        {
            DataRow myRow = null;
            Room room;
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    room = new Room();
                    room.RoomID = Convert.ToString(myRow["RoomID"]).TrimEnd();
                    room.RoomType = Convert.ToString(myRow["RoomType"]).TrimEnd();
                    room.IsAvailable = Convert.ToBoolean(myRow["RoomStatus"]);
                    rooms.Add(room);
                }
            }
        }

        private void FillRow(DataRow aRow, Room room, DB.DBOperation operation)
        {
            if (operation == DB.DBOperation.Add)
            {
                aRow["RoomID"] = room.RoomID;
            }
            aRow["RoomID"] = room.RoomID;
            aRow["RoomType"] = room.RoomType;
            aRow["RoomStatus"] = room.IsAvailable;
        }

        private int FindRow(Room room, string table)
        {
            int rowIndex = 0;
            DataRow myRow;
            int returnValue = -1;
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (myRow.RowState != DataRowState.Deleted)
                {
                    if (room.RoomID == Convert.ToString(dsMain.Tables[table].Rows[rowIndex]["RoomID"]))
                    {
                        returnValue = rowIndex;
                    }
                }
                rowIndex++;
            }
            return returnValue;
        }
        #endregion


        #region Database Operations CRUD
        public void DataSetChange(Room room, DB.DBOperation operation)
        {
            DataRow aRow = null;
            switch (operation)
            {
                case DB.DBOperation.Add:
                    aRow = dsMain.Tables[table].NewRow();
                    FillRow(aRow, room, operation);
                    dsMain.Tables[table].Rows.Add(aRow);
                    break;
                case DB.DBOperation.Edit:
                    int rowIndex = FindRow(room, table);
                    if (rowIndex != -1)
                    {
                        aRow = dsMain.Tables[table].Rows[rowIndex];
                        FillRow(aRow, room, operation);
                    }
                    break;
                case DB.DBOperation.Delete:
                    int deleteIndex = FindRow(room, table);
                    if (deleteIndex != -1)
                    {
                        dsMain.Tables[table].Rows[deleteIndex].Delete();
                    }
                    break;
            }
        }

        public bool UpdateDataSource(Room room, DB.DBOperation operation)
        {
            bool success = true;
            switch (operation)
            {
                case DB.DBOperation.Add: Create_INSERT_Command(room); break;
                case DB.DBOperation.Edit: Create_UPDATE_Command(room); break;
                case DB.DBOperation.Delete: Create_DELETE_Command(room); break;
            }
            DataSetChange(room, operation);
            success = UpdateDataSource(sqlLocal, table);
            return success;
        }
        #endregion

        #region Specialized Room Methods
        public Collection<Room> GetAvailableRooms(DateTime arrivalDate, DateTime departureDate)
        {
            Collection<Room> availableRooms = new Collection<Room>();
            foreach (Room room in rooms)
            {
                if (room.IsAvailable)
                {
                    availableRooms.Add(room);
                }
            }
            return availableRooms;
        }

        public Room FindRoomByNumber(string roomID)
        {
            foreach (Room room in rooms)
            {
                if (room.RoomID == roomID)
                    return room;
            }
            return null;
        }

        public void UpdateRoomAvailability(string roomID, bool isAvailable)
        {
            Room room = FindRoomByID(roomID);
            if (room != null)
            {
                room.IsAvailable = isAvailable;
                UpdateDataSource(room, DB.DBOperation.Edit);
            }
        }

        private Room FindRoomByID(string roomID)
        {
            foreach (Room room in rooms)
            {
                if (room.RoomID == roomID)
                    return room;
            }
            return null;
        }


        #endregion

        #region Build Parameters, Create Commands & Update database

        private void Build_INSERT_Parameters(Room room)
        {
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@RoomID", SqlDbType.NVarChar, 15, "RoomID"); daMain.InsertCommand.Parameters.Add(param);
            param = new SqlParameter("@RoomType", SqlDbType.NVarChar, 50, "RoomType"); daMain.InsertCommand.Parameters.Add(param);
            param = new SqlParameter("@IsAvailable", SqlDbType.Bit, 0, "RoomStatus"); daMain.InsertCommand.Parameters.Add(param);
        }

        private void Create_INSERT_Command(Room room)
        {
            daMain.InsertCommand = new SqlCommand(
                @"INSERT INTO Rooms (RoomID, RoomType, RoomStatus, Status)
                VALUES (@RoomID, @RoomType, @IsAvailable)",
                cnMain);
            Build_INSERT_Parameters(room);
        }

        private void Build_UPDATE_Parameters(Room room)
        {
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@RoomType", SqlDbType.NVarChar, 50, "RoomType"); param.SourceVersion = DataRowVersion.Current; daMain.UpdateCommand.Parameters.Add(param);
            param = new SqlParameter("@IsAvailable", SqlDbType.Bit, 0, "RoomStatus"); param.SourceVersion = DataRowVersion.Current; daMain.UpdateCommand.Parameters.Add(param);
            param = new SqlParameter("@RoomID", SqlDbType.NVarChar, 15, "RoomID"); param.SourceVersion = DataRowVersion.Original; daMain.UpdateCommand.Parameters.Add(param);
        }

        public void Create_UPDATE_Command(Room room)
        {
            daMain.UpdateCommand = new SqlCommand(
                @"UPDATE Rooms SET RoomType = @RoomType, RoomStatus = @IsAvailable,
                WHERE RoomID = @Original_RoomID", cnMain);
            Build_UPDATE_Parameters(room);
        }

        private void Build_DELETE_Parameters(Room room)
        {
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@RoomID", SqlDbType.NVarChar, 50, "RoomID"); param.SourceVersion = DataRowVersion.Original; daMain.DeleteCommand.Parameters.Add(param);
        }

        private void Create_DELETE_Command(Room room)
        {
            daMain.DeleteCommand = new SqlCommand("DELETE FROM Rooms WHERE RoomID = @RoomID", cnMain);
            Build_DELETE_Parameters(room);
        }

        #endregion
}
