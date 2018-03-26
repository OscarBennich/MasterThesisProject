using PhysUnitLibrary.Length_Units;
using PhysUnitLibrary.SI_Derived_Units;
using PhysUnitLibrary.Time_Units;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhysUnitLibrary
{   
    /// <summary>
    /// The superclass for all units in the library
    /// </summary>
    public class PhysicalUnit
    {
        public double Value { get; protected set; } // The actual value of the unit, in its own quantity
        
        public int LengthDimension { get; protected set; }

        public int MassDimension { get; protected set; }

        public int TimeDimension { get; protected set; }    

        public double? MinValue { get; protected set; }

        public double? MaxValue { get; protected set; }

        public PhysicalUnit() { }

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

        public int[] GetDimensionArray()
        {
            return new int[] { LengthDimension, MassDimension, TimeDimension };
        }
           
        public static PhysicalUnit operator *(PhysicalUnit unit1, PhysicalUnit unit2)
        {
            int newLengthDimension = unit1.LengthDimension + unit2.LengthDimension;
            int newMassDimension = unit1.MassDimension + unit2.MassDimension;
            int newTimeDimension = unit1.TimeDimension + unit2.TimeDimension;

            int[] dimensionArray = new int[]
            {
                newLengthDimension,
                newMassDimension,
                newTimeDimension,
            };

            if(AllowedUnitsDictionary.GetUnit(dimensionArray) != null) // The operation is allowed
            {   
                Type physicalUnitType = AllowedUnitsDictionary.GetUnit(dimensionArray);
                double unitValue = unit1.Value * unit2.Value;
                PhysicalUnit physicalUnit = (PhysicalUnit)Activator.CreateInstance(physicalUnitType, new Object[] { unitValue }); // See https://stackoverflow.com/questions/752/get-a-new-object-instance-from-a-type

                return physicalUnit;
            }
            else
            {
                return new PhysicalUnit(unit1.Value * unit2.Value, newLengthDimension, newTimeDimension, newMassDimension);
            }
        }

        public static PhysicalUnit operator /(PhysicalUnit unit1, PhysicalUnit unit2)
        {
            int newLengthDimension = unit1.LengthDimension - unit2.LengthDimension;
            int newMassDimension = unit1.MassDimension - unit2.MassDimension;
            int newTimeDimension = unit1.TimeDimension - unit2.TimeDimension;
            
            int[] dimensionArray = new int[]
            {
                newLengthDimension,
                newMassDimension,
                newTimeDimension,
            };

            if (AllowedUnitsDictionary.GetUnit(dimensionArray) != null) // The operation is allowed
            {
                Type physicalUnitType = AllowedUnitsDictionary.GetUnit(dimensionArray);

                double unitValue = unit1.Value / unit2.Value;
                PhysicalUnit physicalUnit = (PhysicalUnit)Activator.CreateInstance(physicalUnitType, new Object[] { unitValue });

                return physicalUnit;
            }
            else
            {
                return new PhysicalUnit(unit1.Value / unit2.Value, newLengthDimension, newTimeDimension, newMassDimension);
            }
        }

        // Not sure how to do this in a better way (for now)
        public static PhysicalUnit GetUnknownUnit(PhysicalUnit result, PhysicalUnit knownUnit, int unknownUnitValue)
        {
            int newLengthDimension = result.LengthDimension - knownUnit.LengthDimension;
            int newMassDimension = result.MassDimension - knownUnit.MassDimension;
            int newTimeDimension = result.TimeDimension - knownUnit.TimeDimension;

            int[] dimensionArray = new int[]
            {
                newLengthDimension,
                newMassDimension,
                newTimeDimension,
            }; 

            if (AllowedUnitsDictionary.GetUnit(dimensionArray) != null) // Valid unit
            {
                Type physicalUnitType = AllowedUnitsDictionary.GetUnit(dimensionArray);

                double unitValue = unknownUnitValue;
                PhysicalUnit physicalUnit = (PhysicalUnit)Activator.CreateInstance(physicalUnitType, new Object[] { unitValue });

                return physicalUnit;
            }
            else
            {
                return new PhysicalUnit(unknownUnitValue, newLengthDimension, newTimeDimension, newMassDimension);
            }
        }
    }
}
