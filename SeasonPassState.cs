using System;
using System.Collections.Generic;
using System.Text;

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
            
            int monthNo = DateTime.Now.Month; //not sure how to get the number of months fromm input
            Console.WriteLine("Renewing season parking pass...");
            Console.WriteLine("Month to extend season parking pass is " + monthNo);

            string confirmation = Confirm("");
            if(confirmation.Equals("Y"))
            {
                Console.WriteLine("Pass successfully renewed for another " + monthNo);
                
            }

            else
            {
                Renew();
            }
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
            Console.WriteLine("Please enter ");
            string confirmPass = Console.ReadLine();
            if (!confirmPass.Equals("Y") && !confirmPass.Equals("N"))
            {
                confirmPass = Confirm("Please enter only 'Y/N' to confirm: ");
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
            vsp.SetCurrentState(vsp.GetValidState());
            // implementation here
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
