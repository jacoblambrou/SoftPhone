using SoftPhone.Common.SipClientModels.Enums;
using SoftPhone.Common.SipClientModels.Headers.Abstractions;
using SoftPhone.Common.StringHelpers;

namespace SoftPhone.Common.SipClientModels.Headers.SipHeaders
{
    public class ContentTypeHeader : HeaderBase
    {
        private string contentType;
        public ContentTypeHeader(ContentType contentType)
        {
            HeaderPrefix = "Content-Type:";
            this.contentType = EnumConverter.ConvertToString(contentType);

        }
        public override string GetHeader() => $"{HeaderPrefix} {contentType}";
    }
}
