using SoftPhone.Common.SipClientModels.Headers;
using SoftPhone.Common.SipClientModels.UserAgents;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftPhone.Common.SipClientModels.SipMessages
{
    public class SipMessageBase
    {
        private MessageType _messageType;
        private AllowHeader _allowHeader;
        private AuthorizationHeader _authorizationHeader;
        private CallIdHeader _callIdHeader;
        private ContactHeader _contactHeader;
        private ContentLength _contentLength;
        private ExpiresHeader _expiresHeader;
        private FromHeader _fromHeader;
        private MaxForwardsHeader _maxForwards;
        private RequestLine _requestLine;
        private RouteHeader _routeHeader;
        private StatusLine _statusLine;
        private ToHeader _toHeader;
        private UserAgentHeader _userAgent;
        private ViaHeader _viaHeader;
        private SipBody _body;

        public SipMessageBase(SipUserAgentClient sipUac, SipTransportManager sipTransportManager, SipMethod sipMethod, SipResponse sipResponse)
        {
            _requestLine = new RequestLine(sipUac, sipTransportManager, sipMethod);
            _statusLine = new StatusLine(sipUac, sipTransportManager, sipResponse);
            _viaHeader = new ViaHeader(sipUac, sipTransportManager);
            _fromHeader = new FromHeader(sipUac, sipTransportManager);
            _toHeader = new ToHeader(sipUac, sipTransportManager);
            _callIdHeader = new CallIdHeader();
            _contactHeader = new ContactHeader(sipUac, sipTransportManager);
            _routeHeader = new RouteHeader(sipUac, sipTransportManager);
            _userAgent = new UserAgentHeader();
            _expiresHeader = new ExpiresHeader();
            _maxForwards = new MaxForwardsHeader();
            _allowHeader = new AllowHeader();
            _contentLength = new ContentLength(_body);
            _messageType = GetMessageType();
        }

        public string GetSipMessage()
        {
            if (_messageType == MessageType.Request)
                return GetRequestMessage();
            else
                return GetStatusMessage();
        }

        private string GetRequestMessage()
        {
            return $"{_requestLine.GetHeader()}{Environment.NewLine}" +
                $"{_viaHeader.GetHeader()}{Environment.NewLine}" +
                $"{_fromHeader.GetHeader()}{Environment.NewLine}" +
                $"{_toHeader.GetHeader()}{Environment.NewLine}" +
                $"{_callIdHeader.GetHeader()}{Environment.NewLine}" +
                $"{_contactHeader.GetHeader()}{Environment.NewLine}" +
                $"{_routeHeader.GetHeader()}{Environment.NewLine}" +
                $"{_userAgent.GetHeader()}{Environment.NewLine}" +
                $"{_expiresHeader.GetHeader()}{Environment.NewLine}" +
                $"{_maxForwards.GetHeader()}{Environment.NewLine}" +
                $"{_allowHeader.GetHeader()}{Environment.NewLine}" +
                $"{_contentLength.GetHeader()}{Environment.NewLine}";
        }

        private string GetStatusMessage()
        {
            return $"{_statusLine.GetHeader()}{Environment.NewLine}" +
                $"{_viaHeader.GetHeader()}{Environment.NewLine}" +
                $"{_fromHeader.GetHeader()}{Environment.NewLine}" +
                $"{_toHeader.GetHeader()}{Environment.NewLine}" +
                $"{_callIdHeader.GetHeader()}{Environment.NewLine}" +
                $"{_contactHeader.GetHeader()}{Environment.NewLine}" +
                $"{_routeHeader.GetHeader()}{Environment.NewLine}" +
                $"{_userAgent.GetHeader()}{Environment.NewLine}" +
                $"{_expiresHeader.GetHeader()}{Environment.NewLine}" +
                $"{_maxForwards.GetHeader()}{Environment.NewLine}" +
                $"{_allowHeader.GetHeader()}{Environment.NewLine}" +
                $"{_contentLength.GetHeader()}{Environment.NewLine}";
        }

        //private MessageType GetMessageType()
        //{
        //    if ()
        //}
    }
}
