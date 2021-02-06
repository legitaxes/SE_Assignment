using System;
using System.Collections.Generic;
using System.Text;

namespace SEAssignment
{
    class Manager : User
    {
        //attributes 
        // use propfull, <tab>, <tab> to create the variables with getter and setter
        private string managerID;

        public string ManagerID
        {
            get { return managerID; }
            set { managerID = value; }
        }

        //constructor
        public Manager(string id, string sname, string pw, string add, int mobile) : base(sname, pw, add, mobile)
        {
            managerID = id;
        }

        // methods / actions


    }
}
