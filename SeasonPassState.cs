﻿using System;
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

        void RejectPass();

    }

    //pendingstate class
    class PendingState : ISeasonPassState {
        private SeasonPass vsp;
        public PendingState(SeasonPass sp)
        {
            vsp = sp;
        }

        public void ApprovePass() {
            Console.WriteLine();
            Console.WriteLine("Are you sure you want to approve this Season Parking Pass? (y/n)");
            string confirm_approve = Console.ReadLine().ToLower();
            switch (confirm_approve)
            {
                case "y":
                    vsp.SetCurrentState(vsp.GetValidState()); //set season pass state
                    Console.WriteLine("Season pass with ID of {0} sucessfully approved.", vsp.SeasonPassID);
                    break;
                case "n":
                    Console.WriteLine();
                    Console.WriteLine("Action cancelled. Season Parking Pass remains pending.");
                        break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("Invalid input. Returning to the main menu.");
                    break;
            }
        }
        public void Renew() {
            // implementation
            Console.WriteLine("Not allowed to renew pass that is in Pending state!");
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
            //if (vsp.CurrentState.GetType() != typeof(ValidState))
            //{
                //vsp.Vehicle.LicensePlate = v.LicensePlate;
                Console.WriteLine("Not allowed to Transfer Season Pass in Pending state!");
            //}
            //Console.WriteLine("Not allowed to Transfer Season Pass in Pending state!");

        }
        public void TerminatePass()
        {
            Console.WriteLine("Not allowed to Terminate Season Pass in Pending state!");
        }

        public void RejectPass()
        {
            Console.WriteLine();
            Console.WriteLine("Are you sure you want to reject this Season Parking Pass? This will result in its termination. (y/n)");
            string confirm_approve = Console.ReadLine().ToLower();
            switch (confirm_approve)
            {
                case "y":
                    vsp.SetCurrentState(vsp.GetRejectedState()); //set season pass state
                    Console.WriteLine();
                    Console.WriteLine("Season pass with ID of {0} Rejected.", vsp.SeasonPassID);
                    break;
                case "n":
                    Console.WriteLine();
                    Console.WriteLine("Action cancelled. Season Parking Pass remains pending.");
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("Invalid input. Returning to the main menu.");
                    break;
            }
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
                if(rpm<0 || rpm >15)
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
                    vsp.EndDate = vsp.EndDate.AddMonths(rpm);
                    vsp.RemainingMonth = vsp.RemainingMonth + rpm;
                    Console.WriteLine("The remaining month of your pass is {0} month(s)", vsp.RemainingMonth);
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
            if (vsp.CurrentState.GetType() == typeof(ValidState))
            {
                Console.WriteLine("");
                Console.Write("Please enter new license plate: ");
                string license = Console.ReadLine();
                if (license.Length == 7)
                {
                    Console.Write("Please enter vehicle type: ");
                    string lvt = Console.ReadLine();
                    if (vsp.VehicleType == lvt)
                    {
                        Console.Write("Please enter the exact IUNumber: ");
                        string liun = Console.ReadLine();
                        if (liun == vsp.IUNumber)
                        {
                            v.LicensePlate = license;
                            Console.WriteLine("Season Pass Transferred Successfully!");
                        }
                        else
                        {
                            Console.WriteLine("IUNumber Do Not Match!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Vehicle Type Do Not Match!");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid license plate!");
                } 
            }
        }

        public void TerminatePass()
        {
            double price;
            double refunded;
            if (vsp.VehicleType == "Car" || vsp.VehicleType == "Lorry")
            {
                price = 80;
            }
            else
            {
                price = 15;
            }

            refunded = price * vsp.RemainingMonth;
            Console.WriteLine("Total amount of $" + refunded + " is refunded back to you.");
            Console.WriteLine("Your Season Parking Pass has been terminated. Thank you and have a nice day.");
            //User's account will be set to terminated.
            vsp.SetCurrentState(vsp.GetTerminatedState());
            Console.WriteLine("Season pass has been terminated.");
        }

        public void RejectPass()
        {
            Console.WriteLine("Not allowed to reject a pass that was already approved!");
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
            //if (vsp.CurrentState.GetType() != typeof(ValidState))
           // {
                //vsp.Vehicle = v;
                Console.WriteLine("Not allowed to Transfer Season Pass that is already Terminated!");
            //}
        }

        public void TerminatePass()
        {


            Console.WriteLine("Not allowed to Terminate Season Pass that is already Terminated!");
        }

        public void RejectPass()
        {
            Console.WriteLine("Not allowed to reject a pass that has been terminated!");
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
                if (rpm < 0 || rpm > 15)
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
                    vsp.RemainingMonth = vsp.EndDate.Month - vsp.StartDate.Month;
                    vsp.SetCurrentState(vsp.GetValidState()); //set season pass state to valid
                    Console.WriteLine("The remianing month of your pass is {0} month(s)", vsp.RemainingMonth);
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
            //if (vsp.CurrentState.GetType() != typeof(ValidState))
            //{
               // vsp.Vehicle.LicensePlate = v.LicensePlate; 
                Console.WriteLine("Not allowed to Transfer Season Pass that has already Expired!");
            //}
        }

        public void TerminatePass()
        {
            Console.WriteLine("Not allowed to Terminate Season Pass that has already Expired!");
        }

        public void RejectPass()
        {
            Console.WriteLine("Not allowed to reject a pass that has been terminated!");
        }
    }

    // expiredstate class
    class RejectedState : ISeasonPassState
    {
        private SeasonPass vsp;
        public RejectedState(SeasonPass sp)
        {
            vsp = sp;
        }

        public void ApprovePass()
        {
            Console.WriteLine("You can't approve a Season Parking Pass that has been rejected!");
        }

        public void Renew()
        {
            Console.WriteLine("You can't renew a Season Parking Pass that has been rejected!");
        }

        public void TransferPass(Vehicle v)
        {
            //if (vsp.CurrentState.GetType() != typeof(ValidState))
            //{
            // vsp.Vehicle.LicensePlate = v.LicensePlate; 
            Console.WriteLine("Not allowed to Transfer Season Pass that has already Expired!");
            //}
        }

        public void TerminatePass()
        {
            Console.WriteLine("Not allowed to Terminate Season Pass that has already Expired!");
        }

        public void RejectPass()
        {
            Console.WriteLine("Not allowed to reject a pass that has already been rejected!");
        }
    }


}

