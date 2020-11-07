using SoftPhone.Common.SipClientModels.Headers.Abstractions;
using SoftPhone.Common.SipClientModels.UserAgents;

namespace SoftPhone.Common.SipClientModels.Headers
{
    public class FromHeader : HeaderBaseWithHash
    {
        private readonly string FriendlyName;

        public FromHeader(SipUserAgentClient sipUac, SipTransportManager sipTransportManager) : base(sipUac, sipTransportManager)
        {
            HeaderPrefix = "From:";

            if (!string.IsNullOrWhiteSpace(sipUac.SipUser.Name))
                FriendlyName = $"\"{sipUac.SipUser.Name}\" ";
        }

        public override string GetHeader() => $"{HeaderPrefix} {FriendlyName}<{new SipUri(User, Address, SipProtocol).GetSipUri()}>;{Tag}";
    }
}
