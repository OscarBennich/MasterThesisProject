using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhysUnitLibrary;
using PhysUnitLibrary.Exceptions;
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

        [TestMethod]
        public void UnknownUnitTest()
        {
            double value1 = 300;
            int unknownUnitValue = 100;

            Metre metre = new Metre(value1);         
            Velocity velocity = new Velocity(0);

            PhysicalUnit calculatedUnit = PhysicalUnit.GetUnknownUnit(velocity, metre, unknownUnitValue);

            int[] dimensionArray = calculatedUnit.GetDimensionArray(); // The uknown unit should be s^-1, because velocity is calculated as m/s

            Assert.AreEqual(expected: 0, actual: dimensionArray[0]);
            Assert.AreEqual(expected: 0, actual: dimensionArray[1]);
            Assert.AreEqual(expected: -1, actual: dimensionArray[2]); // Therefore this should be -1 in the dimension array for this unit
        }

        [TestMethod]
        public void AccelerationAdditionTest()
        {
            double value1 = 100;
            double value2 = 200;
            double value3 = 300;
            double value4 = 400;

            Metre metre1 = new Metre(value1);
            Second second1 = new Second(value2);

            Metre metre2 = new Metre(value3);
            Second second2 = new Second(value4);

            Acceleration acceleration1 = (Acceleration)(metre1 / (second1 * second1));
            Acceleration acceleration2 = (Acceleration)(metre2 / (second2 * second2));

            Acceleration acceleration3 = (Acceleration)(acceleration1 + acceleration2);

            Assert.AreEqual(expected: acceleration1.Value + acceleration2.Value, actual: acceleration3.Value);
        }

        [TestMethod]
        public void AccelerationMultiplicationTest()
        {
            double value1 = 100;
            double value2 = 200;
            double value3 = 300;
            double value4 = 400;

            Metre metre1 = new Metre(value1);
            Second second1 = new Second(value2);

            Metre metre2 = new Metre(value3);
            Second second2 = new Second(value4);

            Acceleration acceleration1 = (Acceleration)(metre1 / (second1 * second1));
            Acceleration acceleration2 = (Acceleration)(metre2 / (second2 * second2));

            Acceleration acceleration3 = (Acceleration)(acceleration1 + acceleration2);

            PhysicalUnit accelerationTest = acceleration1 * acceleration2;
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidUnitOperationException))]
        public void InvalidDerivedUnitAdditionTest()
        {
            Velocity velocity = new Velocity(0);     
            Acceleration acceleration = new Acceleration(0);

            PhysicalUnit physicalUnit = velocity + acceleration;
        }
    }
}
