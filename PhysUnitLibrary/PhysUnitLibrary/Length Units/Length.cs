using System;
using System.Collections.Generic;
using System.Text;

namespace PhysUnitLibrary.Length_Units
{
    /// <summary>
    /// One of 7 physical unit dimensions
    /// </summary>
    public abstract class Length : PhysicalUnit
    {
        public double ConversionFactor;

        // All inheriting classes must define how they are to be converted into Metre
        // Metre being the basic unit of Length 
        public abstract Metre Convert();

        public static Metre operator +(Length firstLength, Length secondLength)
        {
            double value = firstLength.Convert().Value + secondLength.Convert().Value;
            return CreateNewMetre(value, firstLength.Convert(), secondLength.Convert());
        }

        public static Metre operator +(Length firstLength, int intOperationValue)
        {
            double newValue = firstLength.Convert().Value + (intOperationValue * firstLength.ConversionFactor);
            return CreateNewMetre(newValue, firstLength.Convert());
        }

        public static Metre operator +(Length firstLength, double doubleOperationValue)
        {
            double newValue = firstLength.Convert().Value + (doubleOperationValue * firstLength.ConversionFactor);
            return CreateNewMetre(newValue, firstLength.Convert());
        }

        public static Metre operator -(Length firstLength, Length secondLength)
        {
            double newValue = firstLength.Convert().Value - secondLength.Convert().Value;
            return CreateNewMetre(newValue, firstLength.Convert(), secondLength.Convert());
        }

        public static Metre operator -(Length firstLength, int intOperationValue)
        {
            double newValue = firstLength.Convert().Value - (intOperationValue * firstLength.ConversionFactor);
            return CreateNewMetre(newValue, firstLength.Convert());
        }

        public static Metre operator -(Length firstLength, double doubleOperationValue)
        {
            double newValue = firstLength.Convert().Value - (doubleOperationValue * firstLength.ConversionFactor);
            return CreateNewMetre(newValue, firstLength.Convert());
        }

        public static Metre operator *(Length firstLength, Length secondLength)
        {
            double newValue = firstLength.Convert().Value * secondLength.Convert().Value;
            return CreateNewMetre(newValue, firstLength.Convert(), secondLength.Convert());
        }

        public static Metre operator *(Length firstLength, int intOperationValue)
        {
            double newValue = firstLength.Convert().Value * (intOperationValue * firstLength.ConversionFactor);
            return CreateNewMetre(newValue, firstLength.Convert());
        }

        public static Metre operator *(Length firstLength, double doubleOperationValue)
        {
            double newValue = firstLength.Convert().Value * (doubleOperationValue * firstLength.ConversionFactor);
            return CreateNewMetre(newValue, firstLength.Convert());
        }

        public static Metre operator /(Length firstLength, Length secondLength)
        {
            double newValue = firstLength.Convert().Value / secondLength.Convert().Value;
            return CreateNewMetre(newValue, firstLength.Convert(), secondLength.Convert());
        }

        public static Metre operator /(Length firstLength, int intOperationValue)
        {
            double newValue = firstLength.Convert().Value / (intOperationValue * firstLength.ConversionFactor);
            return CreateNewMetre(newValue, firstLength.Convert());
        }

        public static Metre operator /(Length firstLength, double doubleOperationValue)
        {
            double newValue = firstLength.Convert().Value / (doubleOperationValue * firstLength.ConversionFactor);
            return CreateNewMetre(newValue, firstLength.Convert());
        }

        public static Metre CreateNewMetre(double value, Metre firstLength, Metre secondLength)
        {
            if (firstLength.MaxValue == null && secondLength.MaxValue != null) // Takes the max & min value from the first Length
            {
                double newMin = (double)secondLength.MinValue;
                double newMax = (double)secondLength.MaxValue;
                return new Metre(value, newMin, newMax);
            }
            else if (firstLength.MaxValue != null && secondLength.MaxValue == null) // Takes the max & min value from the second Length
            {
                double newMin = (double)firstLength.MinValue;
                double newMax = (double)firstLength.MaxValue;
                return new Metre(value, newMin, newMax);
            }
            else if (firstLength.MaxValue == null && secondLength.MaxValue == null) // None of the Lengthes has a range set
            {
                return new Metre(value);
            }
            else // Takes the highest max value and the lowest min value from both Lengthes 
            {
                double newMin = Math.Min((double)firstLength.MinValue, (double)secondLength.MinValue);
                double newMax = Math.Max((double)firstLength.MaxValue, (double)secondLength.MaxValue);
                return new Metre(value, newMin, newMax);
            }
        }

        // For when adding a value to an existing Length, instead of two Lengthes together
        public static Metre CreateNewMetre(double value, Metre Metre)
        {
            if (Metre.MaxValue != null)
            {
                double newMin = (double)Metre.MinValue;
                double newMax = (double)Metre.MaxValue;
                return new Metre(value, newMin, newMax);
            }
            else
            {
                return new Metre(value);
            }
        }
    }
}
