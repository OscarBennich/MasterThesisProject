using System;
using System.Collections.Generic;
using System.Text;

namespace PhysUnitLibrary.Mass_Units
{
    /// <summary>
    /// Unit of mass - Equal to 14.593903kg
    /// </summary>
    public class Slug : Mass
    {
        public double Value { get; private set; }

        public Slug(double value)
        {
            Value = value;
        }

        public override Kilogram Convert()
        {
            return new Kilogram(this.Value * 14.593903);
        }

        public override string ToString()
        {
            return Value + "sl";
        }
    }
}
