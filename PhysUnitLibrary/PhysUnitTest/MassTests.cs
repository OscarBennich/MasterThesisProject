﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhysUnitLibrary;
using PhysUnitLibrary.Mass_Units;

namespace PhysUnitTest
{
    [TestClass]
    public class MassTests
    {
        [TestMethod]
        public void AddingKiloToPoundTest()
        {
            Kilogram mass1 = new Kilogram(500);
            Pound mass2 = new Pound(1000);

            Kilogram kilogram = mass1 + mass2;

            Assert.AreEqual(expected: mass1.Value + mass2.Value * 0.45359237, actual: kilogram.Value);
        }

        [TestMethod]
        public void AddingPoundToKiloTest()
        {
            Pound mass1 = new Pound(1000);
            Kilogram mass2 = new Kilogram(500);            

            Kilogram kilogram = mass1 + mass2;

            Assert.AreEqual(expected: mass1.Value * 0.45359237 + mass2.Value, actual: kilogram.Value);
        }

        [TestMethod]
        public void AddingKiloToKiloTest()
        {
            Kilogram mass1 = new Kilogram(500);
            Kilogram mass2 = new Kilogram(1000);

            Kilogram kilogram = mass1 + mass2;

            Assert.AreEqual(expected: mass1.Value + mass2.Value, actual: kilogram.Value);
        }

        [TestMethod]
        public void AddingPoundToPoundTest()
        {
            Pound mass1 = new Pound(500);
            Pound mass2 = new Pound(1000);

            Kilogram kilogram = mass1 + mass2;

            Assert.AreEqual(expected: mass1.Value * 0.45359237 + mass2.Value * 0.45359237, actual: kilogram.Value);
        }
    }
}
