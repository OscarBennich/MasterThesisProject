using PhysUnitLibrary.Length_Units;
using PhysUnitLibrary.SI_Derived_Units;
using PhysUnitLibrary.Time_Units;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhysUnitLibrary
{
    public abstract class PhysicalUnit
    {
        public double Value;

        //early version, length in meters, time in seconds ONLY, should be for all kinds of lengths and all kinds of times
        public static Velocity operator /(PhysicalUnit unit1, PhysicalUnit unit2)
        {   
            if(unit1.GetType() == typeof(Metre) && unit2.GetType() == typeof(Second))
            {
                return new Velocity(unit1.Value / unit2.Value);
            }
            else
            {
                return null;
            }
        }
    }
}
