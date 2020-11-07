using SoftPhone.Common.SipClientModels.Enums;
using SoftPhone.Common.SipClientModels.Headers.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftPhone.Common.SipClientModels.Headers.SipBodyHeaders
{
    public class MediaAttribute : HeaderBase
    {
        private Codec codec;

        public MediaAttribute(Codec codec)
        {
            HeaderPrefix = "a=";
            this.codec = codec;
        }

        public override string GetHeader() => $"{HeaderPrefix}{codec}";
    }
}
