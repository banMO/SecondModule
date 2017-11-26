using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JalaFoundation.Dev23.Practice;

namespace JalaFoundation.Dev23.Types.Tests
{
    [TestClass]
    public class ReferenceTypeTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Student student1 = new Student("Pepe");
            Student student2 = student1;
            AssignName(student2);
            Assert.AreEqual(student1.Name, "Pepe");
            Assert.AreEqual(student2.Name, "Pepe");

        }

        private void AssignName(Student student)
        {
            student = new Student("Juan");
        }


    }
}