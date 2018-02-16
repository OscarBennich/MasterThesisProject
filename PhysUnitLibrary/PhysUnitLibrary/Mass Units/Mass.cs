using PhysUnitLibrary.Mass_Units;
using System;

namespace PhysUnitLibrary
{
    public abstract class Mass 
    {
        // All inheriting classes must define how they are to be converted into kilogram
        // Kilogram being the basic unit of mass 
        public abstract Kilogram Convert(); 

        public static Kilogram operator +(Mass firstMass, Mass secondMass)
        {
            return new Kilogram((firstMass.Convert().Value) + secondMass.Convert().Value); 
        }

        public static Kilogram operator -(Mass firstMass, Mass secondMass)
        {
            return new Kilogram((firstMass.Convert().Value) - secondMass.Convert().Value);
        }

        public static Kilogram operator *(Mass firstMass, Mass secondMass)
        {
            return new Kilogram((firstMass.Convert().Value) * secondMass.Convert().Value);
        }

        public static Kilogram operator /(Mass firstMass, Mass secondMass)
        {
            return new Kilogram((firstMass.Convert().Value) / secondMass.Convert().Value);
        }
    }
}
