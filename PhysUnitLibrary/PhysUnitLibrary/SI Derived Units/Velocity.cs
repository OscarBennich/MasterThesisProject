using System;
using System.Collections.Generic;
using System.Text;

namespace PhysUnitLibrary.SI_Derived_Units
{
    public class Velocity : DerivedUnit
    {
        public Velocity(double value)
        {
            Value = value;
            LengthDimension = 1;
            TimeDimension = -1;
            MassDimension = 0;
        }

        public override string ToString()
        {
            return Value + "m/s";
        }
    }
}
