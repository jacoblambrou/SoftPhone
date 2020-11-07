using SoftPhone.Common.SipClientModels.Headers.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftPhone.Common.SipClientModels.Headers
{
    public class ExpiresHeader : HeaderBase
    {
        private int _expiry = 180;

        public ExpiresHeader()
        {
            HeaderPrefix = "Expires:";
        }

        public override string GetHeader() => $"{HeaderPrefix} {_expiry}";
    }
}
