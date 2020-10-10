using System;
using System.Collections.Generic;
using System.Text;

namespace SoftPhone.Common.SipClientModels
{
    public class SipSession : IDisposable
    {
        public readonly string Branch;
        public readonly string Tag;
        public readonly string CallId;
        public readonly int ListeningPort;

        public SipSession(string branch, string tag, string callId, int listeningPort)
        {
            Branch = branch;
            Tag = tag;
            CallId = callId;
            ListeningPort = listeningPort;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
