using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JalaFoundation.Dev23.Types.Tests
{
    [TestClass]
    public class ValueTypeTest
    {
        [TestMethod]
        public void TestMethod1ValueType()
        {
            int quantity = 10;
            Pay(quantity);
            Assert.AreEqual(10, quantity);
    
        }

        [TestMethod]
        public void TestMethod2ValueType()
        {
            bool accept = false;
            bool cancell = accept;
            cancell = true;
            Assert.AreEqual(false, accept);
        }

        private void Pay(int quantity)
        {
            quantity -= 5; 
        }
    }
}
