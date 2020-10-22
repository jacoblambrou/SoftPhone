namespace SoftPhone.Common.SipClientModels
{
    public class SipUri
    {
        private string User;
        private string Host;
        private SipProtocol SipProtocol;

        public SipUri(string user, string host, SipProtocol sipProtocol)
        {
            User = user;
            Host = host;
            SipProtocol = sipProtocol;
        }

        public string GetSipUri()
        {
            return $"{SipProtocol.ToString()}:{User}@{Host}";
        }

        //public void SetSipUri(string user, string host, SipProtocol sipProtocol)
        //{
        //    User = user;
        //    Host = host;
        //    SipProtocol = sipProtocol;
        //}
    }
}
