////////////////////////////////////////////////
// © https://github.com/badhitman
////////////////////////////////////////////////
using System.Runtime.Serialization;

namespace QIWI.json
{
    [DataContract]
    public class QiwiFieldViewClass
    {
        [DataMember]
        public string type;

        [DataMember]
        public string field;
    }
}
