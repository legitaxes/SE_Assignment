using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SEAssignment
{
    public class CarPark
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

        public Dictionary<string, string> PastRevenue {
            get { return pastRevenue; }
            set { pastRevenue = value; }
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
            pastRevenue = new Dictionary<string, string>();
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
            else {
                Console.WriteLine("The Vehicle is already parked at the Carpark!");
            }
        }

        public void GenerateReport(int month) {
            int currentMonth = DateTime.Now.Month;
            Console.WriteLine();
            Console.WriteLine("Generating Financial Report...");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Console.WriteLine();
            Console.WriteLine("=========== " + DateTime.Now + " ===========");
            Console.WriteLine();
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

        public void ShowCarParkFares() { //print parking charges
            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.WriteLine("------------------------------------ For Cars --------------------------------------");
            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.WriteLine("|                            |        Surface Lots      |       Sheltered Lots     |");
            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.WriteLine("| Season Parking (For Staff) |         $80/month        |         $110/month       |");
            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.WriteLine("| Vistor Parking             |                          |                          |");
            Console.WriteLine("| Mondays to Saturdays       |                          |                          |");
            Console.WriteLine("| 7 am to 10.30 pm           | $1.20 per hour (/min)    | $1.20 per hour (/min)    |");
            Console.WriteLine("| Sundays & Public Holidays  | Free                     | Free                     |");
            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.WriteLine("--------------------------------- For Motorcycles ----------------------------------");
            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.WriteLine("| Season Parking (For Staff) |         $15/month        |          $17/month       |");
            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.WriteLine("| Vistor Parking             |                          |                          |");
            Console.WriteLine("| Mondays to Saturdays       |                          |                          |");
            Console.WriteLine("| 7 am to 10.30 pm           | $0.20 per hour (/min)    | $0.20 per hour (/min)    |");
            Console.WriteLine("|                            | capped at $0.65 /session | capped at $0.65 /session |");
            Console.WriteLine("| Sundays & Public Holidays  | Free                     | Free                     |");
            Console.WriteLine("------------------------------------------------------------------------------------");
        }
    }
}
