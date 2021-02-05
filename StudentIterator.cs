using System;
using System.Collections.Generic;
using System.Text;

namespace SEAssignment
{
    public class StudentIterator : IStudentIterator
    {
        private StudentList studentList;
        private int position = 0;
        private string studentID;
        public bool isfound = false;

        public StudentIterator(StudentList list, string studentID)
        {
            studentList = list;
            this.studentID = studentID;

            while (position < studentList.NumberOfStudents)
            {
                if (studentList.studentCollection[position].StudentID == studentID)
                {
                    isfound = true;
                    break;
                }

                else
                {
                    position++;
                }
            }
        }

        public bool HasNext()
        {
            if (position < studentList.NumberOfStudents || isfound == false)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public object Found()
        {
            Student student = studentList.studentCollection[position];
            return student;
        }

        public void Remove()
        {
            Console.WriteLine("Remove not supported by Student Iterator");
        }
    }
}
