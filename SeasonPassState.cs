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
            vsp.SetCurrentState(vsp.GetValidState()); //set season pass state to valid
            Console.WriteLine("Season pass with ID of {0} sucessfully approved.", vsp.SeasonPassID);
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
            int price = 0;
            bool status = true;
            while (status) //if user did not confirm
            {
                Console.WriteLine("----Renew Season Parking Pass----");
                Console.Write("Please enter no. of months you want to renew: ");
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
                if (confirmation.ToLower() == "y")
                {
                    Console.WriteLine("You decide to renew " + rpm + " month(s) of your season parking pass");
                    Console.WriteLine();
                    Console.WriteLine("Calculating season pass amount...");
                    if (vsp.VehicleType == "Car" || vsp.VehicleType == "Lorry") //if seasonpass is car type
                    {
                        price = 80;
                        int amt = price * rpm;
                        Console.WriteLine("Amount needed to pay: $" + amt);
                        Console.WriteLine("Pass successfully extended for " + rpm + " month(s)");

                        //add payment record
                        Payment p = new Payment(DateTime.Now, amt, "Credit", "Surface", vsp);
                        p.makePayment();
                        vsp.AddPayment(p);
                    }

                    else if (vsp.VehicleType == "Motorbike")
                    { //if seasonpass is motorbike type
                        price = 15;
                        int amt = price * rpm;
                        Console.WriteLine("Amount needed to pay: $" + amt);

                        Console.WriteLine("Pass successfully extended for " + rpm + " month(s)");

                        //add payment record
                        Payment p = new Payment(DateTime.Now, amt, "Credit", "Surface", vsp);
                        p.makePayment();
                        vsp.AddPayment(p);
                    }
                    //add number of months extended by user
                    vsp.EndDate.AddMonths(rpm);
                    vsp.RemainingMonth = vsp.RemainingMonth + rpm;
                    Console.WriteLine("Your Season Pass New Expiry Date: {0}", vsp.EndDate);
                    status = false;
                }
            }
        }
        private static string Confirm(string message)
        {
            Console.Write("Please enter y/n: ");
            string confirmPass = Console.ReadLine();
            confirmPass = confirmPass.ToLower();
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
            int price = 0;
            bool status = true;
            while (status) //if user did not confirm
            {
                Console.WriteLine("----Renew Season Parking Pass----");
                Console.Write("Please enter no. of months you want to renew: ");
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
                if (confirmation.ToLower() == "y")
                {
                    Console.WriteLine("You decide to renew " + rpm + " month(s) of your season parking pass");
                    Console.WriteLine();
                    Console.WriteLine("Calculating season pass amount...");
                    if (vsp.VehicleType == "Car" || vsp.VehicleType == "Lorry") //if seasonpass is car type
                    {
                        price = 80;
                        int amt = price * rpm;
                        Console.WriteLine("Amount needed to pay: $" + amt);
                        Console.WriteLine("Pass successfully extended for " + rpm + " month(s)");

                        //add payment record
                        Payment p = new Payment(DateTime.Now, amt, "Credit", "Surface", vsp);
                        p.makePayment();
                        vsp.AddPayment(p);
                    }

                    else if (vsp.VehicleType == "Motorbike")
                    { //if seasonpass is motorbike type
                        price = 15;
                        int amt = price * rpm;
                        Console.WriteLine("Amount needed to pay: $" + amt);

                        Console.WriteLine("Pass successfully extended for " + rpm + " month(s)");
                        
                        //add payment record
                        Payment p = new Payment(DateTime.Now, amt, "Credit", "Surface", vsp);
                        p.makePayment();
                        vsp.AddPayment(p);
                    }
                    //add number of months extended by user
                    //vsp.EndDate.AddMonths(rpm);
                    //vsp.RemainingMonth = vsp.RemainingMonth + rpm; //add input month to remaining month 
                    vsp.StartDate = DateTime.Now;
                    vsp.EndDate = DateTime.Now.AddMonths(rpm);
                    vsp.RemainingMonth = vsp.StartDate.Month - vsp.EndDate.Month;
                    vsp.SetCurrentState(vsp.GetValidState()); //set season pass state to valid
                    Console.WriteLine("Your Season Pass New Expiry Date: {0}", vsp.EndDate);
                    status = false;
                }
            }
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
