using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReturnValues;

namespace TestReturnValues
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestWhereModifyValueRef()
        {
            var myClass = new MyClass(10);
            ref int b = ref myClass.GetValueByRef();
            b += 15;
            Assert.AreEqual(25, myClass.GetValueByVal());
        }
        [TestMethod]
        public void TestWhereModifyValue()
        {
            var myClass = new MyClass(10);
            int a = myClass.GetValueByVal();
            a -= 4;
            Assert.AreNotEqual(6, myClass.GetValueByVal());
        }

       
    }
}
