using SoftPhone.Common.SipClientModels.Enums;
using SoftPhone.Common.SipClientModels.SipMessages;
using SoftPhone.Common.SipClientModels.UserAgents;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SoftPhone.Common.SipClientModels
{
    public class SipSession
    {
        private readonly string callId;
        private readonly CallDirection callDirection;

        public LocalSipUserAgentServer LocalSipUas;
        public RemoteSipUserAgentServer RemoteSipUas;
        public SipTransportManager TransportManager;

        public bool Busy = false;
        public SipMessage SipMessage { get; private set; }

        public SipSession(LocalSipUserAgentServer localSipUas, RemoteSipUserAgentServer remoteSipUas, CallDirection callDirection)
        {
            this.LocalSipUas = localSipUas;
            this.RemoteSipUas = remoteSipUas;
            this.callDirection = callDirection;

            if (callDirection == CallDirection.Outgoing)
            {
                this.SipMessage = new SipMessage(localSipUas, remoteSipUas,);
            }
            
        }

        public async Task SendSipMessageAsync()
        {
            await TransportManager.SendSipMessageAsync(SipMessage);
        }
    }
}
