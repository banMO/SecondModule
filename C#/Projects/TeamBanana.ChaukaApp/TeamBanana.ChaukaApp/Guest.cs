using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamBanana.ChaukaApp
{
    public class Guest: User
    {
        Invitation invitation;

        public Guest(string name, string email): base(name, email)
        {

        }

        public Invitation getInvitation()
        {
            return this.invitation;
        }
    }
}
