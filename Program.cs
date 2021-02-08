using System;
using System.Collections.Generic;
using System.Threading;

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

            //add into studentlist's Student Collection 
            StudentList studentList = new StudentList();
            studentList.StudentCollection.Add(s1);
            studentList.StudentCollection.Add(s2);
            studentList.StudentCollection.Add(s3);
            studentList.StudentCollection.Add(s4);
            studentList.StudentCollection.Add(s5);


            // initialize a few lecturers
            Lecturer lect1 = new Lecturer("1", "Mr Tan", "1234", "Xyz Street 679", 52634789);
            Lecturer lect2 = new Lecturer("2", "Ms Lee", "1234", "Lmn Street 66", 58749632);
            Lecturer lect3 = new Lecturer("3", "Mr Guan", "1234", "Queit Street 33", 98953111);
            Lecturer lect4 = new Lecturer("4", "Ms Hock", "1234", "Belk Street 64", 78631242);
            Lecturer lect5 = new Lecturer("5", "Mr Mak", "1234", "Traverse Town District #1", 67356235);

            LecturerList lecturerList = new LecturerList();
            lecturerList.LecturerCollection.Add(lect1);
            lecturerList.LecturerCollection.Add(lect2);
            lecturerList.LecturerCollection.Add(lect3);
            lecturerList.LecturerCollection.Add(lect4);
            lecturerList.LecturerCollection.Add(lect5);

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

            //the only vehicle without season pass
            Vehicle v14 = new Vehicle(14, "CINJRDA", "Motorbike", "8355822804", lect5);



            // create and set season parking pass to a few students's vehicle and lecturer's vehicle
            // each season parking pass is unique to ONE vehicle ONLY
            DateTime dt1 = new DateTime(2021, 01, 01);
            DateTime dt2 = new DateTime(2021, 02, 01);
            DateTime dt3 = new DateTime(2020, 10, 01);
            DateTime dt4 = new DateTime(2020, 11, 01);
            DateTime dt5 = new DateTime(2020, 12, 01);
            DateTime dt6 = new DateTime(2020, 08, 01);
            DateTime dt7 = new DateTime(2020, 09, 01);

            //initialize season pass and force its state
            SeasonPass sp1 = new SeasonPass(1, "Car", "4255459871", dt1, dt2, v1, "valid");
            SeasonPass sp2 = new SeasonPass(2, "Lorry", "7339451801", dt3, dt4, v2, "valid");
            SeasonPass sp3 = new SeasonPass(3, "Motorbike", "1990744994", dt3, dt4, v3, "expired");
            SeasonPass sp4 = new SeasonPass(4, "Motorbike", "5615482270", dt1, dt2, v4, "expired");
            SeasonPass sp5 = new SeasonPass(5, "Car", "5061391536", dt4, dt5, v5, "expired");
            SeasonPass sp6 = new SeasonPass(6, "Car", "1199152458", dt4, dt5, v6, "terminated");
            SeasonPass sp7 = new SeasonPass(7, "Motorbike", "0893730734", dt4, dt5, v7, "terminated");
            SeasonPass sp8 = new SeasonPass(8, "Motorbike", "9750302576", dt6, dt7, v8, "terminated");
            SeasonPass sp9 = new SeasonPass(9, "Car", "5495875714", dt6, dt4, v9, "pending");
            SeasonPass sp10 = new SeasonPass(10, "Motorbike", "9597863958", dt7, dt1, v10, "pending");
            SeasonPass sp11 = new SeasonPass(11, "Car", "5475482306", dt7, dt3, v11, "pending");
            SeasonPass sp12 = new SeasonPass(12, "Motorbike", "7432282064", dt7, dt2, v12, "valid");
            SeasonPass sp13 = new SeasonPass(13, "Car", "1552733025", dt6, dt2, v13, "valid");

            List<SeasonPass> spList = new List<SeasonPass> { sp1, sp2, sp3, sp4, sp5, sp6, sp7, sp8, sp9, sp10, sp11, sp12, sp13 }; //was trying to display the indiv student season pass but failed


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

            // create a few Parking Session for Vehicles Parked in carparks to simulate cars that are parked
            DateTime dt8 = new DateTime(2020, 01, 01);
            DateTime dt9 = new DateTime(2020, 01, 03);
            DateTime dt10 = new DateTime(2020, 10, 01);
            DateTime dt11 = new DateTime(2020, 10, 05);
            DateTime dt12 = new DateTime(2020, 11, 06);
            DateTime dt13 = new DateTime(2020, 11, 07);

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



            //// have a few vehicles parked in some of the carparks
            ////add to parking list under carpark
            //cp1.AddVehicleParking(ps1);
            //cp1.AddVehicleParking(ps5);
            //cp1.AddVehicleParking(ps9);
            //cp1.AddVehicleParking(ps10);
            //cp2.AddVehicleParking(ps2);
            //cp2.AddVehicleParking(ps4);
            //cp2.AddVehicleParking(ps7);
            //cp2.AddVehicleParking(ps8);
            //cp3.AddVehicleParking(ps3);
            //cp3.AddVehicleParking(ps6);

            ////add the location of vehicle where the carpark is parked
            //v1.AddVehicleParking(ps1);
            //v2.AddVehicleParking(ps2);
            //v3.AddVehicleParking(ps3);
            //v4.AddVehicleParking(ps4);
            //v5.AddVehicleParking(ps5);
            //v6.AddVehicleParking(ps6);
            //v7.AddVehicleParking(ps7);
            //v8.AddVehicleParking(ps8);
            //v9.AddVehicleParking(ps9);
            //v10.AddVehicleParking(ps10);




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
                        Console.Write("Enter your Student ID: ");
                        string studID = Console.ReadLine();

                        StudentIterator studentiterator = new StudentIterator(studentList, studID);
                        if (studentiterator.isfound == true)
                        {
                            Student student = (Student)studentiterator.Found();
                            Console.Write("Welcome, {0}", student.Name);
                            StudentMenu(student);
                            //student.studentMenu();
                            break;
                        }

                        Console.Write("No student with the given student ID found.");
                        break;

                    case 2: //login as lecturer
                        Console.Write("Enter your Staff ID: ");
                        string staffID = Console.ReadLine();

                        LecturerIterator lectureriterator = new LecturerIterator(lecturerList, staffID);
                        if (lectureriterator.isfound == true)
                        {
                            Lecturer lecturer = (Lecturer)lectureriterator.Found();
                            Console.Write("Welcome, {0}", lecturer.Name);
                            LecturerMenu();
                            //lecturer.lecturerMenu();
                            break;
                        }

                        Console.Write("No Lecturer with the given staff ID found.");
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
                        Console.WriteLine("Welcome! {0}", manager.Name);
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
            // ====================================================================
            // ======================= End of Main Program ========================
            // ====================================================================           

            // --------------------------------------------------------------------

            // ====================================================================
            // ============================= Menus ================================
            // ====================================================================
            void StudentMenu(Student student)
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
                    Console.WriteLine("5) View Parking Charges");
                    Console.WriteLine("6) Logout");
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
                            //foreach (var v in vList)
                            //{
                                
                                
                            //}
                            //viewSeasonPass();

                            break;

                        case 2: //renew season parking pass
                            Console.WriteLine(student.MyVehicle.Count);

                            Console.WriteLine("Renew Season Parking Pass");
                            Console.Write("Please enter no. of months you want to renew: ");
                            string rpMonth = Console.ReadLine();
                            int rpm;
                            bool r = Int32.TryParse(rpMonth, out rpm);
                            if(!r)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Please enter valid number");
                                continue;
                            }
                            if(rpm < 0 || rpm > 12)
                            {
                                Console.WriteLine("Please enter a valid month between 1 -12");
                                continue;
                            }

                            
                            sp3.Renew();
                            break;

                        case 3: // terminate season parking pass
                            //terminateSeasonPass();
                            break;

                        case 4: // transfer season parking pass
                            //transferSeasonPass();
                            break;

                        case 5:
                            cp1.ShowCarParkFares();
                            break;

                        case 6: //log out of student
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
                    Console.WriteLine("5) View Parking Charges");
                    Console.WriteLine("6) Logout");
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
                            Console.WriteLine("Renew Season Parking Pass");
                            Console.Write("Please enter no. of months you want to renew: ");
                            //renewSeasonPass();
                            break;

                        case 3: // terminate season parking pass
                            //terminateSeasonPass();
                            break;

                        case 4: // transfer season parking pass
                            //transferSeasonPass();
                            break;

                        case 5:
                            cp1.ShowCarParkFares();
                            break;

                        case 6: //log out of lecturer
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
                        Console.WriteLine("Please Enter Interger Input only!");
                        continue;
                    }

                    switch (manager_choice)
                    {
                        case 1: // process season parking pass
                            //processSeasonParking();
                            break;

                        case 2: // generate report for specific car park
                            cp.GenerateReport(cpList);
                            //switch (cpn) { //execute according to carpark number - probably the wrong way to do this but idrc
                            //    case 1:
                            //        cp1.GenerateReport(months);
                            //        break;
                            //    case 2:
                            //        cp2.GenerateReport(months);
                            //        break;
                            //    case 3:
                            //        cp3.GenerateReport(months);
                            //        break;
                            //}
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
