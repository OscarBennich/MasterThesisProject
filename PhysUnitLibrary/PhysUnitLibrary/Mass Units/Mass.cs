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

        public static Mass operator +(Mass firstMass, Mass secondMass)
        {   
            if(IsSameType(firstMass, secondMass))
            {
                double value = firstMass.Value + secondMass.Value;
                return CreateNewMassObject(value, firstMass, secondMass);
            }
            else
            {
                double value = firstMass.Convert().Value + secondMass.Convert().Value;
                return CreateNewMassObject(value, firstMass, secondMass);
            }
        }

        public static Mass operator +(Mass mass, double operationValue)
        {
            Type physicalUnitType = mass.GetType();
            double newValue = mass.Value + operationValue;

            if(mass.MaxValue != null)
            {
                Mass massUnit = (Mass)Activator.CreateInstance(physicalUnitType, new Object[] { newValue, mass.MinValue, mass.MaxValue });
                return massUnit;
            }
            else
            {
                Mass massUnit = (Mass)Activator.CreateInstance(physicalUnitType, new Object[] { newValue });
                return massUnit;
            }        
        }

        public static Mass operator -(Mass firstMass, Mass secondMass)
        {
            if (IsSameType(firstMass, secondMass))
            {
                double value = firstMass.Value - secondMass.Value;
                return CreateNewMassObject(value, firstMass, secondMass);
            }
            else
            {
                double value = firstMass.Convert().Value - secondMass.Convert().Value;
                return CreateNewMassObject(value, firstMass, secondMass);
            }
        }

        public static Mass operator -(Mass mass, double operationValue)
        {
            Type physicalUnitType = mass.GetType();
            double newValue = mass.Value - operationValue;

            if (mass.MaxValue != null)
            {
                Mass massUnit = (Mass)Activator.CreateInstance(physicalUnitType, new Object[] { newValue, mass.MinValue, mass.MaxValue });
                return massUnit;
            }
            else
            {
                Mass massUnit = (Mass)Activator.CreateInstance(physicalUnitType, new Object[] { newValue });
                return massUnit;
            }
        }

        public static Mass operator *(Mass mass, double operationValue)
        {
            Type physicalUnitType = mass.GetType();
            double newValue = mass.Value - operationValue;

            if (mass.MaxValue != null)
            {
                Mass massUnit = (Mass)Activator.CreateInstance(physicalUnitType, new Object[] { newValue, mass.MinValue, mass.MaxValue });
                return massUnit;
            }
            else
            {
                Mass massUnit = (Mass)Activator.CreateInstance(physicalUnitType, new Object[] { newValue });
                return massUnit;
            }
        }

        public static Mass operator /(Mass mass, double operationValue)
        {
            Type physicalUnitType = mass.GetType();
            double newValue = mass.Value - operationValue;

            if (mass.MaxValue != null)
            {
                Mass massUnit = (Mass)Activator.CreateInstance(physicalUnitType, new Object[] { newValue, mass.MinValue, mass.MaxValue });
                return massUnit;
            }
            else
            {
                Mass massUnit = (Mass)Activator.CreateInstance(physicalUnitType, new Object[] { newValue });
                return massUnit;
            }
        }    

        public static Mass CreateNewMassObject(double newValue, Mass firstMass, Mass secondMass)
        {
            if(IsSameType(firstMass,secondMass)) // If the masses are of the same type, they will be returned as that type (instead of kilograms)
            {
                Type physicalUnitType = firstMass.GetType();

                if (firstMass.MaxValue == null && secondMass.MaxValue != null) // Takes the max & min value from the first mass
                {
                    double newMin = (double)secondMass.MinValue;
                    double newMax = (double)secondMass.MaxValue;

                    Mass massUnit = (Mass)Activator.CreateInstance(physicalUnitType, new Object[] { newValue, newMin, newMax });
                    return massUnit;
                }
                else if (firstMass.MaxValue != null && secondMass.MaxValue == null) // Takes the max & min value from the second mass
                {
                    double newMin = (double)firstMass.MinValue;
                    double newMax = (double)firstMass.MaxValue;
   
                    Mass massUnit = (Mass)Activator.CreateInstance(physicalUnitType, new Object[] { newValue, newMin, newMax });
                    return massUnit;
                }
                else if (firstMass.MaxValue != null && secondMass.MaxValue != null) // Takes the highest max value and the lowest min value from both masses 
                {
                    double newMin = Math.Min((double)firstMass.MinValue, (double)secondMass.MinValue);
                    double newMax = Math.Max((double)firstMass.MaxValue, (double)secondMass.MaxValue);

                    Mass massUnit = (Mass)Activator.CreateInstance(physicalUnitType, new Object[] { newValue, newMin, newMax });
                    return massUnit;
                }
                else // None of the masses has a range set
                {
                    Mass massUnit = (Mass)Activator.CreateInstance(physicalUnitType, new Object[] { newValue });
                    return massUnit;
                }
            }
            else
            {

                if (firstMass.MaxValue == null && secondMass.MaxValue != null) // Takes the max & min value from the first mass
                {
                    double newMin = (double)secondMass.MinValue * secondMass.GetConversionFactor();
                    double newMax = (double)secondMass.MaxValue * secondMass.GetConversionFactor();

                    return new Kilogram(newValue, newMin, newMax);
                }
                else if (firstMass.MaxValue != null && secondMass.MaxValue == null) // Takes the max & min value from the second mass
                {
                    double newMin = (double)firstMass.MinValue * firstMass.GetConversionFactor();
                    double newMax = (double)firstMass.MaxValue * firstMass.GetConversionFactor();

                    return new Kilogram(newValue, newMin, newMax);
                }
                else if (firstMass.MaxValue != null && secondMass.MaxValue != null) // Takes the highest max value and the lowest min value from both masses 
                {
                    double newMin = Math.Min((double)firstMass.MinValue * firstMass.GetConversionFactor(), (double)secondMass.MinValue * secondMass.GetConversionFactor());
                    double newMax = Math.Max((double)firstMass.MaxValue * firstMass.GetConversionFactor(), (double)secondMass.MaxValue * secondMass.GetConversionFactor());

                    return new Kilogram(newValue, newMin, newMax);
                }
                else // None of the masses has a range set
                {
                    return new Kilogram(newValue);
                }
            }
        }

        public static bool IsSameType(Mass firstMass, Mass secondMass)
        {
            return firstMass.GetType().IsEquivalentTo(secondMass.GetType());
        }
    }
}
