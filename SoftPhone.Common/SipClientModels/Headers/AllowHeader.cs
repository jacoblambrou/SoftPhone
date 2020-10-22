﻿using SoftPhone.Common.SipClientModels.Headers.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftPhone.Common.SipClientModels.Headers
{
    public class AllowHeader : IHeader
    {
        public string GetHeader()
        {
            return $"{SipMethod.ACK.ToString()}, " +
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
}
