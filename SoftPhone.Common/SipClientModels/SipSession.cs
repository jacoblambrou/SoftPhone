using System;
using System.Collections.Generic;
using System.Text;

namespace SoftPhone.Common.SipClientModels
{
    public class SipSession
    {
        public readonly string Tag;
        public readonly string CallId;
        public readonly int ListeningPort;

        public SipSession(string tag, string callId, int listeningPort)
        {
            Tag = tag;
            CallId = callId;
            ListeningPort = listeningPort;
        }
    }
}
