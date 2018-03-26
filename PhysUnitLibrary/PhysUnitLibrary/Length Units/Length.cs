using System;
using System.Collections.Generic;
using System.Text;

namespace PhysUnitLibrary.Length_Units
{
    /// <summary>
    /// One of 7 physical unit dimensions
    /// The base unit of length is the metre (m)
    /// </summary>
    public abstract class Length : PhysicalUnit
    {
        // All inheriting classes must define how they are to be converted into Metre
        // Metre being the basic unit of Length 
        public abstract Metre Convert();

        public abstract double GetConversionFactor();

        public static Metre operator +(Length firstLength, Length secondLength)
        {
            double value = firstLength.Convert().Value + secondLength.Convert().Value;
            return CreateNewLengthObject(value, firstLength.Convert(), secondLength.Convert());
        }

        public static Metre operator -(Length firstLength, Length secondLength)
        {
            double newValue = firstLength.Convert().Value - secondLength.Convert().Value;
            return CreateNewLengthObject(newValue, firstLength.Convert(), secondLength.Convert());
        }

        public static Metre operator +(Length length, double operationValue)
        {
            double newValue = length.Value + operationValue;

            if (length.MaxValue != null)
            {
                return new Metre(newValue, (double)length.MinValue, (double)length.MaxValue);
            }
            else
            {
                return new Metre(newValue);
            }
        }

        public static Metre operator -(Length length, double operationValue)
        {
            double newValue = length.Value - operationValue;

            if (length.MaxValue != null)
            {
                return new Metre(newValue, (double)length.MinValue, (double)length.MaxValue);
            }
            else
            {
                return new Metre(newValue);
            }
        }

        public static Metre operator *(Length length, double operationValue)
        {
            double newValue = length.Value * operationValue;

            if (length.MaxValue != null)
            {
                return new Metre(newValue, (double)length.MinValue, (double)length.MaxValue);
            }
            else
            {
                return new Metre(newValue);
            }
        }

        public static Metre operator /(Length length, double operationValue)
        {
            double newValue = length.Value / operationValue;

            if (length.MaxValue != null)
            {
                return new Metre(newValue, (double)length.MinValue, (double)length.MaxValue);
            }
            else
            {
                return new Metre(newValue);
            }
        }

        /// <summary>
        /// Contains functionality to properly create a new length object from two existing ones
        /// </summary>
        /// <param name="value"></param>
        /// <param name="firstLength"></param>
        /// <param name="secondLength"></param>
        /// <returns></returns>
        public static Metre CreateNewLengthObject(double value, Metre firstLength, Metre secondLength)
        {
            if (firstLength.MaxValue == null && secondLength.MaxValue != null) // Takes the max & min value from the first length
            {
                double newMin = (double)secondLength.MinValue;
                double newMax = (double)secondLength.MaxValue;
                return new Metre(value, newMin, newMax);
            }
            else if (firstLength.MaxValue != null && secondLength.MaxValue == null) // Takes the max & min value from the second length
            {
                double newMin = (double)firstLength.MinValue;
                double newMax = (double)firstLength.MaxValue;
                return new Metre(value, newMin, newMax);
            }
            else if (firstLength.MaxValue != null && secondLength.MaxValue != null) // Takes the highest max value and the lowest min value from both lengths
            {
                double newMin = Math.Min((double)firstLength.MinValue, (double)secondLength.MinValue);
                double newMax = Math.Max((double)firstLength.MaxValue, (double)secondLength.MaxValue);
                return new Metre(value, newMin, newMax);            
            }
            else // None of the lengths has a range set
            {
                return new Metre(value);
            }
        }
    }
}
