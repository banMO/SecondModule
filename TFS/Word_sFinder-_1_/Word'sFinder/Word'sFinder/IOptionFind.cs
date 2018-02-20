using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_sFinder
{
    public interface  IOptionFind
    {
        MyList<ResultText> FindAllCoincidence(MyList<string> blockLines, string wordFind, Configuration configuration);
        MyList<ResultText> FindWord(MyList<string> blockLines, string wordFind, Configuration configuration);
    }
}
