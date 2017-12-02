using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamBanana.ChaukaApp
{
    public class Event
    {
        private string name;
        List<Guest> guests;
        private string description;
        DateTime startTime;
        string state;
        Location location;
        string place;

        public Event(string name)
        {
            this.name = name;
            guests = new List<Guest>();
        }

        public string getName()
        {
            return name;
        }

        public void addGuest(Guest guest)
        {
            guests.Add(guest);
        }
    }
}
