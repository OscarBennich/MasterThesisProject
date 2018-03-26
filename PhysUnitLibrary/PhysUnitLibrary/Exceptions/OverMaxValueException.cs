using System;
using System.Collections.Generic;
using System.Text;

namespace PhysUnitLibrary
{   
    /// <summary>
    /// This exception is thrown when a unit exceeds the maximum allowed value of it's range 
    /// Often as a result of an operation involving another unit
    /// </summary>
    public class OverMaxValueException : Exception
    {
        public OverMaxValueException() { }
        public OverMaxValueException(string message) : base(message) { }
        public OverMaxValueException(string message, Exception inner) : base(message, inner) { }
    }
}
