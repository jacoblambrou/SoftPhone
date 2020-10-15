using System;
using System.Collections.Generic;
using System.Text;

namespace SoftPhone.Common.SipClientModels.UserAgents
{
    public class SipUserAgentClient
    {
        public SipUser SipUser;
        public LocalSipUserAgentServer LocalSipUas;
        public RemoteSipUserAgentServer RemoteSipUas;
        
        public SipUserAgentClient()
        {
            SipUser = new SipUser();
            LocalSipUas = new LocalSipUserAgentServer();
            RemoteSipUas = new RemoteSipUserAgentServer();
        }
    }
}
