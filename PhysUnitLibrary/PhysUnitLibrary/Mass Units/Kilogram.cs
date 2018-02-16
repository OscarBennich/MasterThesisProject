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
    }
}
