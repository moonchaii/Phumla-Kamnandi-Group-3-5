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
        private string creditCardNum;
        #endregion

        #region Constructors
        public Guest() : base()
        {
            this.creditCardNum = "";
        }
        public Guest(long id, string fName, string lName, string phoneNum, string email, string address, string creditCardNum)
            : base(id, fName, lName, phoneNum, email, address)
        {
            this.creditCardNum = creditCardNum;
        }
        #endregion

        #region Properties
        public string CreditCardNum
        {
            get { return creditCardNum; }
            set { creditCardNum = value; }
        }
        #endregion
    }
}
