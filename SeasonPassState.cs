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
            vsp.SetCurrentState(vsp.GetValidState()); //set season pass state
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
                    vsp.EndDate.AddMonths(rpm);
                    vsp.RemainingMonth = vsp.RemainingMonth + rpm;
                    Console.WriteLine("The remianing month of your pass is {0} month(s)", vsp.RemainingMonth);
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
                if (vsp.CurrentState.GetType() == typeof(ValidState))
                {
                    vsp.Vehicle = v;
                    vsp.Vehicle.LicensePlate = v.LicensePlate;
                    Console.WriteLine("Season Pass Transferred Successfully!");
                }
                
            }
        }

        public void TerminatePass()
        {
            //implementation of Terminate Pass
            int price = 0;
            bool status = true;
            while (status) {
                Console.WriteLine("----Terminate Season Parking Pass----");
                Console.Write("Would you like to terminate your Season Parking Pass? y/n"); //Confirmation of Termination.
                string termPass = Console.ReadLine();
                termPass = termPass.ToLower();

                if (termPass.Equals("y")){
                   Console.WriteLine("Please enter your license plate number."); //System prompt for user to input license plate number.
                   string vehicleNo = Console.ReadLine();
                   vehicleNo = vehicleNo.ToUpper();
                   if (vsp.Vehicle.LicensePlate == vehicleNo){
                       Console.WriteLine("Please enter reason for termination."); //System prompt for user to input reason.
                       string termReason = Console.ReadLine();
                       if (termReason == null) {

                           Console.WriteLine("You cannot terminate pass without a reason."); //Validation to make sure user has entered a reason to terminate season parking pass.
                           return;

                       }
                       else
                       {
                           Console.WriteLine("Are you sure you want to Terminate your Season Parking Pass? y/n"); //2nd Confirmation of Termination.
                           string termConfirm = Console.ReadLine();
                           termPass = termPass.ToLower();
                           if (termConfirm.Equals("y")){
                               if (vsp.VehicleType == "Car" || vsp.VehicleType == "Lorry") { //System calculates and refunds months not used based on Vehicle Type.
                                   price = 80;
                                   int refunded = price * vsp.RemainingMonth;
                                   Console.WriteLine("Total amount of " + refunded + "is refunded back to you.");
                                   Console.WriteLine("Your Season Parking Pass has been terminated. Thank you and have a nice day.");
                                   vsp.SetCurrentState (vsp.GetTerminatedState()); //User's account will be set to terminated. 
                               }
                               else if (vsp.VehicleType == "Motorbike") { //System calculates and refunds months not used based on Vehicle Type.
                                   price = 15;
                                   int refunded = price * vsp.RemainingMonth;
                                   Console.WriteLine("Total amount of " + refunded + "is refunded back to you.");
                                   Console.WriteLine("Your Season Parking Pass has been terminated. Thank you and have a nice day.");
                                   vsp.SetCurrentState (vsp.GetTerminatedState()); //User's account will be set to terminated.
                               }
                           }
                       }
                   }
                   else 
                   {
                       Console.WriteLine("Vehicle is not found, please check that you have entered the correct license plate number."); //If license plate number is not found the system will prompt user to re-enter.
                       return;
                   }

                }
                if (!termPass.Equals("y") && !termPass.Equals("n")) //Validation to make sure user has entered either y/n.
                {
                    Console.WriteLine();
                    Console.WriteLine("Please enter y/n.");
                    return;
                }
            }

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

    }
}
