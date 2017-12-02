using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnValues
{
    class Program
    {
        static void Main(string[] args)
        {
            var message = "Hello";
            var first = message.GetFirstLetter();
            Console.WriteLine(first);
        }
    }
}
