using System;
using System.Collections.Generic;
using System.Text;

namespace PhysUnitLibrary
{
    class UnderMinValueException : Exception
    {
        public UnderMinValueException() { }
        public UnderMinValueException(string message) : base(message) { }
        public UnderMinValueException(string message, Exception inner) : base(message, inner) { }
    }
}
