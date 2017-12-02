using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JalaFoundation.SegurosApp
{
    public  class Person
    {
       
        public Person(string newName)
        {
            name = newName;
        }

        public string name { get; set; }
    }
}
