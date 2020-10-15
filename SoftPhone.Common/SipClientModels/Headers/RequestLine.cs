using SoftPhone.Common.SipClientModels.Headers.Bases;
using SoftPhone.Common.SipClientModels.UserAgents;

namespace SoftPhone.Common.SipClientModels.Headers
{
    public class RequestLine : StatusRequestLineHeaderBase
    {
        public string ConcatenateHeader => $"{Address}:{Port}";     // TODO: Update to use SipUri

        public RequestLine(SipUserAgentClient sipUac, SipTransportManager sipTransportManager, SipMethod sipMethod) : base (sipUac, sipTransportManager, sipMethod)
        {
            
        }
    }
}
