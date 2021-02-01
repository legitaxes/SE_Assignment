using System;
using System.Collections.Generic;
using System.Text;

namespace SEAssignment
{
    class SeasonPass
    {
        private int seasonPassID;
        private string vehicleType;
        private DateTime startDate;
        private DateTime endDate;
        private Vehicle vehicle;

        //states implementation - season parking pass
        private SeasonPassState pendingState;
        private SeasonPassState validState;
        private SeasonPassState terminatedState;
        private SeasonPassState expiredState;

        private SeasonPassState currentState;

        //properties
        public int SeasonPassID
        {
            get { return seasonPassID; }
            set { seasonPassID = value; }
        }

        public string VehicleType
        {
            get { return vehicleType; }
            set { vehicleType = value; }
        }

        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        public DateTime EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }

        public Vehicle Vehicle {
            get { return vehicle; }
            set { vehicle = value; }

        }

        //retrieve states
        public SeasonPassState getPendingState() { return pendingState; }
        public SeasonPassState getValidState() { return validState; }
        public SeasonPassState getTerminatedState() { return terminatedState; }
        public SeasonPassState getExpiredState() { return expiredState; }
        //sets the state
        public void setCurrentState(SeasonPassState currentState) { 
            this.currentState = currentState;
        }

        //constructor for seasonpass
        public SeasonPass() {
            pendingState = new PendingState(this);
            validState = new ValidState(this);
            terminatedState = new TerminatedState(this);
            expiredState = new ExpiredState(this);

            currentState = validState;

        }

        public void renew() { currentState.renew(); }
        public void transferPass(string vt, Vehicle v) { currentState.transferPass(vt, v); }
        public void terminatePass() { currentState.terminatePass(); }
        public void enterParking() { currentState.enterParking(); }
        public void exitParking() { currentState.exitParking(); }
    }
}
