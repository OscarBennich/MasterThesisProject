using System;
using System.Collections.Generic;
using System.Text;

namespace PhysUnitLibrary.Length_Units
{
    /// <summary>
    /// Metre (m) - Base unit of length
    /// </summary>
    public class Metre : Length
    {
        private static double ConversionFactor = 1;

        public Metre(double value)
        {
            Value = value;
            LengthDimension = 1;
            TimeDimension = 0;
            MassDimension = 0;
        }

        public Metre(double value, double minValue, double maxValue)
        {
            if (value > maxValue)
            {
                throw new OverMaxValueException("The length is over the max allowed amount");
            }
            else if (value < minValue)
            {
                throw new UnderMinValueException("The length is under the minimum allowed amount");
            }

            Value = value;
            LengthDimension = 1;
            TimeDimension = 0;
            MassDimension = 0;
            MinValue = minValue;
            MaxValue = maxValue;
        }

        public override Metre Convert()
        {
            return this;
        }

        public override double GetConversionFactor()
        {
            return ConversionFactor;
        }

        public static implicit operator Metre(Kilometre kilometre)
        {
            return new Metre(kilometre.Value * kilometre.GetConversionFactor());
        }

        public static implicit operator Metre(Foot foot)
        {
            return new Metre(foot.Value * foot.GetConversionFactor());
        }

        public override string ToString()
        {
            return Value + "m";
        }
    }
}
