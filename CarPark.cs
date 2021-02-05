using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

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
        
        private double generatedRevenue;
        private Dictionary<string, string> pastRevenue;
        
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

        public double GeneratedRevenue
        {
            get { return generatedRevenue; }
            set { generatedRevenue = value; }
        }

        //---constructor---
        public CarPark(int id, string name, int tps, string desc, string loc, double gr) {
            carParkID = id;
            carParkName = name;
            totalParkingSpace = tps;
            description = desc;
            location = loc;
            remainingSpace = totalParkingSpace;
            generatedRevenue = gr;

            // defining vehicleList in carpark - many to many association with vehicles
            vehicleParkingList = new List<ParkingSession>();
            pastRevenue = new Dictionary<string, string>() { //initializing some dummy data for pastRevenue
                { "Jan", "2019: 1204.24,2020: 2367.70"},
                { "Feb", "2019: 4897.30,2020: 2314.76"},
                { "Mar", "2019: 2189.68,2020: 7893.11"},
                { "Apr", "2019: 443.24,2020: 202.60"},
                { "May", "2019: 1234.74,2020: 4874.75"},
                { "Jun", "2019: 5768.58,2020: 4562.73"},
                { "Jul", "2019: 1204.47,2020: 2344.20"},
                { "Aug", "2019: 2345.88,2020: 2367.17"},
                { "Sep", "2019: 5655.34,2020: 1311.11"},
                { "Oct", "2019: 1336.37,2020: 3908.22"},
                { "Nov", "2019: 333.24,2020: 221.82"},
                { "Dec", "2019: 112.44,2020: 228.45"}
            };
        }

        //---methods---
        //check parking space and return the number of space
        public void CheckParkingSpace() {
            Console.WriteLine("There are " + remainingSpace + " spaces left");
            //return totalParkingSpace - occupiedSpace; // find out the number parking slots used
        }
        
        // adds to the parksession list
        public void AddVehicleParking(ParkingSession ps)
        {
            if (!vehicleParkingList.Contains(ps))
            {
                vehicleParkingList.Add(ps);
            }
        }

        public void GenerateReport(int month) {
            int currentMonth = DateTime.Now.Month;
            Console.WriteLine("Generating Financial Report...");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Console.WriteLine("=========== " + DateTime.Now + " ===========");
            Console.WriteLine("Financial Report for the Month of {0} for {1}", pastRevenue.ElementAt(Convert.ToInt32(month - 1)).Key, carParkName);

            // if month entered is the same as the current month in the computer, the printed revenue will be for the current month as well
            // put the generatedrevenue into the current month
            if (currentMonth == month)
            {
                AddToPastRevenue(month);
            }
            // print the carpark name and the generated revenue for the month of each year
            Console.WriteLine("Total amount of revenue generated from " + carParkName + " for the month of {0} is...", pastRevenue.ElementAt(month - 1).Key);
            
            //split the string by comma and print it out line by line for better visibility
            string[] yearofRevenue = pastRevenue.ElementAt(month - 1).Value.Split(",");
            foreach (var x in yearofRevenue) {
                Console.WriteLine(x);
            }
        }

        public void AddToPastRevenue(int month) { // this function adds the current generatedrevenue into the dictionary of month
            // save the original input of the month
            string o_i = pastRevenue.ElementAt(month - 1).Value;
            // concatenate the year and value together
            string amount = "," + DateTime.Now.Year.ToString() + ": " + generatedRevenue;
            // concatenate the original input of the month with new generated revenue
            pastRevenue[pastRevenue.ElementAt(month - 1).Key] = o_i + amount;
        }
    }
}
