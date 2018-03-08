using System;
using System.Collections.Generic;
using System.Text;

namespace PhysUnitLibrary.Mass_Units
{
    /// <summary>
    /// Unit of mass - Equal to 1.98855 * 10^30 kg
    /// </summary>
    public class SolarMass : Mass
    {
        //public double Value { get; private set; }

        public SolarMass(double value)
        {
            Value = value;
        }

        #region Conversion Methods
        public override Kilogram Convert()
        {
            return new Kilogram(this.Value * 1.98855 * Math.Pow(10, 30));
        }

        public static implicit operator SolarMass(Kilogram kilogram)
        {
            return new SolarMass(kilogram.Value * (5 * Math.Pow(10, -31))); // One kilogram is equal to 5*10^-31Mo
        }

        public static implicit operator SolarMass(AtomicMass atomicMass)
        {
            return atomicMass.Convert();
        }

        public static implicit operator SolarMass(Pound pound)
        {
            return pound.Convert();
        }

        public static implicit operator SolarMass(PlanckMass planckMass)
        {
            return planckMass.Convert();
        }

        public static implicit operator SolarMass(Slug slug)
        {
            return slug.Convert();
        }

        public static implicit operator SolarMass(Tonne tonne)
        {
            return tonne.Convert();
        }
        #endregion

        public override string ToString()
        {
            return Value + "Mo";
        }
    }
}
