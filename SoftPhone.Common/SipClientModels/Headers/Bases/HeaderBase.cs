using SoftPhone.Common.SipClientModels.UserAgents;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftPhone.Common.SipClientModels.Headers.Bases
{
    public class HeaderBase
    {
        public string User { get; private set; }                    // TODO: obtain User
        public string Address { get; private set; }
        public int Port { get; private set; }
        public SipProtocol SipProtocol { get; private set; }
        public SipUri SipUri { get; private set; }

        public HeaderBase(SipUserAgentClient sipUac, SipTransportManager sipTransportManager)
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

        public void SetSipUri(string user, string host, SipProtocol sipProtocol)
        {
            SipUri.SetSipUri(user, host, SipProtocol);
        }
    }
}
