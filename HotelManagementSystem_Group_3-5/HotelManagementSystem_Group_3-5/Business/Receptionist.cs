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
    public class Receptionist : Employee
    {
        #region Constructors
        public Receptionist() : base()
        {
            this.Role = "Receptionist";
        }

        public Receptionist(string id, string name, string phoneNum, string email, string address, string staffID, string role)
            : base(id, name, phoneNum, email, address, staffID, role)
        {
            this.Role = "Receptionist";
        }
        #endregion
    }
}
