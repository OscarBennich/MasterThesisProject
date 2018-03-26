using PhysUnitLibrary.Time_Units;
using PhysUnitLibrary.SI_Derived_Units;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhysUnitLibrary.Time_Units
{
    /// <summary>
    /// One of 7 physical unit dimensions
    /// The base unit of time is the second (s)
    /// </summary>
    public abstract class Time : PhysicalUnit
    {
        // All inheriting classes must define how they are to be converted into Second
        // Second being the basic unit of Time 
        public abstract Second Convert();

        public abstract double GetConversionFactor();

        public static Second operator +(Time firstTime, Time secondTime)
        {
            double value = firstTime.Convert().Value + secondTime.Convert().Value;
            return CreateNewTimeObject(value, firstTime.Convert(), secondTime.Convert());
        }

        public static Second operator -(Time firstTime, Time secondTime)
        {
            double newValue = firstTime.Convert().Value - secondTime.Convert().Value;
            return CreateNewTimeObject(newValue, firstTime.Convert(), secondTime.Convert());
        }

        public static Second operator +(Time time, double operationValue)
        {
            double newValue = time.Value + operationValue;

            if (time.MaxValue != null)
            {
                return new Second(newValue, (double)time.MinValue, (double)time.MaxValue);
            }
            else
            {
                return new Second(newValue);
            }
        }

        public static Second operator -(Time time, double operationValue)
        {
            double newValue = time.Value - operationValue;

            if (time.MaxValue != null)
            {
                return new Second(newValue, (double)time.MinValue, (double)time.MaxValue);
            }
            else
            {
                return new Second(newValue);
            }
        }

        public static Second operator *(Time time, double operationValue)
        {
            double newValue = time.Value * operationValue;

            if (time.MaxValue != null)
            {
                return new Second(newValue, (double)time.MinValue, (double)time.MaxValue);
            }
            else
            {
                return new Second(newValue);
            }
        }

        public static Second operator /(Time time, double operationValue)
        {
            double newValue = time.Value / operationValue;

            if (time.MaxValue != null)
            {
                return new Second(newValue, (double)time.MinValue, (double)time.MaxValue);
            }
            else
            {
                return new Second(newValue);
            }
        }

        /// <summary>
        /// Contains functionality to properly create a new time object from two existing ones
        /// </summary>
        /// <param name="newValue"></param>
        /// <param name="firstTime"></param>
        /// <param name="secondTime"></param>
        /// <returns></returns>
        public static Second CreateNewTimeObject(double newValue, Second firstTime, Second secondTime)
        {
            if (firstTime.MaxValue == null && secondTime.MaxValue != null) // Takes the max & min value from the first Time
            {
                double newMin = (double)secondTime.MinValue;
                double newMax = (double)secondTime.MaxValue;
                return new Second(newValue, newMin, newMax);
            }
            else if (firstTime.MaxValue != null && secondTime.MaxValue == null) // Takes the max & min value from the second Time
            {
                double newMin = (double)firstTime.MinValue;
                double newMax = (double)firstTime.MaxValue;
                return new Second(newValue, newMin, newMax);
            }
            else if (firstTime.MaxValue != null && secondTime.MaxValue != null) // Takes the highest max value and the lowest min value from both times
            {
                double newMin = Math.Min((double)firstTime.MinValue, (double)secondTime.MinValue);
                double newMax = Math.Max((double)firstTime.MaxValue, (double)secondTime.MaxValue);
                return new Second(newValue, newMin, newMax);
            }
            else // None of the times has a range set
            {
                return new Second(newValue);
            }
        }
    }
}
