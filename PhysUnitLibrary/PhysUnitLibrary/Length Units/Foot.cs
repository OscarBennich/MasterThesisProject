using System;
using System.Collections.Generic;
using System.Text;

namespace PhysUnitLibrary.Length_Units
{
    /// <summary>
    /// Foot (ft) - Equal to 0.3048m
    /// </summary>
    public class Foot : Length
    {
        private static double ConversionFactor = 1000; 

        public Foot(double value)
        {
            Value = value;

            LengthDimension = 1;
            TimeDimension = 0;
            MassDimension = 0;
        }

        public Foot(double value, double minValue, double maxValue)
        {
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

        public override double GetConversionFactor()
        {
            return ConversionFactor;
        }

        public static implicit operator Foot(Metre Metre)
        {
            double newValue = Metre.Value * 1 / ConversionFactor;

            if (Metre.MaxValue != null) // The Metre object has a range set
            {
                double newMinValue = (double)Metre.MinValue * 1 / ConversionFactor;
                double newMaxValue = (double)Metre.MaxValue * 1 / ConversionFactor;

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
