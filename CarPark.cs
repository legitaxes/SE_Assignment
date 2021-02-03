using System;
using System.Collections.Generic;
using System.Text;

namespace SEAssignment
{
    class CarPark
    {
        //---properties---
        private int carParkID;
        private string carParkName;
        private int totalParkingSpace;
        private string description;
        private string location;
        private int remainingSpace;
        //private List<Vehicle> vehicleList;
        private List<ParkingSession> vehicleParkingList; // many to many association (Vehicle and ParkingSession)


        //---getter setter properties---
        public int CarParkID
        {
            get { return carParkID; }
            set { carParkID = value; }
        }

        public string CarParkName
        {
            get { return carParkName; }
            set { carParkName = value; }
        }

        public int TotalParkingSpace
        {
            get { return totalParkingSpace; }
            set { totalParkingSpace = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string Location
        {
            get { return location; }
            set { location = value; }
        }

        public int RemainingSpace {
            get { return remainingSpace; }
            set { remainingSpace = value; }
        }
       
        //---constructor---
        public CarPark(int id, string name, int tps, string desc, string loc) {
            carParkID = id;
            carParkName = name;
            totalParkingSpace = tps;
            description = desc;
            location = loc;
            remainingSpace = totalParkingSpace;

            // defining vehicleList in carpark - many to many association with vehicles
            vehicleParkingList = new List<ParkingSession>();
        }

        //---methods---
        //check parking space and return the number of space
        public void CheckParkingSpace() {
            Console.WriteLine("There are about " + remainingSpace + " spaces left");
            //return totalParkingSpace - occupiedSpace; // find out the number parking slots used
        }

        //add vehicle function to the carpark
        //public void AddVehicle(Vehicle v) {
        //    if (!vehicleList.Contains(v)) {
        //        vehicleList.Add(v);
        //        v.CarPark = this;
        //    }
        //}
        public void AddVehicleParking(ParkingSession ps)
        {
            if (!vehicleParkingList.Contains(ps))
            {
                vehicleParkingList.Add(ps);
            }
        }
    }
}
