using System;
using System.Collections.Generic;
using System.Text;

namespace PhysUnitLibrary.Exceptions
{   
    /// <summary>
    /// This exception is thrown when trying to perform an invalid operation between two incompatible units
    /// </summary>
    public class InvalidUnitOperationException : Exception
    {
        public InvalidUnitOperationException() { }
        public InvalidUnitOperationException(string message) : base(message) { }
        public InvalidUnitOperationException(string message, Exception inner) : base(message, inner) { }
    }
}

