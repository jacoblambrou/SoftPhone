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
            $"{SipMethod.ACK.ToString()}, " +
            $"{SipMethod.BYE.ToString()}, " +
            $"{SipMethod.CANCEL.ToString()}, " +
            $"{SipMethod.INFO.ToString()}, " +
            $"{SipMethod.MESSAGE.ToString()}, " +
            $"{SipMethod.NOTIFY.ToString()}, " +
            $"{SipMethod.OPTIONS.ToString()}, " +
            $"{SipMethod.PRACK.ToString()}, " +
            $"{SipMethod.REFER.ToString()}, " +
            $"{SipMethod.UPDATE.ToString()}";
        
    }
}
