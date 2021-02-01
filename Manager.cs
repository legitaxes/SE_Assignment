using System;
using System.Collections.Generic;
using System.Text;

namespace SEAssignment
{
    class Manager
    {
        //attributes 
        // use propfull, <tab>, <tab> to create the variables with getter and setter
        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

        //constructor
        public Manager() { 
        
        }

        // methods / actions
        public void managerMenu() 
        {
            bool condition = true;
            while (condition)
            {
                Console.WriteLine();
                Console.WriteLine("===Student Landing Page===");
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
                    Console.WriteLine("Please Enter an Interger Input only!");
                    continue;
                }

                switch (manager_choice)
                {
                    case 1: // process season parking pass
                        processSeasonParking();
                        break;

                    case 2: // generate report for specific car park
                        generateReport();
                        break;

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
       
        public void processSeasonParking() 
        { 
            // implementation of process season parking

        }

        public void generateReport()
        {
            // implementation of generating report

        }

    }
}
