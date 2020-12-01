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

        public SipMessage(SipUserAgentClient sipUac, SipTransportManager sipTransportManager, SipMethod sipMethod)
        {
            this.messageType = MessageType.Request;
            this.requestLine = new RequestLine(sipUac, sipTransportManager, sipMethod);
            this.viaHeader = new ViaHeader(sipUac, sipTransportManager);
            this.fromHeader = new FromHeader(sipUac, sipTransportManager);
            this.toHeader = new ToHeader(sipUac, sipTransportManager);
            this.callIdHeader = new CallIdHeader();
            this.contactHeader = new ContactHeader(sipUac, sipTransportManager);
            this.routeHeader = new RouteHeader(sipUac, sipTransportManager);
            this.userAgent = new UserAgentHeader();
            this.expiresHeader = new ExpiresHeader();
            this.maxForwards = new MaxForwardsHeader();
            this.allowHeader = new AllowHeader();
            this.contentLength = new ContentLength(body);
        }

        public SipMessage(SipUserAgentClient sipUac, SipTransportManager sipTransportManager, SipResponseCode sipResponse)
        {
            this.messageType = MessageType.Response;
            this.statusLine = new StatusLine(sipUac, sipTransportManager, sipResponse);
            this.viaHeader = new ViaHeader(sipUac, sipTransportManager);
            this.fromHeader = new FromHeader(sipUac, sipTransportManager);
            this.toHeader = new ToHeader(sipUac, sipTransportManager);
            this.callIdHeader = new CallIdHeader();
            this.contactHeader = new ContactHeader(sipUac, sipTransportManager);
            this.routeHeader = new RouteHeader(sipUac, sipTransportManager);
            this.userAgent = new UserAgentHeader();
            this.expiresHeader = new ExpiresHeader();
            this.maxForwards = new MaxForwardsHeader();
            this.allowHeader = new AllowHeader();
            this.contentLength = new ContentLength(body);
        }

        public string GetSipMessage()
        {
            if (this.messageType == MessageType.Request)
                return GetRequestMessage();
            else
                return GetStatusMessage();
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
