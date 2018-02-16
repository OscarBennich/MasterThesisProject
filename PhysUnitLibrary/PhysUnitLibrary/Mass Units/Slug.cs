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
            return new Kilogram(this.Value * 14.593903);
        }

        public override string ToString()
        {
            return Value + "sl";
        }
    }
}
