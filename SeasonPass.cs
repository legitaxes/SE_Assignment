using System;
using System.Collections.Generic;
using System.Text;

namespace SEAssignment
{
    class SeasonPass
    {
        //---properties---
        private int seasonPassID;
        private string vehicleType;
        private DateTime startDate;
        private DateTime endDate;
        private Vehicle vehicle; // one to one association with Vehicle class

        //states properties implementation - season parking pass
        private ISeasonPassState pendingState;
        private ISeasonPassState validState;
        private ISeasonPassState terminatedState;
        private ISeasonPassState expiredState;

        private ISeasonPassState currentState;

        //---getter setter of properties---
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

        // one to one association with vehicle
        public Vehicle Vehicle {
            set {
                if (vehicle != value) {
                    vehicle = value;
                    value.VehicleSeasonPass = this;
                }
            }
        }

        //retrieve states
        public ISeasonPassState GetPendingState() { return pendingState; }
        public ISeasonPassState GetValidState() { return validState; }
        public ISeasonPassState GetTerminatedState() { return terminatedState; }
        public ISeasonPassState GetExpiredState() { return expiredState; }
        
        //sets the state
        public void SetCurrentState(ISeasonPassState currentState) { 
            this.currentState = currentState;
        }

        //constructor for seasonpass
        public SeasonPass() {
            // season pass states goes here
            pendingState = new PendingState(this);
            validState = new ValidState(this);
            terminatedState = new TerminatedState(this);
            expiredState = new ExpiredState(this);

            currentState = validState;

            //rest of the property define below for seasonpass

        }

        // !!! functions to be called to run the function in the specific state !!!
        public void Renew() { currentState.Renew(); }
        public void TransferPass(string vt, Vehicle v) { currentState.TransferPass(vt, v); }
        public void TerminatePass() { currentState.TerminatePass(); }
        //public void EnterParking() { currentState.EnterParking(); }
        //public void ExitParking() { currentState.ExitParking(); }
    }
}
