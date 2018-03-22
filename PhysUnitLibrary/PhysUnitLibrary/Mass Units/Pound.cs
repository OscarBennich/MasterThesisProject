using System;
using System.Collections.Generic;
using System.Text;

namespace PhysUnitLibrary.Mass_Units
{
    /// <summary>
    /// Unit of mass - Equal to 0.45359237kg
    /// </summary>
    public class Pound : Mass
    {
        public static double PoundConversionFactor = 0.45359237; // 1 pound is equal to to 0.45359237kg

        public Pound(double value)
        {
            ConversionFactor = PoundConversionFactor;

            Value = value;
            LengthDimension = 0;
            TimeDimension = 0;
            MassDimension = 1;
        }

        public Pound(double value, double minValue, double maxValue)
        {
            ConversionFactor = PoundConversionFactor;

            Value = value;
            LengthDimension = 0;
            TimeDimension = 0;
            MassDimension = 1;

            MinValue = minValue;
            MaxValue = maxValue;
        }

        #region Conversion Methods
        public override Kilogram Convert()
        {
            double newValue = Value * ConversionFactor;

            if (MaxValue != null) // There is a range for this object
            {
                double newMinValue = (double)MinValue * ConversionFactor;
                double newMaxValue = (double)MaxValue * ConversionFactor;

                return new Kilogram(newValue, newMinValue, newMaxValue);
            }
            else // If it does not
            {
                return new Kilogram(newValue);
            }
        }

        public static implicit operator Pound(Kilogram kilogram)
        {
            double newValue = kilogram.Value * 1 / PoundConversionFactor;

            if (kilogram.MaxValue != null) // The kilogram object has a range set
            {
                double newMinValue = (double)kilogram.MinValue * 1 / PoundConversionFactor;
                double newMaxValue = (double)kilogram.MaxValue * 1 / PoundConversionFactor;

                return new Pound(newValue, newMinValue, newMaxValue);
            }
            else // If it does not
            {
                return new Pound(newValue);
            }        
        }

        public static implicit operator Pound(Tonne tonne)
        {
            return tonne.Convert();
        }
        #endregion

        public override string ToString()
        {
            return Value + "lb";
        }
    }
}
