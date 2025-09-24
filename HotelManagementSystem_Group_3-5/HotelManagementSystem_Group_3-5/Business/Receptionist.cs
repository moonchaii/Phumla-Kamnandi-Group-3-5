using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem_Group_3_5.Business
{
    public class Receptionist : Employee
    {
        #region Constructors
        public Receptionist() : base()
        {
            this.Role = "Receptionist";
        }

        public Receptionist(long id, string fName, string lName, string phoneNum, string email, string address, string staffID, string role)
            : base(id, fName, lName, phoneNum, email, address, staffID, role)
        {
            this.Role = "Receptionist";
        }
        #endregion
    }
}
