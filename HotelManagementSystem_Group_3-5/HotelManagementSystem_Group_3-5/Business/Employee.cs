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
        #endregion

        #region Properties
        public string StaffID
        {
            get { return staffID; }
            set { staffID = value; }
        }
        #endregion
    }
}
