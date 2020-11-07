using SoftPhone.Common.SipClientModels.Headers.Abstractions;
using SoftPhone.Common.SipClientModels.UserAgents;
using SoftPhone.Common.StringHelpers;
using System;

namespace SoftPhone.Common.SipClientModels.Headers
{
    public class ToHeader : HeaderBaseWithHash
    {
        public ToHeader(SipUserAgentClient sipUac, SipTransportManager sipTransportManager) : base(sipUac, sipTransportManager)
        {
            HeaderPrefix = "To:";
        }

        public override string GetHeader() => $"{HeaderPrefix} <{new SipUri(User, Address, SipProtocol).GetSipUri()}>;{Tag}";
    }
}
