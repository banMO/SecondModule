using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnValues
{
    public class OtherNamespace
    {
        public void Method1()
        {
            var message = "hello world";
            var first = message.GetFirstLetter();
        }
    }
}
