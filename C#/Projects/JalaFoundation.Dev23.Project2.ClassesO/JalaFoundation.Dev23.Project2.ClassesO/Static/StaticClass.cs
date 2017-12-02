using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JalaFoundation.Dev23.Project2.ClassesO.Static
{
    static class StaticClass
    {
        static StaticClass()//sobreeescribimos ctor por defecto 
        {
            Value = 10;
        }
        public static int Value { get; set; }
    }
}
