﻿////////////////////////////////////////////////
// © https://github.com/badhitman - Telegram @fakegov
////////////////////////////////////////////////
using System.Runtime.Serialization;

namespace QIWI.json
{
    [DataContract]
    public class QiwiReceiptItemClass
    {
        [DataMember]
        public string type;
        [DataMember]
        public QiwiFieldViewClass title;
        [DataMember]
        public QiwiFieldViewClass value;
    }
}
