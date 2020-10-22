using SoftPhone.Common.SipClientModels.Headers.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftPhone.Common.SipClientModels.Headers
{
    public class ContentLength : IHeader
    {
        private int _length;

        public ContentLength(SipBody body)
        {
            _length = body.GetLength();
        }

        public string GetHeader()
        {
            return $"Content-Length: {_length}";
        }
    }
}
