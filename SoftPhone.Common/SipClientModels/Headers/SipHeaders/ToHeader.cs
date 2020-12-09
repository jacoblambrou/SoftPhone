using SoftPhone.Common.SipClientModels.Enums;
using SoftPhone.Common.SipClientModels.Headers.Abstractions;
using SoftPhone.Common.SipClientModels.UserAgents;
using SoftPhone.Common.StringHelpers;
using System;

namespace SoftPhone.Common.SipClientModels.Headers.SipHeaders
{
    public class ToHeader : HeaderBaseWithHash
    {
        public ToHeader(LocalSipUserAgentServer localSipUas, SipProtocol sipProtocol) : base(localSipUas, sipProtocol)
        {
            HeaderPrefix = "To:";
        }

        public override string GetHeader() => $"{HeaderPrefix} <{new SipUri(User, Address, SipProtocol).GetSipUri()}>;{Tag}";
    }
}
