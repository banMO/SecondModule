using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnValues
{
    public static class MyExtensions
    {
        public static string GetFirstLetter(this string str)
        {
            return str.Substring(0, 1);
        }

        /*public static void GetSomething()
        {

        }*/
    }
}
