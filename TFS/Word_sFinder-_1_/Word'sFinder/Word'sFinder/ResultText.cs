using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_sFinder
{
    public class ResultText
    {
        public Lista<int> NumberLine { get; set; }
        public Lista<int> NumberCol { get; set; }
        public Lista<string> Text { get; set; }
        public int AmountLine { get; set; }

        /// <summary>
        ///  Constructor
        /// </summary>
        /// <param name="numberLine"></param>
        /// <param name="numberCol"></param>
        /// <param name="text"></param>
        /// <param name="amountLine"></param>
        /// 
        public ResultText()
        {

        }

        public ResultText(Lista<int> numberLine, Lista<int> numberCol, Lista<string> text, int amountLine)
        {
            NumberLine = numberLine;
            NumberCol = numberCol;
            Text = text;
            AmountLine = amountLine;
        }
    }
}
