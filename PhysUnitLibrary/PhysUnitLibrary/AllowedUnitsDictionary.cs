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
        //static Dictionary<int[], PhysicalUnit> dictionary = new Dictionary<int[], PhysicalUnit> (new UnitArrayComparer())
        //{
        //    {new int[] {1,0,0}, new Metre(0)}, 
        //    {new int[] {0,1,0}, new Kilogram(0)},
        //    {new int[] {0,0,1}, new Second(0)},
        //    {new int[] {2,0,0}, new Area(0)},
        //    {new int[] {1,0,-1}, new Velocity(0)},
        //    {new int[] {1,0,-2}, new Acceleration(0)}
        //};

        static Dictionary<int[], Type> dictionary = new Dictionary<int[], Type>(new UnitArrayComparer())
        {
            {new int[] {1,0,0}, typeof(Metre) },
            {new int[] {0,1,0}, typeof(Kilogram)},
            {new int[] {0,0,1}, typeof(Second)},
            {new int[] {2,0,0}, typeof(Area)},
            {new int[] {1,0,-1}, typeof(Velocity)},
            {new int[] {1,0,-2}, typeof(Acceleration)}
        };

        public static Type GetUnit(int[] dimensionArray)
        {
            if (dictionary.TryGetValue(dimensionArray, out Type physicalUnitType))
            {
                return physicalUnitType;
            }
            else
            {
                return null;
            }
        }
    }   
}
