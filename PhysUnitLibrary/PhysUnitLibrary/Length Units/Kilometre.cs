using System;
using System.Collections.Generic;
using System.Text;

namespace PhysUnitLibrary.Length_Units
{
    public class Kilometre : Length
    {
        public static double KilometreConversionFactor = 1000; // 1 kilometre is equal to 1000m

        public Kilometre(double value)
        {
            ConversionFactor = KilometreConversionFactor;

            Value = value;
            LengthDimension = 1;
            TimeDimension = 0;
            MassDimension = 0;
        }

        public Kilometre(double value, double minValue, double maxValue)
        {
            ConversionFactor = KilometreConversionFactor;

            Value = value;
            LengthDimension = 1;
            TimeDimension = 0;
            MassDimension = 0;

            MinValue = minValue;
            MaxValue = maxValue;
        }

        #region Conversion Methods
        public override Metre Convert()
        {
            double newValue = Value * ConversionFactor;

            if (MaxValue != null) // There is a range for this object
            {
                double newMinValue = (double)MinValue * ConversionFactor;
                double newMaxValue = (double)MaxValue * ConversionFactor;

                return new Metre(newValue, newMinValue, newMaxValue);
            }
            else // If it does not
            {
                return new Metre(newValue);
            }
        }

        public static implicit operator Kilometre(Metre Metre)
        {
            double newValue = Metre.Value * 1 / KilometreConversionFactor;

            if (Metre.MaxValue != null) // The Metre object has a range set
            {
                double newMinValue = (double)Metre.MinValue * 1 / KilometreConversionFactor;
                double newMaxValue = (double)Metre.MaxValue * 1 / KilometreConversionFactor;

                return new Kilometre(newValue, newMinValue, newMaxValue);
            }
            else // If it does not
            {
                return new Kilometre(newValue);
            }
        }

        public static implicit operator Kilometre(Foot foot)
        {
            return foot.Convert();
        }
        #endregion

        public override string ToString()
        {
            return Value + "km";
        }
    }
}
