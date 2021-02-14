using System;
using System.Collections.Generic;
using System.Text;

namespace SEAssignment
{
    public interface IUserIterator
    {
        object Found();
        bool HasNext();
        void Remove();
    }
}
