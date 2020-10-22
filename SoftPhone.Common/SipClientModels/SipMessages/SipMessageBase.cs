﻿using SoftPhone.Common.SipClientModels.Headers;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftPhone.Common.SipClientModels.SipNessages
{
    public class SipMessageBase
    {
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

        public SipMessageBase()
        {
            
        }

        public string GetRequestMessage()
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

        public string GetStatusMessage()
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
    }
}