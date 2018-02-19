using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_sFinder
{
    public class Configuration : IConfiguration
    {
        public bool IsCaseSensitive { get; set; }
        public bool IsWholeWord { get; set; }
        public Configuration(bool isCaseSensitive, bool isWholeWord)
        {
            IsCaseSensitive = isCaseSensitive;
            IsWholeWord = isWholeWord;
        }
    }
}
