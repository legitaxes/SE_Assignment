using System;
using System.Collections.Generic;
using System.Text;

namespace SEAssignment
{
    public class Student
    {
        //attributes 
        // use propfull, <tab>, <tab> to create the variables with getter and setter
        private string studentID;
        private string name;
        private string password;
        private string address;
        private int mobileNumber;

        //---getter setter for properties---
        public string StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public int MobileNumber
        {
            get { return mobileNumber; }
            set { mobileNumber = value; }
        }

        //constructor
        public Student(string id, string sname, string pw, string add, int mobile)
        {
            StudentID = id;
            name = sname;
            password = pw;
            address = add;
            mobileNumber = mobile;

        }

        public void studentMenu()
        {
            bool condition = true;
            while (condition)
            {
                Console.WriteLine();
                Console.WriteLine("===Student Landing Page===");
                Console.WriteLine("1) View Season Parking Pass");
                Console.WriteLine("2) Renew Season Parking Pass");
                Console.WriteLine("3) Terminate Season Parking Pass");
                Console.WriteLine("4) Transfer Season Parking Pass");
                Console.WriteLine("5) Enter Parking");
                Console.WriteLine("6) Exit Parking");
                Console.WriteLine("7) Logout");
                Console.WriteLine();


                //validation to ensure the input are NUMBERS ONLY
                int stud_choice;
                Console.Write("Enter choice: ");
                string choice = Console.ReadLine();
                bool success = Int32.TryParse(choice, out stud_choice);

                if (!success) //checks if 'choice' input is valid
                {
                    Console.WriteLine("Please Enter an Interger Input only!");
                    continue;
                }

                switch (stud_choice)
                {
                    case 1: // view season parking pass
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
        public void viewSeasonPass()
        {
            // implementation for viewing season parking pass

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