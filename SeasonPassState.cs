using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SEAssignment
{
    public interface ISeasonPassState
    {
        void ApprovePass();

        void Renew();

        void TransferPass(Vehicle v);

        void TerminatePass();

    }

    //pendingstate class
    class PendingState : ISeasonPassState {
        private SeasonPass vsp;
        public PendingState(SeasonPass sp)
        {
            vsp = sp;
        }

        public void ApprovePass() { 
            //implementation of Approve Season Parking Pass
        }

        public void Renew() {
            // implementation
            Console.WriteLine("Not allowed to renew when you don't have a season pass!");
        }

        public void TransferPass(Vehicle v) {
            // vt - vehicletype in string (Lorry, Car, Motorbike)
            // implementation of transfering pass to another vehicle
            // code below works, i accidentally did it lol. all i did was create a class called vehicle and put vehicle property under seasonpass
            //if (sp.VehicleType == vt) {
            //    sp.Vehicle = v;
            //    Console.WriteLine("Pass Transferred Successfully!");
            // if vehicle type does not match
            //    do something..
            Console.WriteLine("Not allowed to Transfer Season Pass in Pending state!");
        }
        public void TerminatePass()
        {
            Console.WriteLine("Not allowed to Terminate Season Pass in Pending state!");
        }

    }

    //validstate class
    class ValidState : ISeasonPassState {
        private SeasonPass vsp;

        public ValidState(SeasonPass sp)
        {
            vsp = sp;
        }



        public void ApprovePass() {
            Console.WriteLine("Not allowed to Approve Season Pass that is already Valid!");
        }

        public void Renew()
        {

            Console.WriteLine("Please select the season parking pass you want to renew: ");
            string sPass = Console.ReadLine();
            int sp;
            bool s = Int32.TryParse(sPass, out sp);
            if(!s)
            {
                Console.WriteLine();
                Console.WriteLine("Please enter a valid number!");
                return;
            }
            if(sp <0 || sp>5   )
            {
                Console.WriteLine("Please enter a season pass displayed.");
                return;
            }


            Console.WriteLine("----Renew Season Parking Pass----");
            Console.WriteLine("Please enter no. of months you want to renew: ");
            string rpMonth = Console.ReadLine();
            int rpm;
            bool r = Int32.TryParse(rpMonth, out rpm);
            if(!r)
            {
                Console.WriteLine();
                Console.WriteLine("Please enter valid number");
                return;
            }
            if(rpm<0 || rpm >12)
            {
                Console.WriteLine("Please enter a valid month between 1 -12");
                return;
            }

            Console.WriteLine("Renewing season parking pass...");
            Console.WriteLine("Extend season parking pass for another " + rpm + " month(s)");
            

            string confirmation = Confirm("");
            if (confirmation.Equals("y"))
            {
                Console.WriteLine("You decide to renew " + rpm + " month(s) of your season parking pass");
                Console.WriteLine();
                Console.WriteLine("Calculating season pass amount...");
                //int sprice = 0;
                int amt = 0;
                Console.WriteLine("Amount needed to pay: $" + amt);
              
            }

            else
            {
                Console.WriteLine("Please enter no. of months you want to renew: ");
                string rpMonth2 = Console.ReadLine();
                int rpm2;
                bool r2 = Int32.TryParse(rpMonth2, out rpm2);
                if (!r2)
                {
                    Console.WriteLine();
                    Console.WriteLine("Please enter valid number");
                    return;
                }
                if (rpm2 < 0 || rpm2 > 12)
                {
                    Console.WriteLine("Please enter a valid month between 1 -12");
                    return;
                }

                Console.WriteLine("Renewing season parking pass...");
                Console.WriteLine("Extend season parking pass for another " + rpm2 + " month(s)");
                string confirmation2 = Confirm("");
                if (confirmation2.Equals("y"))
                {
                    Console.WriteLine("You decide to renew " + rpm2 + " month(s) of your season parking pass");
                    Console.WriteLine();
                    Console.WriteLine("Calculating season pass amount...");
                    //int sprice = 0;
                    int amt = 0;
                    Console.WriteLine("Amount needed to pay: $" + amt);

                }
            }

            //Console.WriteLine("Calculating season pass amount...");
            //Console.WriteLine();

            /*if (vsp.StartDate <= vsp.EndDate)
            {
                // # TODO print a few lines of code that says pass successfully extended and set end month of season pass according to input
                // asssginees: yongfarm
                //dont have to set state to valid as it is already at valid state
                //Console.WriteLine("Renewing season parking pass...");
                //Console.WriteLine("Month to extend season parking pass is " + month);
                

                Console.WriteLine();

                //vsp.SetCurrentState(vsp.GetValidState()); 
            }*/
            // implementation here
        }

        

        private static string Confirm(string message)
        {
            Console.WriteLine("Please enter y/n: ");
            string confirmPass = Console.ReadLine();
            if (!confirmPass.Equals("y") && !confirmPass.Equals("n"))
            {
                confirmPass = Confirm("Please enter only 'y/n' to confirm: ");
            }
            return (confirmPass);
        }

        

        public void TransferPass(Vehicle v)
        {
            // vt - vehicletype in string (Lorry, Car, Motorbike)
            // implementation of transfering pass to another vehicle
            // code below works, i accidentally did it lol. all i did was create a class called vehicle and put vehicle property under seasonpass
            //if (sp.VehicleType == vt) {
            //    sp.Vehicle = v;
            //    Console.WriteLine("Pass Transferred Successfully!");
            // if vehicle type does not match
            //    do something..
            if (vsp.VehicleType == v.VehicleType)
            {
                vsp.Vehicle = v;
                Console.WriteLine("Season Pass Transferred Successfully!");
            }
        }

        public void TerminatePass()
        {
            //implementation
        }

    }

    //terminatedstate class
    class TerminatedState : ISeasonPassState {
        private SeasonPass vsp;
        public TerminatedState(SeasonPass sp)
        {
            vsp = sp;
        }

        public void ApprovePass()
        {
            Console.WriteLine("Not allowed to Approve Season Pass that is already Terminated!");
        }

        public void Renew()
        {
            Console.WriteLine("Not allowed to Renew Season Pass that is already Terminated!");
        }

        public void TransferPass(Vehicle v)
        {
            Console.WriteLine("Not allowed to Transfer Season Pass that is already Terminated!");
        }

        public void TerminatePass()
        {
            Console.WriteLine("Not allowed to Terminate Season Pass that is already Terminated!");
        }

    }

    // expiredstate class
    class ExpiredState : ISeasonPassState {
        private SeasonPass vsp;
        public ExpiredState(SeasonPass sp)
        {
            vsp = sp;
        }
        public void ApprovePass()
        {
            Console.WriteLine("Not allowed to Approve Season Pass that has already Expired!");
        }

        public void Renew()
        {
            Console.WriteLine("Please select the season parking pass you want to renew: ");
            string sPass = Console.ReadLine();
            int sp;
            bool s = Int32.TryParse(sPass, out sp);
            if (!s)
            {
                Console.WriteLine();
                Console.WriteLine("Please enter a valid number!");
                return;
            }
            if (sp != vsp.SeasonPassID)
            {
                Console.WriteLine("Please enter a season pass displayed.");
                return;
            }


            Console.WriteLine("----Renew Season Parking Pass----");
            Console.WriteLine("Please enter no. of months you want to renew: ");
            string rpMonth = Console.ReadLine();
            int rpm;
            bool r = Int32.TryParse(rpMonth, out rpm);
            if (!r)
            {
                Console.WriteLine();
                Console.WriteLine("Please enter valid number");
                return;
            }
            if (rpm < 0 || rpm > 12)
            {
                Console.WriteLine("Please enter a valid month between 1 -12");
                return;
            }

            Console.WriteLine("Renewing season parking pass...");
            Console.WriteLine("Extend season parking pass for another " + rpm + " month(s)");


            string confirmation = Confirm("");
            if (confirmation.Equals("y"))
            {
                Console.WriteLine("You decide to renew " + rpm + " month(s) of your season parking pass");
                Console.WriteLine();
                Console.WriteLine("Calculating season pass amount...");
                //int sprice = 0;
                int amt = 0;
                Console.WriteLine("Amount needed to pay: $" + amt);

            }

            else
            {
                Console.WriteLine("Please enter no. of months you want to renew: ");
                string rpMonth2 = Console.ReadLine();
                int rpm2;
                bool r2 = Int32.TryParse(rpMonth2, out rpm2);
                if (!r2)
                {
                    Console.WriteLine();
                    Console.WriteLine("Please enter valid number");
                    return;
                }
                if (rpm2 < 0 || rpm2 > 12)
                {
                    Console.WriteLine("Please enter a valid month between 1 -12");
                    return;
                }

                Console.WriteLine("Renewing season parking pass...");
                Console.WriteLine("Extend season parking pass for another " + rpm2 + " month(s)");
                string confirmation2 = Confirm("");
                if (confirmation2.Equals("y"))
                {
                    Console.WriteLine("You decide to renew " + rpm2 + " month(s) of your season parking pass");
                    Console.WriteLine();
                    Console.WriteLine("Calculating season pass amount...");
                    //int sprice = 0;
                    int amt = 0;
                    Console.WriteLine("Amount needed to pay: $" + amt);

                }
            }
            vsp.SetCurrentState(vsp.GetValidState());
            // implementation here
        }

        private static string Confirm(string message)
        {
            Console.WriteLine("Please enter y/n: ");
            string confirmPass = Console.ReadLine();
            if (!confirmPass.Equals("y") && !confirmPass.Equals("n"))
            {
                confirmPass = Confirm("Please enter only 'y/n' to confirm: ");
            }
            return (confirmPass);
        }

        public void TransferPass(Vehicle v)
        {
            Console.WriteLine("Not allowed to Transfer Season Pass that has already Expired!");
        }

        public void TerminatePass()
        {
            Console.WriteLine("Not allowed to Terminate Season Pass that has already Expired!");
        }

    }
}
