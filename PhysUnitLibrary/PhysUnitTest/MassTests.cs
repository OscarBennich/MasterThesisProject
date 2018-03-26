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
        [ExpectedException(typeof(OverMaxValueException))]
        public void OverMaxAllowedRangeAdditonExceptionTest()
        {
            double value1 = 100;
            double value2 = 300;

            Kilogram kilogram1 = new Kilogram(value1); 
            Kilogram kilogram2 = new Kilogram(value2, 10,340); // Lowest allowed is 100, highest is 340

            Kilogram kilogram3 = kilogram1 + kilogram2;
                
            Assert.AreEqual(expected: value1 + value2, actual: kilogram3.Value); // Should fail because of the range
        }

        [TestMethod]
        [ExpectedException(typeof(UnderMinValueException))]
        public void UnderMinAllowedRangeSubtractionExceptionTest()
        {
            double value1 = 250;
            double value2 = 300;

            Kilogram kilogram1 = new Kilogram(value1); 
            Kilogram kilogram2 = new Kilogram(value2, 100, 340); 

            Kilogram kilogram3 = kilogram2 - kilogram1;

            Assert.AreEqual(expected: value2 - value1, actual: kilogram3.Value); // Should fail because of the range
        }

        [TestMethod]
        [ExpectedException(typeof(OverMaxValueException))]
        public void OverMaxAllowedRangePoundTest()
        {
            double value1 = 100;
            double value2 = 300;

            Kilogram kilogram1 = new Kilogram(value1, 100, 350);
            Kilogram kilogram2 = new Kilogram(value2);

            Pound pound = kilogram1 + kilogram2;

            Assert.AreEqual(expected: (value2 + value1) * pound.GetConversionFactor(), actual: pound.Value); // Should fail because of the range
        }

        //[TestMethod]
        //public void OverMaxAllowedRangeAddIntToTonne()
        //{
        //    Tonne tonne = new Tonne(2, 0.01, 9);

        //    try
        //    {
        //        tonne = (Tonne)(tonne + 5);
        //    }
        //    catch(Exception e)
        //    {
        //        Exception innerException = e.GetBaseException();
        //        Assert.IsTrue(true);
        //    }

        //   // Assert.AreEqual(expected: 7, actual: tonne.Value); // Should fail because of the range
        //}
    }
}
