using System;
using System.Collections.Generic;
using System.Text;

namespace SEAssignment
{
    class Vehicle
    {
        private int vehicleID;
        private string licensePlate;
        private string vehicleType;
        private List<string> offences;

        public int VehicleID
        {
            get { return vehicleID; }
            set { vehicleID = value; }
        }

        public string LicensePlate
        {
            get { return licensePlate; }
            set { licensePlate = value; }
        }

        public string VehicleType
        {
            get { return vehicleType; }
            set { vehicleType = value; }
        }

        public List<string> Offences
        {
            get { return offences; }
            set { offences = value; }
        }


    }
}
