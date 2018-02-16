using System;
using System.Collections.Generic;
using System.Text;

namespace PhysUnitLibrary.Mass_Units
{
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
