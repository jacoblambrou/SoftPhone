using SoftPhone.Common.SipClientModels.Headers.Abstractions;
using SoftPhone.Common.SipClientModels.UserAgents;

namespace SoftPhone.Common.SipClientModels.Headers.SipHeaders
{
    public class ContactHeader : HeaderBaseWithSipUri
    {
        public ContactHeader(SipUserAgentClient sipUac, SipTransportManager sipTransportManager) : base (sipUac, sipTransportManager)
        {
            HeaderPrefix = "Contact:";
        }

        public override string GetHeader() => $"{HeaderPrefix} <{new SipUri(User, Address, SipProtocol).GetSipUri()}:{Port}>";
    }
}
