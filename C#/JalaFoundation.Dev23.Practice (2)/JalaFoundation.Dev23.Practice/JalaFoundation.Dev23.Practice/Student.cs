using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JalaFoundation.Dev23.Practice
{
    public class Student
    {

        public Student()
        {
            Name = "PEPEBYDEFAULT";
        }
        public Student(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
    }
}
