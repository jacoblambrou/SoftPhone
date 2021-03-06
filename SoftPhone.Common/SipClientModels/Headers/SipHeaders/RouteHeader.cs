﻿using SoftPhone.Common.SipClientModels.Enums;
using SoftPhone.Common.SipClientModels.Headers.Abstractions;
using SoftPhone.Common.SipClientModels.UserAgents;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftPhone.Common.SipClientModels.Headers.SipHeaders
{
    public class RouteHeader : HeaderBaseWithSipUri
    {
        public RouteHeader(LocalSipUserAgentServer localSipUas, SipProtocol sipProtocol) : base(localSipUas, sipProtocol)
        {
            HeaderPrefix = "Route:";
        }

        public override string GetHeader() => $"{HeaderPrefix} <{new SipUri(User, Address, SipProtocol).GetSipUri()};lr";
    }
}
