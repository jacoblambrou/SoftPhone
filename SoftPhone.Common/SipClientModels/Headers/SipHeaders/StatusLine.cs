using SoftPhone.Common.SipClientModels.Enums;
using SoftPhone.Common.SipClientModels.Headers.Abstractions;
using SoftPhone.Common.SipClientModels.UserAgents;

namespace SoftPhone.Common.SipClientModels.Headers.SipHeaders
{
    public class StatusLine : HeaderBaseWithSipUri
    {
        private SipResponseCode sipResponse;

        public StatusLine(SipUserAgentClient sipUac, SipTransportManager sipTransportManager, SipResponseCode sipResponse) : base(sipUac, sipTransportManager)
        {
            HeaderPrefix = "Status-Line:";
            this.sipResponse = sipResponse;
        }

        public override string GetHeader() => $"{HeaderPrefix} {this.sipResponse} {new SipUri(User, Address, SipProtocol).GetSipUri()}:{Port}";
    }
}
