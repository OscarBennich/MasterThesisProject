using PhysUnitLibrary.Length_Units;
using PhysUnitLibrary.SI_Derived_Units;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhysUnitLibrary.Time_Units
{
    /// <summary>
    /// One of 7 physical unit dimensions
    /// </summary>
    public abstract class Time
    {
        public abstract Second Convert();

        public static Velocity operator /(Metre metre, Time time)
        {
            return new Velocity(metre.Value / time.Convert().Value);
        }
    }
}
