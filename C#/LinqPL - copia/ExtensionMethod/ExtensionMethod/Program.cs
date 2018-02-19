using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "43.35";
            double data = text.ToDouble();
            Console.WriteLine(data+2);
        }
    }

    public static class StringExtensions
    {
        static public double ToDouble(this string data)
        {
            double result = double.Parse(data);
            return result;
        }
    }
}
