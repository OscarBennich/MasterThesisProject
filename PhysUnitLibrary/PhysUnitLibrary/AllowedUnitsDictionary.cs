using PhysUnitLibrary.Length_Units;
using PhysUnitLibrary.Time_Units;
using PhysUnitLibrary.Mass_Units;
using System;
using System.Collections.Generic;
using System.Text;
using PhysUnitLibrary.SI_Derived_Units;

namespace PhysUnitLibrary
{
    public static class AllowedUnitsDictionary
    {
        // In the form of [L, M, T] 
        // Each value representing the value of that dimension
        static Dictionary<int[], PhysicalUnit> dictionary = new Dictionary<int[], PhysicalUnit> (new UnitArrayComparer())
        {
            {new int[] {1,0,0}, new Metre(0)}, 
            {new int[] {0,1,0}, new Kilogram(0)},
            {new int[] {0,0,1}, new Second(0)},
            {new int[] {0,2,0}, new Area(0)}
        };

        public static PhysicalUnit GetUnit(int[] dimensionArray)
        {
            if (dictionary.TryGetValue(dimensionArray, out PhysicalUnit physicalUnitResult))
            {
                return physicalUnitResult;
            }
            else
            {
                return null;
            }
        }
    }   
}
