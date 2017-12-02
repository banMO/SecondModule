using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JalaFoundation.Dev23.Practice2.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 1412;
            object newInt = a;
            //object newInt2 = new int(1412);
            Assert.AreEqual(1412, (int)newInt);
        }
    }
}
