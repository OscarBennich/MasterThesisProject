using System;
using System.Collections.Generic;
using System.Text;

namespace PhysUnitLibrary.Mass_Units
{
    /// <summary>
    /// Unit of mass - Equal to 14.593903kg
    /// </summary>
    public class Slug : Mass
    {
        public double Value { get; private set; }

        public Slug(double value)
        {
            Value = value;
        }

        #region Conversion methods 

        public override Kilogram Convert()
        {
            return new Kilogram(this.Value * 14.593903);
        }

        public static implicit operator Slug(Kilogram kilogram)
        {
            return new Slug(kilogram.Value * 0.0685217659); // One kilogram is equal to 0.0685217659sl
        }

        public static implicit operator Slug(Pound pound)
        {
            // First converts pounds into kilos using the Convert()-method 
            // and then implicitly converts kg into slugs using the method above
            return pound.Convert(); 
        }

        public static implicit operator Slug(AtomicMass atomicMass)
        {
            return atomicMass.Convert(); 
        }

        public static implicit operator Slug(PlanckMass planckMass)
        {
            return planckMass.Convert();
        }

        public static implicit operator Slug(SolarMass solarMass)
        {
            return solarMass.Convert();
        }

        public static implicit operator Slug(Tonne tonne)
        {
            return tonne.Convert();
        }

        #endregion

        public override string ToString()
        {
            return Value + "sl";
        }
    }
}
