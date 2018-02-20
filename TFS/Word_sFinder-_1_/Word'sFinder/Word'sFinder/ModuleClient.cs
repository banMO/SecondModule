using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_sFinder
{
    public class ModuleClient
    {
        IReader Reader = new MyFileReader();
        IOptionFind Finder = new FinderWords();
        
        public void FindAllCoincidence(string pathFile, string wordFind, Configuration configuration)
        {
            MyList<string> blockLines = Reader.Read(pathFile);
            MyList<ResultText> Result = new MyList<ResultText>();

            Result = Finder.FindAllCoincidence(blockLines, wordFind, configuration);

            if (Result.counter <= 0)
            {
                Console.WriteLine("0 Matches for that word.");
            }
            else
            {
                while (Result.counter > 0)
                {
                    ResultText ResultText = Result.Extraer();

                    Console.WriteLine("Match found in this line: " + ResultText.Text.Extraer());
                    Console.WriteLine("Col. Number: " + ResultText.NumberCol.Extraer());
                    Console.WriteLine("Line. Number: " + ResultText.NumberLine.Extraer());
                }
            }
        }

        public void FindWord(string pathFile, string wordFind, Configuration configuration)
        {
            MyList<string> blockLines = Reader.Read(pathFile);
            MyList<ResultText> Result = new MyList<ResultText>();

            Result = Finder.FindWord(blockLines, wordFind, configuration);

            if (Result.counter <= 0)
            {
                Console.WriteLine("0 Matches for that word.");
            }
            else
            {
                while (Result.counter > 0)
                {
                    ResultText ResultText = Result.Extraer();

                    Console.WriteLine("Match found in this line: " + ResultText.Text.Extraer());
                    Console.WriteLine("Col. Number: " + ResultText.NumberCol.Extraer());
                    Console.WriteLine("Line. Number: " + ResultText.NumberLine.Extraer());
                }
            }
        }
    }
}
