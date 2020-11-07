using SoftPhone.Common.SipClientModels.Headers.Abstractions;
using SoftPhone.Common.SipClientModels.UserAgents;

namespace SoftPhone.Common.SipClientModels.Headers
{
    public class StatusLine : HeaderBaseWithSipUri
    {
        private SipResponse _sipResponse;

        public StatusLine(SipUserAgentClient sipUac, SipTransportManager sipTransportManager, SipResponse sipResponse) : base(sipUac, sipTransportManager)
        {
            HeaderPrefix = "Status-Line:";
            _sipResponse = sipResponse;
        }

        public override string GetHeader() => $"{HeaderPrefix} {_sipResponse} {new SipUri(User, Address, SipProtocol).GetSipUri()}:{Port}";
    }
}
