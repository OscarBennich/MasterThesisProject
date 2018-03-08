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

            Velocity velocity = metre / second;

            Assert.AreEqual(expected: value1 / value2, actual: velocity.Value);
        }

        [TestMethod]
        public void ForceTest()
        {
            PhysicalUnit acceleration = new Acceleration(20); 
            PhysicalUnit kilogram = new Kilogram(200);

            Force force = acceleration * kilogram; 

            Assert.AreEqual(expected: 20*200, actual: force.Value);
        }
    }
}
