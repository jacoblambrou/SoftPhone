using SoftPhone.Common.SipClientModels.Headers.Abstractions;
using SoftPhone.Common.SipClientModels.UserAgents;

namespace SoftPhone.Common.SipClientModels.Headers
{
    public class RequestLine : HeaderBaseWithSipUri
    {
        private SipMethod _sipMethod;

        public RequestLine(SipUserAgentClient sipUac, SipTransportManager sipTransportManager, SipMethod sipMethod) : base (sipUac, sipTransportManager)
        {
            HeaderPrefix = "Request-Line:";
            _sipMethod = sipMethod;
        }

        public override string GetHeader() => $"{HeaderPrefix} {_sipMethod} {new SipUri(User, Address, SipProtocol).GetSipUri()}:{Port}";
    }
}
