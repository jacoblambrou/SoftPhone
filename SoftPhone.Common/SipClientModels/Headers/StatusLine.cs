using SoftPhone.Common.SipClientModels.Headers.Abstractions;
using SoftPhone.Common.SipClientModels.UserAgents;

namespace SoftPhone.Common.SipClientModels.Headers
{
    public class StatusLine : StatusRequestLineHeaderBase, IHeader
    {
        public StatusLine(SipUserAgentClient sipUac, SipTransportManager sipTransportManager, SipMethod sipMethod) : base (sipUac, sipTransportManager, sipMethod)
        {

        }

        public string GetHeader()
        {
            return $"Status-Line: {new SipUri(User, Address, SipProtocol).GetSipUri()}:{Port}";
        }
    }
}
