using SoftPhone.Common.SipClientModels.Enums;
using SoftPhone.Common.SipClientModels.Headers.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftPhone.Common.SipClientModels.Headers.SipHeaders
{
    public class AllowHeader : HeaderBase
    {
        public AllowHeader()
        {
            HeaderPrefix = "Allow:";
        }

        public override string GetHeader() =>
            $"{HeaderPrefix} " +
            $"{SipMethod.ACK}, " +
            $"{SipMethod.BYE}, " +
            $"{SipMethod.CANCEL}, " +
            $"{SipMethod.INFO}, " +
            $"{SipMethod.MESSAGE}, " +
            $"{SipMethod.NOTIFY}, " +
            $"{SipMethod.OPTIONS}, " +
            $"{SipMethod.PRACK}, " +
            $"{SipMethod.REFER}, " +
            $"{SipMethod.UPDATE}";
    }
}
