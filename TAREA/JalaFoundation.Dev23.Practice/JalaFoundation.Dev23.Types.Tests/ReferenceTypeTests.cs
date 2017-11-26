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
            /*studen2 = new Student();
            studen2.Name = "Juan";*/

            Assert.AreEqual("Pepe", student1.Name);
            Assert.AreEqual("Pepe", student2.Name);
        }
        private void AssignName(Student student)
        {
            //student.Name = "Juan";
            student = new Student("Juan");

        }
        [TestMethod]
        public void TestMethod2()
        {
            Student student1 = new Student("Pepe");
            Student student2 = student1;

            AssignName2(ref student2);
            Assert.AreEqual("Pepe", student1.Name);
            Assert.AreEqual("Juan", student2.Name);
        }
        private void AssignName2(ref Student student)
        {
            student = new Student("Juan");
        }
        [TestMethod]
        public void TestMethod3()
        {
            Student student1 = new Student("Pepe");
            Student student2 = student1;

            AssignName3(out student2);       
            Assert.AreEqual("Pepe", student1.Name);
            Assert.AreEqual("Juan", student2.Name);
        }
        private void AssignName3(out Student student)
        {
            student = new Student("Juan");
        }
    }
}
