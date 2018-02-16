using System;
using System.Collections.Generic;
using System.Text;

namespace PhysUnitLibrary
{
    public class Kilogram : Mass
    {
        public double Value { get; private set; }

        public Kilogram(double value)
        {
            Value = value;
        }

        public override Kilogram Convert()
        {
            return this;
        }

        public override string ToString()
        {
            return Value + "kg";
        }
    }
}
