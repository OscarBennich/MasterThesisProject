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
        public double Value { get; private set; }

        public SolarMass(double value)
        {
            Value = value;
        }

        public override Kilogram Convert()
        {
            return new Kilogram(this.Value * 1.98855 * Math.Pow(10, 30));
        }

        public override string ToString()
        {
            return Value + "Mo";
        }
    }
}
