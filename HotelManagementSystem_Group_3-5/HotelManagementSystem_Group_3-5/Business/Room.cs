using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IdentityModel.Protocols.WSTrust;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelManagementSystem_Group_3_5.Business
{
    public class Room
    {
        #region Constants

        public const decimal LOW_SEASON_RATE = 550m;
        public const decimal MID_SEASON_RATE = 750m;
        public const decimal HIGH_SEASON_RATE = 995m;

        #endregion 

        #region Data Members

        public string roomID;
        public int roomNumber;
        public string roomType;
        public decimal baseRate;
        public bool isAvailable;

        #endregion

        #region Properties

        public string RoomID
        {
            get { return roomID; }
            set { roomID = value; }
        }

        public int RoomNumber
        {
            get { return roomNumber; }
            set { roomNumber = value; }
        }

        public string RoomType
        {
            get { return roomType; }
            set { roomType = value; }
        }

        public decimal BaseRate
        {
            get { return baseRate; }
            set { baseRate = value; }
        }

        public bool IsAvailable
        {
            get { return isAvailable; }
            set { isAvailable = value; }
        }

        #endregion

        #region Constructors

        public Room()
        {
           isAvailable = true;
        }

        public Room(string roomID, int roomNumber, string roomType, decimal baseRate)
        {
            this.roomID = roomID;
            this.roomNumber = roomNumber;
            this.roomType = roomType;
            this.baseRate = baseRate;
            isAvailable = true;
        }

        #endregion

        #region Methods

        public decimal GetSeasonalRate(DateTime date)
        {
            int day = date.Day;

            if (day >= 1 && day <= 7)
                return LOW_SEASON_RATE;
            else if (day >= 8 && day <= 15)
                return MID_SEASON_RATE;
            else
                return HIGH_SEASON_RATE;
        }

        public void UpdateAvailability(bool availability)
        {
            isAvailable = availability;
        }

        

        public void ReleaseRoom()
        {
            isAvailable = true;
        }

        public static Collection<Room> FindAvailableRooms(DateTime arrivalDate, DateTime departureDate)
        {
            // This will be implemented in RoomDB class
            // For now, returns empty collection - actual implementation will query database
            return new Collection<Room>();
        }

        public override string ToString()
        {
            return $"Room {roomNumber} - {roomType} - R{baseRate}/night - {(isAvailable ? "Available" : "Occupied")}";
        }

        #endregion
    }
}
