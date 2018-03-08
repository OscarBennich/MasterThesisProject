using System;
using System.Collections.Generic;
using System.Text;

namespace PhysUnitLibrary.Length_Units
{
    /// <summary>
    /// One of 7 physical unit dimensions
    /// </summary>
    public abstract class Length : PhysicalUnit
    {
        public static Area operator *(Length firstLength, Length secondLength)
        {
            return new Area(firstLength.Value * secondLength.Value);
        }
    }
}
