using System;
using System.Collections.Generic;
using System.Text;

namespace PhysUnitLibrary.Length_Units
{
    public class Foot : Length
    {
        public static double FootConversionFactor = 0.3048; // 1 Foot is equal to 0.3048m

        public Foot(double value)
        {
            ConversionFactor = FootConversionFactor;

            Value = value;
            LengthDimension = 1;
            TimeDimension = 0;
            MassDimension = 0;
        }

        public Foot(double value, double minValue, double maxValue)
        {
            ConversionFactor = FootConversionFactor;

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

        public static implicit operator Foot(Metre Metre)
        {
            double newValue = Metre.Value * 1 / FootConversionFactor;

            if (Metre.MaxValue != null) // The Metre object has a range set
            {
                double newMinValue = (double)Metre.MinValue * 1 / FootConversionFactor;
                double newMaxValue = (double)Metre.MaxValue * 1 / FootConversionFactor;

                return new Foot(newValue, newMinValue, newMaxValue);
            }
            else // If it does not
            {
                return new Foot(newValue);
            }
        }

        public static implicit operator Foot(Kilometre kilometre)
        {
            return kilometre.Convert();
        }
        #endregion

        public override string ToString()
        {
            return Value + "ft";
        }
    }
}
