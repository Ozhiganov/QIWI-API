////////////////////////////////////////////////
// © https://github.com/badhitman - Telegram @fakegov
////////////////////////////////////////////////
using System.Runtime.Serialization;

namespace QIWI.json
{
    [DataContract]
    public class QiwiWidgetClass
    {
        [DataMember]
        public string type;
        [DataMember]
        public string mask;
        [DataMember]
        public string keyboard;
        [DataMember]
        public bool stripStaticSymbols;
    }
}