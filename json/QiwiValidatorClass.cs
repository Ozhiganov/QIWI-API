////////////////////////////////////////////////
// © https://github.com/badhitman
////////////////////////////////////////////////
using System.Runtime.Serialization;

namespace QIWI.json
{
    [DataContract]
    public class QiwiValidatorClass
    {
        [DataMember]
        public string type;
        [DataMember]
        public QiwiPredicateClass predicate;
        [DataMember]
        public string message;
    }
}