using System;
using System.Collections.Generic;
using SoftPhone.Common.SipClientModels;
using System.Text;

namespace SoftPhone.Common.StringHelpers
{
    public static class EnumConverter
    {
        public static string ConvertToString(this ContentType contentType)
        {
            return (contentType == ContentType.applicationSdp) ? "application/sdp" : Enum.GetName(contentType.GetType(), contentType);
        }

        public static ContentType ConverToEnum(this string enumValue)
        {
            ContentType contentType;
            if (!Enum.TryParse(enumValue, true, out contentType))
            {
                if (enumValue.Equals("application/sdp", StringComparison.InvariantCultureIgnoreCase))
                    contentType = ContentType.applicationSdp;
                else
                    throw new InvalidCastException($"'{enumValue}' is not a valid value for enum ContentType");
            }

            return contentType;
        }
    }
}
