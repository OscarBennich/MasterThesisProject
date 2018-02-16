using Microsoft.VisualStudio.TestTools.UnitTesting;
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
        public void AddingPoundToPoundTest()
        {
            Pound mass1 = new Pound(500);
            Pound mass2 = new Pound(1000);

            Kilogram kilogram = mass1 + mass2;

            Assert.AreEqual(expected: mass1.Value * 0.45359237 + mass2.Value * 0.45359237, actual: kilogram.Value);
        }

        [TestMethod]
        public void AddingThreeMassesTest()
        {
            Pound mass1 = new Pound(500);
            Pound mass2 = new Pound(1000);
            Kilogram mass3 = new Kilogram(1500);

            Kilogram kilogram = mass1 + mass2 + mass3;

            Assert.AreEqual(expected: mass1.Value * 0.45359237 + mass2.Value * 0.45359237 + mass3.Value, actual: kilogram.Value);
        }

        public void AddingFourMassesTest()
        {
            Pound mass1 = new Pound(500);
            Pound mass2 = new Pound(1000);
            Kilogram mass3 = new Kilogram(1500);
            Kilogram mass4 = new Kilogram(3000);

            Kilogram kilogram = mass1 + mass2 + mass3 + mass4;

            Assert.AreEqual(expected: mass1.Value * 0.45359237 + mass2.Value * 0.45359237 + mass3.Value + mass4.Value, actual: kilogram.Value);
        }
    }
}
