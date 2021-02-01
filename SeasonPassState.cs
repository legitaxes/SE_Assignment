using System;
using System.Collections.Generic;
using System.Text;

namespace SEAssignment
{
    interface SeasonPassState
    {
        void renew();

        void transferPass(string vt, Vehicle v);

        void terminatePass();

        void enterParking();

        void exitParking();
    }

    //pendingstate class
    class PendingState : SeasonPassState {
        private SeasonPass sp;
        public PendingState(SeasonPass sp)
        {
            this.sp = sp;
        }

        public void renew() {
            // implementation
            Console.WriteLine("You are not allowed to renew when you don't have a season pass!");
        }

        public void transferPass(string vt, Vehicle v) { 
            // vt - vehicletype in string (Lorry, Car, Motorbike)
            // implementation of transfering pass to another vehicle
            // code below works, i accidentally did it lol. all i did was create a class called vehicle and put vehicle property under seasonpass
            //if (sp.VehicleType == vt) {
            //    sp.Vehicle = v;
            //    Console.WriteLine("Pass Transferred Successfully!");
            // if vehicle type does not match
            //    do something..
        }
        public void terminatePass()
        {
            // implementation here - should not allow
        }

        public void enterParking() { 
            // implementation here...?? idk
        }
        public void exitParking() {
            // implementation here...?? idk
        }
    }

    //validstate class
    class ValidState : SeasonPassState {
        private SeasonPass sp;
        public ValidState(SeasonPass sp)
        {
            this.sp = sp;
        }

        public void renew()
        {
            // implementation here
        }

        public void transferPass(string vt, Vehicle v)
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

        public void terminatePass()
        {
            // implementation here - should not allow
        }

        public void enterParking()
        {
            // implementation here...?? idk
        }
        public void exitParking()
        {
            // implementation here...?? idk
        }

    }

    //terminatedstate class
    class TerminatedState : SeasonPassState {
        private SeasonPass sp;
        public TerminatedState(SeasonPass sp)
        {
            this.sp = sp;
        }

        public void renew()
        {
            // implementation here
        }

        public void transferPass(string vt, Vehicle v)
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

        public void terminatePass()
        {
            // implementation here - should not allow
        }

        public void enterParking()
        {
            // implementation here...?? idk
        }
        public void exitParking()
        {
            // implementation here...?? idk
        }

    }

    // expiredstate class
    class ExpiredState : SeasonPassState {
        private SeasonPass sp;
        public ExpiredState(SeasonPass sp)
        {
            this.sp = sp;
        }

        public void renew()
        {
            // implementation here
        }

        public void transferPass(string vt, Vehicle v)
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

        public void terminatePass()
        {
            // implementation here - should not allow
        }

        public void enterParking()
        {
            // implementation here...?? idk
        }
        public void exitParking()
        {
            // implementation here...?? idk
        }
    }
}
