using System;
using System.Collections.Generic;
using System.Text;

namespace PhysUnitLibrary
{
    public class OverMaxValueException : Exception
    {
        public OverMaxValueException() { }
        public OverMaxValueException(string message) : base(message) { }
        public OverMaxValueException(string message, Exception inner) : base(message, inner) { }
    }
}
