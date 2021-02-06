using System;
using System.Collections.Generic;
using System.Text;

namespace SEAssignment
{
    class Lecturer : User
    {
        //attributes 
        // use propfull, <tab>, <tab> to create the variables with getter and setter
        private string staffID;
        public string StaffID
        {
            get { return staffID; }
            set { staffID = value; }
        }

        //constructor
        public Lecturer(string id, string sname, string pw, string add, int mobile) : base(sname, pw, add, mobile)
        {
            StaffID = id;
        }

        // methods / actions

    }
}
