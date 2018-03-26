using PhysUnitLibrary.Mass_Units;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhysUnitLibrary
{   
    /// <summary>
    /// Basic unit of mass
    /// </summary>
    public class Kilogram : Mass
    {
        private static double ConversionFactor = 1;

        public Kilogram(double value)
        {
            Value = value;
            LengthDimension = 0;
            MassDimension = 1;
            TimeDimension = 0;            
        }

        public Kilogram(double value, double minValue, double maxValue)
        {   
            if (value > maxValue)
            {
                throw new OverMaxValueException("The mass is over the max allowed amount");
            }
            else if(value < minValue)
            {
                throw new UnderMinValueException("The mass is under the minimum allowed amount");
            }

            Value = value;
            LengthDimension = 0;
            MassDimension = 1;
            TimeDimension = 0;
            MinValue = minValue;
            MaxValue = maxValue;
        }
        
        #region Conversion methods 
        public override Kilogram Convert()
        {
            return this;
        }

        public override double GetConversionFactor()
        {
            return ConversionFactor;
        }

        public static implicit operator Kilogram(Pound pound)
        {
            return new Kilogram(pound.Value * pound.GetConversionFactor()); 
        }

        public static implicit operator Kilogram(Tonne tonne)
        {
            return new Kilogram(tonne.Value * tonne.GetConversionFactor());
        }
        #endregion

        public override string ToString()
        {
            return Value + "kg";
        }
    }
}
