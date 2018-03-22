using System;
using System.Collections.Generic;
using System.Text;

namespace PhysUnitLibrary.Time_Units
{
    public class Minute : Time 
    {
        public static double MinuteConversionFactor = 60; // 1 Minute is equal to 60sec

        public Minute(double value)
        {
            ConversionFactor = MinuteConversionFactor;

            Value = value;
            LengthDimension = 0;
            TimeDimension = 1;
            MassDimension = 0;
        }

        public Minute(double value, double minValue, double maxValue)
        {
            ConversionFactor = MinuteConversionFactor;

            Value = value;
            LengthDimension = 0;
            TimeDimension = 1;
            MassDimension = 0;

            MinValue = minValue;
            MaxValue = maxValue;
        }

        #region Conversion Methods
        public override Second Convert()
        {
            double newValue = Value * ConversionFactor;

            if (MaxValue != null) // There is a range for this object
            {
                double newMinValue = (double)MinValue * ConversionFactor;
                double newMaxValue = (double)MaxValue * ConversionFactor;

                return new Second(newValue, newMinValue, newMaxValue);
            }
            else // If it does not
            {
                return new Second(newValue);
            }
        }

        public static implicit operator Minute(Second Second)
        {
            double newValue = Second.Value * 1 / MinuteConversionFactor;

            if (Second.MaxValue != null) // The Second object has a range set
            {
                double newMinValue = (double)Second.MinValue * 1 / MinuteConversionFactor;
                double newMaxValue = (double)Second.MaxValue * 1 / MinuteConversionFactor;

                return new Minute(newValue, newMinValue, newMaxValue);
            }
            else // If it does not
            {
                return new Minute(newValue);
            }
        }

        public static implicit operator Minute(Hour hour)
        {
            return hour.Convert();
        }
        #endregion

        public override string ToString()
        {
            return Value + "min";
        }
    }
}
