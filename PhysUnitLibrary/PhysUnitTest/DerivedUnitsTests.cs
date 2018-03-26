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
        public void AreaTest()
        {
            double value1 = 100;
            double value2 = 300;

            Metre metre1 = new Metre(value1, 100, 600);
            Metre metre2 = new Metre(value2);

            PhysicalUnit physicalUnit = metre1 * metre2;

            bool isArea = physicalUnit.GetType() == typeof(Area);

            Assert.IsTrue(isArea);
        }

        [TestMethod]
        public void VelocityTest()
        {
            double value1 = 300;
            double value2 = 100;

            Metre metre = new Metre(value1);
            Second second = new Second(value2);

            PhysicalUnit physicalUnit = metre / second;

            bool isVelocity = physicalUnit.GetType() == typeof(Velocity);

            Assert.IsTrue(isVelocity);
        }

        [TestMethod]
        public void AccelerationTest()
        {
            double value1 = 300;
            double value2 = 100;

            Metre metre = new Metre(value1);
            Second second = new Second(value2);

            PhysicalUnit physicalUnit1 = second * second;
            PhysicalUnit physicalUnit2 = metre / (second * second);

            bool isAcceleration = physicalUnit2.GetType() == typeof(Acceleration);

            Assert.IsTrue(isAcceleration);
        }

        [TestMethod]
        public void RandomUnitTest()
        {
            double value1 = 300;
            double value2 = 100;

            Metre metre = new Metre(value1);
            Second second = new Second(value2);

            PhysicalUnit physicalUnit = metre / (second * second * second * second * second);

            Assert.AreEqual(physicalUnit.TimeDimension, -5);
        }

        //[TestMethod]
        //public void UnknownUnitTest()
        //{
        //    double value1 = 300;

        //    //double value2 = 100;

        //    Metre metre = new Metre(value1);
        //    int unknownUnitValue = 100;

        //    //Area area = new Area(0);
        //    Velocity velocity = new Velocity(0);

        //    //PhysicalUnit calculatedUnit = PhysicalUnit.GetUnknownUnit(area, metre, unknownUnitValue);
        //    PhysicalUnit calculatedUnit = PhysicalUnit.GetUnknownUnit(velocity, metre, unknownUnitValue);

        //    //Second second = new Second(value2);

        //    //PhysicalUnit x = calculatedUnit / second;

        //    Assert.Fail();
        //}
    }
}
