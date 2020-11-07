using SoftPhone.Common.SipClientModels.Headers.Abstractions;
using SoftPhone.Common.SipClientModels.Headers.SipBodyHeaders;

namespace SoftPhone.Common.SipClientModels.Headers.SipHeaders
{
    public class ContentLength : HeaderBase
    {
        private int length = 0;

        public ContentLength(SipBody body)
        {
            HeaderPrefix = "Content-Length:";
            this.length = body != null ? body.GetLength() : 0;
        }

        public override string GetHeader() => $"{HeaderPrefix} {this.length}";
    }
}
