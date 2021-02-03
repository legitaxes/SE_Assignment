using System;
using System.Collections.Generic;
using System.Text;

namespace SEAssignment
{
    class ParkingSession
    {
        //---properties---
        private int sessionID;
        private DateTime checkInDate;
        private DateTime checkOutDate;
        private Vehicle vehicleInSession;

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

        public Vehicle VehicleInSession {
            set
            {
                if (vehicleInSession != value) {
                    vehicleInSession = value;
                    value.vehicleParkingSession = this;
                }
            }
        }
    }
}
