using System;
using System.Collections.Generic;
using System.Text;

namespace SEAssignment
{
    class CarPark
    {
        private int carParkID;
        private string carParkName;
        private int totalParkingSpace;
        private string description;
        private string location;
        private int occupiedSpace;
        private List<Vehicle> vehicleList;

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

        public int OccupiedSpace {
            get { return occupiedSpace; }
            set { occupiedSpace = value; }
        }
       
        //constructor
        public CarPark(int id, string name, int tps, string desc, string loc) {
            carParkID = id;
            carParkName = name;
            totalParkingSpace = tps;
            description = desc;
            location = loc;
            occupiedSpace = 0;
            // defining vehicleList in carpark
            vehicleList = new List<Vehicle>();
        }

        //check parking space and return the number of space
        public int checkParkingSpace() {
            Console.WriteLine("There are about " + (totalParkingSpace - occupiedSpace) + " spaces left");
            return totalParkingSpace - occupiedSpace; // find out the number parking slots used
        }

        //add vehicle function to the carpark
        public void addVehicle(Vehicle v) {
            if (!vehicleList.Contains(v)) {
                vehicleList.Add(v);
                v.TheCarPark = this;
            }
        }

    }
}
