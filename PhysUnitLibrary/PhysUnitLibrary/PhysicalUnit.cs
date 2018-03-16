using PhysUnitLibrary.Length_Units;
using PhysUnitLibrary.SI_Derived_Units;
using PhysUnitLibrary.Time_Units;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhysUnitLibrary
{
    public class PhysicalUnit
    {
        public double Value { get; protected set; }
        
        public int LengthDimension { get; protected set; }

        public int TimeDimension { get; protected set; }

        public int MassDimension { get; protected set; }

        public double? MinValue { get; protected set; }

        public double? MaxValue { get; protected set; }

        // Don't know about this, doing it for now
        public PhysicalUnit()
        {

        }

        public PhysicalUnit(double value, int lengthDimension, int timeDimension, int massDimension)
        {
            Value = value;
            LengthDimension = lengthDimension;
            TimeDimension = timeDimension;
            MassDimension = massDimension;
        }

        public PhysicalUnit(double value, int lengthDimension, int timeDimension, int massDimension, double minValue, double maxValue)
        {
            Value = value;
            LengthDimension = lengthDimension;
            TimeDimension = timeDimension;
            MassDimension = massDimension;
            MinValue = minValue;
            MaxValue = maxValue; 
        }

        #region Operators
        //early version, length in meters, time in seconds ONLY, should be for all kinds of lengths and all kinds of times
        public static Velocity operator /(PhysicalUnit unit1, PhysicalUnit unit2)
        {
            if (unit1.GetType() == typeof(Metre) && unit2.GetType() == typeof(Second))
            {
                return new Velocity(unit1.Value / unit2.Value);
            }
            else
            {
                return null;
            }
        }
        
        public static Force operator *(PhysicalUnit unit1, PhysicalUnit unit2)
        {
            if (unit1.GetType() == typeof(Kilogram) && unit2.GetType() == typeof(Acceleration) 
                || 
                unit1.GetType() == typeof(Acceleration) && unit2.GetType() == typeof(Kilogram))
            {
                return new Force(unit1.Value * unit2.Value);
            }
            else
            {
                return null;
            }
        }

        //public static PhysicalUnit operator /(PhysicalUnit unit1, PhysicalUnit unit2)
        //{

        //}

        //public static PhysicalUnit operator +(PhysicalUnit unit1, PhysicalUnit unit2)
        //{

        //}

        #endregion
    }
}
