using System;
using System.Collections.Generic;
using System.Text;

namespace PhysUnitLibrary.Length_Units
{
    public class Metre : Length
    {
        public Metre(double value)
        {
            ConversionFactor = 1;
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

            ConversionFactor = 1;
            Value = value;
            LengthDimension = 1;
            TimeDimension = 0;
            MassDimension = 0;
            MinValue = minValue;
            MaxValue = maxValue;
        }

        #region Conversion methods 
        public override Metre Convert()
        {
            return this;
        }

        public static implicit operator Metre(Kilometre kilometre)
        {
            return new Metre(kilometre.Value * Kilometre.KilometreConversionFactor);
        }

        public static implicit operator Metre(Foot foot)
        {
            return new Metre(foot.Value * Foot.FootConversionFactor);
        }
        #endregion

        public override string ToString()
        {
            return Value + "m";
        }
    }
}
