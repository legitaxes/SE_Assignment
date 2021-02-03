using System;
using System.Collections.Generic;
using System.Text;

namespace SEAssignment
{
    class Vehicle
    {
        //---properties---
        private int vehicleID;
        private string licensePlate;
        private string vehicleType;
        private List<string> offences;
        private List<ParkingSession> vehicleParkingList; // many to many association (Vehicle and CarPark)
        
        private SeasonPass vehicleSeasonPass; //one to one association (Vehicle and SeasonPass)

        //---getter setter for properties---
        public int VehicleID
        {
            get { return vehicleID; }
            set { vehicleID = value; }
        }

        public string LicensePlate
        {
            get { return licensePlate; }
            set { licensePlate = value; }
        }

        public string VehicleType
        {
            get { return vehicleType; }
            set { vehicleType = value; }
        }

        public List<string> Offences
        {
            get { return offences; }
            set { offences = value; }
        }
        
        // one to one association with Vehicle - Season Pass
        public SeasonPass VehicleSeasonPass {
            set {
                if (vehicleSeasonPass != value) {
                    vehicleSeasonPass = value;
                    value.Vehicle = this;
                }
            }
        }

        //---constructor---
        public Vehicle(int id, string lp, string vt, SeasonPass vsp)
        {
            vehicleID = id;
            licensePlate = lp;
            vehicleType = vt;
            vehicleSeasonPass = vsp;

            offences = new List<string>();
            vehicleParkingList = new List<ParkingSession>();
        }

        //---Functions---
        public void AddVehicleParking(ParkingSession ps)
        {
            if (!vehicleParkingList.Contains(ps))
            {
                vehicleParkingList.Add(ps);
            }
        }
    }
}
