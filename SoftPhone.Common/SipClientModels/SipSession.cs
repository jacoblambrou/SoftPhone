using SoftPhone.Common.SipClientModels.Enums;
using SoftPhone.Common.SipClientModels.SipMessages;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftPhone.Common.SipClientModels
{
    public class SipSession
    {
        private readonly string callId;
        private readonly int listeningPort;
        private readonly CallDirection callDirection;

        public SipMessage SipMessage { get; private set; }

        public SipSession(string callId, int listeningPort, CallDirection callDirection)
        {
            this.callId = callId;
            this.listeningPort = listeningPort;
            this.callDirection = callDirection;
        }
    }
}
