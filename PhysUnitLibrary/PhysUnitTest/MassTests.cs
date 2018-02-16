using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhysUnitLibrary;
using PhysUnitLibrary.Mass_Units;
using System;

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
        public void AddingPoundToPoundTest()
        {
            Pound mass1 = new Pound(500);
            Pound mass2 = new Pound(1000);

            Kilogram kilogram = mass1 + mass2;

            Assert.AreEqual(expected: mass1.Value * 0.45359237 + mass2.Value * 0.45359237, actual: kilogram.Value);
        }

        [TestMethod]
        public void AddingMoreThanTwoMassesTest()
        {
            Pound mass1 = new Pound(500);
            Pound mass2 = new Pound(1000);
            Kilogram mass3 = new Kilogram(1500);

            Kilogram kilogram = mass1 + mass2 + mass3;

            Assert.AreEqual(expected: mass1.Value * 0.45359237 + mass2.Value * 0.45359237 + mass3.Value, actual: kilogram.Value);
        }

        [TestMethod]
        public void AddingThreeDifferentMassesTest()
        {
            Pound mass1 = new Pound(500);
            Pound mass2 = new Pound(1000);
            Tonne mass3 = new Tonne(4); 

            Kilogram kilogram = mass1 + mass2 + mass3;

            Assert.AreEqual(expected: mass1.Value * 0.45359237 + mass2.Value * 0.45359237 + mass3.Value * 1000, actual: kilogram.Value);
        }

        [TestMethod]
        public void AddingPoundToSolarmassTest()
        {
            Pound mass1 = new Pound(500);
            SolarMass mass2 = new SolarMass(1);
            Tonne mass3 = new Tonne(400);
            SolarMass mass4 = new SolarMass(1.5);

            Kilogram kilogram = mass1 + mass2 + mass3 + mass4;

            Assert.AreEqual(expected: mass1.Value * 0.45359237 + (mass2.Value * 1.98855 * Math.Pow(10, 30)) + mass3.Value * 1000 + (mass4.Value * 1.98855 * Math.Pow(10, 30)), actual: kilogram.Value);
        }

        [TestMethod]
        public void AtomicMassTest()
        {
            AtomicMass mass1 = new AtomicMass(100000);
            AtomicMass mass2 = new AtomicMass(1000);

            Kilogram kilogram = mass1 + mass2;

            Assert.AreEqual(expected: (mass1.Value * 1.660539040 * Math.Pow(10, -27)) + (mass2.Value * 1.660539040 * Math.Pow(10, -27)), actual: kilogram.Value);
        }

        [TestMethod]
        public void AddingAllMassesTest()   
        {
            AtomicMass mass1 = new AtomicMass(100000000000000000);
            Kilogram mass2 = new Kilogram(400);
            PlanckMass mass3 = new PlanckMass(100000000000000000);
            Pound mass4 = new Pound(100);
            Slug mass5 = new Slug(50);
            SolarMass mass6 = new SolarMass(0.00000000000000000000000000001);
            Tonne mass7 = new Tonne(4);

            Kilogram kilogram = mass1 + mass2 + mass3 + mass4 + mass5 + mass6 + mass7;

            Assert.AreEqual(expected: (mass1.Value * 1.660539040 * Math.Pow(10, -27)) + (mass2.Value) + (mass3.Value * 2.17647051 * Math.Pow(10, -8)) + (mass4.Value * 0.45359237) + (mass5.Value * 14.593903) + (mass6.Value * 1.98855 * Math.Pow(10, 30) + (mass7.Value * 1000)), actual: kilogram.Value);
        }

        [TestMethod]
        public void AtomicMassAbbreviationTest()
        {
            AtomicMass atomicMass = new AtomicMass(1);
            Assert.AreEqual(expected: "1u", actual: atomicMass.ToString());
        }

        [TestMethod]
        public void KilogramAbbreviationTest()
        {
            Kilogram kilogram = new Kilogram(1);
            Assert.AreEqual(expected: "1kg", actual: kilogram.ToString());
        }

        [TestMethod]
        public void PlanckMassAbbreviationTest()
        {
            PlanckMass planckMass = new PlanckMass(1);
            Assert.AreEqual(expected: "1mP", actual: planckMass.ToString());
        }

        [TestMethod]
        public void PoundAbbreviationTest()
        {
            Pound pound = new Pound(1);
            Assert.AreEqual(expected: "1lb", actual: pound.ToString());
        }

        [TestMethod]
        public void SlugAbbreviationTest()
        {
            Slug slug = new Slug(1);
            Assert.AreEqual(expected: "1sl", actual: slug.ToString());
        }

        [TestMethod]
        public void SolarMassAbbreviationTest()
        {
            SolarMass solarMass = new SolarMass(1);
            Assert.AreEqual(expected: "1Mo", actual: solarMass.ToString());
        }

        [TestMethod]
        public void TonneAbbreviationTest()
        {
            Tonne tonne = new Tonne(1);
            Assert.AreEqual(expected: "1t", actual: tonne.ToString());
        }
    }
}
