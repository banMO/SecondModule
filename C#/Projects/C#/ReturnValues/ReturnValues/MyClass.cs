using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnValues
{
    public class MyClass
    {
        private int value;
        public MyClass(int val)
        {
            value = val;

        }
        public int GetValueByVal()
        {
            return value;//Return by value
        }
        public ref int GetValueByRef()
        {
            return ref value;//Return by reference
        }


    }
}
