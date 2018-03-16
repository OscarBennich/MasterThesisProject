using System;
using System.Collections.Generic;
using System.Text;

namespace PhysUnitLibrary.SI_Derived_Units
{
    public class Area : DerivedUnits 
    {
        public Area(double value)
        {
            Value = value;
            LengthDimension = 2;
            TimeDimension = 0;
            MassDimension = 0;
        }

        public Area(double value, double minValue, double maxValue)
        {
            Value = value;
            LengthDimension = 2;
            TimeDimension = 0;
            MassDimension = 0;
            MinValue = minValue;
            MaxValue = maxValue;
        }
    }
}
