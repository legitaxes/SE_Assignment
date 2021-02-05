using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SEAssignment
{
    public class StudentList : IStudentList
    {
        private string studentid;
        public string Studentid
        {
            get { return studentid; }
            set { studentid = value; }
        }


        public List<Student> studentCollection = new List<Student>();
        
        public int NumberOfStudents
        {
            get { return studentCollection.Count; }
        }

        public StudentIterator CreateIterator()
        {
            return new StudentIterator(this, studentid);
        }
    }
}
