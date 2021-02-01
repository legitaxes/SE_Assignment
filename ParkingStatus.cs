using System;
using System.Collections.Generic;
using System.Text;

namespace SEAssignment
{
    class ParkingStatus
    {
        private bool status = false;

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }

        //implementation of parking status
        private ParkingStatusState parkedState;
        private ParkingStatusState exitedState;

        private ParkingStatusState currentParkingState;

        // retrieve state
        public ParkingStatusState getParkedState() { return parkedState; }
        public ParkingStatusState getExitedState() { return exitedState; }
        // set state
        public void setParkingState(ParkingStatusState ps) {
            this.currentParkingState = ps;
        }

        public ParkingStatus() {
            parkedState = new ParkedState(this);
            exitedState = new ExitedState(this);

            currentParkingState = exitedState;
        }

        public void enterParking() { currentParkingState.enterParking(); }
        public void exitParking() { currentParkingState.exitParking(); }
    }
}
