using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace SoftPhone.Data.Transports.Udp
{
    public class UdpClientWithDisposedStatus : UdpClient
    {
        public bool IsDisposed { get; private set; } = false;

        public UdpClientWithDisposedStatus(int port) : base(port)
        {

        }

        public new void Dispose()
        {
            base.Close();
            base.Dispose();
            IsDisposed = true;
        }
    }
}
