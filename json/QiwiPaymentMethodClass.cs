////////////////////////////////////////////////
// © https://github.com/badhitman - Telegram @fakegov
////////////////////////////////////////////////
using System.Runtime.Serialization;

namespace QIWI.json
{
    [DataContract]
    public class QiwiPaymentMethodClass
    {
        [DataMember]
        public readonly string accountId = "643";
        [DataMember]
        public readonly string type = "Account";
    }
}
