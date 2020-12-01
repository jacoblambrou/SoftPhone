using SoftPhone.Common.SipClientModels.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SoftPhone.Common.SipClientModels.UserAgents
{
    public class SipUserAgentClient
    {
        private int totalConcurrentSipSessions = 2;

        public SipUser SipUser { get; set; }
        public LocalSipUserAgentServer LocalSipUas { get; set; }
        public RemoteSipUserAgentServer RemoteSipUas { get; set; }
        public SipSession[] SipSessions { get; set; }

        public SipUserAgentClient()
        {
            SipUser = new SipUser();
            LocalSipUas = new LocalSipUserAgentServer();
            RemoteSipUas = new RemoteSipUserAgentServer();
            SipSessions = new SipSession[2];
        }

        public async Task DialAsync(string cli)
        {
            await CreateSipSessionAsync(CallDirection.Outgoing);
        }

        private async Task<bool> CreateSipSessionAsync(CallDirection callDirection)
        {
            for (int i = 0; i < totalConcurrentSipSessions; i++)
            {
                if (SipSessions[i] == null)
                {
                    SipSessions[i] = new SipSession(LocalSipUas, RemoteSipUas, callDirection);
                    return true;
                }
            }
            return false;
        }
    }
}
