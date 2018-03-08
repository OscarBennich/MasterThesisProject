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
        public void AreaEquation()
        {
            int value1 = 100;
            int value2 = 150;

            Length metre1 = new Metre(value1);
            Length metre2 = new Metre(value2);

            Area area = metre1 * metre2;

            Assert.AreEqual(expected: value1 * value2, actual: area.Value);
        }
    }
}
