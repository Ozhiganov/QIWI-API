////////////////////////////////////////////////
// © https://github.com/badhitman
////////////////////////////////////////////////
using System.Runtime.Serialization;

namespace QIWI.json
{
    [DataContract]
    public class QiwiCommissionClass
    {
        [DataMember]
        public QiwiRangeCommissionClass[] ranges;
    }
}