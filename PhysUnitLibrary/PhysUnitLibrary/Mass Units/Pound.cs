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
        //public double Value { get; private set; }

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
            return new Kilogram(this.Value * 0.45359237);
        }

        public static implicit operator Pound(Kilogram kilogram)
        {
            return new Pound(kilogram.Value * 2.20462262); // One pound is equal to 2.20462262kg
        }

        //public static implicit operator Pound(AtomicMass atomicMass)
        //{
        //    return atomicMass.Convert();
        //}

        //public static implicit operator Pound(PlanckMass planckMass)
        //{
        //    return planckMass.Convert();
        //}

        //public static implicit operator Pound(Slug slug)
        //{
        //    return slug.Convert();
        //}

        //public static implicit operator Pound(SolarMass solarMass)
        //{
        //    return solarMass.Convert();
        //}

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
