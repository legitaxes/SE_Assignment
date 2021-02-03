using System;
using System.Collections.Generic;
using System.Text;

namespace SEAssignment
{
    interface ISeasonPassState
    {
        void Renew();

        void TransferPass(string vt, Vehicle v);

        void TerminatePass();

        void EnterParking();

        void ExitParking();
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

        public void TransferPass(string vt, Vehicle v) { 
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

        public void EnterParking() { 
            // implementation here...?? idk
        }
        public void ExitParking() {
            // implementation here...?? idk
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
            // implementation here
        }

        public void TransferPass(string vt, Vehicle v)
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

        public void EnterParking()
        {
            // implementation here...?? idk
        }
        public void ExitParking()
        {
            // implementation here...?? idk
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

        public void TransferPass(string vt, Vehicle v)
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

        public void EnterParking()
        {
            // implementation here...?? idk
        }
        public void ExitParking()
        {
            // implementation here...?? idk
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
            // implementation here
        }

        public void TransferPass(string vt, Vehicle v)
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

        public void EnterParking()
        {
            // implementation here...?? idk
        }
        public void ExitParking()
        {
            // implementation here...?? idk
        }
    }
}
