using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamBanana.ChaukaApp
{
    public class Invitation
    {
        private string response;
        private Event ev;

        public Invitation(Event ev)
        {
            this.ev = ev;
            this.response = "pending";
        }

        public string getResponse()
        {
            return response;
        }

        public Event getEvent()
        {
            return ev;
        }

        public void setResponse(string response)
        {
            this.response = response;
        }
    }
}
