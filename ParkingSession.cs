using System;
using System.Collections.Generic;
using System.Text;

namespace SEAssignment
{
    // association class
    class ParkingSession
    {
        //---properties---
        private int sessionID;
        private DateTime checkInDate;
        private DateTime checkOutDate;
        private Vehicle vehicleInSession;

        private Vehicle vehicle;
        private CarPark vehicleCarPark;

        //---getter setter properties---
        public int SessionID
        {
            get { return sessionID; }
            set { sessionID = value; }
        }

        public DateTime CheckInDate
        {
            get { return checkInDate; }
            set { checkInDate = value; }
        }

        public DateTime CheckOutDate
        {
            get { return checkOutDate; }
            set { checkOutDate = value; }
        }

    }
}
