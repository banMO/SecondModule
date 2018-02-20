using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_sFinder
{
    public class ResultText
    {
        public MyList<int> NumberLine { get; set; }
        public MyList<int> NumberCol { get; set; }
        public MyList<string> Text { get; set; }
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

        public ResultText(MyList<int> numberLine, MyList<int> numberCol, MyList<string> text, int amountLine)
        {
            NumberLine = numberLine;
            NumberCol = numberCol;
            Text = text;
            AmountLine = amountLine;
        }
    }
}
