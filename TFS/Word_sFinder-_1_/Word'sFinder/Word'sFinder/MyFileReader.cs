using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_sFinder
{
    public class MyFileReader : IReader
    {
        public MyList<string> Read(string pathDirectory)
        {
            StreamReader reader = new StreamReader(pathDirectory);
            string line = "";
            MyList<string> blockLines = new MyList<string>();

            while (line != null)
            {
                line = reader.ReadLine();
                if (line != null)
                    blockLines.Insert(line);
            }
            reader.Close();

            return blockLines;
        }
    }
}
