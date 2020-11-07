using SoftPhone.Common.SipClientModels.Enums;

namespace SoftPhone.Common.SipClientModels
{
    public class SipUri
    {
        private string user;
        private string host;
        private SipProtocol sipProtocol;

        public SipUri(string user, string host, SipProtocol sipProtocol)
        {
            this.user = user;
            this.host = host;
            this.sipProtocol = sipProtocol;
        }

        public string GetSipUri()
        {
            return $"{this.sipProtocol.ToString()}:{this.user}@{this.host}";
        }
    }
}
