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
        public string LocalCli;
        public string RemoteCli;

        public bool IsBusy = false;                                   //TODO: Change to IState object
        public SipMessage SipMessage { get; private set; }

        public SipSession(SipUser sipUser, LocalSipUserAgentServer localSipUas, RemoteSipUserAgentServer remoteSipUas)
        {
            this.LocalSipUas = localSipUas;
            this.RemoteSipUas = remoteSipUas;
            this.TransportManager = new SipTransportManager(LocalSipUas.SipPort, RemoteSipUas.SipServerAddress, RemoteSipUas.SipPort);
            this.SipMessage = new SipMessage(sipUser, LocalSipUas, TransportManager, SipMethod.INVITE);
        }

        internal void UpdateRemoteCli(string cli)
        {
            SipMessage.UpdateRemoteCli(cli);
        }

        public async Task SendSipMessageAsync()
        {
            await TransportManager.SendSipMessageAsync(SipMessage);
        }
    }
}
