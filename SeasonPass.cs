using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SEAssignment
{
    public class SeasonPass
    {
        //---properties---
        private int seasonPassID;
        private string vehicleType;
        private string iuNumber;
        private DateTime startDate;
        private DateTime endDate;
        private int remainingMonth; //calculated and implied from start and end date | check constructor
        private Vehicle vehicle; // one to one association with Vehicle class
        private List<Payment> payment;

        //states properties implementation - season parking pass
        private ISeasonPassState pendingState; // not used for apply season pass because it is not implemented
        private ISeasonPassState validState;
        private ISeasonPassState terminatedState;
        private ISeasonPassState expiredState;
        private ISeasonPassState rejectedState;

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

        public string IUNumber
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

        public int RemainingMonth {
            get { return remainingMonth; }
            set { remainingMonth = value; }
        }

        // one to one association with vehicle
        public Vehicle Vehicle {
            get { return vehicle; }
            set {
                if (vehicle != value) {
                    vehicle = value;
                    value.VehicleSeasonPass = this;
                }
            }
        }

        public List<Payment> Payment
        {
            get { return payment; }
        }

        public SeasonPass() { }
        //constructor for seasonpass
        public SeasonPass(int id, string vt, string iun, DateTime sd, DateTime ed, Vehicle v, string validity)
        {
            // season pass states goes here
            pendingState = new PendingState(this);
            validState = new ValidState(this);
            terminatedState = new TerminatedState(this);
            expiredState = new ExpiredState(this);
            rejectedState = new RejectedState(this);

            // added the ability to force seasonpass at the correct state upon creation
            if (validity == "pending") { currentState = pendingState; }
            else if (validity == "valid") { currentState = validState; }
            else if (validity == "terminated") { currentState = terminatedState; }
            else if (validity == "expired") { currentState = expiredState; }
            else if (validity == "rejected") { currentState = rejectedState;  }

            //rest of the property define below for seasonpass
            seasonPassID = id;
            vehicleType = vt;
            iuNumber = iun;
            startDate = sd;
            endDate = ed;
            vehicle = v;
            if (DateTime.Now >= startDate)
            {
                remainingMonth = ((endDate.Year - DateTime.Now.Year ) * 12)  + endDate.Month - DateTime.Now.Month;
            }

            else
            {
                remainingMonth = ((endDate.Year - startDate.Year ) * 12 ) +  endDate.Month - startDate.Month;
            }
            //Check for negatives and sets it it 0, and state to expired
            if (remainingMonth <= 0)
            {
                remainingMonth = 0;
                currentState = expiredState;
            }
            v.VehicleSeasonPass = this;

            payment = new List<Payment>(); // a list of payment

        }

        public ISeasonPassState CurrentState
        {
            get { return currentState; }
            set { currentState = value; }
        }

        // !!! functions to be called to run the function in the specific state !!!
        //retrieve states
        public ISeasonPassState GetPendingState() { return pendingState; }
        public ISeasonPassState GetValidState() { return validState; }
        public ISeasonPassState GetTerminatedState() { return terminatedState; }
        public ISeasonPassState GetExpiredState() { return expiredState; }

        public ISeasonPassState GetRejectedState() { return rejectedState; }

        // sets the state
        public void SetCurrentState(ISeasonPassState currentState)
        {
            this.currentState = currentState;
        }

        // Functions in SeasonPassstate.cs
        public void ApprovePass() { currentState.ApprovePass(); }
        public void Renew() {currentState.Renew(); }
        public void TransferPass(Vehicle v) { currentState.TransferPass(v); }
        public void TerminatePass() { currentState.TerminatePass(); }
        public void RejectPass() { currentState.RejectPass(); }

        public void AddPayment(Payment p) { 
            if (!payment.Contains(p))
            {
                payment.Add(p);
                p.SeasonPass = this;
            }
        }
    }
}
