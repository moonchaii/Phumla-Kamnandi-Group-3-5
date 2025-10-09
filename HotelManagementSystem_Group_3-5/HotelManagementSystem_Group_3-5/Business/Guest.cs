using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem_Group_3_5.Business
{
    public class Guest : Person
    {
        #region Data Members
        private string guestID;
        private string creditCardNum;
        #endregion

        #region Constructors
        public Guest() : base()
        {
            this.creditCardNum = "";
        }
        public Guest(string id, string fName, string lName, string phoneNum, string email, string address, string guestID,string creditCardNum)
            : base(id, fName, lName, phoneNum, email, address)
        {
            this.guestID = guestID;
            this.creditCardNum = creditCardNum;
        }
        #endregion

        #region Properties

        public string GuestID
        {
            get { return guestID; }
            set { guestID = value; }
        }
        public string CreditCardNum
        {
            get { return creditCardNum; }
            set { creditCardNum = value; }
        }
        #endregion

        #region Methods
        public void updateCreditCard(string newCreditCardNum)
        {
            this.creditCardNum = newCreditCardNum;
        }
        #endregion
    }
}
