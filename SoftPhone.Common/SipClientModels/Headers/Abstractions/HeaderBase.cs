using SoftPhone.Common.SipClientModels.UserAgents;
using SoftPhone.Common.StringHelpers;
using System;

namespace SoftPhone.Common.SipClientModels.Headers.Abstractions
{
    public abstract class HeaderBase
    {
        protected string HeaderPrefix { get; set; }

        public abstract string GetHeader();
    }
}
