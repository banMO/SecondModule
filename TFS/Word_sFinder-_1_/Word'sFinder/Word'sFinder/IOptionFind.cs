using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_sFinder
{
    public interface  IOptionFind
    {
        Lista<ResultText> FindAllCoincidence(Lista<string> blockLines, string wordFind, Configuration configuration);
        Lista<ResultText> FindWord(Lista<string> blockLines, string wordFind, Configuration configuration);
    }
}
