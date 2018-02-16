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
        public double Value { get; private set; }

        public Tonne(double value)
        {
            Value = value;
        }

        #region Conversion Methods
        public override Kilogram Convert()
        {
            return new Kilogram(this.Value * 1000);
        }

        public static implicit operator Tonne(Kilogram kilogram)
        {
            return new Tonne(kilogram.Value / 1000); // One kg is equal to 0.001 tonnes
        }

        public static implicit operator Tonne(AtomicMass atomicMass)
        {
            return atomicMass.Convert();
        }

        public static implicit operator Tonne(Pound pound)
        {
            return pound.Convert();
        }

        public static implicit operator Tonne(PlanckMass planckMass)
        {
            return planckMass.Convert();
        }

        public static implicit operator Tonne(SolarMass solarMass)
        {
            return solarMass.Convert();
        }
#endregion

        public override string ToString()
        {
            return Value + "t";
        }
    }
}
