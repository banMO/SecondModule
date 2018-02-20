using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_sFinder
{
    public class FinderWords : IOptionFind
    { 
        public MyList<ResultText> FindAllCoincidence(MyList<string> blockLines, string wordFind, Configuration configuration)
        {
            return AllCoincidence(blockLines, wordFind, configuration);
        }

        public MyList<ResultText> FindWord(MyList<string> blockLines, string wordFind, Configuration configuration)
        { 
            return FindIsCaseSensitive(blockLines, wordFind, configuration);
        }

        private MyList<ResultText> FindIsCaseSensitive(MyList<string> blockLines, string wordFind, Configuration configuration)
        {
            var results = new MyList<ResultText>();
            var ResultText = new ResultText();
            int sizeWordFind = wordFind.Length;
            int sizeLine = 0;
            int numberLine = 0;
            string TextLine;
            char beforeWord;
            char laterWord;

            //foreach (var line in blockLines)
            while(blockLines.counter > 0)
            {
                var matchesPosition = new MyList<int>();
                numberLine++;
                //sizeLine = line.Length;
                TextLine = blockLines.Extraer();
                sizeLine = TextLine.Length;
                for (int i = 0; i <= sizeLine - sizeWordFind; i++)
                {
                    int j;
                    for (j = 0; j < sizeWordFind; j++)
                        if (TextLine[i + j] != wordFind[j])
                            break;

                    if (j == sizeWordFind)
                    {
                        matchesPosition.Insert(i + 1);
                    }
                }
                if (matchesPosition.counter != 0)
                { 
                    try
                    {
                        beforeWord = TextLine[TextLine.IndexOf(wordFind) - 1];
                    }
                    catch (Exception)
                    {
                        beforeWord = ' ';
                    }

                    try
                    {
                        laterWord = TextLine[TextLine.IndexOf(wordFind) + wordFind.Length];
                    }
                    catch (Exception)
                    {
                        laterWord = ' ';
                    }

                    if (beforeWord == ' ' && laterWord == ' ')
                    {
                         Console.WriteLine("NumberLIne: " + numberLine + " MatchesPosition " + matchesPosition.Extraer() + " WordFind " + wordFind + " Matches Poss Count: " + matchesPosition.counter);
                    }
                }
            }
            return results;
        }

        private MyList<ResultText> AllCoincidence(MyList<string> blocklines, string wordFind, Configuration configuration)
        {
            var ListOfResults = new MyList<ResultText>();
            var NumberLine = new MyList<int>();
            var NumberCol = new MyList<int>();
            var Result = new ResultText();
            var TextFindWord = new MyList<string>();
            string TextLine = "";
            int CountLine = 0;
            char beforeWord;
            char laterWord;
            StringComparison comp = StringComparison.Ordinal;

            bool IsWordFind;

            while (blocklines.counter > 0)
            {
                TextLine = blocklines.Extraer();

                IsWordFind = TextLine.Contains(wordFind);

                CountLine++;

                if (IsWordFind)
                {
                    try
                    {
                        beforeWord = TextLine[TextLine.IndexOf(wordFind) - 1];
                    }
                    catch (Exception)
                    {
                        beforeWord = ' ';
                    }

                    try
                    {
                        laterWord = TextLine[TextLine.IndexOf(wordFind) + wordFind.Length];
                    }
                    catch (Exception)
                    {
                        laterWord = ' ';
                    }

                    if (beforeWord == ' ' && laterWord == ' ')
                    {
                        NumberCol.Insert(TextLine.IndexOf(wordFind));
                        NumberLine.Insert(CountLine);
                        TextFindWord.Insert(TextLine);

                        Result.AmountLine = 0;
                        Result.Text = TextFindWord;
                        Result.NumberCol = NumberCol;
                        Result.NumberLine = NumberLine;


                        ListOfResults.Insert(Result);
                    }
                }
            }

            return ListOfResults;
        }
    }
}
