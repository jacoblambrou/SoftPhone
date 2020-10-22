using SoftPhone.Common.SipClientModels.Headers.Abstractions;
using SoftPhone.Common.SipClientModels.UserAgents;
using SoftPhone.Common.StringHelpers;
using System;

namespace SoftPhone.Common.SipClientModels.Headers
{
    public class ViaHeader : HeaderBase, IHeader
    {
        private string Branch => HashGenerator.ConvertToHash($"{DateTime.Now:dd/MM/yyyy HH:mm:ss.fff}{Guid.NewGuid()}");
        private string RPort = "rport";
        private readonly SipTransport SipTransport;
        public string ConcatenateHeader => $"Via: SIP/2.0/{SipTransport} {Address}:{Port};{RPort};branch=z9hG4bK{Branch}"; // TODO: Update to use SipUri

        public ViaHeader(SipUserAgentClient sipUac, SipTransportManager sipTransportManager) : base (sipUac, sipTransportManager)
        {
            SipTransport = sipTransportManager.SipTransport;
        }

        public string GetHeader() => $"Via: SIP/2.0/{SipTransport} {Address}:{Port};{RPort};branch=z9hG4bK{Branch}";
    }
}
