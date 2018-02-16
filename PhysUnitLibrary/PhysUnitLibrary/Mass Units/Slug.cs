using System;
using System.Collections.Generic;
using System.Text;

namespace PhysUnitLibrary.Mass_Units
{
    public class Slug : Mass
    {
        public double Value { get; private set; }

        public Slug(double value)
        {
            Value = value;
        }

        public override Kilogram Convert()
        {
            return new Kilogram(this.Value * 14.593903); // One slug has the mass of 14.593903kg
        }

        public override string ToString()
        {
            return Value + "sl";
        }
    }
}
