using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SEAssignment
{
    public class LecturerList : ILecturerList
    {
        private string staffid;

        public string StaffID
        {
            get { return staffid; }
            set { staffid = value; }
        }

        private List<Lecturer> lecturerCollection;

        public List<Lecturer> LecturerCollection
        {
            get { return lecturerCollection; }
            set { lecturerCollection = value; }
        }

        public int NumberOfLecturers
        {
            get { return lecturerCollection.Count; }
        }

        public LecturerList()
        {
            lecturerCollection = new List<Lecturer>();
        }

        public LecturerIterator CreateIterator(string staffid)
        {
            return new LecturerIterator(this, staffid);
        }
    }
}
