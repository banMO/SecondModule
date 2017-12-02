using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JalaFoundation.Dev23.Project2.ClassesO.Sealed
{
    class Class: NonSealed
    {
        public sealed override void DoSomething()//virtual sobreeescrito
        {
            Console.WriteLine("class.Dosomt");
        }
    }
    class DerivesClass: Class
    {
        public sealed override void DoSomething()//virtual sobreeescrito
        {
            Console.WriteLine("class.Dosomt");
        }
    }
}
