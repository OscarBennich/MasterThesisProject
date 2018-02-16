using System;
using System.Collections.Generic;
using System.Text;

namespace PhysUnitLibrary.Mass_Units
{
    /// <summary>
    /// Unit of mass - Equal to 1.660539040 * 10^-27 kg
    /// </summary>
    public class AtomicMass : Mass
    {
        public double Value { get; private set; }

        public AtomicMass(double value)
        {
            Value = value;
        }
         
        #region Conversion methods 
        public override Kilogram Convert()
        {
            return new Kilogram(this.Value * (1.660539040 * Math.Pow(10, -27)));
        }

        public static implicit operator AtomicMass(Kilogram kilogram)
        {
            return new AtomicMass(kilogram.Value * (6.0221366516752 * Math.Pow(10,26))); // One kilogram is equal to 6.0221366516752 * 10^26u
        }

        public static implicit operator AtomicMass(Pound pound)
        {
            return pound.Convert();
        }

        public static implicit operator AtomicMass(PlanckMass planckMass)
        {
            return planckMass.Convert();
        }

        public static implicit operator AtomicMass(Slug slug)
        {
            return slug.Convert();
        }

        public static implicit operator AtomicMass(SolarMass solarMass)
        {
            return solarMass.Convert();
        }

        public static implicit operator AtomicMass(Tonne tonne)
        {
            return tonne.Convert();
        }
        #endregion

        public override string ToString()
        {
            return Value + "u";
        }
    }
}
