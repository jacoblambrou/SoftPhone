using SoftPhone.Common.SipClientModels.Enums;
using SoftPhone.Common.SipClientModels.Headers.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftPhone.Common.SipClientModels.Headers.SipHeaders
{
    public class CSeqHeader : HeaderBase
    {
        private int cSeqNumber = 0;
        private SipMethod sipMethod;       //TODO: Get SipMethod

        public CSeqHeader(SipMethod sipMethod)
        {
            HeaderPrefix = "CSeq:";
            this.sipMethod = sipMethod;
        }

        public override string GetHeader() => $"{HeaderPrefix} {IncrementCSeq()} {this.sipMethod}";

        private int IncrementCSeq() => this.cSeqNumber++;
    }
}
