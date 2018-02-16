using System;
using System.Collections.Generic;
using System.Text;

namespace PhysUnitLibrary.Mass_Units
{
    /// <summary>
    /// Unit of mass - Equal to 2.17647051 * 10^-8 kg
    /// </summary>
    public class PlanckMass : Mass
    {
        public double Value { get; private set; }

        public PlanckMass(double value)
        {
            Value = value;
        }

        #region Conversion Methods
        public override Kilogram Convert()
        {
            return new Kilogram(this.Value * 2.17647051 * Math.Pow(10, -8));
        }

        public static implicit operator PlanckMass(Kilogram kilogram)
        {
            return new PlanckMass(kilogram.Value * 45940892.447777); // One kilogram is equal to 45940892.447777mP
        }

        public static implicit operator PlanckMass(AtomicMass atomicMass)
        {
            return atomicMass.Convert();
        }

        public static implicit operator PlanckMass(Pound pound)
        {
            return pound.Convert();
        }

        public static implicit operator PlanckMass(Slug slug)
        {
            return slug.Convert();
        }

        public static implicit operator PlanckMass(SolarMass solarMass)
        {
            return solarMass.Convert();
        }

        public static implicit operator PlanckMass(Tonne tonne)
        {
            return tonne.Convert();
        }
        #endregion

        public override string ToString()
        {
            return Value + "mP";
        }
    }
}
