using System;
using System.Collections.Generic;
using System.Text;

namespace PhysUnitLibrary.Time_Units
{
    public class Hour : Time
    {
        private static double ConversionFactor = 3600; // 1 Hour is equal to 3600sec

        public Hour(double value)
        {
            Value = value;
            LengthDimension = 0;
            TimeDimension = 1;
            MassDimension = 0;
        }

        public Hour(double value, double minValue, double maxValue)
        {
            if (value > maxValue)
            {
                throw new OverMaxValueException("The time is over the max allowed amount");
            }
            else if (value < minValue)
            {
                throw new UnderMinValueException("The time is under the minimum allowed amount");
            }

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

        public override double GetConversionFactor()
        {
            return ConversionFactor;
        }

        public static implicit operator Hour(Second Second)
        {
            double newValue = Second.Value * 1 / ConversionFactor;

            if (Second.MaxValue != null) // The Second object has a range set
            {
                double newMinValue = (double)Second.MinValue * 1 / ConversionFactor;
                double newMaxValue = (double)Second.MaxValue * 1 / ConversionFactor;

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
