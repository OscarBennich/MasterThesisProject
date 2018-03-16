using System;
using System.Collections.Generic;
using System.Text;

namespace PhysUnitLibrary.Mass_Units
{
    /// <summary>
    /// Unit of mass - Equal to 1000kg
    /// </summary>
    public class Tonne : Mass
    {
        //public double Value { get; private set; }

        public Tonne(double value)
        {
            Value = value;
            LengthDimension = 0;
            TimeDimension = 0;
            MassDimension = 1;
        }

        public Tonne(double value, double minValue, double maxValue)
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
            double conversionFactor = 1000; // One tonne is equal to 1000kg
            double newValue = Value * conversionFactor;

            if (MaxValue != null) // There is a range for this object
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

        public static implicit operator Tonne(Kilogram kilogram)
        {
            double conversionFactor = 0.001; // One kg is equal to 0.001 tonnes
            double newValue = kilogram.Value * conversionFactor;

            if (kilogram.MaxValue != null) // The kilogram object has a range set
            {
                double newMinValue = (double)kilogram.MinValue * conversionFactor;
                double newMaxValue = (double)kilogram.MaxValue * conversionFactor;

                return new Tonne(newValue, newMinValue, newMaxValue);
            }
            else
            {
                return new Tonne(newValue);
            }
        }

        public static implicit operator Tonne(Pound pound)
        {
            return pound.Convert();
        }
        #endregion

        public static double ConvertToKilogram(double value) // Value in tonnes
        {
            return value * 0.001;
        }

        public override string ToString()
        {
            return Value + "t";
        }
    }
}
