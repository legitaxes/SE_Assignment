using System;
using System.Collections.Generic;
using System.Text;

namespace SEAssignment
{
    class Lecturer
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
        public Lecturer() { 
        
        }


        // methods / actions
        public void lecturerMenu() {
            bool condition = true;
            while (condition)
            {
                Console.WriteLine();
                Console.WriteLine("===Lecturer Landing Page===");
                Console.WriteLine("1) View Season Parking Pass");
                Console.WriteLine("2) Renew Season Parking Pass");
                Console.WriteLine("3) Terminate Season Parking Pass");
                Console.WriteLine("4) Transfer Season Parking Pass");
                Console.WriteLine("5) Enter Parking");
                Console.WriteLine("6) Exit Parking");
                Console.WriteLine("7) Logout");
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
                        viewSeasonPass();

                        break;

                    case 2: //renew season parking pass
                        renewSeasonPass();
                        break;

                    case 3: // terminate season parking pass
                        terminateSeasonPass();
                        break;

                    case 4: // transfer season parking pass
                        transferSeasonPass();
                        break;

                    case 5: // enter parking 
                        enterParking();
                        break;

                    case 6: // exit parking
                        exitParking();
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
        public void viewSeasonPass() { 
            // implementation for view season parking pass
        }

        public void renewSeasonPass()
        {
            // implementation for renew season parking pass

        }

        public void terminateSeasonPass()
        {
            // implementation for terminate season parking pass

        }

        public void transferSeasonPass()
        {
            // implementation for transfer season parking pass

        }

        public void enterParking()
        {
            // implementation for enter parking lot

        }

        public void exitParking()
        {
            // implementation for exit parking lot

        }

    }
}
