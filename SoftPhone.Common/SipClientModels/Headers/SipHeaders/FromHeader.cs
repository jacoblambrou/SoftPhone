using SoftPhone.Common.SipClientModels.Enums;
using SoftPhone.Common.SipClientModels.Headers.Abstractions;
using SoftPhone.Common.SipClientModels.UserAgents;
using SoftPhone.Common.Utilities;

namespace SoftPhone.Common.SipClientModels.Headers.SipHeaders
{
    public class FromHeader : HeaderBaseWithHash, ILogger
    {
        private readonly string friendlyName;

        public FromHeader(SipUser sipUser, LocalSipUserAgentServer localSipUas, SipProtocol sipProtocol) : base(localSipUas, sipProtocol)
        {
            HeaderPrefix = "From:";

            if (!string.IsNullOrWhiteSpace(sipUser.Name))
                this.friendlyName = $"\"{sipUser.Name}\" ";
            else
                this.friendlyName = string.Empty;
        }

        public override string GetHeader() => $"{HeaderPrefix} {this.friendlyName}<{SipUri.GetSipUri()}>;{Tag}";

        public string Log()
        {
            throw new System.NotImplementedException();
        }
    }
}
