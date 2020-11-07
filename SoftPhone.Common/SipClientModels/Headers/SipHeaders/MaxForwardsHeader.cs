using SoftPhone.Common.SipClientModels.Headers.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftPhone.Common.SipClientModels.Headers.SipHeaders
{
    public class MaxForwardsHeader : HeaderBase
    {
        private int maxForwards = 70;

        public MaxForwardsHeader()
        {
            HeaderPrefix = "Max-Forwards:";
        }

        public override string GetHeader() => $"{HeaderPrefix} {this.maxForwards}";
    }
}
