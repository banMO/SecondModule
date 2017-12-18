using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JalaFoundation.SegurosApp
{
    sealed class Citizen : Person
    {
        public Citizen(string newName, int CI) : base(newName)
        {
            this.CI = CI;
        } 

        public int CI { get; set; }
    }
}
