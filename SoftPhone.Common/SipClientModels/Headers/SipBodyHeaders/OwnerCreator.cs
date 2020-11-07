using SoftPhone.Common.SipClientModels.Headers.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftPhone.Common.SipClientModels.Headers.SipBodyHeaders
{
    public class OwnerCreator : HeaderBase
    {
        public OwnerCreator()
        {
            HeaderPrefix = "o=";
        }
        public override string GetHeader() => $"{HeaderPrefix}";
    }
}
