using System;
using System.Collections.Generic;
using System.Text;

namespace PhysUnitLibrary.SI_Derived_Units
{
    public class Velocity : DerivedUnits
    {
        public double Value { get; private set; }

        public Velocity(double value)
        {
            Value = value;
        }
    }
}
