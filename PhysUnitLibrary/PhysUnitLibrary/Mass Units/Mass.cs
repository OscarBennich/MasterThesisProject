using PhysUnitLibrary.Mass_Units;
using System;

namespace PhysUnitLibrary
{
    public class Mass
    {
        public static Kilogram operator +(Mass kilogramIn, Mass poundIn)
        {
            Pound pound = (Pound)poundIn;
            Kilogram kilogram = (Kilogram)kilogramIn;

            Kilogram kilogramNew = new Kilogram((pound.Value * 0.45359237) + kilogram.Value); //One pound is equal to 0.45359237 kilograms
            return kilogramNew;
        }
    }
}
