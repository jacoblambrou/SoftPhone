using SoftPhone.Common.SipClientModels.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftPhone.Common.SipClientModels
{
    public class SipTransportManager
    {
        public SipProtocol SipProtocol;
        public SipTransport SipTransport;

        public SipTransportManager(SipProtocol sipProtocol, SipTransport sipTransport)
        {
            SipProtocol = sipProtocol;
            SipTransport = sipTransport;
        }
    }
}
