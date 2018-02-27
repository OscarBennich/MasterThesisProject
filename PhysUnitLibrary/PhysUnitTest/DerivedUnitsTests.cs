using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhysUnitLibrary;
using PhysUnitLibrary.Length_Units;
using PhysUnitLibrary.SI_Derived_Units;
using PhysUnitLibrary.Time_Units;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhysUnitTest
{   
    [TestClass]
    public class DerivedUnitsTests
    {
        [TestMethod]
        public void VelocityEquation()
        {
            int value1 = 100;
            int value2 = 100;

            PhysicalUnit second = new Second(value1);
            PhysicalUnit metre = new Metre(value2);

            Velocity velocity = metre / second; //should work (gives velocity, m/s)

            Assert.AreEqual(expected: value1/value2, actual: velocity.Value);
        }

        [TestMethod]
        public void IncorrectVelocityEquation()
        {
            int value1 = 100;
            int value2 = 100;

            PhysicalUnit second = new Second(value1);
            PhysicalUnit kilogram = new Kilogram(value2);

            Velocity velocity = kilogram / second; //should not work as kg / s does not give velocity

            Assert.AreEqual(expected: null, actual: velocity); //returns null for this division as it is not compatible
        }

    }
}
