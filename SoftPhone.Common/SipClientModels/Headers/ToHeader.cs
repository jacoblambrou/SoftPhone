using SoftPhone.Common.SipClientModels.Headers.Bases;
using SoftPhone.Common.SipClientModels.UserAgents;

namespace SoftPhone.Common.SipClientModels.Headers
{
    public class ToHeader : ToFromHeaderBase
    {
        public string ConcatenateHeader => $"To: <{new SipUri(User, Address, SipProtocol).ConcatenateSipUri}>;{Tag}";   // TODO: Update to use SipUri

        public ToHeader(SipUserAgentClient sipUac, SipTransportManager sipTransportManager) : base (sipUac, sipTransportManager)
        {
            
        }
    }
}
