using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_sFinder
{
    public interface IReader
    {
        MyList<string> Read(string pathDirectory);
    }
}
