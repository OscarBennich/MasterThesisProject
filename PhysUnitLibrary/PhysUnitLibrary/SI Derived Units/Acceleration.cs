using System;
using System.Collections.Generic;
using System.Text;

namespace PhysUnitLibrary.SI_Derived_Units
{   
    /// <summary>
    /// Acceleration (m/s2) - Dervied from length and time
    /// </summary>
    public class Acceleration : DerivedUnit
    {   
        public Acceleration(double value)
        {
            Value = value;
            LengthDimension = 1;
            TimeDimension = -2;
            MassDimension = 0;
        }

        public override string ToString()
        {
            return Value + "m/s2";
        }
    }
}
