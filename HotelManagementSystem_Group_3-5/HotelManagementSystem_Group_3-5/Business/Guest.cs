using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Group 3-5
// Members:
// Shakila Africa : AFRSHA001
// Chai Europa : ERPTEA001
// Lilitha Somana : SMNBON004
// Lindani Xaba : XBXLIN006
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
        public Guest(string id, string name, string phoneNum, string email, string address, string guestID,string creditCardNum)
            : base(id, name, phoneNum, email, address)
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

        private static readonly Random random = new Random();

        public void updateCreditCard(string newCreditCardNum)
        {
            this.creditCardNum = newCreditCardNum;
        }

        public static string GenerateGuestID()
        {
            int number = random.Next(0, 100000);

            return $"GST{number:D5}";
        }
        #endregion
    }
}