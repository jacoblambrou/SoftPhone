using SoftPhone.Common.SipClientModels.Headers.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftPhone.Common.SipClientModels.Headers.SipBodyHeaders
{
    public class MediaDescription : HeaderBase
    {
        public MediaDescription()
        {
            HeaderPrefix = "m=";
        }
        public override string GetHeader() => $"{HeaderPrefix}";
    }
}
