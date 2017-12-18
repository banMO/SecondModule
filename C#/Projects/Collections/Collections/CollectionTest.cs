using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Concurrent;
using System.Threading.Tasks;
using System.Threading;

namespace Collections
{
    [TestClass]
    public class CollectionTest
    {
        [TestMethod]
        public void CurrentBag()
        {
            var concurrentBag = new ConcurrentBag<int>();
            AutoResetEvent autoReset = new AutoResetEvent(false);
            Action action = () =>
            {
                for (int i = 1; i <= 5; i++)
                {
                    //Console.WriteLine("TID={0}", Thread.CurrentThread());
                    concurrentBag.Add(i);
                }
                autoReset.WaitOne();//se detiene
                 
                while(concurrentBag.TryTake(out int result))
                {
                    Console.WriteLine(result);
                }
            };

            Task task1 = Task.Factory.StartNew(action);

            Action action2 = () =>
            {
                for (int i = 6; i <= 100; i++)
                {
                    //Console.WriteLine("TID={0}",Thread.CurrentThread());
                    concurrentBag.Add(i);
                }
                autoReset.Set();//envia el evento
            };

            Task task2 = Task.Factory.StartNew(action2);

            Task.WaitAll(task1, task2);

            //task1.Wait();
           /* foreach (var item in concurrentBag)
            {
                Console.WriteLine(item);
            }*/
        }

        [TestMethod]
        public void BlockingCollection()
        {
            //esta coleccion    IDisposable
            //No deja a anoadir objetos
            using (var blockingCollection = new BlockingCollection<int>())
            {
                for(int i = 1; i <= 1000; i++)
                {
                    blockingCollection.Add(i);
                }
                blockingCollection.CompleteAdding();
                //blockingCollection.Add(456);
            
                Action action1 = () =>
                {
                    while(blockingCollection.TryTake(out int result))
                    {
                        Console.WriteLine(result);
                    }

                    /*foreach(var item in blockingCollection.GetConsumingEnumerable())
                    {
                        Console.WriteLine(item);
                    }*/
                    Assert.AreEqual(0, blockingCollection.Count);
                };

                Task task1 = Task.Factory.StartNew(action1);
                task1.Wait();
            }
        }

        [TestMethod]
        public void ConcurrentQueue()
        {
            var concurrentQueue1 = new ConcurrentQueue<int>();

            Action action1 = () => {
                for (int i = 1; i <= 100; i++)
                {
                    concurrentQueue1.Enqueue(i);
                }
            };

            Task task1 = Task.Factory.StartNew(action1);

            Action action2 = () =>
            {
                for (int i = 120; i <= 500; i++)
                {
                    concurrentQueue1.Enqueue(i);
                }
            };

            Task task2 = Task.Factory.StartNew(action2);
            Task.WaitAll(task1, task2);

            Action action3 = () =>
            {
                while (concurrentQueue1.TryDequeue(out int result))
                {
                    Console.WriteLine(result);
                }
            };

            Task task3 = Task.Factory.StartNew(action3);
            Action action4 = () =>
            {
                while (concurrentQueue1.TryDequeue(out int result))
                {
                    Console.WriteLine(result);
                }
            };
            Task task4 = Task.Factory.StartNew(action4);
            task1.Wait();
            task2.Wait();
            task3.Wait();
            task4.Wait();
        }
    }
}
