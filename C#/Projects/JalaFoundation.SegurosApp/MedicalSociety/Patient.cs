using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JalaFoundation.SegurosApp
{
    public class Patient
    {
        public Patient(string name, int CI) 
        {
            this.name = name;
            this.CI = CI;
            this.code = this.name + "-" + this.CI;
        }

        public string code { get; set; }
        public string name { get; set; }
        public int CI { get; set; }
    }
}
