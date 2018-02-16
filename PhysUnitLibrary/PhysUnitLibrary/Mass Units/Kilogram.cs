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
        public double Value { get; private set; }

        public Kilogram(double value)
        {
            Value = value;
        }

        public override Kilogram Convert()
        {
            return this;
        }

        public static implicit operator Kilogram(AtomicMass atomicMass)
        {
            return new Kilogram(atomicMass.Value * 1.660539040 * Math.Pow(10, -27)); // One atomic mass is equal to 1.660539040 * 10^-27 kg
        }

        public static implicit operator Kilogram(PlanckMass planckMass)
        {
            return new Kilogram(planckMass.Value * 2.17647051 * Math.Pow(10, -8)); // One planck mass is equal to 2.17647051 * 10^-8 kg
        }

        public static implicit operator Kilogram(Pound pound)
        {
            return new Kilogram(pound.Value * 0.45359237); // One pound is equal to 0.45359237kg
        }

        public static implicit operator Kilogram(Slug slug)
        {
            return new Kilogram(slug.Value * 14.593903); // One slug is equal to 14.593903kg
        }

        public static implicit operator Kilogram(SolarMass solarMass)
        {
            return new Kilogram(solarMass.Value * 1.98855 * Math.Pow(10, 30)); // One solar mass is equal to 1.98855 * 10^30 kg
        }

        public static implicit operator Kilogram(Tonne tonne)
        {
            return new Kilogram(tonne.Value * 1000); // One tonne is equal to 1000kg
        }

        public override string ToString()
        {
            return Value + "kg";
        }
    }
}
