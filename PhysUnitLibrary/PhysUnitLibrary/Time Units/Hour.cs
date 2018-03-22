using System;
using System.Collections.Generic;
using System.Text;

namespace PhysUnitLibrary.Time_Units
{
    public class Hour : Time
    {
        public static double HourConversionFactor = 3600; // 1 Hour is equal to 3600sec

        public Hour(double value)
        {
            ConversionFactor = HourConversionFactor;

            Value = value;
            LengthDimension = 0;
            TimeDimension = 1;
            MassDimension = 0;
        }

        public Hour(double value, double minValue, double maxValue)
        {
            ConversionFactor = HourConversionFactor;

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

        public static implicit operator Hour(Second Second)
        {
            double newValue = Second.Value * 1 / HourConversionFactor;

            if (Second.MaxValue != null) // The Second object has a range set
            {
                double newMinValue = (double)Second.MinValue * 1 / HourConversionFactor;
                double newMaxValue = (double)Second.MaxValue * 1 / HourConversionFactor;

                return new Hour(newValue, newMinValue, newMaxValue);
            }
            else // If it does not
            {
                return new Hour(newValue);
            }
        }

        public static implicit operator Hour(Minute minute)
        {
            return minute.Convert();
        }
        #endregion

        public override string ToString()
        {
            return Value + "hr";
        }
    }
}
