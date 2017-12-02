using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JalaFoundation.SegurosApp
{
    public sealed class Reservation
    {
        public Reservation(Patient patient, Doctor doctor, DateTime time)
        {
            this.patient = patient;
            this.doctor = doctor;
            this.time = time;
        }

        public Patient patient { get; set; }
        public Doctor doctor { get; set; }
        public DateTime time { get; set; }
    }

}
