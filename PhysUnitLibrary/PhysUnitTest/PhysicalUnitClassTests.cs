using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhysUnitLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhysUnitTest
{
    [TestClass]
    public class PhysicalUnitClassTests
    {
        [TestMethod]
        public void MinMaxValues()
        {
            PhysicalUnit physicalUnit1 = new PhysicalUnit(1, 1, 0, 0);
            PhysicalUnit physicalUnit2 = new PhysicalUnit(1, 1, 0, 0, 1, 1000);

            Assert.AreEqual(expected: null, actual: physicalUnit1.MaxValue);
            Assert.AreEqual(expected: 1000, actual: physicalUnit2.MaxValue);
        }

        [TestMethod]
        public void KilogramTest()
        {
            Kilogram kilogram = new Kilogram(40);

            Assert.AreEqual(expected: 1, actual: kilogram.MassDimension);
        }
    }
}
