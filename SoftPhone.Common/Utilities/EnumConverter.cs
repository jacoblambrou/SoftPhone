using System;
using System.Collections.Generic;
using SoftPhone.Common.SipClientModels;
using System.Text;
using SoftPhone.Common.SipClientModels.Enums;

namespace SoftPhone.Common.StringHelpers
{
    public static class EnumConverter
    {
        public static string ConvertToString(this ContentType contentType)
        {
            string convertedContentType = string.Empty;
            if (contentType == ContentType.applicationSdp)
                convertedContentType = "application/sdp";
            else if (contentType == ContentType.textHtml)
                convertedContentType = "text/html";
            else
                convertedContentType = Enum.GetName(contentType.GetType(), contentType);

            return convertedContentType;
        }

        public static ContentType ConvertToEnum(this string enumValue)
        {
            ContentType contentType;
            if (!Enum.TryParse(enumValue, true, out contentType))
            {
                if (enumValue.Equals("application/sdp", StringComparison.InvariantCultureIgnoreCase))
                    contentType = ContentType.applicationSdp;
                else if (enumValue.Equals("text/html", StringComparison.InvariantCultureIgnoreCase))
                    contentType = ContentType.textHtml;
                else
                    throw new InvalidCastException($"'{enumValue}' is not a valid value for enum ContentType");
            }

            return contentType;
        }
    }
}
