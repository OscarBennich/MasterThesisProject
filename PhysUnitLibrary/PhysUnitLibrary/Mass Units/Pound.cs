using System;
using System.Collections.Generic;
using System.Text;

namespace PhysUnitLibrary.Mass_Units
{
    public class Pound : Mass
    {
        public double Value { get; private set; }

        public Pound(double value)
        {
            Value = value;
        }

        public override Kilogram Convert()
        {
            return new Kilogram(this.Value * 0.45359237); //One pound is equal to 0.45359237 kilograms
        }

        public override string ToString()
        {
            return Value + "lb";
        }
    }
}
