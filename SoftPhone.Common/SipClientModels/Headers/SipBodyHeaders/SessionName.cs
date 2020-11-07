using SoftPhone.Common.SipClientModels.Headers.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftPhone.Common.SipClientModels.Headers.SipBodyHeaders
{
    public class SessionName : HeaderBase
    {
        private const string SessionNameValue = "clientMedia";

        public SessionName()
        {
            HeaderPrefix = "s=";
        }
        public override string GetHeader() => $"{HeaderPrefix}{SessionNameValue}";
    }
}
