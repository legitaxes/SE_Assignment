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


    }
}