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
        #endregion
    }
}
