using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_sFinder
{
    public class FinderWords : IOptionFind
    { 
        /// <summary>
        /// Find all matches by a line 
        /// </summary>
        /// <param name="blockLines"></param>
        /// <param name="wordFind"></param>
        /// <param name="configuration"></param>
        /// <returns></returns>
        public Lista<ResultText> FindAllCoincidence(Lista<string> blockLines, string wordFind, Configuration configuration)
        {
            return AllCoincidence(blockLines, wordFind, configuration);
        }

        public Lista<ResultText> FindWord(Lista<string> blockLines, string wordFind, Configuration configuration)
        {
            /*if (configuration.IsCaseSensitive)
            {
                return FindIsCaseSensitive(blockLines, wordFind, configuration);
            }
            else
            {
                Console.WriteLine("Entro");
                return FindIsNotCaseSensitive(blockLines, wordFind, configuration);
            }*/

            return FindIsCaseSensitive(blockLines, wordFind, configuration);
        }

        private Lista<ResultText> FindIsCaseSensitive(Lista<string> blockLines, string wordFind, Configuration configuration)
        {
            var results = new Lista<ResultText>();
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
                var matchesPosition = new Lista<int>();
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
                        matchesPosition.Insertar(i + 1);
                    }
                }
                if (matchesPosition.counter != 0)
                {
                    //ResultText.NumberLine = numberLine;

                    //results.Add(new ResultText(numberLine, matchesPosition, wordFind, matchesPosition.Count));
                    //results.Insertar(new ResultText());

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

        private Lista<ResultText> AllCoincidence(Lista<string> blocklines, string wordFind, Configuration configuration)
        {
            var ListOfResults = new Lista<ResultText>();
            var NumberLine = new Lista<int>();
            var NumberCol = new Lista<int>();
            var Result = new ResultText();
            var TextFindWord = new Lista<string>();
            string TextLine;
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
                        NumberCol.Insertar(TextLine.IndexOf(wordFind));
                        NumberLine.Insertar(CountLine);
                        TextFindWord.Insertar(TextLine);

                        Result.AmountLine = 0;
                        Result.Text = TextFindWord;
                        Result.NumberCol = NumberCol;
                        Result.NumberLine = NumberLine;


                        ListOfResults.Insertar(Result);
                    }
                }
            }

            return ListOfResults;
        }
    }
}
