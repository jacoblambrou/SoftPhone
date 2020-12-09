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
        protected SipUri SipUri { get; set; }
        protected SipProtocol SipProtocol { get; set; }

        public HeaderBaseWithSipUri(LocalSipUserAgentServer localSipUas, SipProtocol sipProtocol)
        {
            this.Address = localSipUas.Address;
            this.Port = DefineSipPortBasedOnProtocol(sipProtocol, localSipUas);
            this.SipProtocol = sipProtocol;
        }

        private int DefineSipPortBasedOnProtocol(SipProtocol sipProtocol, LocalSipUserAgentServer localSipUac)
        {
            //if (sipProtocol == SipProtocol.sip)
                return localSipUac.SipPort;
            //else
            //    return localSipUac.SipsPort;
        }

        internal void SetUser(string user)
        {
            this.User = user;
            SetSipUri();
        }

        private void SetSipUri()
        {
            this.SipUri = new SipUri(User, Address, SipProtocol);
        }

        public abstract override string GetHeader();
    }
}
