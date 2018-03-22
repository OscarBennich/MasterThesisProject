using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhysUnitLibrary;
using PhysUnitLibrary.Time_Units;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhysUnitTest
{
    [TestClass]
    public class TimeTests
    {
        [TestMethod]
        [ExpectedException(typeof(OverMaxValueException))]
        public void TimeTestOverMax()
        {
            double value1 = 100;
            double value2 = 300;

            Second second1 = new Second(value1, 100, 350);
            Second second2 = new Second(value2);

            Minute minute = second1 + second2;

            Assert.AreEqual(expected: (value2 + value1) * Minute.MinuteConversionFactor, actual: minute.Value);
        }

        [TestMethod]
        public void TimeTestPassing()
        {
            double value1 = 100;
            double value2 = 300;

            Second second1 = new Second(value1, 100, 600);
            Second second2 = new Second(value2);

            Minute minute = second1 + second2;

            Assert.AreEqual(expected: (value2 + value1) * 1 / Minute.MinuteConversionFactor, actual: minute.Value);
        }
    }
}
