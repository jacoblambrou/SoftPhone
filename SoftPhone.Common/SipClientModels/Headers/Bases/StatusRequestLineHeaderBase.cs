using SoftPhone.Common.SipClientModels.UserAgents;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftPhone.Common.SipClientModels.Headers.Bases
{
    public class StatusRequestLineHeaderBase : HeaderBase
    {
        public SipMethod SipMethod { get; private set; }

        public StatusRequestLineHeaderBase(SipUserAgentClient sipUac, SipTransportManager sipTransportManager, SipMethod sipMethod) : base (sipUac, sipTransportManager)
        {
            SipMethod = sipMethod;
        }
    }
}
