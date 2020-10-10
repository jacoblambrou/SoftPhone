using System;
using System.Collections.Generic;
using System.Text;

namespace SoftPhone.Common.SipClientModels
{
    public class SipProfile
    {
        public SipUser SipUser;
        public SipServer SipServer;
        public int SipListeningPort { get; set; } = 39999;
        public int SipsListeningPort { get; set; } = 39998;
        public int AudioStartPort { get; set; } = 20000;
        public int AudioEndPort { get; set; } = 20099;
        public string SipUserAgent { get; set; } = "Jakes SIP Client";
        public string SipServerWithPort
        {
            get
            {
                return $"{SipServer.SipServerAddress}:{SipServer.SipServerPort}";
            }
        }

        public SipProfile()
        {
            SipUser = new SipUser();
            SipServer = new SipServer();
        }
    }
}
