using SoftPhone.Common.SipClientModels.Headers.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftPhone.Common.SipClientModels.Headers.SipHeaders
{
    public class AuthorizationHeader : HeaderBase
    {
        public AuthorizationHeader()
        {
            HeaderPrefix = "Authorization:";
        }
        public override string GetHeader() => $"{HeaderPrefix}";
    }
}
