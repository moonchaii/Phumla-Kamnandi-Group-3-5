using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem_Group_3_5.Business
{
    public class Employee : Person
    {
        #region Data Members
        private string staffID;
        private string role;
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
