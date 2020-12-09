using System;
using System.Collections.Generic;
using System.Text;

namespace SoftPhone.Common.SipClientModels.UserAgents
{
    public class RemoteSipUserAgentServer
    {
        public string SipServerAddress { get; set; }
        public string RegisterAddress { get; set; }
        public string Domain { get; set; }
        public int SipPort { get; set; }
        public int Expiry { get; set; } = 180;
    }
}
