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

        public override Kilogram Convert()
        {
            return new Kilogram(this.Value * 2.17647051 * Math.Pow(10, -8));
        }

        public override string ToString()
        {
            return Value + "mP";
        }
    }
}
