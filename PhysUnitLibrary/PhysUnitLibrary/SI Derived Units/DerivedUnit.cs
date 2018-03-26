using PhysUnitLibrary.Exceptions;
using PhysUnitLibrary.Length_Units;
using PhysUnitLibrary.Time_Units;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhysUnitLibrary.SI_Derived_Units
{   
    /// <summary>
    /// Units derived from the 7 base SI units
    /// </summary>
    public abstract class DerivedUnit : PhysicalUnit
    {
        public static DerivedUnit operator +(DerivedUnit firstDerivedUnit, DerivedUnit secondDerivedUnit)
        {   
            if(firstDerivedUnit.GetType().Equals(secondDerivedUnit.GetType()))
            {
                Type physicalUnitType = firstDerivedUnit.GetType();
                double unitValue = firstDerivedUnit.Value + secondDerivedUnit.Value;
                DerivedUnit derivedUnit = (DerivedUnit)Activator.CreateInstance(physicalUnitType, new Object[] { unitValue });
                return derivedUnit;
            }
            else
            {
                throw new InvalidUnitOperationException("This operation is not allowed"); 
            }
        }

        public static DerivedUnit operator -(DerivedUnit firstDerivedUnit, DerivedUnit secondDerivedUnit)
        {
            if (firstDerivedUnit.GetType().Equals(secondDerivedUnit.GetType()))
            {
                Type physicalUnitType = firstDerivedUnit.GetType();
                double unitValue = firstDerivedUnit.Value - secondDerivedUnit.Value;
                DerivedUnit derivedUnit = (DerivedUnit)Activator.CreateInstance(physicalUnitType, new Object[] { unitValue });
                return derivedUnit;
            }
            else
            {
                throw new InvalidUnitOperationException("This operation is not allowed");
            }
        }
    }
}
