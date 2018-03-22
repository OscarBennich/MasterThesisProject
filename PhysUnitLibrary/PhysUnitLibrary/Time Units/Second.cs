using System;
using System.Collections.Generic;
using System.Text;

namespace PhysUnitLibrary.Time_Units
{
    public class Second : Time
    {
        public Second(double value)
        {
            ConversionFactor = 1;
            Value = value;
            LengthDimension = 0;
            TimeDimension = 1;
            MassDimension = 0;
        }

        public Second(double value, double minValue, double maxValue)
        {
            if (value > maxValue)
            {
                throw new OverMaxValueException("The time is over the max allowed amount");
            }
            else if (value < minValue)
            {
                throw new UnderMinValueException("The time is under the minimum allowed amount");
            }

            ConversionFactor = 1;
            Value = value;
            LengthDimension = 0;
            TimeDimension = 1;
            MassDimension = 0;
            MinValue = minValue;
            MaxValue = maxValue;
        }

        #region Conversion methods 
        public override Second Convert()
        {
            return this;
        }

        public static implicit operator Second(Hour hour)
        {
            return new Second(hour.Value * Hour.HourConversionFactor);
        }

        public static implicit operator Second(Minute minute)
        {
            return new Second(minute.Value * Minute.MinuteConversionFactor);
        }
        #endregion

        public override string ToString()
        {
            return Value + "sec";
        }
    }
}
