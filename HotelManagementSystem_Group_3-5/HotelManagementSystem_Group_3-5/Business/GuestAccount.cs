using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.ObjectModel;

namespace HotelManagementSystem_Group_3_5.Business
{
    public class GuestAccount
    {
        #region Data Members
        private string accountID;
        private string bookingID;
        private string guestID;
        private decimal totalAmount;
        private decimal amountPaid;
        private string status;
        private DateTime createdDate;
        private DateTime? closedDate;
        private decimal accountBalance;
        #endregion

        #region Properties

        public string AccountID
        {
            get { return accountID; }
            set { accountID = value; }
        }

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

        public decimal TotalAmount 
        { 
            get { return totalAmount; } 
            set { totalAmount = value; } 
        }

        public decimal AmountPaid 
        { 
            get { return amountPaid; } 
            set { amountPaid = value; } 
        }

        public string Status 
        { 
            get { return status; } 
            set { status = value; } 
        }

        public decimal AccountBalance
        {
            get { return accountBalance; }
            set { accountBalance = value; }
        }

        public DateTime CreatedDate 
        { 
            get { return createdDate; } 
            set { createdDate = value; } 
        }
        public DateTime? ClosedDate 
        { 
            get { return closedDate; } 
            set { closedDate = value; } 
        }

        #endregion

        #region Constructors

        public GuestAccount(Guest guest)
        {
            this.guestID = guest.GuestID;
            this.accountBalance = 0m;
            status = "Open";
            createdDate = DateTime.Now;
        }

        public GuestAccount(string accountID, string bookingID, string guestID, decimal totalAmount)
        {
            this.accountID = accountID;
            this.bookingID = bookingID;
            this.guestID = guestID;
            this.totalAmount = totalAmount;
            this.accountBalance = 0m;
            amountPaid = 0;
            createdDate = DateTime.Now;
            status = "Open";
        }

        #endregion

        #region Methods
        

        private void UpdateStatus()
        {
            if (Status != "Settled" && accountBalance <= 0)
            {
                status = "Settled";
                closedDate = DateTime.Now;
            }
            else if (accountBalance > 0 && status == "Open")
            {
                status = "Open";
            }
        }

        public void CloseAccount()
        {
            if (accountBalance == 0) status = "Settled";
            else status = "Closed";
            closedDate = DateTime.Now;
        }

        

        #endregion
    }
}
