using SoftPhone.Common.SipClientModels.Headers.Abstractions;
using SoftPhone.Common.SipClientModels.UserAgents;
using SoftPhone.Common.StringHelpers;
using System;

namespace SoftPhone.Common.SipClientModels.Headers
{
    public class ViaHeader : HeaderBaseWithSipUri
    {
        private string Branch => HashGenerator.ConvertToHash($"{DateTime.Now:dd/MM/yyyy HH:mm:ss.fff}{Guid.NewGuid()}");
        private string RPort = "rport";
        private readonly SipTransport SipTransport;

        public ViaHeader(SipUserAgentClient sipUac, SipTransportManager sipTransportManager) : base(sipUac, sipTransportManager)
        {
            HeaderPrefix = "Via: SIP/2.0/";
            SipTransport = sipTransportManager.SipTransport;
        }

        public override string GetHeader() => $"{SipTransport} {Address}:{Port};{RPort};branch=z9hG4bK{Branch}";
    }
}
