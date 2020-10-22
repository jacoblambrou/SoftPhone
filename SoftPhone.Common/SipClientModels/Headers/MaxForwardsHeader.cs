using SoftPhone.Common.SipClientModels.Headers.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftPhone.Common.SipClientModels.Headers
{
    public class MaxForwardsHeader : IHeader
    {
        private int _maxForwards = 70;

        public string GetHeader() => $"Max-Forwards: {_maxForwards}";
    }
}
