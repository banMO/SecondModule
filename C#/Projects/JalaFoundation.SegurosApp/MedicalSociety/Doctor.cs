using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JalaFoundation.SegurosApp
{
    public class Doctor: Person
    {
        public Doctor( string name, int CI, TimeSpan startTime, TimeSpan endTime): base(name)
        {
            this.startTime = startTime;
            this.endTime = endTime;
        }

        public TimeSpan startTime { get; set;}
        public TimeSpan endTime { get; set; }
    }
}
