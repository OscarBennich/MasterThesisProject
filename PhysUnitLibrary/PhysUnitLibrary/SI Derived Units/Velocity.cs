﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PhysUnitLibrary.SI_Derived_Units
{
    public class Velocity : DerivedUnits
    {
        public Velocity(double value)
        {
            Value = value;
            LengthDimension = 1;
            TimeDimension = -1;
            MassDimension = 0;
        }
    }
}
