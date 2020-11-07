using SoftPhone.Common.SipClientModels.Headers.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftPhone.Common.SipClientModels.Headers.SipBodyHeaders
{
    public class TimeDescription : HeaderBase
    {
        public TimeDescription()
        {
            HeaderPrefix = "t=";
        }
        public override string GetHeader() => $"{HeaderPrefix}";
    }
}
