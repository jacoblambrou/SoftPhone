using SoftPhone.Common.SipClientModels.Enums;
using SoftPhone.Common.SipClientModels.Headers.Abstractions;
using SoftPhone.Common.SipClientModels.UserAgents;
using SoftPhone.Common.StringHelpers;
using System;

namespace SoftPhone.Common.SipClientModels.Headers.SipHeaders
{
    public class ViaHeader : HeaderBaseWithSipUri
    {
        private string branch => HashGenerator.ConvertToHash($"{DateTime.Now:dd/MM/yyyy HH:mm:ss.fff}{Guid.NewGuid()}");
        private string rPort = "rport";
        private readonly SipTransport sipTransport;

        public ViaHeader(LocalSipUserAgentServer localSipUas, SipProtocol sipProtocol, SipTransport sipTransport) : base(localSipUas, sipProtocol)
        {
            HeaderPrefix = "Via: SIP/2.0/";
            this.sipTransport = sipTransport;
        }

        public override string GetHeader() => $"{this.sipTransport} {Address}:{Port};{this.rPort};branch=z9hG4bK{this.branch}";
    }
}
