using System;
using System.Collections.Generic;
using System.Text;

namespace SoftPhone.Common.SipClientModels
{
    public class SipSession
    {
        private readonly string _callId;
        private readonly int _listeningPort;
        private readonly CallDirection _callDirection;

        public SipMessage _sipMessage;

        public SipSession(string callId, int listeningPort, CallDirection callDirection)
        {
            _callId = callId;
            _listeningPort = listeningPort;
            _callDirection = callDirection;
        }
    }
}
