using SoftPhone.Common.SipClientModels.Headers.Abstractions;
using SoftPhone.Common.SipClientModels.UserAgents;
using SoftPhone.Common.StringHelpers;
using System;

namespace SoftPhone.Common.SipClientModels.Headers
{
    public class ToHeader : HashHeaderBase, IHeader, IHashHeaderGenerator
    {
        public ToHeader(SipUserAgentClient sipUac, SipTransportManager sipTransportManager) : base(sipUac, sipTransportManager)
        {
            
        }

        public string GetHeader()
        {
            return $"To: <{new SipUri(User, Address, SipProtocol).GetSipUri()}>;{Tag}";
        }
    }
}
