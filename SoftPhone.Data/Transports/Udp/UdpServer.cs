using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SoftPhone.Data.Transports.Udp
{
    public class UdpServer : UdpBase
    {
        public UdpServer(UdpClientWithDisposedStatus udpClient) : base(udpClient)
        {

        }

        public async Task ReceiveAsync()
        {
            OnStatusUpdated($"Starting UDP server...");

            var messageReceived = await UdpClient.ReceiveAsync();

            //await Task.Factory.StartNew(ReceiveAsync);

            var message = ConvertToString(messageReceived.Buffer, 0, messageReceived.Buffer.Length);
            var sender = messageReceived.RemoteEndPoint;

            OnStatusUpdated($"{sender}: {message}");
        }
    }
}
