////////////////////////////////////////////////
// © https://github.com/badhitman
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
