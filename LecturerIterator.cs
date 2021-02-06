using System;
using System.Collections.Generic;
using System.Text;

namespace SEAssignment
{
    public class LecturerIterator : ILecturerIterator
    {
        private LecturerList lecturerList;
        private int position = 0;
        private string staffID;
        public bool isfound = false;

        public LecturerIterator(LecturerList list, string staffID)
        {
            lecturerList = list;
            this.staffID = staffID;

            while (position < lecturerList.NumberOfLecturers)
            {
                if (lecturerList.LecturerCollection[position].StaffID == staffID)
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
            if (position < lecturerList.NumberOfLecturers || isfound == false)
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
            Lecturer lecturer = lecturerList.LecturerCollection[position];
            return lecturer;
        }

        public void Remove()
        {
            Console.WriteLine("Remove not supported by Lecturer Iterator");
        }
    }
}
