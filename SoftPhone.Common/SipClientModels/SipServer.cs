using System;
using System.Collections.Generic;
using System.Text;

namespace SoftPhone.Common.SipClientModels
{
    public class SipServer
    {
        public string SipServerAddress { get; set; }
        public string SipRegisterAddress { get; set; }
        public string Domain { get; set; }
        public int SipServerPort { get; set; }
        public int Expiry { get; set; } = 180;
    }
}
