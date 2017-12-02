using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamBanana.ChaukaApp
{
    public class User
    {
        string name;
        string email;
        List<Invitation> invitations;
        List<Location> locations;

        public User(string name, string email)
        {
            this.name = name;
            this.email = email;
            invitations = new List<Invitation>();
        }
        
        public List<Invitation> getInvitations()
        {
            return invitations;
        }

        public void setInvitation(Invitation invitation)
        {
            this.invitations.Add(invitation);
        }
    }
}
