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

        public string reservationID;
        public string guestID;
        public string roomID;
        public string roomNumber;
        public decimal totalAmount;
        public decimal depositAmount;
        public bool depositPaid;
        public string referenceNumber;
        public DateTime arrivalDate;
        public DateTime departureDate;
        public DateTime dateCreated;


        #endregion

        #region Properties

        public string ReservationID
        {
            get { return reservationID; }
            set { reservationID = value; }
        }

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

        public Guest Guest 
        { 
            get { return Guest; } 
            set { Guest = value; } 
        }

        public Room Room 
        {
            get { return Room; }
            set { Room = value; }
        }
        public GuestAccount Account 
        {
            get { return Account; }
            set { Account = value; }
        }

        #endregion

        #region Constructors

        public Booking()
        {
            dateCreated = DateTime.Now;
            GenerateReferenceNumber();
        }

        public Booking(string reservationID, string guestID, string roomID, DateTime arrivalDate, DateTime departureDate, int numberOfGuests)
        {
            this.reservationID = reservationID;
            this.guestID = guestID;
            this.roomID = roomID;
            this.arrivalDate = arrivalDate;
            this.departureDate = departureDate;
            dateCreated = DateTime.Now;
            GenerateReferenceNumber();
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
