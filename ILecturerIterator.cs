using System;
using System.Collections.Generic;
using System.Text;

namespace SEAssignment
{
    public interface ILecturerIterator
    {
        object Found();
        bool HasNext();
        void Remove();
    }
}
