using SoftPhone.Common.SipClientModels.Headers.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftPhone.Common.SipClientModels.Headers
{
    public class CSeqHeader : IHeader
    {
        private int _cSeqNumber = 0;
        private SipMethod _sipMethod;

        public string GetHeader() => $"CSeq: {IncrementCSeq()} {_sipMethod}";

        private int IncrementCSeq() => _cSeqNumber++;
    }
}
