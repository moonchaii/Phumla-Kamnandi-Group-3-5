using HotelManagementSystem_Group_3_5.Business;
using HotelManagementSystem_Group_3_5.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem_Group_3_5.Business
{

    public class BookingHandler
    {
        #region Data Members
        BookingDB bookingDB;
        Collection<Booking> bookings;
        #endregion

        #region Properties
        public Collection<Booking> AllBookings
        {
            get
            {
                return bookings;
            }
        }
        #endregion

        #region Constructor
        public BookingHandler()
        {
            bookingDB = new BookingDB();
            bookings = bookingDB.AllBookings;
        }
        #endregion

        #region Database Communication.
        public void DataMaintenance(Booking booking, DB.DBOperation operation)
        {
            int index = 0;

            bookingDB.DataSetChange(booking, operation);

            switch (operation)
            {
                case DB.DBOperation.Add:
                    bookings.Add(booking);
                    break;

                case DB.DBOperation.Edit:
                    index = FindIndex(booking);
                    if (index != -1)
                    {
                        bookings[index] = booking;
                    }
                    break;

                case DB.DBOperation.Delete:
                    index = FindIndex(booking);
                    if (index != -1)
                    {
                        bookings.RemoveAt(index);
                    }
                    break;
            }
        }

        public bool FinalizeChanges(Booking booking)
        {
            return bookingDB.UpdateDataSource(booking);
        }
        #endregion

        #region Search Method
        public Booking Find(string referenceNumber)
        {
            int index = 0;
            bool found = (bookings[index].ReferenceNumber == referenceNumber);
            int count = bookings.Count;

            while (!found && index < count - 1)
            {
                index++;

                found = (bookings[index].ReferenceNumber == referenceNumber);
            }

            if (found)
            {
                return bookings[index];
            }
            else
            {
                return null;
            }
        }

        public int FindIndex(Booking booking)
        {
            int counter = 0;
            bool found = false;

            found = (booking.ReferenceNumber == bookings[counter].ReferenceNumber);

            while (!found && counter < bookings.Count - 1)
            {
                counter++;

                found = (booking.ReferenceNumber == bookings[counter].ReferenceNumber);
            }

            if (found)
            {
                return counter;
            }

            else
            {
                return -1;
            }
        }
        #endregion
    }
}
