using SoftPhone.Common.SipClientModels.Headers.Abstractions;
using SoftPhone.Common.StringHelpers;
using System;

namespace SoftPhone.Common.SipClientModels.Headers.SipHeaders
{
    public class CallIdHeader : HeaderBase, IHashHeaderGenerator
    {
        private readonly string callId;

        public CallIdHeader()
        {
            HeaderPrefix = "Call-ID:";
            this.callId = GenerateUniqueHash();
        }

        public string GenerateUniqueHash() => HashGenerator.ConvertToHash($"{DateTime.Now:dd/MM/yyyy HH:mm:ss.fff}{Guid.NewGuid()}");

        public override string GetHeader() => $"{HeaderPrefix} {this.callId}";
    }
}
