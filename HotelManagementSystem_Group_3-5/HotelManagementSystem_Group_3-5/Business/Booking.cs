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

        public string bookingID;
        public string guestID;
        public string roomID;
        public string roomNumber;
        public decimal totalAmount;
        public decimal depositAmount;
        public bool depositPaid;
        public string referenceNumber;
        private string status;
        public DateTime arrivalDate;
        public DateTime departureDate;
        public DateTime dateCreated;


        #endregion

        #region Properties

        public string BookingID
        {
            get { return bookingID; }
            set { bookingID = value; }
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
        public string Status 
        { 
            get { return status; } 
            set { status = value; } 
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

        public Booking(string bookingID, string guestID, string roomID, DateTime arrivalDate, DateTime departureDate)
        {
            this.bookingID = bookingID;
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

        public decimal CalculateTotalAmount(Room room)
        {
            decimal total = 0;
            DateTime currentDate = arrivalDate;
            while (currentDate < departureDate)
            {
                total += room.GetSeasonalRate(currentDate);
                currentDate = currentDate.AddDays(1);
            }
            totalAmount = total;
            return total;
        }

        public decimal CalculateDeposit()
        {
            depositAmount = Math.Round(totalAmount * 0.10m, 2);
            return depositAmount;
        }

        public bool IsDepositRequired()
        {
            return (arrivalDate - DateTime.Now).Days <= 14;
        }

        public void ConfirmBooking()
        {
            if (depositPaid || !IsDepositRequired())
                status = "Confirmed";
        }

        public void CancelBooking()
        {
            status = "Cancelled";
        }

        public bool CanBeCancelled()
        {
            return status != "Cancelled" && status != "CheckedOut" && arrivalDate > DateTime.Now;
        }

        public decimal CalculateRefundAmount()
        {
            if (!depositPaid) return 0;

            TimeSpan daysUntilArrival = arrivalDate - DateTime.Now;

            if (daysUntilArrival.TotalDays > 14) return depositAmount;
            else return 0;
        }

        public override string ToString()
        {
            return $"Booking {referenceNumber} - {status} - {arrivalDate:dd MMM yyyy} to {departureDate:dd MMM yyyy} - R{totalAmount}";
        }

        #endregion
    }
}
