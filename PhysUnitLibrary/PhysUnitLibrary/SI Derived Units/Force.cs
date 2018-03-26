using System;
using System.Collections.Generic;
using System.Text;

namespace PhysUnitLibrary.SI_Derived_Units
{
    /// <summary>
    /// Force (N) - Derived from mass and acceleration
    /// </summary>
    public class Force : DerivedUnit
    {
        public Force(double value)
        {
            Value = value;
            LengthDimension = 1;
            TimeDimension = -2;
            MassDimension = 1;
        }

        public override string ToString()
        {
            return Value + "N";
        }
    }
}
