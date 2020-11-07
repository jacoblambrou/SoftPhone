using SoftPhone.Common.SipClientModels.Headers.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftPhone.Common.SipClientModels.Headers.SipHeaders
{
    public class WwwAuthenticateHeader : HeaderBase
    {
        public WwwAuthenticateHeader()
        {
            HeaderPrefix = "WWW-Authenticate:";
        }

        public override string GetHeader()
        {
            throw new NotImplementedException();
        }
    }
}
