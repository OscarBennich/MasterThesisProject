﻿using PhysUnitLibrary.Mass_Units;
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
        public Kilogram(double value)
        {
            ConversionFactor = 1;
            Value = value;
            LengthDimension = 0;
            TimeDimension = 0;
            MassDimension = 1;
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

            ConversionFactor = 1;
            Value = value;  
            LengthDimension = 0;
            TimeDimension = 0;
            MassDimension = 1;
            MinValue = minValue;
            MaxValue = maxValue;
        }

        #region Conversion methods 
        public override Kilogram Convert()
        {
            return this;
        }

        public static implicit operator Kilogram(Pound pound)
        {
            return new Kilogram(pound.Value * Pound.PoundConversionFactor); 
        }

        public static implicit operator Kilogram(Tonne tonne)
        {
            return new Kilogram(tonne.Value * Tonne.TonneConversionFactor);
        }
        #endregion

        public override string ToString()
        {
            return Value + "kg";
        }
    }
}
