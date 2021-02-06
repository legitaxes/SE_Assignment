﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SEAssignment
{
    public class SeasonPass
    {
        //---properties---
        private int seasonPassID;
        private string vehicleType;
        private int iuNumber;
        private DateTime startDate;
        private DateTime endDate;
        private Vehicle vehicle; // one to one association with Vehicle class

        //states properties implementation - season parking pass
        private ISeasonPassState pendingState; // not used for apply season pass because it is not implemented
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

        public int IUNumber
        {
            get { return iuNumber; }
            set { iuNumber = value; }
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

        //constructor for seasonpass
        public SeasonPass(int id, string vt, int iun, DateTime sd, DateTime ed, Vehicle v)
        {
            // season pass states goes here
            pendingState = new PendingState(this);
            validState = new ValidState(this);
            terminatedState = new TerminatedState(this);
            expiredState = new ExpiredState(this);

            currentState = validState;

            //rest of the property define below for seasonpass
            seasonPassID = id;
            vehicleType = vt;
            iuNumber = iun;
            startDate = sd;
            endDate = ed;
            vehicle = v;
        }

        // !!! functions to be called to run the function in the specific state !!!
        //retrieve states
        public ISeasonPassState GetPendingState() { return pendingState; }
        public ISeasonPassState GetValidState() { return validState; }
        public ISeasonPassState GetTerminatedState() { return terminatedState; }
        public ISeasonPassState GetExpiredState() { return expiredState; }

        // sets the state
        public void SetCurrentState(ISeasonPassState currentState)
        {
            this.currentState = currentState;
        }

        // Functions in SeasonPassstate.cs
        public void ApprovePass() { currentState.ApprovePass(); }
        public void Renew() { currentState.Renew(); }
        public void TransferPass(Vehicle v) { currentState.TransferPass(v); }
        public void TerminatePass() { currentState.TerminatePass(); }
    }
}
