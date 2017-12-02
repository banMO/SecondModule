using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TeamBanana.ChaukaApp.Tests
{
    [TestClass]
    public class InvitationsServiceTests
    {
        [TestMethod]
        public void WHEN_INVITATION_IS_CREATED_RETURN_TRUE()
        {
            InvitationService invitationService = new InvitationService();
            Guest guest = new Guest("Bruce Camello", "bruce@gmail.com");
            Event ev = new Event("wally");
            Invitation invitation = invitationService.create(ev, guest);
            Assert.AreEqual("wally", invitation.getEvent().getName());
        }

        [TestMethod]
        public void WHEN_AN_INVITATION_IS_CREATED_DEFAULT_RESPONSE_IS_PENDING()
        {
            InvitationService invitationService = new InvitationService();
            Guest guest = new Guest("Cinthia Argote", "cinthia@gmail.com");
            Event ev = new Event("salchipapeada");
            Invitation invitation = invitationService.create(ev, guest);
            Assert.AreEqual("pending", invitation.getResponse());
        }

        [TestMethod]
        public void WHEN_CHANGE_RESPONSE_OF_INVITATION_TO_ACCEPTED_RETURN_ACCEPTED()
        {
            InvitationService invitationService = new InvitationService();
            Guest guest = new Guest("Gaia Antezana", "gaia@gmail.com");
            Event ev = new Event("wally");
            invitationService.create(ev, guest);
            invitationService.updateResponse(1, "accepted");
            Assert.AreEqual("accepted", invitationService.getResponse(1));
        }

        [TestMethod]
        public void WHEN_CHANGE_RESPONSE_OF_INVITATION_TO_REJECTED_RETURN_REJECTED()
        {
            InvitationService invitationService = new InvitationService();
            Guest guest = new Guest("William Wallas", "william@gmail.com");
            Event ev = new Event("futbol");
            invitationService.create(ev, guest);
            invitationService.updateResponse(1, "rejected");
            Assert.AreEqual("rejected", invitationService.getResponse(1));
        }
    }
}
