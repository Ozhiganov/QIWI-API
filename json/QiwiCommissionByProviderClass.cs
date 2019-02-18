////////////////////////////////////////////////
// © https://github.com/badhitman
////////////////////////////////////////////////

using System.Runtime.Serialization;

namespace QIWI.json
{
    [DataContract]
    public class QiwiCommissionByProviderClass
    {
        [DataMember]
        public string id;

        [DataMember]
        public QiwiContentCommissionByProviderClass content;

        [DataMember]
        public QiwiReceiptItemsClass receipt;

        [DataMember]
        public QiwiWalletTermsClass walletTerms;
    }
}
