using SoftPhone.Common.SipClientModels.Headers.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftPhone.Common.SipClientModels.Headers
{
    public class ContentLength : HeaderBase
    {
        private int _length;

        public ContentLength(SipBody body)
        {
            HeaderPrefix = "Content-Length:";
            _length = body.GetLength();
        }

        public override string GetHeader() => $"{HeaderPrefix} {_length}";
    }
}
