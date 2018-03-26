using System;
using System.Collections.Generic;
using System.Text;

namespace PhysUnitLibrary
{
    /// <summary>
    /// This exception is thrown when a unit is below the the miniumum allowed value of it's range 
    /// Often as a result of an operation involving another unit
    /// </summary>
    public class UnderMinValueException : Exception
    {
        public UnderMinValueException() { }
        public UnderMinValueException(string message) : base(message) { }
        public UnderMinValueException(string message, Exception inner) : base(message, inner) { }
    }
}
