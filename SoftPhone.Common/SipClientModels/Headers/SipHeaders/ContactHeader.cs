using SoftPhone.Common.SipClientModels.Enums;
using SoftPhone.Common.SipClientModels.Headers.Abstractions;
using SoftPhone.Common.SipClientModels.UserAgents;

namespace SoftPhone.Common.SipClientModels.Headers.SipHeaders
{
    public class ContactHeader : HeaderBaseWithSipUri
    {
        public ContactHeader(LocalSipUserAgentServer localSipUas, SipProtocol sipProtocol) : base(localSipUas, sipProtocol)
        {
            HeaderPrefix = "Contact:";
        }

        public override string GetHeader() => $"{HeaderPrefix} <{SipUri.GetSipUri()}:{Port}>";
    }
}
