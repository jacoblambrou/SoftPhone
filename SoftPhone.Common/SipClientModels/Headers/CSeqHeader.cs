using SoftPhone.Common.SipClientModels.Headers.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftPhone.Common.SipClientModels.Headers
{
    public class CSeqHeader : HeaderBase
    {
        private int _cSeqNumber = 0;
        private SipMethod _sipMethod;       //TODO: Get SipMethod

        public CSeqHeader()
        {
            HeaderPrefix = "CSeq:";
        }

        public override string GetHeader() => $"{HeaderPrefix} {IncrementCSeq()} {_sipMethod}";

        private int IncrementCSeq() => _cSeqNumber++;
    }
}
