using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace SoftPhone.Data.Sockets
{
    public class UdpSocketSender
    {
        public static event Action<string> StatusUpdated;

        public static bool messageSent = false;
        static int s_listenPort = SIP.Server.Port;

        public static void SendCallback(IAsyncResult ar)
        {
            UdpClient u = (UdpClient)ar.AsyncState;

            StatusUpdated.Invoke($"number of bytes sent: {u.EndSend(ar)}");
            messageSent = true;
        }

        public static void SendMessage(string server, string message)
        {
            // create the udp socket
            UdpClient u = new UdpClient();

            byte[] sendBytes = Encoding.ASCII.GetBytes(message);

            // send the message
            // the destination is defined by the server name and port
            u.BeginSend(sendBytes, sendBytes.Length, server, s_listenPort, new AsyncCallback(SendCallback), u);
            int i = 0;
            // Do some work while we wait for the send to complete. For this example, we'll just sleep
            while (!messageSent)
            {
                if (i == 0)
                    StatusUpdated.Invoke("Sending message...");
                else
                    StatusUpdated.Invoke("Still sending...");

                Thread.Sleep(100);
                i++;
            }
            StatusUpdated.Invoke("Sending complete.");
        }
    }
}
