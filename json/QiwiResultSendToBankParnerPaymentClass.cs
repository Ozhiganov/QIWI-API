////////////////////////////////////////////////
// © https://github.com/badhitman - Telegram @fakegov
////////////////////////////////////////////////
using System.Runtime.Serialization;

namespace QIWI.json
{
    [DataContract]
    public class QiwiResultSendToBankParnerPaymentClass: QiwiResultSendPaymentClass
    {
        [DataMember]
        public QiwiFieldsPaymentToBankPartnerClass fields;
    }
}
