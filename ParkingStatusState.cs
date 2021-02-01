using System;
using System.Collections.Generic;
using System.Text;

namespace SEAssignment
{
    interface ParkingStatusState
    {
        void enterParking();
        void exitParking();
    }

    //parkedstate class
    class ParkedState : ParkingStatusState {
        private ParkingStatus ps;
        public ParkedState(ParkingStatus ps) { this.ps = ps; }
        public void enterParking()
        {
            ps.Status = true;
            ps.setParkingState(ps.getParkedState());
        }
        public void exitParking()
        {
            ps.Status = false;
            ps.setParkingState(ps.getExitedState());
        }
    }

    // exitedstate class
    class ExitedState : ParkingStatusState {
        private ParkingStatus ps;
        public ExitedState(ParkingStatus ps) { this.ps = ps; }
        public void enterParking()
        {
            ps.Status = true;
            ps.setParkingState(ps.getParkedState());
        }
        public void exitParking()
        {
            ps.Status = false;
            ps.setParkingState(ps.getExitedState());
        }
    }
}
