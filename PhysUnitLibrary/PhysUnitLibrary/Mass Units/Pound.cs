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
    }
}
