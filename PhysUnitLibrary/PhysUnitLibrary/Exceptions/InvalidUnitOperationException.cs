using System;
using System.Collections.Generic;
using System.Text;

namespace PhysUnitLibrary.Exceptions
{
    public class InvalidUnitOperationException : Exception
    {
        public InvalidUnitOperationException() { }
        public InvalidUnitOperationException(string message) : base(message) { }
        public InvalidUnitOperationException(string message, Exception inner) : base(message, inner) { }
    }
}

