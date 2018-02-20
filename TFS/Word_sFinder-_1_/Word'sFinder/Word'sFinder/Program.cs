using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_sFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            var ModuleClient = new ModuleClient();

            ModuleClient.FindAllCoincidence(@"C:\TextToFind.txt", "que", new Configuration(false, false));
        }
    }
}
