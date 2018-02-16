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

        public override Kilogram Convert()
        {
            return new Kilogram(this.Value * 1.660539040 * Math.Pow(10, -27));
        }

        public override string ToString()
        {
            return Value + "u";
        }
    }
}
