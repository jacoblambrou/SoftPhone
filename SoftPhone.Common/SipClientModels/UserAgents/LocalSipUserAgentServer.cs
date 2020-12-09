using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace SoftPhone.Common.SipClientModels.UserAgents
{
    public class LocalSipUserAgentServer
    {
        public string Address { get; set; } = IPAddress.Any.ToString();
        public int SipPort { get; set; } = 5060;
        public int AudioStartPort { get; set; } = 20000;
        public int AudioEndPort { get; set; } = 20099;
        //TODO: public ISip State;
    }
}
