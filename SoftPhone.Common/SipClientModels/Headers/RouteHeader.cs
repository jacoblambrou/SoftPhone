using SoftPhone.Common.SipClientModels.Headers.Abstractions;
using SoftPhone.Common.SipClientModels.UserAgents;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftPhone.Common.SipClientModels.Headers
{
    public class RouteHeader : HeaderBase, IHeader
    {
        public RouteHeader(SipUserAgentClient sipUac, SipTransportManager sipTransportManager) : base(sipUac, sipTransportManager)
        {
        }

        public string GetHeader() => $"Route: <{new SipUri(User, Address, SipProtocol).GetSipUri()};lr";
    }
}
