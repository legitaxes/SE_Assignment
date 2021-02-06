using System;
using System.Collections.Generic;
using System.Text;

namespace SEAssignment
{
    public class Vehicle
    {
        //---properties---
        private int vehicleID;
        private string licensePlate;
        private string vehicleType;
        private string iuNumber; // 10 digit number
        private List<string> offences;

        private List<ParkingSession> vehicleParkingList; // many to many association (Vehicle and CarPark)
        private User userVehicle; // one to many assoication with User to Vehicles
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

        public string IUNumber
        {
            get { return iuNumber; }
            set { iuNumber = value; }
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

        // one to many association with User and Vehicle
        public User UserVehicle {
            get { return userVehicle; }
            set {
                if (userVehicle != value)
                {
                    userVehicle = value;
                    value.RegisterVehicle(this);
                }
                else {
                    Console.WriteLine("This user already has the vehicle assigned to him");
                }
            }
        }
        
        //---constructor---
        public Vehicle(int id, string lp, string vt, string iun, User carOwner)
        {
            vehicleID = id;
            licensePlate = lp;
            vehicleType = vt;
            iuNumber = iun;
            vehicleSeasonPass = null;
            userVehicle = carOwner;

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
