using System;

namespace SoftPhone.Common.SipClientModels.Headers.SipBodyHeaders
{
    public class SipBody
    {
        private ConnectionInfo connectionInfo;
        private MediaAttribute[] mediaAttributes;
        private OwnerCreator ownerCreator;
        private SdpVersion sdpVersion;
        private SessionName sessionName;
        private TimeDescription timeDescription;

        public SipBody()
        {
            

        }

        public int GetLength()
        {
            return connectionInfo != null ? this.connectionInfo.ToString().Length : 0;
        }
    }
}