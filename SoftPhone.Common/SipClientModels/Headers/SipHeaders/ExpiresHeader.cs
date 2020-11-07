using SoftPhone.Common.SipClientModels.Headers.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftPhone.Common.SipClientModels.Headers.SipHeaders
{
    public class ExpiresHeader : HeaderBase
    {
        private int expiry = 180;

        public ExpiresHeader()
        {
            HeaderPrefix = "Expires:";
        }

        public override string GetHeader() => $"{HeaderPrefix} {this.expiry}";
    }
}
