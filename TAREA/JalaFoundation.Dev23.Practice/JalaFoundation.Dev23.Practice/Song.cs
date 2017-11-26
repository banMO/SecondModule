using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JalaFoundation.Dev23.Practice
{
    public class Song
    {
        public Song()
        {
            Name = "Emerger del Caos";
        }
        public Song(string name)
        {
            Name = name;
        }
        public string Name { get; set; }

    }
}
