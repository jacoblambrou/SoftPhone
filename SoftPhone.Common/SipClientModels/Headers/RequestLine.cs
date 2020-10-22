using SoftPhone.Common.SipClientModels.Headers.Abstractions;
using SoftPhone.Common.SipClientModels.UserAgents;

namespace SoftPhone.Common.SipClientModels.Headers
{
    public class RequestLine : StatusRequestLineHeaderBase, IHeader
    {
        public RequestLine(SipUserAgentClient sipUac, SipTransportManager sipTransportManager, SipMethod sipMethod) : base (sipUac, sipTransportManager, sipMethod)
        {
            
        }

        public string GetHeader()
        {
            return $"Request-Line: {new SipUri(User, Address, SipProtocol).GetSipUri()}:{Port}";
        }
    }
}
