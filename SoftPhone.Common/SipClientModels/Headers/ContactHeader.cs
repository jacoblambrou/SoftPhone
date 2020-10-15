using SoftPhone.Common.SipClientModels.Headers.Bases;
using SoftPhone.Common.SipClientModels.UserAgents;

namespace SoftPhone.Common.SipClientModels.Headers
{
    public class ContactHeader : HeaderBase
    {
        public ContactHeader(SipUserAgentClient sipUac, SipTransportManager sipTransportManager) : base (sipUac, sipTransportManager)
        {

        }
    }
}
