using SoftPhone.Common.SipClientModels.Enums;
using SoftPhone.Common.SipClientModels.UserAgents;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftPhone.Common.SipClientModels.Headers.Abstractions
{
    public abstract class HeaderBaseWithSipUri : HeaderBase
    {
        protected string User { get; set; }                    // TODO: obtain User
        protected string Address { get; set; }
        protected int Port { get; set; }
        protected SipProtocol SipProtocol { get; set; }

        public HeaderBaseWithSipUri(SipUserAgentClient sipUac, SipTransportManager sipTransportManager)
        {
            Address = sipUac.LocalSipUas.Address;
            Port = DefineSipPortBasedOnProtocol(sipTransportManager.SipProtocol, sipUac.LocalSipUas);
            SipProtocol = sipTransportManager.SipProtocol;
        }

        public int DefineSipPortBasedOnProtocol(SipProtocol sipProtocol, LocalSipUserAgentServer localSipUac)
        {
            if (sipProtocol == SipProtocol.sip)
                return localSipUac.SipPort;
            else
                return localSipUac.SipsPort;
        }

        public abstract override string GetHeader();
    }
}
