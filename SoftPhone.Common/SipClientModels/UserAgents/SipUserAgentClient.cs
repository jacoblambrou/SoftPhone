using System;
using System.Collections.Generic;
using System.Text;

namespace SoftPhone.Common.SipClientModels.UserAgents
{
    public class SipUserAgentClient
    {
        public SipUser SipUser { get; private set; }
        public LocalSipUserAgentServer LocalSipUas { get; private set; }
        public RemoteSipUserAgentServer RemoteSipUas { get; private set; }
        
        public SipUserAgentClient()
        {
            SipUser = new SipUser();
            LocalSipUas = new LocalSipUserAgentServer();
            RemoteSipUas = new RemoteSipUserAgentServer();
        }
    }
}
