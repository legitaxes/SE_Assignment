using System;
using System.Collections.Generic;
using System.Text;

namespace SEAssignment
{
    // association class
    public class ParkingSession
    {
        //---properties---
        private int sessionID;
        private DateTime checkInDate;
        private DateTime checkOutDate;

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

        // may not need getter and setter for vehicle and vehiclecarpark - idk see how for now 
        // # TODO check with Mr Victor whether getter setter is needed for this
        // # labels: check-with-teacher
        public Vehicle Vehicle
        {
            get { return vehicle; }
            set { vehicle = value; }
        }

        public CarPark VehicleCarPark
        {
            get { return vehicleCarPark; }
            set { vehicleCarPark = value; }
        }

        public ParkingSession(int sid, DateTime cd, DateTime co, Vehicle v, CarPark vcp) {
            sessionID = sid;
            checkInDate = cd;
            checkOutDate = co;
            vehicle = v;
            vehicleCarPark = vcp;

            v.AddVehicleParking(this);
            vcp.AddVehicleParking(this);
        }
    }
}
