using SoftPhone.Common.SipClientModels.Headers.Bases;
using SoftPhone.Common.SipClientModels.UserAgents;
using SoftPhone.Common.StringHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftPhone.Common.SipClientModels.Headers
{
    public class FromHeader : ToFromHeaderBase
    {
        private readonly string FriendlyName;
        public string ConcatenateHeader => $"From: {FriendlyName} <{new SipUri(User, Address, SipProtocol).ConcatenateSipUri}>;{Tag}";  // TODO: Update to use SipUri

        public FromHeader(SipUserAgentClient sipUac, SipTransportManager sipTransportManager) : base (sipUac, sipTransportManager)
        {
            if (!string.IsNullOrWhiteSpace(sipUac.SipUser.Name))
                FriendlyName = $"\"{sipUac.SipUser.Name}\"";
        }
    }
}
