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
        public Pound(double value)
        {
            Value = value;
            LengthDimension = 0;
            TimeDimension = 0;
            MassDimension = 1;
        }

        public Pound(double value, double minValue, double maxValue)
        {
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
            double conversionFactor = 0.45359237; // Kilogram is equal to  to 0.45359237lb
            double newValue = Value * conversionFactor;

            if (MaxValue != null) // The kilogram object has a range set
            {
                double newMinValue = (double)MinValue * conversionFactor;
                double newMaxValue = (double)MaxValue * conversionFactor;

                return new Kilogram(newValue, newMinValue, newMaxValue);
            }
            else
            {
                return new Kilogram(newValue);
            }

        }

        public static implicit operator Pound(Kilogram kilogram)
        {
            double conversionFactor = 2.20462262; // One pound is equal to 2.20462262kg
            double newValue = kilogram.Value * conversionFactor;

            if (kilogram.MaxValue != null) // The kilogram object has a range set
            {                     
                double newMinValue = (double)kilogram.MinValue * conversionFactor;
                double newMaxValue = (double)kilogram.MaxValue * conversionFactor;

                return new Pound(newValue, newMinValue, newMaxValue);
            }
            else
            {
                return new Pound(newValue);
            }        
        }

        public static implicit operator Pound(Tonne tonne)
        {
            return tonne.Convert();
        }
        #endregion


        public static double ConvertToKilogram(double value) // Value in pounds
        {
            return value * 0.45359237;
        }

        public override string ToString()
        {
            return Value + "lb";
        }
    }
}
