using System;
using System.Collections.Generic;
using System.Text;

namespace PhysUnitLibrary.Mass_Units
{
    /// <summary>
    /// Unit of mass - Equal to 1000kg
    /// </summary>
    public class Tonne : Mass
    {
        //public double Value { get; private set; }

        public Tonne(double value)
        {
            Value = value;
            LengthDimension = 0;
            TimeDimension = 0;
            MassDimension = 1;
        }

        public Tonne(double value, double minValue, double maxValue)
        {
            Value = value;
            LengthDimension = 0;
            TimeDimension = 0;
            MassDimension = 1;
            MinValue = minValue;
            MaxValue = maxValue;
        }

        #region Conversion Methods
        public override Kilogram Convert()
        {
            return new Kilogram(this.Value * 1000);
        }

        public static implicit operator Tonne(Kilogram kilogram)
        {
            return new Tonne(kilogram.Value / 1000); // One kg is equal to 0.001 tonnes
        }

        public static implicit operator Tonne(Pound pound)
        {
            return pound.Convert();
        }
#endregion

        public override string ToString()
        {
            return Value + "t";
        }
    }
}
