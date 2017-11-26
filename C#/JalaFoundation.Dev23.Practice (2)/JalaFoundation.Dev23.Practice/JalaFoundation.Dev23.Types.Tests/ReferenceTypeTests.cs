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
            Student studen1 = new Student("Pepe");
            Student studen2 = studen1;

            AssignName(studen2);
            /*studen2 = new Student();
            studen2.Name = "Juan";*/

            Assert.AreEqual("Pepe", studen1.Name);
            Assert.AreEqual("Pepe", studen2.Name);
        }
        private void AssignName(Student student)
        {
            //student.Name = "Juan";
            student = new Student("Juan");

        }
        [TestMethod]
        public void TestMethod2()
        {
            Student studen1 = new Student("Pepe");
            Student studen2 = studen1;

            AssignName2(ref studen2);
            /*studen2 = new Student();
            studen2.Name = "Juan";*/

            Assert.AreEqual("Pepe", studen1.Name);
            Assert.AreEqual("Juan", studen2.Name);
        }
        private void AssignName2(ref Student student)
        {
            //student.Name = "Juan";
            student = new Student("Juan");

        }
        [TestMethod]
        public void TestMethod3()
        {
            Student studen1 = new Student("Pepe");
            Student studen2 = studen1;

            AssignName3(out studen2);
            /*studen2 = new Student();
            studen2.Name = "Juan";*/

            Assert.AreEqual("Pepe", studen1.Name);
            Assert.AreEqual("Juan", studen2.Name);
        }
        private void AssignName3(out Student student)
        {
            //student.Name = "Juan";
            student = new Student("Juan");
        }
    }
}
