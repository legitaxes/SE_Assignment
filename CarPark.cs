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
        private int remainingSpace; //implied and calculated
        private double generatedRevenue;

        private Dictionary<string, string> pastRevenue; // a list of past revenue of the year based on the month
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
        public CarPark() { } //empty carpar constructor

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
        //updates the remaining parking space 
        public void UpdateParkingSpace() {
            remainingSpace = remainingSpace - vehicleParkingList.Count();
        }

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

        public void GenerateReport(List<CarPark> cpList, List<SeasonPass> spList)
        {
            // code to generatereport function -- # TODO calculate the total amount for the month

            int currentMonth = DateTime.Now.Month; //set currentMonth as this month
            double totalAmount = 0;
            int totalVehicleEntry = 0;
            int countCars = 0;
            int countMotorBike = 0;
            int countLorry = 0;
            int seasonPassRevenue = 0;
            int countCarSeasonPass = 0;
            int countMotorBikeSeasonPass = 0;
            double ta = 0;

            // prompt user for what month should the report be generated
            Console.Write("Enter Month in numbers to Generate Report for: ");
            string month = Console.ReadLine();
            int months;
            bool c = Int32.TryParse(month, out months);
            if (!c)
            {
                Console.WriteLine();
                Console.WriteLine("Please Enter Interger Input only!");
                return;
            }
            if (months < 0 || months > 12)
            {
                Console.WriteLine("Please enter a valid month between 1 - 12");
                return;
            }

            //prompt user whether to generate report for all carparks or only 1 carpark
            Console.Write("Do you want to display ALL carpark generated revenue? [Y/N] ");
            string confirmation = Console.ReadLine();
            if (confirmation.ToUpper() == "N") //display one carpark only
            {
                //list all carpark and prompt for user to select one carpark
                Console.WriteLine();
                Console.WriteLine("======= Listing All Carparks =======");
                Console.WriteLine();
                foreach (var cp in cpList)
                {
                    Console.WriteLine("{0}.  {1}", cp.CarParkID, cp.CarParkName);
                }
                // prompt for input of carpark #
                Console.WriteLine();
                Console.Write("Select Carpark: ");
                string cpNumber = Console.ReadLine();
                int cpn;
                c = Int32.TryParse(cpNumber, out cpn);
                if (!c)
                {
                    Console.WriteLine();
                    Console.WriteLine("Please Enter an Integer Input only!");
                    return;
                }
                if (cpn < 0 || cpn > 3)
                {
                    Console.WriteLine("Please enter a valid Carpark number between 1 - 3");
                    return;
                }

                // code to generate report for one carpark

                // cast the carpark into a local object 
                CarPark currentCP = cpList[Convert.ToInt32(cpNumber) - 1];
                Console.WriteLine();
                Console.WriteLine("Generating Financial Report...");
                Thread.Sleep(TimeSpan.FromSeconds(2));
                Console.WriteLine();
                Console.WriteLine("=========== " + DateTime.Now + " ===========");
                Console.WriteLine();
                Console.WriteLine("Financial Report for the Month of {0} for {1}", currentCP.PastRevenue.ElementAt(months - 1).Key, currentCP.CarParkName);

                // if month entered is the same as the current month in the computer, the printed revenue will be for the current month as well
                // put the generatedrevenue into the current month
                if (currentMonth == months) // add to pastrevenue if month matches
                {
                    string o_i = currentCP.PastRevenue.ElementAt(months - 1).Value;
                    // concatenate the year and value together
                    string amount = "," + DateTime.Now.Year.ToString() + ": $" + currentCP.GeneratedRevenue;
                    // concatenate the original input of the month with new generated revenue
                    currentCP.PastRevenue[currentCP.PastRevenue.ElementAt(months - 1).Key] = o_i + amount;
                }

                // count the number of cars and motorcycle that entered the carpark
                List<ParkingSession> psList = currentCP.vehicleParkingList; // cast the parkingsession list into a ParkingSession object first
                foreach (var ps in psList)
                { // not efficient way to doing it but too bad!
                    if (ps.Vehicle.VehicleType == "Car") { countCars += 1; }
                    else if (ps.Vehicle.VehicleType == "Motorbike") { countMotorBike += 1; }
                    else if (ps.Vehicle.VehicleType == "Lorry") { countLorry += 1; }
                }
                // print the number of vehicles that entered
                Console.WriteLine("No. of Vehicles entered {0}: {1}", currentCP.carParkName, currentCP.vehicleParkingList.Count());
                // print number of vehicles that entered, split between the count of cars and motorbikes
                Console.WriteLine("No. of Cars: {0} | Number of Motorcycles: {1} | Number of Lorries: {2}", countCars, countMotorBike, countLorry);
                // print the carpark name and the generated revenue for the month of each year
                Console.WriteLine("Total amount of revenue generated from " + currentCP.CarParkName + " for the month of {0} is...", currentCP.pastRevenue.ElementAt(months - 1).Key);

                //split the string by comma and print it out line by line for better visibility
                string[] yearofRevenue = currentCP.PastRevenue.ElementAt(months - 1).Value.Split(",");
                foreach (var x in yearofRevenue)
                {
                    string y = x.Substring(7);
                    double amount = Convert.ToDouble(y);
                    totalAmount = amount + totalAmount;
                    Console.WriteLine(x);
                }
                Console.WriteLine("The total amount of revenue generated over the years are ${0}", Math.Round(totalAmount, 2));
            }

            // code to generate report for ALL carpark
            else if (confirmation.ToUpper() == "Y")
            {
                Console.WriteLine();
                Console.WriteLine("Generating Financial Report...");
                Thread.Sleep(TimeSpan.FromSeconds(2));
                Console.WriteLine();
                Console.WriteLine("=========== " + DateTime.Now + " ===========");
                Console.WriteLine();
                Console.WriteLine("Financial Report for the Month of {0} for all carparks", cpList[0].PastRevenue.ElementAt(months - 1).Key);

                // print the carpark name and the generated revenue for the month of each year
                Console.WriteLine("Total amount of revenue generated for all carparks for the month of {0} is...", cpList[0].pastRevenue.ElementAt(months - 1).Key);
                Console.WriteLine();
                // Calculate the parking charges for ALL carparks. 
                // Calculate and print carpark by carpark
                foreach (var ccp in cpList)
                {
                    countLorry = 0;
                    countCars = 0;
                    countMotorBike = 0;
                    totalVehicleEntry = 0;
                    ta = 0;
                    // if month entered is the same as the current month in the computer, the printed revenue will be for the current month as well
                    // put the generatedrevenue into the current month, add to past revenue for current month if the revenue matches
                    if (currentMonth == months)
                    {
                        string o_i = ccp.PastRevenue.ElementAt(months - 1).Value;
                        // concatenate the year and value together
                        string amount = "," + DateTime.Now.Year.ToString() + ": $" + ccp.GeneratedRevenue;
                        // concatenate the original input of the month with new generated revenue
                        ccp.PastRevenue[ccp.PastRevenue.ElementAt(months - 1).Key] = o_i + amount;
                    }

                    //get the year's revenue in double datatype
                    string[] yearofRevenue = ccp.PastRevenue.ElementAt(months - 1).Value.Split(",");
                    foreach (var x in yearofRevenue)
                    {
                        string y = x.Substring(7);
                        double amount = Convert.ToDouble(y);
                        totalAmount = amount + totalAmount;
                        ta = amount + ta;
                    }

                    totalVehicleEntry = ccp.vehicleParkingList.Count() + totalVehicleEntry;
                    Console.WriteLine("============================ " + ccp.CarParkName + " ============================");
                    Console.WriteLine("No. of Vehicles entered: {0}", ccp.vehicleParkingList.Count());
                    // count the number of cars and motorcycle that entered the carpark
                    List<ParkingSession> psList = ccp.vehicleParkingList; // cast the parkingsession list into a ParkingSession object first
                    foreach (var ps in psList)
                    { // not efficient way to doing it but too bad!
                        if (ps.Vehicle.VehicleType == "Car") { countCars += 1; }
                        else if (ps.Vehicle.VehicleType == "Motorbike") { countMotorBike += 1; }
                        else if (ps.Vehicle.VehicleType == "Lorry") { countLorry += 1; }
                    }
                    Console.WriteLine("No. of Cars: {0} | Number of Motorcycles: {1} | Number of Lorries: {2}", countCars, countMotorBike, countLorry);
                    Console.WriteLine("The total number of Vehicle entered across all carparks are {0}", totalVehicleEntry);
                    //print the amount generated in total for all Carparks
                    Console.WriteLine("Total Generated Revenue: ${0}", Math.Round(ta, 2));
                    Console.WriteLine();
                }
                Console.WriteLine("Total Generated Revenue for all carparks: ${0}", Math.Round(totalAmount, 2));
            }
            else {
                Console.WriteLine("Please enter a correct input!");
                return;
            }
            // calculate the season pass revenue generated for the month of purchase
            foreach(var sp in spList)
            {
                List<Payment> pList = sp.Payment; //cast the payment list into an object locally
                foreach (var p in pList) { //iterate through the payment list to find out the purchases of season pass
                    if (p.PurchaseDate.Month == months) {
                        seasonPassRevenue = p.Price + seasonPassRevenue;
                        if (p.Price == 110 || p.Price == 80)
                        {
                            countCarSeasonPass++;
                        }
                        else if (p.Price == 15 || p.Price == 17)
                        {
                            countMotorBikeSeasonPass++;
                        }
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("================= Number of Renewals/Purchases of Season Pass =================");
            Console.WriteLine("Number of Car/Lorry SeasonPass Purchases: {0} ", countCarSeasonPass);
            Console.WriteLine("Number of MotorBike SeasonPass Purchases: {0}", countMotorBikeSeasonPass);
            Console.WriteLine("Total amount collected from Season Pass Puchases for the month {0}: ${1}", cpList[0].pastRevenue.ElementAt(months - 1).Key, seasonPassRevenue);
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

        //this function will be run at the end of each month to add the amount to the dictionary
        public void AddToPastRevenue(DateTime todayDate) { //add generated revenue to the dictionary
            int month = todayDate.Month;

            // save the original amount generated for the month for each year
            string o = pastRevenue.ElementAt(month - 1).Value;
            // concatenate the year and value together
            string amount = "," + todayDate.Year.ToString() + ": " + generatedRevenue;
            // concatenate the original input of the month with new generated revenue
            pastRevenue[pastRevenue.ElementAt(month - 1).Key] = o + amount;

            generatedRevenue = 0; //reset the generated revenue to 0
        }
    }
}
