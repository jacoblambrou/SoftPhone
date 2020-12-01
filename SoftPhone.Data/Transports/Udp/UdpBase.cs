using System;
using System.Collections.Generic;
using System.Text;

namespace SoftPhone.Data.Transports.Udp
{
    internal class UdpBase : TransportBase, IDisposable
    {
        protected UdpClientWithDisposedStatus UdpClient;

        public UdpBase(UdpClientWithDisposedStatus udpClient)
        {
            this.UdpClient = udpClient;
        }

        protected byte[] ConvertToByteArray(string message) => Encoding.ASCII.GetBytes(message);

        protected string ConvertToString(byte[] bytes, int index, int count) => Encoding.ASCII.GetString(bytes, index, count);

        public void Dispose()
        {
            this.UdpClient.Dispose();
        }
    }
}
