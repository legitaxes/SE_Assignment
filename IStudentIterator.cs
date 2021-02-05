using System;
using System.Collections.Generic;
using System.Text;

namespace SEAssignment
{
    public interface IStudentIterator
    {
        object Found();
        bool HasNext();
        void Remove();
    }
}
