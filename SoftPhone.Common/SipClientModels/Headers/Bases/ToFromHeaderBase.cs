using SoftPhone.Common.SipClientModels.UserAgents;
using SoftPhone.Common.StringHelpers;
using System;

namespace SoftPhone.Common.SipClientModels.Headers.Bases
{
    public class ToFromHeaderBase : HeaderBase
    {
        public string Tag;

        public ToFromHeaderBase(SipUserAgentClient sipUac, SipTransportManager sipTransportManager) : base (sipUac, sipTransportManager)
        {
            
        }

        private string GenerateTag()
        {
            return HashGenerator.ConvertToHash($"{DateTime.Now:dd/MM/yyyy HH:mm:ss.fff}{Guid.NewGuid()}");
        }
    }
}
