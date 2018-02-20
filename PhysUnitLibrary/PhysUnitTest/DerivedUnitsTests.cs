using Microsoft.VisualStudio.TestTools.UnitTesting;
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
        public void VelocityConversion()
        {
            int value1 = 100;
            int value2 = 100;

            Second second = new Second(value1);
            Metre metre = new Metre(value2);

            Velocity velocity = metre / second;

            Assert.AreEqual(expected: value1/value2, actual: velocity.Value);
        }
    }
}
