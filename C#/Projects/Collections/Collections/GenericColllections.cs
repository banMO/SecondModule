using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Collections
{
    [TestClass]
    public class GenericColllections
    {
        [TestMethod]
        public void TestMethod1()
        {
            var numbers = new Dictionary<int, string>(){ [1] = "one",
                [2] = "two" } ;
            string strNumbers;
            numbers.TryGetValue(1, out strNumbers);
            Assert.AreEqual("one", strNumbers);

            numbers.TryGetValue(2, out strNumbers);
            Assert.AreEqual("two", strNumbers);

        }

        [TestMethod]
        public void DeleteValueFromList()
        {
            var list = new List<string>() { "uno", "dos", "hola", "hi" };
            
            /*foreach(var item in list)
            {
                if(item == "hola")
                {
                    list.Remove(item);
                    item.////no funciona solucion 
                }
            }*/
            for(var i = list.Capacity -1; i > 0; i--)
            {
                if (list[i] == "hola")
                {
                    list.Remove(list[i]);
                    
                }
            }
        }

        [TestMethod]
        public void GenericSortdedList()
        {
            var numbers = new SortedList<string, string>();
            numbers.Add("bb", "uno");
            numbers.Add("aa", "dos");
            numbers.Add("cc", "tres");

            foreach (var item in numbers)
            {
                Console.WriteLine(item.Key + "---" + item.Value);
            }
        }

        [TestMethod]
        public void Queue()
        { }
    }
}
