////////////////////////////////////////////////
// © https://github.com/badhitman
////////////////////////////////////////////////
using System.Runtime.Serialization;

namespace QIWI.json
{
    [DataContract]
    public class QiwiProviderExtrasClass
    {
        [DataMember]
        public string key;
        [DataMember]
        public string value;
    }
}
