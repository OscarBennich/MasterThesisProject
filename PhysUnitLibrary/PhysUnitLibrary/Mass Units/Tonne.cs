using System;
using System.Collections.Generic;
using System.Text;

namespace PhysUnitLibrary.Mass_Units
{
    class Tonne : Mass
    {
        public double Value { get; private set; }

        public Tonne(double value)
        {
            Value = value;
        }
    }
}
