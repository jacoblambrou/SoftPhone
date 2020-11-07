using SoftPhone.Common.SipClientModels.Headers.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftPhone.Common.SipClientModels.Headers
{
    public class UserAgentHeader : IGetHeader
    {
        const string HeaderPrefix = "User-Agent:";
        const string Name = "Jakes Soft Phone";
        const string Version = "1.0.0";

        public string GetHeader()
        {
            return $"{HeaderPrefix} {Name}/{Version}";
        }
    }
}
