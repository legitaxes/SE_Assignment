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
        //public void viewSeasonPass() { 
        //    // implementation for view season parking pass
        //}

        //public void renewSeasonPass()
        //{
        //    // implementation for renew season parking pass

        //}

        //public void terminateSeasonPass()
        //{
        //    // implementation for terminate season parking pass

        //}

        //public void transferSeasonPass()
        //{
        //    // implementation for transfer season parking pass

        //}

    }
}
