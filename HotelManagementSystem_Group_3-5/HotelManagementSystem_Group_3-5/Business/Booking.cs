using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelManagementSystem_Group_3_5.Business
{
    public class Booking
    {
        #region Data Members
        private string referenceNumber;
        private string guestID;
        private string roomID;
        private int roomNumber;
        private decimal totalAmount;
        private decimal depositAmount;
        private bool depositPaid;
        private DateTime arrivalDate;
        private DateTime departureDate;
        private DateTime dateCreated;

        private Guest guest;
        private Room room;
        private GuestAccount account;
        #endregion

        #region Properties

        public string GuestID
        {
            get { return guestID; }
            set { guestID = value; }
        }

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

        public decimal TotalAmount
        {
            get { return totalAmount; }
            set { totalAmount = value; }
        }

        public decimal DepositAmount
        {
            get { return depositAmount; }
            set { depositAmount = value; }
        }

        public bool DepositPaid
        {
            get { return depositPaid; }
            set { depositPaid = value; }
        }

        public string ReferenceNumber
        {
            get { return referenceNumber; }
            set { referenceNumber = value; }
        }

        public DateTime ArrivalDate
        {
            get { return arrivalDate; }
            set { arrivalDate = value; }
        }

        public DateTime DepartureDate
        {
            get { return departureDate; }
            set { departureDate = value; }
        }

        public DateTime DateCreated
        {
            get { return dateCreated; }
            set { dateCreated = value; }
        }

        public Room Room 
        {
            get { return room; }
            set 
            { 
                room = value;
                if (room != null)
                {
                    roomID = room.RoomID;
                    roomNumber = room.RoomNumber;
                }
            }
        }
        public GuestAccount Account 
        {
            get { return account; }
            set { account = value; }
        }

        public Guest Guest
        {
            get { return guest; }
            set 
            {   
                guest = value; 
                if (guest != null)
                {
                    guestID = guest.GuestID;
                }
            }
        }

        #endregion

        #region Constructors

        public Booking()
        {
            this.referenceNumber = GenerateReferenceNumber();
            dateCreated = DateTime.Now;
        }

        public Booking(string referenceNumber, string guestID, string roomID, int roomNumber, DateTime arrivalDate, DateTime departureDate)
        {
            this.referenceNumber = referenceNumber;
            this.guestID = guestID;
            this.roomID = roomID;
            this.arrivalDate = arrivalDate;
            this.departureDate = departureDate;
            dateCreated = DateTime.Now;
        }

        #endregion

        #region Methods
        private static readonly Random random = new Random();

        public static string GenerateReferenceNumber()
        {
            int number = random.Next(0, 100000);

            return $"REF{number:D5}";
        }

        public int GetNumberOfNights()
        {
            return (departureDate - arrivalDate).Days;
        }
        #endregion
    }
}
