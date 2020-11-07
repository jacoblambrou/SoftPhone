using SoftPhone.Common.SipClientModels.Headers.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftPhone.Common.SipClientModels.Headers.SipHeaders
{
    public class UserAgentHeader : HeaderBase
    {
        private const string Name = "Jakes Soft Phone";
        private const string Version = "1.0.0";

        public UserAgentHeader()
        {
            HeaderPrefix = "User-Agent:";
        }

        public override string GetHeader() => $"{HeaderPrefix} {Name}/{Version}";
    }
}
