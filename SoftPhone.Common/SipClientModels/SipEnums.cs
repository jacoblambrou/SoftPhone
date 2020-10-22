using System;
using System.Collections.Generic;
using System.Text;

namespace SoftPhone.Common.SipClientModels
{
    public enum SipResponse
    {
        Trying = 100,
        Ringing = 180,
        CallIsBeingForwarded = 181,
        Queued = 182,
        SessionProgress = 183,
        EarlyDialogTerminated = 199,
        Ok = 200,
        Accepted = 202,
        NoNotifcation = 204,
        MultipleChoices = 300,
        MovedPermanently = 301,
        MovedTemporarily = 302,
        UseProxy = 305,
        AlternativeService = 380,
        BadRequest = 400,
        Unauthorized = 401,
        NotFound = 404,
        MethodNotAllowed = 405,
        NotAcceptable = 406,
        ProxyAuthenticationRequired = 407,
        RequestTimeout = 408,
        UnsupportedCertificate = 437,
        InvalidIdentityHeader = 438,
        TemporarilyUnavailable = 480,
        CallTransactionDoesNotExist = 481,
        AddressIncomplete = 484,
        BusyHere = 486,
        RequestTerminated = 487,
        NotAcceptableHere = 488,
        InternalServerError = 500,
        NotImplemented = 501,
        BadGateway = 502,
        ServiceUnavailable = 503,
        VersionNotSupported = 505,
        Unwanted = 607,
        Rejected = 608
    }
    
    public enum SipMethod
    {
        ACK,
        BYE,
        CANCEL,
        INFO,
        INVITE,
        MESSAGE,
        NOTIFY,
        OPTIONS,
        PRACK,
        PUBLISH,
        REFER,
        REGISTER,
        SUBSCRIBE,
        UPDATE
    }

    public enum SipProtocol
    {
        sip,
        sips
    }

    public enum ContentType
    {
        applicationSdp,

    }

    public enum SipTransport
    {
        TCP,
        UDP
    }

    public enum CallDirection
    {
        Incoming,
        Outgoing
    }
}
