using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JalaFoundation.Dev23.Practice3
{
    class Program
    {
        static void Main(string[] args)
        {
            var message = "Ana";
            var first = message.GetFirstLetter();
            Console.WriteLine(first);

            //Obtener la ultima letra de cada palabra
            var emerger = "Emerger du Chaos";
            var lastLetter = emerger.LastLetter();
            Console.WriteLine(lastLetter);

            //string: QuickSort
            var emerger1 = "Emerger";
            var result = emerger1.QuickSort();
            Console.WriteLine(result);

            //string: BubbleSort
           // var word = "Emerger";
           // var result = word

        }
    }
}
