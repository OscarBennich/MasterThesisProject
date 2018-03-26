using PhysUnitLibrary.Time_Units;
using PhysUnitLibrary.SI_Derived_Units;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhysUnitLibrary.Time_Units
{
    /// <summary>
    /// One of 7 physical unit dimensions
    /// </summary>
    public abstract class Time : PhysicalUnit
    {
        public double ConversionFactor;

        // All inheriting classes must define how they are to be converted into Second
        // Second being the basic unit of Time 
        public abstract Second Convert();

        public static Second operator +(Time firstTime, Time secondTime)
        {
            double value = firstTime.Convert().Value + secondTime.Convert().Value;
            return CreateNewSecond(value, firstTime.Convert(), secondTime.Convert());
        }

        public static Second operator +(Time firstTime, int intOperationValue)
        {
            double newValue = firstTime.Convert().Value + (intOperationValue * firstTime.ConversionFactor);
            return CreateNewSecond(newValue, firstTime.Convert());
        }

        public static Second operator +(Time firstTime, double doubleOperationValue)
        {
            double newValue = firstTime.Convert().Value + (doubleOperationValue * firstTime.ConversionFactor);
            return CreateNewSecond(newValue, firstTime.Convert());
        }

        public static Second operator -(Time firstTime, Time secondTime)
        {
            double newValue = firstTime.Convert().Value - secondTime.Convert().Value;
            return CreateNewSecond(newValue, firstTime.Convert(), secondTime.Convert());
        }

        public static Second operator -(Time firstTime, int intOperationValue)
        {
            double newValue = firstTime.Convert().Value - (intOperationValue * firstTime.ConversionFactor);
            return CreateNewSecond(newValue, firstTime.Convert());
        }

        public static Second operator -(Time firstTime, double doubleOperationValue)
        {
            double newValue = firstTime.Convert().Value - (doubleOperationValue * firstTime.ConversionFactor);
            return CreateNewSecond(newValue, firstTime.Convert());
        }

        //public static Second operator *(Time firstTime, Time secondTime)
        //{
        //    double newValue = firstTime.Convert().Value * secondTime.Convert().Value;
        //    return CreateNewSecond(newValue, firstTime.Convert(), secondTime.Convert());
        //}

        public static Second operator *(Time firstTime, int intOperationValue)
        {
            double newValue = firstTime.Convert().Value * (intOperationValue * firstTime.ConversionFactor);
            return CreateNewSecond(newValue, firstTime.Convert());
        }

        public static Second operator *(Time firstTime, double doubleOperationValue)
        {
            double newValue = firstTime.Convert().Value * (doubleOperationValue * firstTime.ConversionFactor);
            return CreateNewSecond(newValue, firstTime.Convert());
        }

        //public static Second operator /(Time firstTime, Time secondTime)
        //{
        //    double newValue = firstTime.Convert().Value / secondTime.Convert().Value;
        //    return CreateNewSecond(newValue, firstTime.Convert(), secondTime.Convert());
        //}

        public static Second operator /(Time firstTime, int intOperationValue)
        {
            double newValue = firstTime.Convert().Value / (intOperationValue * firstTime.ConversionFactor);
            return CreateNewSecond(newValue, firstTime.Convert());
        }

        public static Second operator /(Time firstTime, double doubleOperationValue)
        {
            double newValue = firstTime.Convert().Value / (doubleOperationValue * firstTime.ConversionFactor);
            return CreateNewSecond(newValue, firstTime.Convert());
        }

        public static Second CreateNewSecond(double value, Second firstTime, Second secondTime)
        {
            if (firstTime.MaxValue == null && secondTime.MaxValue != null) // Takes the max & min value from the first Time
            {
                double newMin = (double)secondTime.MinValue;
                double newMax = (double)secondTime.MaxValue;
                return new Second(value, newMin, newMax);
            }
            else if (firstTime.MaxValue != null && secondTime.MaxValue == null) // Takes the max & min value from the second Time
            {
                double newMin = (double)firstTime.MinValue;
                double newMax = (double)firstTime.MaxValue;
                return new Second(value, newMin, newMax);
            }
            else if (firstTime.MaxValue == null && secondTime.MaxValue == null) // None of the Timees has a range set
            {
                return new Second(value);
            }
            else // Takes the highest max value and the lowest min value from both Timees 
            {
                double newMin = Math.Min((double)firstTime.MinValue, (double)secondTime.MinValue);
                double newMax = Math.Max((double)firstTime.MaxValue, (double)secondTime.MaxValue);
                return new Second(value, newMin, newMax);
            }
        }

        // For when adding a value to an existing Time, instead of two Timees together
        public static Second CreateNewSecond(double value, Second Second)
        {
            if (Second.MaxValue != null)
            {
                double newMin = (double)Second.MinValue;
                double newMax = (double)Second.MaxValue;
                return new Second(value, newMin, newMax);
            }
            else
            {
                return new Second(value);
            }
        }
    }
}
