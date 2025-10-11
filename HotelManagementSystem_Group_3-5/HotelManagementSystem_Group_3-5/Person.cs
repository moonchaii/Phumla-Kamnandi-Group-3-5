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
        private string id;
        private string name;
        private string phoneNum;
        private string email;
        private string address;
        #endregion

        #region Constructors
        public Person()
        {
            id = "0000000000000";
            name = "";
            phoneNum = "";
            email = "";
            address = "";
        }

        public Person(string id, string name, string phoneNum, string email, string address)
        {
            this.id = id;
            this.name = name;
            this.phoneNum = phoneNum;
            this.email = email;
            this.address = address;
        }
        #endregion

        #region Properties
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
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
