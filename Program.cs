using System;
using System.Collections.Generic;

namespace SEAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // initialize a few students
            Student s1 = new Student("1", "Peter", "1234", "Abc Street", 12346689);
            Student s2 = new Student("2", "Jane", "1234", "Def Street", 12346789);

            StudentList studentList = new StudentList();
            studentList.StudentCollection.Add(s1);
            studentList.StudentCollection.Add(s2);



            // initialize a few lecturers
            Lecturer lect1 = new Lecturer("1", "Mr Tan", "1234", "Xyz Street", 52634789);
            Lecturer lect2 = new Lecturer("2", "Ms Lee", "1234", "Lmn Street", 58749632);




            // initialize a manager
            Manager manager = new Manager("S1111", "Timmy TRG", "blackpeople", "Wattsons Street 61", 82905692);



            // create many vehicles and assign to students and lecturer







            // set season parking pass to a few students's vehicle and lecturer's vehicle
            // each season parking pass is unique to ONE vehicle ONLY







            // initialize 3 carparks - int id, string name, int tps, string desc, string loc, int gr [Refer to constructor of carpark]
            CarPark cp1 = new CarPark(1, "NP CarPark #1", 50, "Carpark at IS Block", "Blk 56", 343.67);
            CarPark cp2 = new CarPark(2, "NP CarPark #2", 70, "Carpark near Munch Canteen", "Blk 16", 1124.30);
            CarPark cp3 = new CarPark(3, "NP CarPark #3", 50, "Carpark at FMS Block", "Blk 76", 524.46);
            cp1.PastRevenue = new Dictionary<string, string>() { //initializing some dummy data for pastRevenue
                { "Jan", "2019: $1204.24,2020: $2367.70"},
                { "Feb", "2019: $4897.30,2020: $2314.76"},
                { "Mar", "2019: $2189.68,2020: $7893.11"},
                { "Apr", "2019: $443.24,2020: $202.60"},
                { "May", "2019: $1234.74,2020: $4874.75"},
                { "Jun", "2019: $5768.58,2020: $4562.73"},
                { "Jul", "2019: $1204.47,2020: $2344.20"},
                { "Aug", "2019: $2345.88,2020: $2367.17"},
                { "Sep", "2019: $5655.34,2020: $1311.11"},
                { "Oct", "2019: $1336.37,2020: $3908.22"},
                { "Nov", "2019: $333.24,2020: $221.82"},
                { "Dec", "2019: $112.44,2020: $228.45"}
            };
            cp2.PastRevenue = new Dictionary<string, string>() {
                { "Jan", "2019: $11204.24,2020: $24367.70"},
                { "Feb", "2019: $1111.35,2020: $2614.71"},
                { "Mar", "2019: $5565.12,2020: $7893.22"},
                { "Apr", "2019: $444.32,2020: $567.22"},
                { "May", "2019: $3453.55,2020: $4587.16"},
                { "Jun", "2019: $2237.99,2020: $4562.48"},
                { "Jul", "2019: $9918.69,2020: $5927.76"},
                { "Aug", "2019: $6656.69,2020: $3458.92"},
                { "Sep", "2019: $2456.59,2020: $3473.24"},
                { "Oct", "2019: $6723.43,2020: $6647.33"},
                { "Nov", "2019: $867.44,2020: $123.78"},
                { "Dec", "2019: $565.12,2020: $117.11"}
            };
            cp3.PastRevenue = new Dictionary<string, string>() { 
                { "Jan", "2019: $2204.24,2020: $2458.68"},
                { "Feb", "2019: $8530.23,2020: $2454.66"},
                { "Mar", "2019: $2558.57,2020: $7573.23"},
                { "Apr", "2019: $456.78,2020: $204.12"},
                { "May", "2019: $9873.79,2020: $4434.60"},
                { "Jun", "2019: $5464.86,2020: $4858.71"},
                { "Jul", "2019: $3937.97,2020: $5683.46"},
                { "Aug", "2019: $3857.78,2020: $3682.33"},
                { "Sep", "2019: $4582.67,2020: $9381.34"},
                { "Oct", "2019: $5827.45,2020: $4857.54"},
                { "Nov", "2019: $6927.24,2020: $564.78"},
                { "Dec", "2019: $484.11,2020: $548.12"}
            };

            // create a list of carpark and add all initialized carpark into the list
            List<CarPark> cpList = new List<CarPark>();
            cpList.Add(cp1);
            cpList.Add(cp2);
            cpList.Add(cp3);




            // create a few Parking Session for Vehicles Parked in carparks







            // have a few vehicles parked in some of the carparks






            // Indian tier code for proof of concept that student iterator is working
            // Will adjust and fix as I understand more of what I need to do
            // =====================================================================
            // ======================= End of Initialization =======================
            // =====================================================================

            // ---------------------------------------------------------------------

            // =====================================================================
            // ======================= Start of Main Program =======================
            // =====================================================================            
            while (true)
            {
                int main_choice;
                // simple login option
                //Console.WriteLine();
                Console.WriteLine("=== Login Page ===");
                Console.WriteLine("1) Student");
                Console.WriteLine("2) Lecturer");
                Console.WriteLine("3) Manager");
                Console.WriteLine("4) Exit");
                Console.WriteLine();

                //validation to ensure the input are NUMBERS ONLY
                Console.Write("Enter choice: ");
                string main_input = Console.ReadLine();
                bool success = Int32.TryParse(main_input, out main_choice);
                if (!success)
                {
                    Console.WriteLine();
                    Console.WriteLine("Please Enter Interger Input only!");
                    continue;
                }

                // choosing the options
                switch (main_choice)
                {
                    case 1: //login as student
                        Console.Write("Enter your StudentID: ");
                        string studID = Console.ReadLine();

                        StudentIterator iterator = new StudentIterator(studentList, studID);
                        if (iterator.isfound == true)
                        {
                            Student student = (Student)iterator.Found();
                            Console.Write("Welcome, {0}", student.Name);
                            StudentMenu();
                            //student.studentMenu();
                            break;
                        }
                        Console.Write("No student with the given student ID found.");
                        break;

                    case 2: //login as lecturer
                        Console.Write("Enter your LecturerID: ");
                        string lecturerID = Console.ReadLine();

                        // retrieve lecturer details, check to ensure its a valid ID as well

                        //Lecturer lecturer = new Lecturer();
                        LecturerMenu();
                        //lect1.lecturerMenu();
                        break;

                    case 3: //login as manager
                        Console.Write("Enter your ManagerID: ");
                        string managerID = Console.ReadLine();

                        // retrieve manager details, check to ensure its a valid ID as well

                        ManagerMenu();
                        //manager.managerMenu();
                        break;

                    case 4: //exit the program
                        System.Environment.Exit(1);
                        break;

                    default: //if entered anything other than the numbers
                        Console.WriteLine();
                        Console.WriteLine("Please enter a Valid Option!!");
                        Console.WriteLine();
                        break;

                }

            }
            // ====================================================================
            // ======================= End of Main Program ========================
            // ====================================================================           

            // --------------------------------------------------------------------

            // ====================================================================
            // ============================= Menus ================================
            // ====================================================================
            void StudentMenu()
            {
                bool condition = true;
                while (condition)
                {
                    Console.WriteLine();
                    Console.WriteLine("=== Student Landing Page ===");
                    Console.WriteLine("1) View Season Parking Pass");
                    Console.WriteLine("2) Renew Season Parking Pass");
                    Console.WriteLine("3) Terminate Season Parking Pass");
                    Console.WriteLine("4) Transfer Season Parking Pass");
                    Console.WriteLine("5) Logout");
                    Console.WriteLine();


                    //validation to ensure the input are NUMBERS ONLY
                    int stud_choice;
                    Console.Write("Enter choice: ");
                    string choice = Console.ReadLine();
                    bool success = Int32.TryParse(choice, out stud_choice);

                    if (!success) //checks if 'choice' input is valid
                    {
                        Console.WriteLine("Please Enter Interger Input only!");
                        continue;
                    }

                    switch (stud_choice)
                    {
                        case 1: // view season parking pass
                            Console.WriteLine("Viewing Your Season Parking Pass");
                            //viewSeasonPass();

                            break;

                        case 2: //renew season parking pass
                            //renewSeasonPass();
                            break;

                        case 3: // terminate season parking pass
                            //terminateSeasonPass();
                            break;

                        case 4: // transfer season parking pass
                            //transferSeasonPass();
                            break;

                        case 5: //log out of student
                            Console.WriteLine();
                            Console.WriteLine("Logging out...");
                            Console.WriteLine();
                            condition = false;
                            break;

                        default: // if wrong option is entered
                            Console.WriteLine();
                            Console.WriteLine("Please enter a valid option!!");
                            Console.WriteLine();
                            break;
                    }

                }
            }

            void LecturerMenu()
            {
                bool condition = true;
                while (condition)
                {
                    Console.WriteLine();
                    Console.WriteLine("===Lecturer Landing Page===");
                    Console.WriteLine("1) View Season Parking Pass");
                    Console.WriteLine("2) Renew Season Parking Pass");
                    Console.WriteLine("3) Terminate Season Parking Pass");
                    Console.WriteLine("4) Transfer Season Parking Pass");
                    Console.WriteLine("5) Logout");
                    Console.WriteLine();

                    int lecturer_choice;
                    Console.Write("Enter choice: ");
                    string choice = Console.ReadLine();
                    bool success = Int32.TryParse(choice, out lecturer_choice);

                    if (!success)
                    {
                        Console.WriteLine("Please Enter an Interger Input only!");
                        continue;
                    }

                    switch (lecturer_choice)
                    {
                        case 1: // view season parking pass
                            Console.WriteLine();
                            Console.WriteLine("Viewing Your Season Parking Pass");
                            //viewSeasonPass();

                            break;

                        case 2: //renew season parking pass
                            //renewSeasonPass();
                            break;

                        case 3: // terminate season parking pass
                            //terminateSeasonPass();
                            break;

                        case 4: // transfer season parking pass
                            //transferSeasonPass();
                            break;

                        case 5: //log out of lecturer
                            Console.WriteLine();
                            Console.WriteLine("Logging out...");
                            condition = false;
                            Console.WriteLine();
                            break;

                        default: // if wrong option is entered
                            Console.WriteLine();
                            Console.WriteLine("Please enter a valid option!!");
                            Console.WriteLine();
                            break;
                    }
                }
            }

            void ManagerMenu()
            {
                bool condition = true;
                while (condition)
                {
                    Console.WriteLine();
                    //Console.WriteLine("Testing something");
                    Console.WriteLine("=== Manager Landing Page ===");
                    Console.WriteLine("1) Process Season Parking Pass");
                    Console.WriteLine("2) Generate Report for Specific Car Park");
                    Console.WriteLine("3) Logout");
                    Console.WriteLine();

                    int manager_choice;
                    Console.Write("Enter choice: ");
                    string choice = Console.ReadLine();
                    bool success = Int32.TryParse(choice, out manager_choice);

                    if (!success)
                    {
                        Console.WriteLine("Please Enter Interger Input only!");
                        continue;
                    }

                    switch (manager_choice)
                    {
                        case 1: // process season parking pass
                            //processSeasonParking();
                            break;

                        case 2: // generate report for specific car park
                            // Retrieve list of Carparks 
                            Console.WriteLine();
                            Console.WriteLine("======= Listing All Carparks =======");
                            Console.WriteLine();
                            foreach (var cp in cpList) {
                                Console.WriteLine("{0}.  {1}", cp.CarParkID, cp.CarParkName);
                            }
                            // prompt for input of carpark #
                            Console.WriteLine();
                            Console.Write("Select Carpark: ");
                            string cpNumber = Console.ReadLine();
                            int cpn;
                            bool c = Int32.TryParse(cpNumber, out cpn);
                            if (!c)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Please Enter an Interger Input only!");
                                continue;
                            }
                            if (cpn < 0 || cpn > 3)
                            {
                                Console.WriteLine("Please enter a valid Carpark number between 1 - 3");
                                continue;
                            }

                            // code to generatereport function -- # TODO calculate the total amount for the month
                            Console.Write("Enter Month in numbers to Generate Report for: ");
                            string month = Console.ReadLine();
                            int months;
                            c = Int32.TryParse(month, out months);
                            if (!c)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Please Enter Interger Input only!");
                                continue;
                            }
                            if (months < 0 || months > 12) {
                                Console.WriteLine("Please enter a valid month between 1 - 12");
                                continue;
                            }

                            switch (cpn) { //execute according to carpark number - probably the wrong way to do this but idrc
                                case 1:
                                    cp1.GenerateReport(months);
                                    break;
                                case 2:
                                    cp2.GenerateReport(months);
                                    break;
                                case 3:
                                    cp3.GenerateReport(months);
                                    break;
                            }
                            break; //finish generating report

                        case 3: // log out of manager
                            Console.WriteLine();
                            Console.WriteLine("Logging out...");
                            condition = false;
                            Console.WriteLine();
                            break;

                        default: // if wrong option is entered
                            Console.WriteLine();
                            Console.WriteLine("Please enter a valid option!!");
                            break;
                    }

                }

            }

        }
    }
}
