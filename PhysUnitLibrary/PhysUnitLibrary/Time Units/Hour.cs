using System;
using System.Collections.Generic;
using System.Text;

namespace PhysUnitLibrary.Time_Units
{
    class Hour : Time
    {
        public double Value { get; private set; }

        public Hour(double value)
        {
            Value = value;
        }

        public override Second Convert()
        {
            return new Second(Value * 3600);
        }
    }
}
