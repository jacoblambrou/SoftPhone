using SoftPhone.Common.SipClientModels.UserAgents;
using SoftPhone.Common.StringHelpers;
using System;

namespace SoftPhone.Common.SipClientModels.Headers.Abstractions
{
    public class HashHeaderBase : HeaderBase, IHashHeaderGenerator
    {
        public string Tag;

        public HashHeaderBase(SipUserAgentClient sipUac, SipTransportManager sipTransportManager) : base(sipUac, sipTransportManager)
        {
            
        }

        public string GenerateUniqueHash() => HashGenerator.ConvertToHash($"{DateTime.Now:dd/MM/yyyy HH:mm:ss.fff}{Guid.NewGuid()}");
    }
}
