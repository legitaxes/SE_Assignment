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

        private List<Student> studentCollection;
        public List<Student> StudentCollection { 
            get { return studentCollection; }
            set { studentCollection = value; }
        }

        public int NumberOfStudents
        {
            get { return studentCollection.Count; }
        }

        public StudentList()
        {
            studentCollection = new List<Student>();
        }
        public StudentIterator CreateIterator()
        {
            return new StudentIterator(this, studentid);
        }


    }
}
