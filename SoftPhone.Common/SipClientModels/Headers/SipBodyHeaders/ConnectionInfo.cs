using SoftPhone.Common.SipClientModels.Headers.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftPhone.Common.SipClientModels.Headers.SipBodyHeaders
{
    public class ConnectionInfo : HeaderBase
    {
        private const string Protocol = "IN IP4";
        private string address;     //TODO: Get address

        public ConnectionInfo()
        {
            HeaderPrefix = "c=";
        }
        public override string GetHeader() => $"{HeaderPrefix}{Protocol} {this.address}";
    }
}
