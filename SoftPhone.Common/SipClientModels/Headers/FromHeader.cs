using SoftPhone.Common.SipClientModels.Headers.Abstractions;
using SoftPhone.Common.SipClientModels.UserAgents;

namespace SoftPhone.Common.SipClientModels.Headers
{
    public class FromHeader : HashHeaderBase, IHeader
    {
        private readonly string FriendlyName;

        public FromHeader(SipUserAgentClient sipUac, SipTransportManager sipTransportManager) : base(sipUac, sipTransportManager)
        {
            if (!string.IsNullOrWhiteSpace(sipUac.SipUser.Name))
                FriendlyName = $"\"{sipUac.SipUser.Name}\"";
        }

        public string GetHeader() => $"From: {FriendlyName} <{new SipUri(User, Address, SipProtocol).GetSipUri()}>;{Tag}";
    }
}
