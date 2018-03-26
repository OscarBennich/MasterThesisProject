using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhysUnitLibrary;
using PhysUnitLibrary.Length_Units;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhysUnitTest
{   
    [TestClass]
    public class LengthTests
    {
        [TestMethod]
        [ExpectedException(typeof(OverMaxValueException))]
        public void LengthTestOverMax()
        {
            double value1 = 100;
            double value2 = 300;

            Metre metre1 = new Metre(value1, 100, 350);
            Metre metre2 = new Metre(value2);

            Kilometre kilometre = metre1 + metre2;

            Assert.AreEqual(expected: (value2 + value1) * kilometre.GetConversionFactor(), actual: kilometre.Value);
        }

        [TestMethod]
        public void LengthTestPassing()
        {
            double value1 = 100;
            double value2 = 300;

            Metre metre1 = new Metre(value1, 100, 600);
            Metre metre2 = new Metre(value2);

            Kilometre kilometre = metre1 + metre2;

            Assert.AreEqual(expected: (value2 + value1) * 1 / kilometre.GetConversionFactor(), actual: kilometre.Value);
        }
    }
}
