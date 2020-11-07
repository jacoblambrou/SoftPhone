using SoftPhone.Common.SipClientModels.Headers.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftPhone.Common.SipClientModels.Headers
{
    public class MaxForwardsHeader : HeaderBase
    {
        private int _maxForwards = 70;

        public MaxForwardsHeader()
        {
            HeaderPrefix = "Max-Forwards:";
        }

        public override string GetHeader() => $"{HeaderPrefix} {_maxForwards}";
    }
}
