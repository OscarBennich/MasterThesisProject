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
        public static double TonneConversionFactor = 1000; // One tonne is equal to 1000kg

        public Tonne(double value)
        {   
            ConversionFactor = TonneConversionFactor;

            Value = value;
            LengthDimension = 0;
            TimeDimension = 0;
            MassDimension = 1;
        }

        public Tonne(double value, double minValue, double maxValue)
        {
            if (value > maxValue)
            {
                throw new OverMaxValueException("The mass is over the max allowed amount");
            }
            else if (value < minValue)
            {
                throw new UnderMinValueException("The mass is under the minimum allowed amount");
            }

            ConversionFactor = TonneConversionFactor;

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

        public static implicit operator Tonne(Kilogram kilogram)
        {
            double newValue = kilogram.Value * 1 / TonneConversionFactor;

            if (kilogram.MaxValue != null) // The kilogram object has a range set
            {
                double newMinValue = (double)kilogram.MinValue * 1 / TonneConversionFactor;
                double newMaxValue = (double)kilogram.MaxValue * 1 / TonneConversionFactor;

                return new Tonne(newValue, newMinValue, newMaxValue);
            }
            else // If it does not
            {
                return new Tonne(newValue);
            }
        }

        public static implicit operator Tonne(Pound pound)
        {
            return pound.Convert();
        }
        #endregion

        public override string ToString()
        {
            return Value + "t";
        }
    }
}
