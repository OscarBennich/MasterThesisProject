using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhysUnitLibrary;
using PhysUnitLibrary.SI_Derived_Units;
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
        public void DimensionArrayTest()
        {
            Acceleration acceleration = new Acceleration(100);

            int[] dimensionArray = acceleration.GetDimensionArray();
            int[] accelerationArray = new int[] { 1, 0, -2 };
            
            Assert.AreEqual(expected: 1, actual: dimensionArray[0]);
            Assert.AreEqual(expected: 0, actual: dimensionArray[1]);
            Assert.AreEqual(expected: -2, actual: dimensionArray[2]);
        }
    }
}
