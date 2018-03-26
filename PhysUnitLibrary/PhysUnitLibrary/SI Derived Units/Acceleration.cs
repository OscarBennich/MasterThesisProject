using System;
using System.Collections.Generic;
using System.Text;

namespace PhysUnitLibrary.SI_Derived_Units
{
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
