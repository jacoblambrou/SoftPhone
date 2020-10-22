using SoftPhone.Common.SipClientModels.Headers.Abstractions;
using SoftPhone.Common.SipClientModels.UserAgents;

namespace SoftPhone.Common.SipClientModels.Headers
{
    public class ContactHeader : HeaderBase, IHeader
    {
        public ContactHeader(SipUserAgentClient sipUac, SipTransportManager sipTransportManager) : base (sipUac, sipTransportManager)
        {
            
        }

        public string GetHeader() => $"Contact: <{new SipUri(User, Address, SipProtocol).GetSipUri()}:{Port}>";
    }
}
