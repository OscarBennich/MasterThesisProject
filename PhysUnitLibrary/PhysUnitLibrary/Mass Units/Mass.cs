using PhysUnitLibrary.Mass_Units;
using System;

namespace PhysUnitLibrary
{   
    /// <summary>
    /// One of 7 physical unit dimensions
    /// </summary>
    public abstract class Mass : PhysicalUnit
    {
        // All inheriting classes must define how they are to be converted into kilogram
        // Kilogram being the basic unit of mass 
        public abstract Kilogram Convert(); 

        public static Kilogram operator +(Mass firstMass, Mass secondMass)
        {
            double value = firstMass.Convert().Value + secondMass.Convert().Value;
            return CreateNewKilogram(value, firstMass.Convert(), secondMass.Convert());
        }

        public static Kilogram operator -(Mass firstMass, Mass secondMass)
        {
            double value = firstMass.Convert().Value - secondMass.Convert().Value;
            return CreateNewKilogram(value, firstMass.Convert(), secondMass.Convert());
        }

        public static Kilogram operator *(Mass firstMass, Mass secondMass)
        {
            double value = firstMass.Convert().Value * secondMass.Convert().Value;
            return CreateNewKilogram(value, firstMass.Convert(), secondMass.Convert());
        }

        public static Kilogram operator /(Mass firstMass, Mass secondMass)
        {
            double value = firstMass.Convert().Value / secondMass.Convert().Value;
            return CreateNewKilogram(value, firstMass.Convert(), secondMass.Convert());
        }

        public static Kilogram CreateNewKilogram(double value, Kilogram firstMass, Kilogram secondMass)
        {   
            if (firstMass.MaxValue == null && secondMass.MaxValue != null) // Takes the max & min value from the first mass
            {   
                double newMin = (double)secondMass.MinValue; 
                double newMax = (double)secondMass.MaxValue;
                return new Kilogram(value, newMin, newMax);
            }
            else if (firstMass.MaxValue != null && secondMass.MaxValue == null) // Takes the max & min value from the second mass
            {
                double newMin = (double)firstMass.MinValue; 
                double newMax = (double)firstMass.MaxValue;
                return new Kilogram(value, newMin, newMax);
            }
            else if(firstMass.MaxValue == null && secondMass.MaxValue == null) // None of the masses has a range set
            {
                return new Kilogram(value);
            }
            else // Takes the highest max value and the lowest min value from both masses 
            {
                double newMin = Math.Min((double)firstMass.MinValue, (double)secondMass.MinValue);
                double newMax = Math.Max((double)firstMass.MaxValue, (double)secondMass.MaxValue);
                return new Kilogram(value, newMin, newMax);
            }
        }
    }
}
