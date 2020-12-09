using SoftPhone.Common.SipClientModels.Enums;
using SoftPhone.Common.SipClientModels.Headers.SipBodyHeaders;
using SoftPhone.Common.SipClientModels.Headers.SipHeaders;
using SoftPhone.Common.SipClientModels.UserAgents;
using System;

namespace SoftPhone.Common.SipClientModels.SipMessages
{
    public class SipMessage
    {
        private MessageType messageType;
        private AllowHeader allowHeader;
        private AuthorizationHeader authorizationHeader;
        private CallIdHeader callIdHeader;
        private ContactHeader contactHeader;
        private ContentLength contentLength;
        private ContentTypeHeader contentType;
        private ExpiresHeader expiresHeader;
        private FromHeader fromHeader;
        private MaxForwardsHeader maxForwards;
        private RequestLine requestLine;
        private RouteHeader routeHeader;
        private StatusLine statusLine;
        private ToHeader toHeader;
        private UserAgentHeader userAgent;
        private ViaHeader viaHeader;
        private WwwAuthenticateHeader wwwAuthenticationHeader;
        private SipBody body;

        public SipMessage(SipUser sipUser, LocalSipUserAgentServer localSipUas, SipTransportManager sipTransportManager, SipMethod sipMethod)
        {
            this.messageType = MessageType.Request;
            this.requestLine = new RequestLine(localSipUas, sipTransportManager.SipProtocol, sipMethod);
            CreateCommonHeaders(sipUser, localSipUas, sipTransportManager);
        }

        public SipMessage(SipUser sipUser, LocalSipUserAgentServer localSipUas, SipTransportManager sipTransportManager, SipResponseCode sipResponse)
        {
            this.messageType = MessageType.Response;
            this.statusLine = new StatusLine(localSipUas, sipTransportManager.SipProtocol, sipResponse);
            CreateCommonHeaders(sipUser, localSipUas, sipTransportManager);
        }

        internal void UpdateRemoteCli(string cli)
        {
            this.toHeader.SetUser(cli);
        }

        public string GetSipMessage()
        {
            if (this.messageType == MessageType.Request)
                return GetRequestMessage();
            else
                return GetStatusMessage();
        }

        private void CreateCommonHeaders(SipUser sipUser, LocalSipUserAgentServer localSipUas, SipTransportManager sipTransportManager)
        {
            this.viaHeader = new ViaHeader(localSipUas, sipTransportManager.SipProtocol, sipTransportManager.SipTransport);
            this.fromHeader = new FromHeader(sipUser, localSipUas, sipTransportManager.SipProtocol);
            this.toHeader = new ToHeader(localSipUas, sipTransportManager.SipProtocol);
            this.callIdHeader = new CallIdHeader();
            this.contactHeader = new ContactHeader(localSipUas, sipTransportManager.SipProtocol);
            this.routeHeader = new RouteHeader(localSipUas, sipTransportManager.SipProtocol);
            this.userAgent = new UserAgentHeader();
            this.expiresHeader = new ExpiresHeader();
            this.maxForwards = new MaxForwardsHeader();
            this.allowHeader = new AllowHeader();
            this.contentLength = new ContentLength(body);
        }

        private string GetRequestMessage() =>
            $"{this.requestLine.GetHeader()}{Environment.NewLine}{GetHeaders()}";

        private string GetStatusMessage() =>
            $"{this.statusLine.GetHeader()}{Environment.NewLine}{GetHeaders()}";

        private string GetHeaders() =>
                $"{this.viaHeader.GetHeader()}{Environment.NewLine}" +
                $"{this.fromHeader.GetHeader()}{Environment.NewLine}" +
                $"{this.toHeader.GetHeader()}{Environment.NewLine}" +
                $"{this.callIdHeader.GetHeader()}{Environment.NewLine}" +
                $"{this.contactHeader.GetHeader()}{Environment.NewLine}" +
                $"{this.routeHeader.GetHeader()}{Environment.NewLine}" +
                $"{this.userAgent.GetHeader()}{Environment.NewLine}" +
                $"{this.expiresHeader.GetHeader()}{Environment.NewLine}" +
                $"{this.maxForwards.GetHeader()}{Environment.NewLine}" +
                $"{this.allowHeader.GetHeader()}{Environment.NewLine}" +
                $"{this.contentLength.GetHeader()}{Environment.NewLine}";
    }
}
