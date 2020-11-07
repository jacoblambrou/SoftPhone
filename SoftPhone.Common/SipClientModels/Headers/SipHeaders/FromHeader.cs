using SoftPhone.Common.SipClientModels.Headers.Abstractions;
using SoftPhone.Common.SipClientModels.UserAgents;

namespace SoftPhone.Common.SipClientModels.Headers.SipHeaders
{
    public class FromHeader : HeaderBaseWithHash
    {
        private readonly string friendlyName;

        public FromHeader(SipUserAgentClient sipUac, SipTransportManager sipTransportManager) : base(sipUac, sipTransportManager)
        {
            HeaderPrefix = "From:";

            if (!string.IsNullOrWhiteSpace(sipUac.SipUser.Name))
                this.friendlyName = $"\"{sipUac.SipUser.Name}\" ";
        }

        public override string GetHeader() => $"{HeaderPrefix} {this.friendlyName}<{new SipUri(User, Address, SipProtocol).GetSipUri()}>;{Tag}";
    }
}
