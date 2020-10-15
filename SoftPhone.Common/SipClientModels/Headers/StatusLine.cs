using SoftPhone.Common.SipClientModels.Headers.Bases;
using SoftPhone.Common.SipClientModels.UserAgents;

namespace SoftPhone.Common.SipClientModels.Headers
{
    public class StatusLine : StatusRequestLineHeaderBase
    {
        public StatusLine(SipUserAgentClient sipUac, SipTransportManager sipTransportManager, SipMethod sipMethod) : base (sipUac, sipTransportManager, sipMethod)
        {

        }
    }
}
