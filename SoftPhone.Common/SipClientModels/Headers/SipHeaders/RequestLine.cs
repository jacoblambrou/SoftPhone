using SoftPhone.Common.SipClientModels.Enums;
using SoftPhone.Common.SipClientModels.Headers.Abstractions;
using SoftPhone.Common.SipClientModels.UserAgents;

namespace SoftPhone.Common.SipClientModels.Headers.SipHeaders
{
    public class RequestLine : HeaderBaseWithSipUri
    {
        private SipMethod sipMethod;

        public RequestLine(SipUserAgentClient sipUac, SipTransportManager sipTransportManager, SipMethod sipMethod) : base (sipUac, sipTransportManager)
        {
            HeaderPrefix = "Request-Line:";
            this.sipMethod = sipMethod;
        }

        public override string GetHeader() => $"{HeaderPrefix} {this.sipMethod} {new SipUri(User, Address, SipProtocol).GetSipUri()}:{Port}";
    }
}
