using SoftPhone.Common.SipClientModels.Headers.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftPhone.Common.SipClientModels.Headers.SipBodyHeaders
{
    public class SdpVersion : HeaderBase
    {
        private const int Version = 0
            ;
        public SdpVersion()
        {
            HeaderPrefix = "v=";
        }

        public override string GetHeader() => $"{HeaderPrefix}{Version}";
    }
}
