////////////////////////////////////////////////
// © https://github.com/badhitman - Telegram @fakegov
////////////////////////////////////////////////
using System.Runtime.Serialization;

namespace QIWI.json
{
    [DataContract]
    public class QiwiContentCommissionByProviderClass
    {
        [DataMember]
        public QiwiContentTermsCommissionByProviderClass terms;
        [DataMember]
        public QiwiContentElementCommissionByProviderClass[] elements;
        [DataMember]
        public QiwiReceiptItemsClass receipt;
    }
}
