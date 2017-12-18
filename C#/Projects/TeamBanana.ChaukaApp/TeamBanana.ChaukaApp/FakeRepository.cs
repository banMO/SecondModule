using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamBanana.ChaukaApp
{
    class FakeRepository : IRepository
    {
        Dictionary<int, Invitation> invitations = new Dictionary<int, Invitation>();
        private static FakeRepository instance;
        int index = 0;

        private FakeRepository() { }

        public static FakeRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FakeRepository();
                }
                return instance;
            }
        }

        public Invitation createInvitation(Invitation invitation)
        {
            index = index + 1;
            invitations.Add(index, invitation);
            return invitations.ElementAt(index).Value;
        }

        public Invitation GetInvitation(int id)
        {
            return invitations.ElementAt(id).Value;
        }

        public string SetInvitationResponse(int id, string response)
        {
            invitations.ElementAt(id).Value.setResponse(response);
            return invitations.ElementAt(id).Value.getResponse();
        }
    }
}
