using System;
using System.Collections.Generic;
using System.Text;

namespace SoftPhone.Common.SipClientModels.UserAgents
{
    public class LocalSipUserAgentServer
    {
        public string Address { get; set; }
        public int SipPort { get; set; } = 39999;
        public int SipsPort { get; set; } = 39998;
        public int AudioStartPort { get; set; } = 20000;
        public int AudioEndPort { get; set; } = 20099;
        public string SipUserAgent { get; set; } = "Jakes SIP Client";
        //TODO: public ISip State;
    }
}
