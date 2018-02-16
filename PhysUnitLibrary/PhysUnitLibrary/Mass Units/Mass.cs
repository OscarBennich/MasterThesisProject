using PhysUnitLibrary.Mass_Units;
using System;

namespace PhysUnitLibrary
{
    public class Mass
    {   
        /// <summary>
        /// Adding two masses together
        /// </summary>
        /// <param name="mass1"></param>
        /// <param name="mass2"></param>
        /// <returns> A new value in kilogram </returns>
        public static Kilogram operator +(Mass mass1, Mass mass2)
        {
            if (mass1.GetType() == typeof(Pound) && mass2.GetType() == typeof(Kilogram))
            {
                Pound pound = (Pound)mass1;
                Kilogram kilogram = (Kilogram)mass2;
                Kilogram kilogramNew = new Kilogram((pound.Value * 0.45359237) + kilogram.Value); //One pound is equal to 0.45359237 kilograms
                return kilogramNew;
            }
            else if (mass1.GetType() == typeof(Kilogram) && mass2.GetType() == typeof(Pound))
            {               
                Kilogram kilogram = (Kilogram)mass1;
                Pound pound = (Pound)mass2;
                Kilogram kilogramNew = new Kilogram((pound.Value * 0.45359237) + kilogram.Value); 
                return kilogramNew;
            }
            else if (mass1.GetType() == typeof(Kilogram) && mass2.GetType() == typeof(Kilogram))
            {
                Kilogram kilogram1 = (Kilogram)mass1;
                Kilogram kilogram2 = (Kilogram)mass2;
                Kilogram kilogramNew = new Kilogram((kilogram1.Value) + kilogram2.Value); 
                return kilogramNew;
            }
            else if(mass1.GetType() == typeof(Pound) && mass2.GetType() == typeof(Pound))
            {
                Pound pound1 = (Pound)mass1;
                Pound pound2 = (Pound)mass2;
                Kilogram kilogramNew = new Kilogram((pound1.Value * 0.45359237) + (pound2.Value * 0.45359237)); 
                return kilogramNew;
            }

            else return null;
        }
    }
}
