using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JalaFoundation.Dev23.Project2.ClassesO.Static
{
    public class NonStatic /*: StaticClass*/
    {
        public NonStatic(int value)
        {
            Value2 = value;
        }
        public int Value { get; set; }
        public static int Value2 { get; set; }
        public static int GetProperty()
        {
            return Value2;
        }

    }
}
