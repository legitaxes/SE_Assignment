using System;
using System.Collections.Generic;
using System.Text;

namespace SEAssignment
{
    public class Student : User
    {
        //attributes 
        // use propfull, <tab>, <tab> to create the variables with getter and setter
        private string studentID;

        //---getter setter for properties---
        public string StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }

        //constructor
        public Student(string id, string sname, string pw, string add, int mobile) : base (sname, pw, add, mobile)
        {
            StudentID = id;
        }

        //public void viewSeasonPass()
        //{
        //    // implementation for viewing season parking pass

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

        //public override string ToString()
        //{
        //    return base.ToString();
        //}

        //public override void ApplyPass(int userID)
        //{
        //    base.ApplyPass(userID);
        //}
    }
}