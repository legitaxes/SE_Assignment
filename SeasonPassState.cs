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
        private SeasonPass vsp;
        public PendingState(SeasonPass sp)
        {
            vsp = sp;
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
        private SeasonPass vsp;
        public ValidState(SeasonPass sp)
        {
            vsp = sp;
        }

        public void Renew()
        {
            if(vsp.StartDate <= vsp.EndDate)
            {
                // # TODO print a few lines of code that says pass successfully extended and set end month of season pass according to input
                // asssginees: yongfarm
                //dont have to set state to valid as it is already at valid state
                vsp.SetCurrentState(vsp.GetValidState()); 
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
        private SeasonPass vsp;
        public TerminatedState(SeasonPass sp)
        {
            vsp = sp;
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
        private SeasonPass vsp;
        public ExpiredState(SeasonPass sp)
        {
            vsp = sp;
        }

        public void Renew()
        {
            vsp.SetCurrentState(vsp.GetValidState());
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
