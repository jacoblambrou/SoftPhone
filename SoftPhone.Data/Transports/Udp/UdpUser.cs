using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SoftPhone.Data.Transports.Udp
{
    public class UdpUser : UdpBase
    {
        public UdpUser(UdpClientWithDisposedStatus udpClient) : base(udpClient)
        {

        }

        public async Task SendAsync(string server, int serverPort, string message)
        {
            OnStatusUpdated("Sending UDP message...");
            byte[] sendBytes = ConvertToByteArray(message);

            await UdpClient.SendAsync(sendBytes, sendBytes.Length, server, serverPort);
            OnStatusUpdated("Sending complete.");
        }
    }
}
