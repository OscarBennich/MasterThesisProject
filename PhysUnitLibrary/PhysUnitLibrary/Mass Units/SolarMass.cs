using System;
using System.Collections.Generic;
using System.Text;

namespace PhysUnitLibrary.Mass_Units
{
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
