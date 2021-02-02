using System;

namespace SEAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // initialize a few students 





            // initialize a few lecturers




            // create many vehicles and assign to students and lecturer





            // set parking pass to a few students's vehicle and lecturer's vehicle




            // initialize 3 carparks






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

                        Student student = new Student();
                        student.studentMenu();
                        break;

                    case 2:
                        Console.Write("Enter your LecturerID: ");
                        string lecturerID = Console.ReadLine();

                        // retrieve lecturer details, check to ensure its a valid ID as well

                        Lecturer lecturer = new Lecturer();
                        lecturer.lecturerMenu();
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

