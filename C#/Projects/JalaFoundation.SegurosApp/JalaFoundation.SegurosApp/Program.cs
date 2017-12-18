using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JalaFoundation.SegurosApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ReservationAgent reservationAgent = new ReservationAgent();
            reservationAgent.AddPacient("Raul Artero", 8675485);
            reservationAgent.AddPacient("Amalia Games", 8675000);
            reservationAgent.AddDoctor("Andres Koler", 2424204, new TimeSpan(8, 30, 00), new TimeSpan(10, 30, 00));
            reservationAgent.Reserve("Raul Artero", "Andres Koler", new DateTime(2017, 11, 20, 09, 00, 00));
            // doctor no existe
            reservationAgent.Reserve("Raul Artero", "Gabriel Gomez", new DateTime(2017, 11, 20, 09, 00, 00));
            // paciente no existe
            reservationAgent.Reserve("Olivia Manicone", "Andres Koler", new DateTime(2017, 11, 20, 09, 00, 00));
            // ya hizo una reserva
            reservationAgent.Reserve("Raul Artero", "Andres Koler", new DateTime(2017, 11, 20, 09, 00, 00));
            // hora ocupada
            reservationAgent.Reserve("Amalia Games", "Andres Koler", new DateTime(2017, 11, 20, 09, 00, 00));
        }
    }
}
