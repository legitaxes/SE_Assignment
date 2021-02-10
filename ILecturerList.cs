using System;
using System.Collections.Generic;
using System.Text;

namespace SEAssignment
{
    public interface ILecturerList
    {
        LecturerIterator CreateIterator(string staffid);
    }
}
