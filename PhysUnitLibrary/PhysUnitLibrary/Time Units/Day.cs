﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PhysUnitLibrary.Time_Units
{
    class Day : Time
    {
        public double Value { get; private set; }

        public Day(double value)
        {
            Value = value;
        }

        public override Second Convert()
        {
            return new Second(Value * 86400);
        }
    }
}
