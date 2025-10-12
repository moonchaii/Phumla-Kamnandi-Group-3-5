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
    public class Employee : Person
    {
        #region Data Members
        private string staffID;
        private string role;
        #endregion

        #region Constructors
        public Employee() : base()
        {
            staffID = string.Empty;
            role = string.Empty;
        }

        public Employee(string id, string name, string phoneNum, string email, string address, string staffID, string role)
            : base(id, name, phoneNum, email, address)
        {
            this.staffID = staffID;
            this.role = role;
        }
        #endregion

        #region Properties
        public string StaffID
        {
            get { return staffID; }
            set { staffID = value; }
        }

        public string Role
        {
            get { return role; }
            set { role = value; }
        }
        #endregion
    }
}
