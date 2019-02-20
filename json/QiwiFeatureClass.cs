////////////////////////////////////////////////
// © https://github.com/badhitman - Telegram @fakegov
////////////////////////////////////////////////
using System.Runtime.Serialization;

namespace QIWI.json
{
    /// <summary>
    /// Служебная информация
    /// </summary>
    [DataContract]
    public class QiwiFeatureClass
    {
        [DataMember]
        public long featureId;

        [DataMember]
        public string featureValue;

        [DataMember]
        public string startDate;

        [DataMember]
        public string endDate;
    }
}
