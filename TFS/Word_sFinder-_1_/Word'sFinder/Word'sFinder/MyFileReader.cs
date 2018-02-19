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
        public Lista<string> Read(string pathDirectory)
        {
            StreamReader objReader = new StreamReader(pathDirectory);
            string sLine = "";
            Lista<string> blockLines = new Lista<string>();

            while (sLine != null)
            {
                sLine = objReader.ReadLine();
                if (sLine != null)
                    blockLines.Insertar(sLine);
            }
            objReader.Close();

            return blockLines;
        }
    }
}
