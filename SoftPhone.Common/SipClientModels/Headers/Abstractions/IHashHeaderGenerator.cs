﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SoftPhone.Common.SipClientModels.Headers.Abstractions
{
    public interface IHashHeaderGenerator
    {
        string GenerateUniqueHash();
    }
}
