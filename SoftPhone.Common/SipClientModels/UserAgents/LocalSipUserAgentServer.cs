using System;
using System.Collections.Generic;
using System.Text;

namespace SoftPhone.Common.SipClientModels.UserAgents
{
    public class LocalSipUserAgentServer
    {
        public string Address { get; set; }
        public int SipPort { get; set; } = 39999;
        public int AudioStartPort { get; set; } = 20000;
        public int AudioEndPort { get; set; } = 20099;
        //TODO: public ISip State;
    }
}
