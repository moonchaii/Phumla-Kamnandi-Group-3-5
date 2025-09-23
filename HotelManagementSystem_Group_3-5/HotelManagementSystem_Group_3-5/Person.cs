using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem_Group_3_5
{
    public class Person
    {
        #region Data Members
        private long id;
        private string fName;
        private string lName;
        private string phoneNum;
        private string email;
        private string address;
        #endregion

        #region Constructors
        public Person()
        {
            id = 0;
            fName = "";
            lName = "";
            phoneNum = "";
            email = "";
            address = "";
        }

        public Person(long id, string fName, string lName, string phoneNum, string email, string address)
        {
            this.id = id;
            this.fName = fName;
            this.lName = lName;
            this.phoneNum = phoneNum;
            this.email = email;
            this.address = address;
        }
        #endregion

        #region Properties
        public long Id
        {
            get { return id; }
            set { id = value; }
        }

        public string FName
        {
            get { return fName; }
            set { fName = value; }
        }

        public string LName
        {
            get { return lName; }
            set { lName = value; }
        }

        public string PhoneNum
        {
            get { return phoneNum; }
            set { phoneNum = value; }
        }   

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        #endregion
    }
}
