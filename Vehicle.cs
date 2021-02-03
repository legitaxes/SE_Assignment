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
        private CarPark carPark;  // many to one association (Vehicle and CarPark class), have to create a carpark variable to state what car belongs in the car park
        private ParkingSession vehicleParkingSession; // one to one association (Vehicle and ParkingSession)
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

        public CarPark CarPark {
            set {
                if (carPark != value) {
                    carPark = value;
                    value.AddVehicle(this);
                }
            }
        }

        public ParkingSession VehicleParkingSession
        {
            set {
                if (vehicleParkingSession != value) {
                    vehicleParkingSession = value;
                    value.VehicleInSession = this;
                }
            }
        }
        
        public SeasonPass VehicleSeasonPass {
            set {
                if (vehicleSeasonPass != value) {
                    vehicleSeasonPass = value;
                    value.SeasonPassVehicle = this;
                }
            }
        }


    }
}
