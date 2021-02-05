using System;
using System.Collections.Generic;
using System.Text;

namespace SEAssignment
{
    public interface IStudentList
    {
        StudentIterator CreateIterator();
    }
}
