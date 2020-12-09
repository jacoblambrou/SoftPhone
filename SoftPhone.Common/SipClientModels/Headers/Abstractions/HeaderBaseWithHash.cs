using SoftPhone.Common.SipClientModels.Enums;
using SoftPhone.Common.SipClientModels.UserAgents;
using SoftPhone.Common.StringHelpers;
using System;

namespace SoftPhone.Common.SipClientModels.Headers.Abstractions
{
    public abstract class HeaderBaseWithHash : HeaderBaseWithSipUri, IHashHeaderGenerator
    {
        public string Tag;

        public HeaderBaseWithHash(LocalSipUserAgentServer localSipUas, SipProtocol sipProtocol) : base(localSipUas, sipProtocol)
        {
            
        }

        public string GenerateUniqueHash() => HashGenerator.ConvertToHash($"{DateTime.Now:dd/MM/yyyy HH:mm:ss.fff}{Guid.NewGuid()}");

        public abstract override string GetHeader();
    }
}
