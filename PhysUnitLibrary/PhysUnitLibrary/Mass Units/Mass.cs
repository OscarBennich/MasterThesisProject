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

        public abstract double GetConversionFactor();

        public static Kilogram operator +(Mass firstMass, Mass secondMass)
        {
            double value = firstMass.Value + secondMass.Value;
            return CreateNewMassObject(value, firstMass, secondMass);
        }

        public static Kilogram operator -(Mass firstMass, Mass secondMass)
        {
            double value = firstMass.Value + secondMass.Value;
            return CreateNewMassObject(value, firstMass, secondMass);
        }

        public static Kilogram operator +(Mass mass, double operationValue)
        {
            double newValue = mass.Value + operationValue;

            if(mass.MaxValue != null)
            {
                return new Kilogram(newValue, (double)mass.MinValue, (double)mass.MaxValue);
            }
            else
            {
                return new Kilogram(newValue);
            }        
        }

        public static Kilogram operator -(Mass mass, double operationValue)
        {
            double newValue = mass.Value + operationValue;

            if (mass.MaxValue != null)
            {
                return new Kilogram(newValue, (double)mass.MinValue, (double)mass.MaxValue);
            }
            else
            {
                return new Kilogram(newValue);
            }
        }

        public static Kilogram operator *(Mass mass, double operationValue)
        {
            double newValue = mass.Value * operationValue;

            if (mass.MaxValue != null)
            {
                return new Kilogram(newValue, (double)mass.MinValue, (double)mass.MaxValue);
            }
            else
            {
                return new Kilogram(newValue);
            }
        }

        public static Kilogram operator /(Mass mass, double operationValue)
        {
            double newValue = mass.Value / operationValue;

            if (mass.MaxValue != null)
            {
                return new Kilogram(newValue, (double)mass.MinValue, (double)mass.MaxValue);
            }
            else
            {
                return new Kilogram(newValue);
            }
        }    

        public static Kilogram CreateNewMassObject(double newValue, Mass firstMass, Mass secondMass)
        {

            if (firstMass.MaxValue == null && secondMass.MaxValue != null) // Takes the max & min value from the first mass
            {
                double newMin = (double)secondMass.MinValue;
                double newMax = (double)secondMass.MaxValue;
                return new Kilogram(newValue, newMin, newMax);
            }
            else if (firstMass.MaxValue != null && secondMass.MaxValue == null) // Takes the max & min value from the second mass
            {
                double newMin = (double)firstMass.MinValue;
                double newMax = (double)firstMass.MaxValue;
                return new Kilogram(newValue, newMin, newMax);
            }
            else if (firstMass.MaxValue != null && secondMass.MaxValue != null) // Takes the highest max value and the lowest min value from both masses 
            {
                double newMin = Math.Min((double)firstMass.MinValue, (double)secondMass.MinValue);
                double newMax = Math.Max((double)firstMass.MaxValue, (double)secondMass.MaxValue);
                return new Kilogram(newValue, newMin, newMax);
            }
            else // None of the masses has a range set
            {
                return new Kilogram(newValue);
            }
        }
    }
}
