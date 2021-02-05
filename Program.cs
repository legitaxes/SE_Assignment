using System;

namespace SEAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // initialize a few students 
            Student s1 = new Student(1, "Peter", "1234", "Abc Street", 12346689);
            Student s2 = new Student(2, "Jane", "1234", "Def Street", 12346789);




            // initialize a few lecturers
            Lecturer lect1 = new Lecturer(1, "Mr Tan", "1234", "Xyz Street", 52634789);
            Lecturer lect2 = new Lecturer(2, "Ms Lee", "1234", "Lmn Street", 58749632);



            // create many vehicles and assign to students and lecturer





            // set parking pass to a few students's vehicle and lecturer's vehicle




            // initialize 3 carparks - int id, string name, int tps, string desc, string loc, int gr [Refer to constructor of carpark]
            CarPark cp1 = new CarPark(1, "NP CarPark #1", 50, "Carpark at IS Block", "Blk 56", 343.67);
            CarPark cp2 = new CarPark(2, "NP CarPark #2", 70, "Carpark at IS Block", "Blk 56", 1124.30);
            CarPark cp3 = new CarPark(3, "NP CarPark #3", 50, "Carpark at IS Block", "Blk 56", 524.46);

            // code to test generatereport function (should not be here!! but its just for testing whether it works)
            Console.Write("Enter Month in numbers to Generate Report for: ");
            string month = Console.ReadLine();
            int months;
            bool c = Int32.TryParse(month, out months);
            if (!c)
            {
                Console.WriteLine();
                Console.WriteLine("Please Enter an Interger Input only!");
                //continue;
            }

            cp2.GenerateReport(months);


            // have a few vehicles parked in some of the carparks




            while (true)
            {
                int main_choice;
                // simple login option
                Console.WriteLine();
                Console.WriteLine("===Login Page===");
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
                    Console.WriteLine("Please Enter an Interger Input only!");
                    continue;
                }

                // choosing the options
                switch (main_choice)
                {
                    case 1:
                        Console.Write("Enter your StudentID: ");
                        string studID = Console.ReadLine();

                        // retrieve student details, check to ensure its a valid ID as well

                        //Student student = new Student();
                        s1.studentMenu();
                        break;

                    case 2:
                        Console.Write("Enter your LecturerID: ");
                        string lecturerID = Console.ReadLine();

                        // retrieve lecturer details, check to ensure its a valid ID as well

                        //Lecturer lecturer = new Lecturer();
                        lect1.lecturerMenu();
                        break;

                    case 3:
                        Console.Write("Enter your ManagerID: ");
                        string managerID = Console.ReadLine();

                        // retrieve manager details, check to ensure its a valid ID as well

                        Manager manager = new Manager();
                        manager.managerMenu();
                        break;

                    case 4:
                        System.Environment.Exit(1);
                        break;

                    default: //if entered anything other than the numbers
                        Console.WriteLine();
                        Console.WriteLine("Please enter a Valid Option!!");
                        Console.WriteLine();
                        break;

                }

            }
        }
    }
}

