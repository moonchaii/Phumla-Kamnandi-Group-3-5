using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem_Group_3_5.Business
{
    public class GuestAccount
    {
        #region Data Members
        private long guestID;
        private double accountBalance;
        #endregion

        #region Constructors
        public GuestAccount(Guest guest)
        {
            this.guestID = guest.GuestID;
            this.accountBalance = 0.0;
        }
        #endregion

        #region Properties
        public double AccountBalance
        {
            get { return accountBalance; }
            set { accountBalance = value; }
        }
        #endregion

        #region Methods
        public void updateBalance(double amount)
        {
            this.accountBalance += amount;
        }
        #endregion
    }
}
