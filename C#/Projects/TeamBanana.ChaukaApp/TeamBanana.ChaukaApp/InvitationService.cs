using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamBanana.ChaukaApp
{
    public class InvitationService
    {
        FakeRepository fakeRepository = FakeRepository.Instance;
        public Invitation create(Event ev, Guest guest)
        {
            Invitation invitation = new Invitation(ev);
            guest.setInvitation(invitation);

            return fakeRepository.createInvitation(invitation);
        }

        public string updateResponse(int invitation_id, string response)
        {
            Invitation invitation = fakeRepository.GetInvitation(invitation_id);
            invitation.setResponse(response);

            return invitation.getResponse();
        }

        public string getResponse(int invitation_id)
        {
            Invitation invitation = fakeRepository.GetInvitation(invitation_id);
            return invitation.getResponse();
        }
    }
}