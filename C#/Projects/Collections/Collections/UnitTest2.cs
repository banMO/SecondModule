using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;

namespace Collections
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void ArrayList()
        {
            var numbers = new ArrayList() { 1, 2, 3, 4 };
            numbers.Add(5);
            Console.WriteLine("ArrayList");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

        }
        [TestMethod]
        public void HashTable()
        {
            var numbers = new Hashtable { ["aa"] = "one", ["ab"] = "two", ["ac"] = "three" };
            foreach (DictionaryEntry item in numbers)
            {
                Console.WriteLine(item.Key + "--"+ item.Value + "-hashCode"+ item.Key.GetHashCode());
            }
        }

        [TestMethod]
        public void Queue()
        {
            var numbers = new Queue();
            numbers.Enqueue(3);
            numbers.Enqueue(2);
            numbers.Enqueue(1);
            numbers.Enqueue(0);
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            //numbers.Dequeue();
            var num = (int)numbers.Peek();
            Assert.AreEqual(3, num);
            Assert.AreEqual(4, numbers.Count);

            var num2 = (int)numbers.Dequeue();
            Assert.AreEqual(3, numbers.Count);

            Console.WriteLine("Queue");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

        }

        [TestMethod]
        public void Stack()
        {
            var numbers = new Stack();
            numbers.Push(3);
            numbers.Push(2);
            numbers.Push(1);

            Console.WriteLine("Stack");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            var num = numbers.Pop();
            Assert.AreEqual(1, num);
            Assert.AreEqual(2, numbers.Count);



        }


    }
}
