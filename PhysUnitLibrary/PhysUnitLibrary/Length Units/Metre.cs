﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PhysUnitLibrary.Length_Units
{
    public class Metre
    {
        public double Value { get; private set; }

        public Metre(double value)
        {
            Value = value;
        }
    }
}
