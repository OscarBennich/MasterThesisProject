using System;
using System.Collections.Generic;
using System.Text;

namespace PhysUnitLibrary.Time_Units
{
    public class Second : Time
    {
        //public double Value { get; private set; }

        public Second(double value)
        {
            Value = value;
        }

        public override Second Convert()
        {
            return this;
        }
    }
}
