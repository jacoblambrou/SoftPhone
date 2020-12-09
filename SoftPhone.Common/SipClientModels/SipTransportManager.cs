using SoftPhone.Common.SipClientModels.Enums;
using SoftPhone.Common.SipClientModels.SipMessages;
using SoftPhone.Data.Transports.Udp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SoftPhone.Common.SipClientModels
{
    public class SipTransportManager
    {
        private UdpClientWithDisposedStatus udpClient;
        private string remoteServerAddress;
        private int remoteServerPort;

        public SipProtocol SipProtocol;
        public SipTransport SipTransport;
        public UdpUser UdpUser;
        public UdpServer UdpServer;

        public SipTransportManager(int localServerPort, string remoteServerAddress, int remoteServerPort, SipProtocol sipProtocol = SipProtocol.sip, SipTransport sipTransport = SipTransport.TCP)
        {
            this.udpClient = new UdpClientWithDisposedStatus(localServerPort);
            this.SipProtocol = sipProtocol;
            this.SipTransport = sipTransport;
            this.UdpUser = new UdpUser(udpClient);
            this.UdpServer = new UdpServer(udpClient);
            this.remoteServerAddress = remoteServerAddress;
            this.remoteServerPort = remoteServerPort;
        }

        internal async Task SendSipMessageAsync(SipMessage sipMessage)
        {
            await UdpUser.SendAsync(remoteServerAddress, remoteServerPort, sipMessage.GetSipMessage());
        }
    }
}
