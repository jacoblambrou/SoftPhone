using SoftPhone.Common.SipClientModels.Headers.Abstractions;
using SoftPhone.Common.StringHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftPhone.Common.SipClientModels.Headers
{
    public class CallIdHeader : IHeader, IHashHeaderGenerator
    {
        private readonly string _callId;

        public CallIdHeader()
        {
            _callId = GenerateUniqueHash();
        }

        public string GenerateUniqueHash() => HashGenerator.ConvertToHash($"{DateTime.Now:dd/MM/yyyy HH:mm:ss.fff}{Guid.NewGuid()}");

        public string GetHeader() =>  $"Call-ID: {_callId}";
    }
}
