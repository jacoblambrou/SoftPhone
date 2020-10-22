using SoftPhone.Common.SipClientModels.Headers.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftPhone.Common.SipClientModels.Headers
{
    public class ExpiresHeader : IHeader
    {
        private int _expiry = 180;

        public string GetHeader() => $"Expires: {_expiry}";
    }
}
