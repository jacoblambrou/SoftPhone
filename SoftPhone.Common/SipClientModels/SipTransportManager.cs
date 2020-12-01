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
        
        public SipProtocol SipProtocol;
        public SipTransport SipTransport;
        public UdpUser UdpUser;
        public UdpServer UdpServer;

        public SipTransportManager(SipProtocol sipProtocol, SipTransport sipTransport, int port)
        {
            this.udpClient = new UdpClientWithDisposedStatus(port);
            this.SipProtocol = sipProtocol;
            this.SipTransport = sipTransport;
            this.UdpUser = new UdpUser(udpClient);
            this.UdpServer = new UdpServer(udpClient);
        }

        internal async Task SendSipMessageAsync(SipMessage sipMessage)
        {
            await UdpUser.SendAsync();
        }
    }
}
