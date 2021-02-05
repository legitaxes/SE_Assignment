using System;
using System.Collections.Generic;
using System.Text;

namespace SEAssignment
{
    public interface ISeasonPassState
    {
        void Renew();

        void TransferPass(Vehicle v);

        void TerminatePass();

    }

    //pendingstate class
    class PendingState : ISeasonPassState {
        private SeasonPass sp;
        public PendingState(SeasonPass sp)
        {
            this.sp = sp;
        }

        public void Renew() {
            // implementation
            Console.WriteLine("You are not allowed to renew when you don't have a season pass!");
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
            // implementation here - should not allow
        }

    }

    //validstate class
    class ValidState : ISeasonPassState {
        private SeasonPass sp;
        public ValidState(SeasonPass sp)
        {
            this.sp = sp;
        }

        public void Renew()
        {
            if(sp.StartDate <= sp.EndDate)
            {
                sp.SetCurrentState(sp.GetValidState());
            }
            // implementation here
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
            // implementation here - should not allow
        }

    }

    //terminatedstate class
    class TerminatedState : ISeasonPassState {
        private SeasonPass sp;
        public TerminatedState(SeasonPass sp)
        {
            this.sp = sp;
        }

        public void Renew()
        {
            // implementation here
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
            // implementation here - should not allow
        }

    }

    // expiredstate class
    class ExpiredState : ISeasonPassState {
        private SeasonPass sp;
        public ExpiredState(SeasonPass sp)
        {
            this.sp = sp;
        }

        public void Renew()
        {
            sp.SetCurrentState(sp.GetValidState());
            // implementation here
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
            // implementation here - should not allow
        }

    }
}
