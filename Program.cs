using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Text;

namespace SEAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // initialize a few students
            Student s1 = new Student("1", "Peter", "1234", "Abc Street #77", 12346689);
            Student s2 = new Student("2", "Jane", "1234", "Def Street #56", 12346789);
            Student s3 = new Student("3", "Jenny", "1234", "Down in the Street #23", 12346789);
            Student s4 = new Student("4", "Pooler", "1234", "Route 59", 12346789);
            Student s5 = new Student("5", "Godot", "1234", "Heaven's Door", 12346789);
            Student s6 = new Student("6", "Abdul", "1234", "Jalalabad", 12346789);
            Student s7 = new Student("7", "J. Epstein", "1234", "Metropolitan Correctional Center, New York", 12346789);
            // One student without a season parking pass to simulate applying for one later on
            Student s8 = new Student("8", "Ah Beng", "1234", "Aw aw Salakau", 12346789);

            //add into studentlist's Student Collection
            StudentList studentList = new StudentList();
            studentList.StudentCollection.Add(s1);
            studentList.StudentCollection.Add(s2);
            studentList.StudentCollection.Add(s3);
            studentList.StudentCollection.Add(s4);
            studentList.StudentCollection.Add(s5);
            studentList.StudentCollection.Add(s6);
            studentList.StudentCollection.Add(s7);
            studentList.StudentCollection.Add(s8);

            // initialize a few lecturers
            Lecturer lect1 = new Lecturer("1", "Mr Tan", "1234", "Xyz Street 679", 52634789);
            Lecturer lect2 = new Lecturer("2", "Ms Lee", "1234", "Lmn Street 66", 58749632);
            Lecturer lect3 = new Lecturer("3", "Mr Guan", "1234", "Queit Street 33", 98953111);
            Lecturer lect4 = new Lecturer("4", "Ms Hock", "1234", "Belk Street 64", 78631242);
            Lecturer lect5 = new Lecturer("5", "Mr Mak", "1234", "Traverse Town District #1", 67356235);
            Lecturer lect6 = new Lecturer("6", "Mr Boon Hock Lay Seng Teng Kwek Soong Oon Huang Ben", "1234", "'DA HOOD', Compton", 67356235);
            // One lecturer without a season parking pass to simulate applying for one later on
            Lecturer lect7 = new Lecturer("7", "Ah Lian", "1234", "Generic lower socio economic background neighbourhood void deck", 67356235);

            LecturerList lecturerList = new LecturerList();
            lecturerList.LecturerCollection.Add(lect1);
            lecturerList.LecturerCollection.Add(lect2);
            lecturerList.LecturerCollection.Add(lect3);
            lecturerList.LecturerCollection.Add(lect4);
            lecturerList.LecturerCollection.Add(lect5);
            lecturerList.LecturerCollection.Add(lect6);
            lecturerList.LecturerCollection.Add(lect7);

            // initialize a manager
            Manager manager = new Manager("S1111", "Timmy TRG", "blackpeople", "Wattsons Street 61", 82905692);



            // create many vehicles and assign to students and lecturer
            Vehicle v1 = new Vehicle(1, "7BJT254", "Car", "4255459871", s1);
            Vehicle v2 = new Vehicle(2, "XMPLPL8", "Lorry", "7339451801", s1);
            Vehicle v3 = new Vehicle(3, "CVBN21V", "Motorbike", "1990744994", s1);
            Vehicle v4 = new Vehicle(4, "3BSGNA1", "Motorbike", "5615482270", s1);
            Vehicle v5 = new Vehicle(5, "6HBFBV7", "Car", "5061391536", s1);
            Vehicle v6 = new Vehicle(6, "IJV5LPA", "Car", "1199152458", s2);
            Vehicle v7 = new Vehicle(7, "FY6LU7A", "Motorbike", "0893730734", s3);
            Vehicle v8 = new Vehicle(8, "FIBS2RA", "Motorbike", "9750302576", s4);
            Vehicle v9 = new Vehicle(9, "FTYPPgA", "Car", "5495875714", s5);
            Vehicle v10 = new Vehicle(10, "MOEVMMA", "Motorbike", "9597863958", lect1);
            Vehicle v11 = new Vehicle(11, "MKKW5OA", "Car", "5475482306", lect2);
            Vehicle v12 = new Vehicle(12, "CKMMONA", "Motorbike", "7432282064", lect3);
            Vehicle v13 = new Vehicle(13, "MWOJ4NA", "Car", "1552733025", lect4);

            //One vehicle without a season pass
            Vehicle v14 = new Vehicle(14, "CINJRDA", "Motorbike", "8355822804", lect5);

            //Three vehicles simulating a season pass application
            Vehicle v15 = new Vehicle(15, "TH3B0MB", "Motorbike", "9425678134", s6);
            Vehicle v16 = new Vehicle(16, "P3D0V4N", "Lorry", "9425678134", s7);
            Vehicle v17 = new Vehicle(17, "P1MP3D", "Car", "9425678134", lect6);

            List<Vehicle> vList = new List<Vehicle> { v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16 , v17};

            // create and set season parking pass to a few students's vehicle and lecturer's vehicle
            // each season parking pass is unique to ONE vehicle ONLY
            DateTime dt0 = new DateTime(2021, 04, 01);
            DateTime dt1 = new DateTime(2021, 01, 01);
            DateTime dt2 = new DateTime(2021, 02, 01);
            DateTime dt3 = new DateTime(2020, 10, 01);
            DateTime dt4 = new DateTime(2020, 11, 01);
            DateTime dt5 = new DateTime(2020, 12, 01);
            DateTime dt6 = new DateTime(2020, 08, 01);
            DateTime dt7 = new DateTime(2020, 09, 01);

            //initialize season pass and force its state
            SeasonPass sp1 = new SeasonPass(1, "Car", "4255459871", dt1, dt2, v1, "valid");
            SeasonPass sp2 = new SeasonPass(2, "Lorry", "7339451801", dt3, dt0, v2, "valid");
            SeasonPass sp3 = new SeasonPass(3, "Motorbike", "1990744994", dt3, dt4, v3, "expired");
            SeasonPass sp4 = new SeasonPass(4, "Motorbike", "5615482270", dt3, dt4, v4, "expired");
            SeasonPass sp5 = new SeasonPass(5, "Car", "5061391536", dt4, dt5, v5, "expired");
            SeasonPass sp6 = new SeasonPass(6, "Car", "1199152458", dt4, dt5, v6, "terminated");
            SeasonPass sp7 = new SeasonPass(7, "Motorbike", "0893730734", dt4, dt5, v7, "terminated");
            SeasonPass sp8 = new SeasonPass(8, "Motorbike", "9750302576", dt6, dt7, v8, "terminated");
            SeasonPass sp9 = new SeasonPass(9, "Car", "5495875714", dt1, dt0, v9, "pending");
            SeasonPass sp10 = new SeasonPass(10, "Motorbike", "9597863958", dt1, dt0, v10, "pending");
            SeasonPass sp11 = new SeasonPass(11, "Car", "5475482306", dt2, dt0, v11, "pending");
            SeasonPass sp12 = new SeasonPass(12, "Motorbike", "7432282064", dt1, dt0, v12, "valid");
            SeasonPass sp13 = new SeasonPass(13, "Car", "1552733025", dt2, dt0, v13, "valid");

            // Simluating pending season passes
            SeasonPass sp14 = new SeasonPass(14, v15.VehicleType, "5265957696", dt1, dt0, v15, "pending");
            SeasonPass sp15 = new SeasonPass(15, v16.VehicleType, "2552220716", dt2, dt0, v16, "pending");
            SeasonPass sp16 = new SeasonPass(16, v17.VehicleType, "5402177516", dt1, dt2, v17, "pending");

            List<SeasonPass> spList = new List<SeasonPass> { sp1, sp2, sp3, sp4, sp5, sp6, sp7, sp8, sp9, sp10, sp11, sp12, sp13, sp14, sp15, sp16}; //was trying to display the indiv student season pass but failed


            //initialize a few dummy dates
            DateTime d1 = new DateTime(2020, 01, 01);
            DateTime d2 = new DateTime(2020, 02, 01);
            DateTime d3 = new DateTime(2020, 03, 01);
            DateTime d4 = new DateTime(2020, 04, 01);
            DateTime d5 = new DateTime(2020, 05, 01);
            DateTime d6 = new DateTime(2020, 06, 01);
            DateTime d7 = new DateTime(2020, 07, 01);


            // add a few payment records for the above season pass
            // 80dollar car - Surface | 110 dollar car - Sheltered | 17 dollar motorbike Sheltered | 15 dollar motorbike Surface
            Payment p1 = new Payment(d1, 80, "Credit Card", "Surface", sp1);
            Payment p2 = new Payment(d3, 80, "Credit Card", "Surface", sp1);
            Payment p3 = new Payment(d2, 110, "Credit Card", "Sheltered", sp2);
            Payment p4 = new Payment(d3, 17, "Credit Card", "Sheltered", sp3);
            Payment p5 = new Payment(d4, 15, "Credit Card", "Surface", sp4);
            Payment p6 = new Payment(d5, 80, "Credit Card", "Surface", sp5);
            Payment p7 = new Payment(d2, 110, "VISA", "Sheltered", sp6);
            Payment p8 = new Payment(d1, 15, "VISA", "Surface", sp7);
            Payment p9 = new Payment(d2, 17, "VISA", "Sheltered", sp8);
            Payment p10 = new Payment(d3, 110, "VISA", "Sheltered", sp9);
            Payment p11 = new Payment(d4, 15, "VISA", "Surface", sp10);
            Payment p12 = new Payment(d5, 80, "VISA", "Surface", sp11);
            Payment p13 = new Payment(d6, 15, "Credit Card", "Surface", sp12);
            Payment p14 = new Payment(d7, 110, "Credit Card", "Sheltered", sp13);
            Payment p15 = new Payment(d2, 110, "Credit Card", "Sheltered", sp1);



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
            List<CarPark> cpList = new List<CarPark>
            {
                cp1,
                cp2,
                cp3
            };


            DateTime dt8 = new DateTime(2020, 01, 01);
            DateTime dt9 = new DateTime(2020, 01, 03);
            DateTime dt10 = new DateTime(2020, 10, 01);
            DateTime dt11 = new DateTime(2020, 10, 05);
            DateTime dt12 = new DateTime(2020, 11, 06);
            DateTime dt13 = new DateTime(2020, 11, 07);
            // create a few Parking Session for Vehicles Parked in carparks to simulate cars that are parked

            ParkingSession ps1 = new ParkingSession(1, dt10, dt11, v1, cp1); // vehicle1 parked in carpark1
            ParkingSession ps2 = new ParkingSession(2, dt8, dt9, v2, cp2); // vehicle2 parked in carpark2
            ParkingSession ps3 = new ParkingSession(3, dt12, dt13, v3, cp3); // vehicle3 parked in carpark3
            ParkingSession ps4 = new ParkingSession(4, dt10, dt12, v4, cp2); // vehicle4 parked in carpark2
            ParkingSession ps5 = new ParkingSession(5, dt11, dt12, v5, cp1); // vehicle5 parked in carpark1
            ParkingSession ps6 = new ParkingSession(6, dt12, dt13, v6, cp3); // vehicle6 parked in carpark3
            ParkingSession ps7 = new ParkingSession(7, dt10, dt12, v7, cp2); // vehicle7 parked in carpark2
            ParkingSession ps8 = new ParkingSession(8, dt9, dt10, v8, cp2); // vehicle8 parked in carpark2
            ParkingSession ps9 = new ParkingSession(9, dt10, dt12, v9, cp1); // vehicle9 parked in carpark1
            ParkingSession ps10 = new ParkingSession(10, dt11, dt12, v10, cp1); // vehicle10 parked in carpark1


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
                    Console.WriteLine("Please Enter Integer Input only!");
                    continue;
                }

                // choosing the options
                switch (main_choice)
                {
                    case 1: //login as student
                        Console.Write("Enter your Student ID: ");
                        string studID = Console.ReadLine();

                        StudentIterator studentiterator = studentList.CreateIterator(studID);
                        if (studentiterator.isfound == true)
                        {
                            Student student = (Student)studentiterator.Found();
                            Console.WriteLine();
                            Console.Write("Welcome, {0}", student.Name);
                            Console.WriteLine();
                            StudentMenu(student);
                            //student.studentMenu();
                            break;
                        }

                        Console.WriteLine("No student with the given student ID found.");
                        break;

                    case 2: //login as lecturer
                        Console.Write("Enter your Staff ID: ");
                        string staffID = Console.ReadLine();

                        LecturerIterator lectureriterator = lecturerList.CreateIterator(staffID);
                        if (lectureriterator.isfound == true)
                        {
                            Lecturer lecturer = (Lecturer)lectureriterator.Found();
                            Console.WriteLine();
                            Console.Write("Welcome, {0}", lecturer.Name);
                            Console.WriteLine();
                            LecturerMenu(lecturer);
                            //lecturer.lecturerMenu();
                            break;
                        }

                        Console.WriteLine("No Lecturer with the given staff ID found.");
                        break;

                    case 3: //login as manager
                        Console.Write("Enter your ManagerID: ");
                        string managerID = Console.ReadLine();
                        //chcek and validate manager ID
                        Console.WriteLine("Logging in...");
                        Thread.Sleep(TimeSpan.FromSeconds(1));
                        if (managerID.ToLower() != manager.ManagerID.ToLower())
                        {
                            Console.WriteLine("User not found!");
                            break;
                        }
                        Console.WriteLine();
                        Console.WriteLine("Login Successful!");
                        Console.WriteLine();
                        Console.WriteLine("Welcome, {0}", manager.Name);
                        Console.WriteLine();
                        ManagerMenu();
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

            void studentapplyPass(string licensePlate, string vehicleType, string IU, Student student, int cost)
            {
                string currentMonth = DateTime.Now.ToString("MM");
                string currentYear = DateTime.Now.Year.ToString();

                DateTime addedDate = DateTime.Now.AddMonths(1);
                Console.WriteLine();
                Console.WriteLine("The current Month in numerical form is: {0}. The next available month is {1}, year {2}", currentMonth, addedDate.Month, addedDate.Year.ToString());
                Console.WriteLine("Season Parking Passes will always start on the first of a month.");

                Console.WriteLine();
                Console.WriteLine("Please enter the month in numberical form that the pass will start on or enter 'c' to cancel :");

                string chosenMonth = Console.ReadLine().ToLower();

                int convertedchosenMonth;

                if (chosenMonth == "c")
                {
                    Console.WriteLine();
                    Console.WriteLine("Process cancelled.");
                    return;
                }

                else if (!Int32.TryParse(chosenMonth, out convertedchosenMonth))
                {
                    Console.WriteLine();
                    Console.WriteLine("Please enter digits only.");
                    studentapplyPass(licensePlate, vehicleType, IU, student, cost);
                    return;
                }

                else if (convertedchosenMonth > 12 || convertedchosenMonth < 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Error: Month out of range. Select a month from {0} to 12", addedDate.Month);
                    studentapplyPass(licensePlate, vehicleType, IU, student, cost);
                }

                else if (addedDate.Year == DateTime.Now.Year && convertedchosenMonth < DateTime.Now.Month)
                {
                    Console.WriteLine();
                    Console.WriteLine("You must pick a month greather that the current month.");
                    studentapplyPass(licensePlate, vehicleType, IU, student, cost);
                }

                else
                {
                savePoint:
                    Console.WriteLine();
                    Console.WriteLine("Enter the amount of months the Season Pass will be valid for (Minimum of 1 month, Maximum of 12:");
                    string numofMonths = Console.ReadLine();
                    int convertednumofMonths;

                    if (!Int32.TryParse(numofMonths, out convertednumofMonths))
                    {
                        Console.WriteLine();
                        Console.WriteLine("Please enter digits only.");
                        goto savePoint;
                    }

                    else if (convertednumofMonths < 1)
                    {
                        Console.WriteLine("Please enter a minium of 1 month.");
                        goto savePoint;
                    }

                    else if (convertednumofMonths > 12)
                    {
                        Console.WriteLine("You can only buy a pass that is valid up to 12 months.");
                        goto savePoint;
                    }

                    else
                    {
                        Vehicle newVehicle = new Vehicle(vList.Last().VehicleID + 1, licensePlate, vehicleType, IU, student);
                        DateTime startDT = new DateTime(Convert.ToInt32(addedDate.Year), convertedchosenMonth, 01);
                        DateTime endDT = startDT.AddMonths(convertednumofMonths);
                        SeasonPass appliedSeasonPass = new SeasonPass(spList.Last().SeasonPassID + 1, newVehicle.VehicleType, newVehicle.IUNumber, startDT, endDT, newVehicle, "pending");
                        vList.Add(newVehicle);
                        spList.Add(appliedSeasonPass);
                        Console.WriteLine();
                        Console.WriteLine("ID:{0}, License Plate: {1}, IU#: {2} Vehicle Type: {3}", appliedSeasonPass.SeasonPassID, newVehicle.LicensePlate, appliedSeasonPass.IUNumber, appliedSeasonPass.VehicleType);
                        Console.WriteLine("Start Date: {0}, Expiry: {1}, Validity: {2}", appliedSeasonPass.StartDate, appliedSeasonPass.EndDate, "PENDING");
                        Console.WriteLine("A total of ${0} was deducted from your bank account", convertednumofMonths * cost);
                        Console.WriteLine();
                        return;
                    }
                }
            }

            void lecturerapplyPass(string licensePlate, string vehicleType, string IU, Lecturer lecturer, int cost)
            {
                string currentMonth = DateTime.Now.ToString("MM");
                string currentYear = DateTime.Now.Year.ToString();

                DateTime addedDate = DateTime.Now.AddMonths(1);
                Console.WriteLine();
                Console.WriteLine("The current Month in numerical form is: {0}. The next available month is {1}, year {2}", currentMonth, addedDate.Month, addedDate.Year.ToString()) ;
                Console.WriteLine("Season Parking Passes will always start on the first of a month.");

                Console.WriteLine();
                Console.WriteLine("Please enter the month in numerical form that the pass will start on or enter 'c' to cancel:");

                string chosenMonth = Console.ReadLine().ToLower();

                int convertedchosenMonth;

                if (chosenMonth == "c")
                {
                    Console.WriteLine();
                    Console.WriteLine("Process cancelled.");
                    return;
                }

                else if (!Int32.TryParse(chosenMonth, out convertedchosenMonth))
                {
                    Console.WriteLine();
                    Console.WriteLine("Please enter digits only.");
                    lecturerapplyPass(licensePlate, vehicleType, IU, lecturer, cost);
                    return;
                }

                else if (convertedchosenMonth > 12 || convertedchosenMonth < 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Error: Month out of range. Select a month from {0} to 12", addedDate.Month);
                    lecturerapplyPass(licensePlate, vehicleType, IU, lecturer, cost);
                }

                else if (addedDate.Year == DateTime.Now.Year && convertedchosenMonth < DateTime.Now.Month)
                {
                    Console.WriteLine();
                    Console.WriteLine("You must pick a month greather that the current month.");
                    lecturerapplyPass(licensePlate, vehicleType, IU, lecturer, cost);
                }

                else
                {
                savePoint:
                    Console.WriteLine();
                    Console.WriteLine("Enter the amount of months the Season Pass will be valid for (Minimum of 1 month, Maximum of 12:");
                    string numofMonths = Console.ReadLine();
                    int convertednumofMonths;

                    if (!Int32.TryParse(numofMonths, out convertednumofMonths))
                    {
                        Console.WriteLine();
                        Console.WriteLine("Please enter digits only.");
                        goto savePoint;
                    }

                    else if (convertednumofMonths < 1)
                    {
                        Console.WriteLine("Please enter a minium of 1 month.");
                        goto savePoint;
                    }

                    else if (convertednumofMonths > 12)
                    {
                        Console.WriteLine("You can only buy a pass that is valid up to 12 months.");
                        goto savePoint;
                    }

                    else
                    {
                        Vehicle newVehicle = new Vehicle(vList.Last().VehicleID + 1, licensePlate, vehicleType, IU, lecturer);
                        DateTime startDT = new DateTime(Convert.ToInt32(addedDate.Year), convertedchosenMonth, 01);
                        DateTime endDT = startDT.AddMonths(convertednumofMonths) ;
                        SeasonPass appliedSeasonPass = new SeasonPass(spList.Last().SeasonPassID + 1, newVehicle.VehicleType, newVehicle.IUNumber, startDT, endDT, newVehicle, "pending");
                        vList.Add(newVehicle);
                        spList.Add(appliedSeasonPass);
                        Console.WriteLine();
                        Console.WriteLine("ID:{0}, License Plate: {1}, IU#: {2} Vehicle Type: {3}", appliedSeasonPass.SeasonPassID, newVehicle.LicensePlate, appliedSeasonPass.IUNumber, appliedSeasonPass.VehicleType);
                        Console.WriteLine("Start Date: {0}, Expiry: {1}, Validity: {2}", appliedSeasonPass.StartDate, appliedSeasonPass.EndDate, "PENDING");
                        Console.WriteLine("A total of ${0} was deducted from your bank account", convertednumofMonths * cost);
                        Console.WriteLine();
                        return;
                    }
                }
            }

            // ====================================================================
            // ======================= End of Main Program ========================
            // ====================================================================

            // --------------------------------------------------------------------

            // ====================================================================
            // ============================= Menus ================================
            // ====================================================================
            void StudentMenu(Student student)
            {
                SeasonPass spass = new SeasonPass();
                bool condition = true;
                while (condition)
                {
                    Console.WriteLine();
                    Console.WriteLine("=== Student Landing Page ===");
                    Console.WriteLine("1) View Season Parking Pass");
                    Console.WriteLine("2) Renew Season Parking Pass");
                    Console.WriteLine("3) Terminate Season Parking Pass");
                    Console.WriteLine("4) Transfer Season Parking Pass");
                    Console.WriteLine("5) View Parking Charges");
                    Console.WriteLine("6) Apply for a season parking pass");
                    Console.WriteLine("7) Logout");
                    Console.WriteLine();


                    //validation to ensure the input are NUMBERS ONLY

                    int stud_choice;
                    Console.Write("Enter choice: ");
                    string choice = Console.ReadLine();
                    bool success = Int32.TryParse(choice, out stud_choice);

                    if (!success) //checks if 'choice' input is valid
                    {
                        Console.WriteLine("Please Enter Integer Input only!");
                        continue;
                    }

                    switch (stud_choice)
                    {
                        case 1: // view season parking pass
                            Console.WriteLine("=============== Viewing Your Season Parking Pass ===============");
                            Console.WriteLine("");
                            foreach (Vehicle v in student.MyVehicle)
                            {
                                foreach (SeasonPass sssp in spList)
                                {
                                    if (v == sssp.Vehicle && sssp.CurrentState.GetType() == typeof(PendingState))
                                    {
                                        //Console.WriteLine("This Season Parking Pass application is still pending. Preliminary details:");
                                        Console.WriteLine("License Plate: {0}, IU#: {1}, Vehicle: {2}, Months Remaining: {3}, Expiry: {4}, Validity: {5}", sssp.Vehicle.LicensePlate, sssp.IUNumber, sssp.VehicleType, sssp.RemainingMonth, sssp.EndDate.ToString("dd/MMM/yyyy"), "PENDING");
                                        Console.WriteLine();
                                    }
                                    else if (v == sssp.Vehicle && sssp.CurrentState.GetType() == typeof(TerminatedState))
                                    {
                                        //Console.WriteLine("This Season Parking Pass application has been terminated:");
                                        Console.WriteLine("License Plate: {0}, IU#: {1}, Vehicle: {2}, Months Remaining: {3}, Expiry: {4}, Validity: {5}", sssp.Vehicle.LicensePlate, sssp.IUNumber, sssp.VehicleType, sssp.RemainingMonth, sssp.EndDate.ToString("dd/MMM/yyyy"), "TERMINATED");
                                        Console.WriteLine();
                                    }
                                    else if (v == sssp.Vehicle && sssp.CurrentState.GetType() == typeof(ExpiredState))
                                    {
                                        //Console.WriteLine("This Season Parking Pass application has expired:");
                                        Console.WriteLine("License Plate: {0}, IU#: {1}, Vehicle: {2}, Months Remaining: {3}, Expiry: {4}, Validity: {5}", sssp.Vehicle.LicensePlate, sssp.IUNumber, sssp.VehicleType, sssp.RemainingMonth, sssp.EndDate.ToString("dd/MMM/yyyy"), "EXPIRED");
                                        Console.WriteLine();
                                    }

                                    else if (v == sssp.Vehicle && sssp.CurrentState.GetType() == typeof(RejectedState))
                                    {
                                        Console.WriteLine("License Plate: {0}, IU#: {1}, Vehicle: {2}, Validity: {3}", sssp.Vehicle.LicensePlate, sssp.IUNumber, sssp.VehicleType, "Rejected");
                                        Console.WriteLine();
                                    }

                                    else if (v == sssp.Vehicle)
                                    {
                                        Console.WriteLine("License Plate: {0}, IU#: {1}, Vehicle: {2}, Months Remaining: {3}, Expiry: {4}, Validity: {5}", sssp.Vehicle.LicensePlate, sssp.IUNumber, sssp.VehicleType, sssp.RemainingMonth, sssp.EndDate.ToString("dd/MMM/yyyy"), "VALID");
                                        Console.WriteLine();
                                    }
                                }
                            }
                            break;

                        case 2: //renew season parking pass

                            //Console.WriteLine("Number of season parking pass: {0}",student.MyVehicle.Count);
                            Vehicle storeVehicle = new Vehicle();
                            Console.WriteLine("");
                            foreach(Vehicle v in student.MyVehicle)
                            {
                                foreach (SeasonPass spp in spList)
                                {
                                    if (v == spp.Vehicle && spp.CurrentState.GetType() == typeof(PendingState))
                                    {
                                        Console.WriteLine("ID:{0}, IU#:{1}, Vehicle:{2}, Months:{3}, Validity: Pending", spp.SeasonPassID, spp.IUNumber, spp.VehicleType, spp.RemainingMonth);
                                    }
                                    else if (v == spp.Vehicle && spp.CurrentState.GetType() == typeof(TerminatedState))
                                    {
                                        Console.WriteLine("ID:{0}, IU#:{1}, Vehicle:{2}, Months:{3}, Validity: Terminated", spp.SeasonPassID, spp.IUNumber, spp.VehicleType, spp.RemainingMonth);
                                    }
                                    else if (v == spp.Vehicle && spp.CurrentState.GetType() == typeof(ExpiredState))
                                    {
                                        Console.WriteLine("ID:{0}, IU#:{1}, Vehicle:{2}, Months:{3}, Validity: Expired", spp.SeasonPassID, spp.IUNumber, spp.VehicleType, spp.RemainingMonth);
                                    }
                                    else if (v == spp.Vehicle && spp.CurrentState.GetType() == typeof(RejectedState))
                                    {
                                        Console.WriteLine("ID:{0}, IU#:{1}, Vehicle:{2}, Months:{3}, Validity: Rejected", spp.SeasonPassID, spp.IUNumber, spp.VehicleType, spp.RemainingMonth);
                                    }
                                    else if (v == spp.Vehicle && spp.CurrentState.GetType() == typeof(ValidState))
                                    {
                                        Console.WriteLine("ID:{0}, IU#:{1}, Vehicle:{2}, Months:{3}, Validity: Valid", spp.SeasonPassID, spp.IUNumber, spp.VehicleType, spp.RemainingMonth);
                                    }
                                }
                            }
                            Console.Write("Please select the Season Pass you want to renew: ");
                            string sPass = Console.ReadLine();
                            int sp;
                            bool s = Int32.TryParse(sPass, out sp);
                            if (!s)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Please enter a valid number!");
                                continue;
                            }
                            if (sp <= 0 || sp > spList.Count)
                            {
                                Console.WriteLine("Please enter a season pass displayed.");
                                continue;
                            }
                            storeVehicle = spList[Convert.ToInt32(sPass) - 1].Vehicle;
                            if (storeVehicle.UserVehicle != student)
                            {
                                Console.WriteLine("Please choose your own Vehicle only!");
                                break;
                            }
                            foreach (SeasonPass x in spList)
                            {
                                if (Convert.ToInt32(sPass) == x.SeasonPassID && x.Vehicle == storeVehicle)
                                {
                                    x.Renew();
                                }
                            }
                            break;

                        case 3: // terminate season parking pass
                            Console.WriteLine("");
                            Console.WriteLine("===== Terminate Season Parking Pass ====");
                            Console.WriteLine("");

                            bool status = true;
                            string input = "";
                            string vehicleNo;
                            bool found = false;
                            while (status)
                            {
                                Console.WriteLine("Please enter your license plate number: "); //System prompt for user to input license plate number.
                                input = Console.ReadLine();
                                vehicleNo = input.ToUpper();
                                foreach (SeasonPass item in spList)
                                {
                                    if (item.Vehicle.LicensePlate == vehicleNo && item.Vehicle.UserVehicle == student)
                                    {
                                        Console.WriteLine("Please enter reason for termination: "); //System prompt for user to input reason.
                                        input = Console.ReadLine();
                                        if (input == "")
                                        {
                                            Console.WriteLine("You cannot terminate pass without a reason."); //Validation to make sure user has entered a reason to terminate season parking pass.
                                            return;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Are you sure you want to Terminate your Season Parking Pass? y/n"); //2nd Confirmation of Termination.
                                            input = Console.ReadLine();

                                            if (input.Equals("y"))
                                            {
                                                item.TerminatePass();
                                            }
                                        }
                                        found = true;
                                    }
                                }
                                if (!found)
                                    Console.WriteLine("No vehicles with input License Plate No. found. Please try again.\n");
                                else
                                    break;
                            }
                            break;


                        case 4: // transfer season parking pass
                            for (int i = 0; i < student.MyVehicle.Count(); i++)
                            {
                                foreach (SeasonPass stusp in spList)
                                {
                                    if (stusp.IUNumber == student.MyVehicle[i].IUNumber)
                                    {
                                        Console.WriteLine($"{i + 1}) License Plate: {student.MyVehicle[i].LicensePlate}  Vehicle Type: " +
                                        $"{student.MyVehicle[i].VehicleType}  IUNumber: {student.MyVehicle[i].IUNumber} Pass Status: {stusp.CurrentState.GetType().ToString().Substring(13)}");
                                    }
                                }
                            }
                            Console.WriteLine("");
                            Console.Write("Please select the vehicle to transfer season parking pass: ");
                            string sselect = Console.ReadLine();
                            int ssp;
                            bool lec = Int32.TryParse(sselect, out ssp);
                            if (!lec)
                            {
                                Console.WriteLine("Please enter valid number");
                                continue;
                            }
                            if (ssp > student.MyVehicle.Count() || ssp < 1)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Please select the available vehicle! ");
                                continue;
                            }
                            else
                            {
                                var stuv = student.MyVehicle[ssp - 1];
                                foreach (SeasonPass seas in spList)
                                {
                                    if (seas.IUNumber == student.MyVehicle[ssp - 1].IUNumber)
                                    {
                                        seas.TransferPass(stuv);
                                    }
                                }
                            }
                            break;

                        case 5:
                            cp1.ShowCarParkFares();
                            break;

                        case 6:
                            Console.WriteLine();
                            Console.WriteLine("Season Parking Pass Application");
                            Console.WriteLine();
                            Console.WriteLine("Please Enter your Vehicle's License Plate:");
                            string licensePlate = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine("Please Enter your Vehicle's IU Number:");
                            string IU = Console.ReadLine();
                            bool studentapplyFound = false;
                            //Checking if a vehicle with the entered license plate number and iu number already exists
                            //Use case stops if the IU number or license plate is found in the list of existing vehicles, bringing the user back to the main menu
                            foreach (Vehicle v in vList)
                            {
                                if (licensePlate == v.LicensePlate)
                                {
                                    foreach (SeasonPass ssssp in spList)
                                    {
                                        if (ssssp.Vehicle.LicensePlate == licensePlate && ssssp.CurrentState.GetType() != typeof(RejectedState) && ssssp.CurrentState.GetType() != typeof(TerminatedState))
                                        {
                                            Console.WriteLine("Error: A vehicle with this license plate number already has a season parking pass.");
                                            studentapplyFound = true;
                                            break;
                                        }
                                        if (ssssp.Vehicle.IUNumber == IU && ssssp.CurrentState.GetType() != typeof(RejectedState) && ssssp.CurrentState.GetType() != typeof(TerminatedState))
                                        {
                                            Console.WriteLine("Error: A vehicle with this IU number already has a season parking pass.");
                                            studentapplyFound = true;
                                            break;
                                        }
                                    }
                                }
                            }

                            if (studentapplyFound)
                            {
                                break;
                            }
                            //Confirmed that IU number and license plate currently doesn't exist, proceed to prompt for vehicle type to create the vehicle object:
                                Console.WriteLine();
                                Console.WriteLine("Please enter your Vehicle type m/c/v (m = Motorbike, c = Car, l = Lorry):");
                                string vehicleType = Console.ReadLine().ToLower();
            
                            switch (vehicleType)
                            {
                                case "m":
                                    studentapplyPass(licensePlate, "Motorcycle", IU, student, 15);
                                    break;

                                case "c":
                                    studentapplyPass(licensePlate, "Car", IU, student, 80);
                                    break;

                                case "l":
                                    studentapplyPass(licensePlate, "Lorry", IU, student, 80);
                                    break;

                                default:
                                    Console.WriteLine();
                                    Console.WriteLine("Invalid vehicle type. Please select from m/c/v only. (m = Motorbike, c = Car, l = Lorry):");
                                    break;
                            }
                            break;

                        case 7: //log out of student
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


            void LecturerMenu(Lecturer lecturer)
            {
                SeasonPass spass = new SeasonPass();
                bool condition = true;
                while (condition)
                {
                    Console.WriteLine();
                    Console.WriteLine("===Lecturer Landing Page===");
                    Console.WriteLine("1) View Season Parking Pass");
                    Console.WriteLine("2) Renew Season Parking Pass");
                    Console.WriteLine("3) Terminate Season Parking Pass");
                    Console.WriteLine("4) Transfer Season Parking Pass");
                    Console.WriteLine("5) View Parking Charges");
                    Console.WriteLine("6) Apply for a season parking pass");
                    Console.WriteLine("7) Logout");
                    Console.WriteLine();

                    int lecturer_choice;
                    Console.Write("Enter choice: ");
                    string choice = Console.ReadLine();
                    bool success = Int32.TryParse(choice, out lecturer_choice);

                    if (!success)
                    {
                        Console.WriteLine("Please Enter an Integer Input only!");
                        continue;
                    }

                    switch (lecturer_choice)
                    {
                        case 1: // view season parking pass
                            Console.WriteLine("=============== Viewing Your Season Parking Pass ===============");
                            Console.WriteLine("");
                            foreach (Vehicle v in lecturer.MyVehicle)
                            {
                                foreach (SeasonPass sssp in spList)
                                {
                                    if (v == sssp.Vehicle && sssp.CurrentState.GetType() == typeof(PendingState))
                                    {
                                        //Console.WriteLine("This Season Parking Pass application is still pending. Preliminary details:");
                                        Console.WriteLine("License Plate: {0}, IU#: {1}, Vehicle: {2}, Months Remaining: {3}, Expiry: {4}, Validity: {5}", sssp.Vehicle.LicensePlate, sssp.IUNumber, sssp.VehicleType, sssp.RemainingMonth, sssp.EndDate.ToString("dd/MMM/yyyy"), "PENDING");
                                        Console.WriteLine();
                                    }
                                    else if (v == sssp.Vehicle && sssp.CurrentState.GetType() == typeof(TerminatedState))
                                    {
                                        //Console.WriteLine("This Season Parking Pass application has been terminated:");
                                        Console.WriteLine("License Plate: {0}, IU#: {1}, Vehicle: {2}, Months Remaining: {3}, Expiry: {4}, Validity: {5}", sssp.Vehicle.LicensePlate, sssp.IUNumber, sssp.VehicleType, sssp.RemainingMonth, sssp.EndDate.ToString("dd/MMM/yyyy"), "TERMINATED");
                                        Console.WriteLine();
                                    }
                                    else if (v == sssp.Vehicle && sssp.CurrentState.GetType() == typeof(ExpiredState))
                                    {
                                        //Console.WriteLine("This Season Parking Pass application has expired:");
                                        Console.WriteLine("License Plate: {0}, IU#: {1}, Vehicle: {2}, Months Remaining: {3}, Expiry: {4}, Validity: {5}", sssp.Vehicle.LicensePlate, sssp.IUNumber, sssp.VehicleType, sssp.RemainingMonth, sssp.EndDate.ToString("dd/MMM/yyyy"), "EXPIRED");
                                        Console.WriteLine();
                                    }
                                    else if (v == sssp.Vehicle && sssp.CurrentState.GetType() == typeof(RejectedState))
                                    {
                                        Console.WriteLine("License Plate: {0}, IU#: {1}, Vehicle: {2}, Validity: {3}", sssp.Vehicle.LicensePlate, sssp.IUNumber, sssp.VehicleType, "Rejected");
                                        Console.WriteLine();
                                    }

                                    else if (v == sssp.Vehicle)
                                    {
                                        Console.WriteLine("License Plate: {0}, IU#: {1}, Vehicle: {2}, Months Remaining: {3}, Expiry: {4}, Validity: {5}", sssp.Vehicle.LicensePlate, sssp.IUNumber, sssp.VehicleType,sssp.RemainingMonth, sssp.EndDate.ToString("dd/MMM/yyyy"), "VALID");
                                        Console.WriteLine();
                                    }
                                }
                            }
                            break;

                        case 2: //renew season parking pass
                            Vehicle storeVehicle = new Vehicle();
                            foreach (Vehicle v in lecturer.MyVehicle)
                            {
                                foreach (SeasonPass spp in spList)
                                {
                                    if (v == spp.Vehicle && spp.CurrentState.GetType() == typeof(PendingState))
                                    {
                                        Console.WriteLine("ID:{0}, IU#:{1}, Vehicle:{2}, Months:{3}, Validity: Pending", spp.SeasonPassID, spp.IUNumber, spp.VehicleType, spp.RemainingMonth);
                                    }
                                    else if (v == spp.Vehicle && spp.CurrentState.GetType() == typeof(TerminatedState))
                                    {
                                        Console.WriteLine("ID:{0}, IU#:{1}, Vehicle:{2}, Months:{3}, Validity: Terminated", spp.SeasonPassID, spp.IUNumber, spp.VehicleType, spp.RemainingMonth);
                                    }
                                    else if (v == spp.Vehicle && spp.CurrentState.GetType() == typeof(ExpiredState))
                                    {
                                        Console.WriteLine("ID:{0}, IU#:{1}, Vehicle:{2}, Months:{3}, Validity: Expired", spp.SeasonPassID, spp.IUNumber, spp.VehicleType, spp.RemainingMonth);
                                    }
                                    else if (v == spp.Vehicle && spp.CurrentState.GetType() == typeof(RejectedState))
                                    {
                                        Console.WriteLine("ID:{0}, IU#:{1}, Vehicle:{2}, Months:{3}, Validity: Rejected", spp.SeasonPassID, spp.IUNumber, spp.VehicleType, spp.RemainingMonth);
                                    }
                                }
                            }
                            Console.Write("Please select the Season Pass you want to renew: ");
                            string sPass = Console.ReadLine();
                            int sp;
                            bool s = Int32.TryParse(sPass, out sp);
                            if (!s)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Please enter a valid number!");
                                return;
                            }
                            if (sp < 0 || sp > spList.Count)
                            {
                                Console.WriteLine("Please enter a season pass displayed.");
                                return;
                            }
                            storeVehicle = spList[Convert.ToInt32(sPass) - 1].Vehicle;
                            if (storeVehicle.UserVehicle != lecturer) {
                                Console.WriteLine("Please choose your own Vehicle only!");
                                break;
                            }
                            foreach (SeasonPass x in spList)
                            {
                                if (Convert.ToInt32(sPass) == x.SeasonPassID && x.Vehicle == storeVehicle)
                                {
                                    x.Renew();
                                }
                            }
                            break;

                        case 3: // terminate season parking pass
                            //terminateSeasonPass();
                            Console.WriteLine("");
                            Console.WriteLine("===== Terminate Season Parking Pass ====");
                            Console.WriteLine("");

                            bool status = true;
                            string input = "";
                            string vehicleNo;
                            bool found = false;
                            while (status)
                            {
                                Console.WriteLine("Please enter your license plate number: "); //System prompt for user to input license plate number.
                                input = Console.ReadLine();
                                vehicleNo = input.ToUpper();
                                foreach (SeasonPass item in spList)
                                {
                                    if (item.Vehicle.LicensePlate == vehicleNo && item.Vehicle.UserVehicle == lecturer)
                                    {
                                        Console.WriteLine("Please enter reason for termination: "); //System prompt for user to input reason.
                                        input = Console.ReadLine();
                                        if (input == "")
                                        {
                                            Console.WriteLine("You cannot terminate pass without a reason."); //Validation to make sure user has entered a reason to terminate season parking pass.
                                            return;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Are you sure you want to Terminate your Season Parking Pass? y/n"); //2nd Confirmation of Termination.
                                            input = Console.ReadLine();

                                            if (input.Equals("y"))
                                            {
                                                item.TerminatePass();
                                            }
                                        }
                                        found = true;
                                    }
                                }
                                if (!found)
                                    Console.WriteLine("No vehicles with input License Plate No. found. Please try again.\n");
                               else 
                                    break;
                            }
                            break;

                        case 4: // transfer season parking pass
                            //transferSeasonPass();
                            Console.WriteLine("");
                            Console.WriteLine("===== Transfer Season Parking Pass ====");
                            Console.WriteLine("");
                            for (int i = 0; i < lecturer.MyVehicle.Count(); i++)
                            {
                                foreach (SeasonPass llsp in spList)
                                {
                                    if (llsp.IUNumber == lecturer.MyVehicle[i].IUNumber)
                                    {
                                        Console.WriteLine($"{i + 1}) License Plate: {lecturer.MyVehicle[i].LicensePlate}  Vehicle Type: " +
                                    $"{lecturer.MyVehicle[i].VehicleType}  IUNumber: {lecturer.MyVehicle[i].IUNumber} Pass Status: {llsp.CurrentState.GetType().ToString().Substring(13)}");
                                    }
                                }
                            }
                            Console.WriteLine("");
                            Console.Write("Please select the vehicle to transfer season parking pass: ");
                            string lselect = Console.ReadLine();
                            int lsp;
                            bool lec = Int32.TryParse(lselect, out lsp);
                            if (!lec)
                            {
                                Console.WriteLine("Please enter valid number");
                                continue;
                            }
                            if (lsp > lecturer.MyVehicle.Count() || lsp < 1)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Please select the available vehicle! ");
                                continue;
                            }
                            else
                            {
                                var lecv = lecturer.MyVehicle[lsp - 1];
                                foreach (SeasonPass seas in spList)
                                {
                                    if (seas.IUNumber == lecturer.MyVehicle[lsp - 1].IUNumber)
                                    {
                                        seas.TransferPass(lecv);
                                    }
                                }
                            }
                            break;

                        case 5:
                            cp1.ShowCarParkFares();
                            break;

                        case 6:
                            Console.WriteLine();
                            Console.WriteLine("Season Parking Pass Application");
                            Console.WriteLine();
                            Console.WriteLine("Please Enter your Vehicle's License Plate:");
                            string licensePlate = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine("Please Enter your Vehicle's IU Number:");
                            string IU = Console.ReadLine();
                            bool lecturerapplyFound = false;
                            //Checking if a vehicle with the entered license plate number and iu number already exists
                            //Use case stops if the IU number or license plate is found in the list of existing vehicles, bringing the user back to the main menu
                            foreach (SeasonPass ssssp in spList)
                            {
                                if (ssssp.Vehicle.LicensePlate == licensePlate && ssssp.CurrentState.GetType() != typeof(RejectedState) && ssssp.CurrentState.GetType() != typeof(TerminatedState))
                                {
                                    Console.WriteLine("Error: A vehicle with this license plate number already has a season parking pass.");
                                    lecturerapplyFound = true;
                                }

                                if (ssssp.Vehicle.IUNumber == IU && ssssp.CurrentState.GetType() != typeof(RejectedState) && ssssp.CurrentState.GetType() != typeof(TerminatedState))
                                {
                                    Console.WriteLine("Error: A vehicle with this IU number already has a season parking pass.");
                                    lecturerapplyFound = true;
                                }
                                if (lecturerapplyFound == true)
                                {
                                    break;
                                }
                            }

                            if (lecturerapplyFound)
                            {
                                break;
                            }
                            //Confirmed that IU number and license plate currently doesn't exist, proceed to prompt for vehicle type to create the vehicle object:
                            Console.WriteLine();
                            Console.WriteLine("Please enter your Vehicle type m/c/v (m = Motorbike, c = Car, l = Lorry):");
                            string vehicleType = Console.ReadLine().ToLower();

                            switch (vehicleType)
                            {
                                case "m":
                                    lecturerapplyPass(licensePlate, "Motorcycle", IU, lecturer, 15);
                                    break;

                                case "c":
                                    lecturerapplyPass(licensePlate, "Car", IU, lecturer, 80);
                                    break;

                                case "l":
                                    lecturerapplyPass(licensePlate, "Lorry", IU, lecturer, 80);
                                    break;

                                default:
                                    Console.WriteLine();
                                    Console.WriteLine("Invalid vehicle type. Please select from m/c/v only. (m = Motorbike, c = Car, l = Lorry):");
                                    break;
                            }
                            break;

                        case 7: //log out of lecturer
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
                CarPark cp = new CarPark();
                bool condition = true;
                while (condition)
                {
                    Console.WriteLine();
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
                        Console.WriteLine("Please Enter Integer Input only!");
                        continue;
                    }

                    switch (manager_choice)
                    {
                        case 1: // process season parking pass
                            //processSeasonParking();
                            Console.WriteLine();
                            Console.WriteLine("================ Process Season Parking Pass ================");
                            List<SeasonPass> pendingList = new List<SeasonPass>();
                            for (int i = 0; i < spList.Count(); i++)
                            {
                                if (spList[i].CurrentState.GetType() == typeof(PendingState))
                                {
                                    Console.WriteLine("ID:{0}, License Plate:{1}, IU#: {2}, Vehicle: {3}, Start Date: {4}, End Date: {5}", spList[i].SeasonPassID, spList[i].Vehicle.LicensePlate, spList[i].IUNumber, spList[i].VehicleType, spList[i].StartDate.ToString("dd/MMM/yyyy"), spList[i].EndDate.ToString("dd/MMM/yyyy"));
                                    //Console.WriteLine("ID:{0}, Vehicle:{1}, I#:{2}, Start date:{3}, End Date:{4}", spList[i].SeasonPassID, spList[i].VehicleType, spList[i].IUNumber, spList[i].StartDate, spList[i].EndDate);
                                    pendingList.Add(spList[i]);
                                }
                            }
                            if (pendingList.Count > 0)
                            {
                                Console.WriteLine();
                                Console.Write("Enter the ID of the Season pass to process:");
                                int process_choice;
                                string option = Console.ReadLine();
                                bool process_success = Int32.TryParse(option, out process_choice);
                                if (!process_success)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Error: Please enter numbers only.");
                                    continue;
                                }
                                bool matchProcess = false;
                                for (int i=0; i < pendingList.Count(); i++)
                                {
                                    if (pendingList[i].SeasonPassID == process_choice)
                                    {
                                        matchProcess = true;
                                        Console.WriteLine();
                                        Console.WriteLine("Processing Season Parking pass with ID of {0}: ", process_choice);
                                        Console.WriteLine();
                                        Console.WriteLine("============ Season Parking Pass Details ============");
                                        Console.WriteLine("ID:{0}, License Plate:{1}, IU#:{2}, Vehicle type:{3}, Start date:{4}, End Date:{5}", pendingList[i].SeasonPassID, pendingList[i].Vehicle.LicensePlate, pendingList[i].IUNumber, pendingList[i].VehicleType, pendingList[i].StartDate, pendingList[i].EndDate);
                                        Console.WriteLine();
                                        Console.Write("Approve or Reject Season Parking Pass? (Enter a to approve, r to reject.) ");
                                        string approve_choice = Console.ReadLine().ToLower();
                                        switch (approve_choice)
                                        {
                                            case "a":
                                                pendingList[i].ApprovePass();
                                                break;

                                            case "r":
                                                pendingList[i].RejectPass();
                                                break;

                                            default:
                                                Console.WriteLine();
                                                Console.WriteLine("Invalid Option! Returning to main menu.");
                                                break;
                                        }
                                        break;
                                    }
                                }
                                if (matchProcess == false)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("No pending Season Parking pass with the ID of {0} found.", process_choice);
                                }
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("There are no pending Season Parking Passes at the moment");
                                break;
                            }
                            break;

                        case 2: // generate report for specific car park
                            cp.GenerateReport(cpList, spList);
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
