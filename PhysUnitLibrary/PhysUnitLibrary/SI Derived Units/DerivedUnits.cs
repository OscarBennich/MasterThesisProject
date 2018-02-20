using PhysUnitLibrary.Length_Units;
using PhysUnitLibrary.Time_Units;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhysUnitLibrary.SI_Derived_Units
{   
    /// <summary>
    /// Units derived from the 7 base SI units
    /// </summary>
    public abstract class DerivedUnits 
    {
        //early version, length in meters, time in seconds ONLY, should be for all kinds of lengths and all kinds of times
        //public static Velocity operator /(Metre metre, Second second) 
        //{
        //    return new Velocity(metre.Value / second.Value);
        //}
    }
}
