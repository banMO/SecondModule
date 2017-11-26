using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JalaFoundation.Dev23.Practice;
namespace JalaFoundation.Dev23.Types.Tests
{
    [TestClass]
    public class BoxingUnBoxingTest
    {
        [TestMethod]
        public void TestMethod1BoingTest()
        {
           
            object newInt = 14;
            object newString = "Sosiego";
            Song first = new Song("Emerger");
            string aux = first.Name;
            object song = first;
            string type = newString.GetType().ToString();

            Assert.AreEqual(14, newInt);
            Assert.AreEqual("System.String", type );
            Assert.AreEqual("Emerger", aux);
            Assert.AreEqual("Emerger", ((Song)song).Name);
        }

       
      
    }
}
