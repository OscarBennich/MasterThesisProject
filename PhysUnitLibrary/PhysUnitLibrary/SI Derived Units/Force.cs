using System;
using System.Collections.Generic;
using System.Text;

namespace PhysUnitLibrary.SI_Derived_Units
{
    public class Force : DerivedUnits
    {
        public Force(double value)
        {
            Value = value;
            LengthDimension = 1;
            TimeDimension = -2;
            MassDimension = 1;
        }
    }
}
