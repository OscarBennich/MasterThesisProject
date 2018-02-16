using System;
using System.Collections.Generic;
using System.Text;

namespace PhysUnitLibrary.Mass_Units
{
    public class Tonne : Mass
    {
        public double Value { get; private set; }

        public Tonne(double value)
        {
            Value = value;
        }

        public override Kilogram Convert()
        {
            return new Kilogram(this.Value * 1000);
        }

        public override string ToString()
        {
            return Value + "t";
        }
    }
}
