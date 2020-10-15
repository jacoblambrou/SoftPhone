using System;
using System.Collections.Generic;
using System.Text;

namespace SoftPhone.Common.SipClientModels
{
    public class SipUri
    {
        private string User;
        private string Host;
        private SipProtocol SipProtocol;
        public string ConcatenateSipUri
        {
            get
            {
                return $"{SipProtocol.ToString()}:{User}@{Host}"; ;
            }
        }

        public SipUri(string uri, SipProtocol sipProtocol)
        {
            if (!uri.Contains("@"))
                throw new ArgumentException("Uri must contain an @ symbol.");

            if (!uri.StartsWith("sip:") || !uri.StartsWith("sips:"))
            {
                User = uri.Substring(0, uri.IndexOf("@"));
                Host = uri.Substring(uri.IndexOf("@") + 1);
                SipProtocol = sipProtocol;
            }
            else
            {
                User = uri.Substring(uri.IndexOf(":")+1, uri.IndexOf("@") - uri.IndexOf(":") - 1);
                Host = uri.Substring(uri.IndexOf("@") + 1);
                SipProtocol = sipProtocol;
            }
        }

        public SipUri(string user, string host, SipProtocol sipProtocol)
        {
            SetSipUri(user, host, SipProtocol);
        }

        public void SetSipUri(string user, string host, SipProtocol sipProtocol)
        {
            User = user;
            Host = host;
            SipProtocol = sipProtocol;
        }
    }
}
