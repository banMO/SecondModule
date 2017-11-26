using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JalaFoundation.Dev23.Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //VALUE TYPES
            Console.WriteLine("Value Types");

            Console.WriteLine("Type Name = " + typeof(bool));
            Console.WriteLine("Is value type = " + typeof(bool).IsValueType);
            Console.WriteLine("Boolean value = " + bool.TrueString);
            Console.WriteLine("Boolean value = " + bool.FalseString);
            Console.WriteLine("Size = Uses " + sizeof(bool) + " to store a value");
            Console.WriteLine("------------------------------------- ");

            Console.WriteLine("Type Name = " + typeof(byte));
            Console.WriteLine("Min value = " + byte.MinValue);
            Console.WriteLine("Max value = " + byte.MaxValue);
            Console.WriteLine("Is value type = " +typeof(byte).IsValueType);
            Console.WriteLine("Size = Uses " + sizeof(byte) + " to store a value");
            Console.WriteLine("------------------------------------- ");

            Console.WriteLine("Type Name = " + typeof(sbyte));
            Console.WriteLine("Min value = " + sbyte.MinValue);
            Console.WriteLine("Max value = " + sbyte.MaxValue);
            Console.WriteLine("Is value type = " + typeof(sbyte).IsValueType);
            Console.WriteLine("Size = Uses " + sizeof(sbyte) + " to store a value");
            Console.WriteLine("------------------------------------- ");

            Console.WriteLine("Type Name = " + typeof(char));
            Console.WriteLine("Is value type = " + typeof(char).IsValueType);
            Console.WriteLine("Size = Uses " + sizeof(char) + " to store a value");
            Console.WriteLine("------------------------------------- ");

            Console.WriteLine("Type Name = " + typeof(decimal));
            Console.WriteLine("Min value = " + decimal.MinValue);
            Console.WriteLine("Max value = " + decimal.MaxValue);
            Console.WriteLine("Is value type = " + typeof(decimal).IsValueType);
            Console.WriteLine("Size = Uses " + sizeof(decimal) + " to store a value");
            Console.WriteLine("------------------------------------- ");

            Console.WriteLine("Type Name = " + typeof(double));
            Console.WriteLine("Min value = " + double.MinValue);
            Console.WriteLine("Max value = " + double.MaxValue);
            Console.WriteLine("Is value type = " + typeof(double).IsValueType);
            Console.WriteLine("Size = Uses " + sizeof(double) + " to store a value");
            Console.WriteLine("------------------------------------- ");

            Console.WriteLine("Type Name = " + typeof(float));
            Console.WriteLine("Min value = " + float.MinValue);
            Console.WriteLine("Max value = " + float.MaxValue);
            Console.WriteLine("Is value type = " + typeof(float).IsValueType);
            Console.WriteLine("Size = Uses " + sizeof(float) + " to store a value");
            Console.WriteLine("------------------------------------- ");

            Console.WriteLine("Type Name = " + typeof(int));
            Console.WriteLine("Min value = " + int.MinValue);
            Console.WriteLine("Max value = " + int.MaxValue);
            Console.WriteLine("Is value type = "+ typeof(int).IsValueType);
            Console.WriteLine("Size = Uses " + sizeof(int) + " to store a value");
            Console.WriteLine("------------------------------------- ");

            Console.WriteLine("Type Name = " + typeof(uint));
            Console.WriteLine("Min value = " + uint.MinValue);
            Console.WriteLine("Max value = " + uint.MaxValue);
            Console.WriteLine("Is value type = " + typeof(uint).IsValueType);
            Console.WriteLine("Size = Uses " + sizeof(uint) + " to store a value");
            Console.WriteLine("------------------------------------- ");

            Console.WriteLine("Type Name = " + typeof(long));
            Console.WriteLine("Min value = " + long.MinValue);
            Console.WriteLine("Max value = " + long.MaxValue);
            Console.WriteLine("Is value type = " + typeof(long).IsValueType);
            Console.WriteLine("Size = Uses " + sizeof(long) + " to store a value");
            Console.WriteLine("------------------------------------- ");

            Console.WriteLine("Type Name = " + typeof(ulong));
            Console.WriteLine("Min value = " + ulong.MinValue);
            Console.WriteLine("Max value = " + ulong.MaxValue);
            Console.WriteLine("Is value type = " + typeof(ulong).IsValueType);
            Console.WriteLine("Size = Uses " + sizeof(ulong) + " to store a value");
            Console.WriteLine("------------------------------------- ");

            Console.WriteLine("Type Name = " + typeof(short));
            Console.WriteLine("Min value = " + short.MinValue);
            Console.WriteLine("Max value = " + short.MaxValue);
            Console.WriteLine("Is value type = " + typeof(short).IsValueType);
            Console.WriteLine("Size = Uses " + sizeof(short) + " to store a value");
            Console.WriteLine("------------------------------------- ");

            Console.WriteLine("Type Name = " + typeof(ushort));
            Console.WriteLine("Min value = " + ushort.MinValue);
            Console.WriteLine("Max value = " + ushort.MaxValue);
            Console.WriteLine("Is value type = " + typeof(ushort).IsValueType);
            Console.WriteLine("Size = Uses " + sizeof(ushort) + " to store a value");
            Console.WriteLine("------------------------------------- ");

            //REFERENCE TYPES
            Console.WriteLine("Reference Types ");

            Console.WriteLine("Type Name = " + typeof(object));
            Console.WriteLine("Is value type = " + typeof(object).IsValueType);
            Console.WriteLine("------------------------------------- ");

            Console.WriteLine("Type Name = " + typeof(string));
            Console.WriteLine("Is value type = " + typeof(string).IsValueType);
            Console.WriteLine("------------------------------------- ");

            Console.ReadKey();
        }
    }
}
