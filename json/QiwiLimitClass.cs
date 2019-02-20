﻿////////////////////////////////////////////////
// © https://github.com/badhitman - Telegram @fakegov
////////////////////////////////////////////////
using System.Runtime.Serialization;

namespace QIWI.json
{
    [DataContract]
    public class QiwiLimitClass
    {
        [DataMember]
        public string currency;
        [DataMember]
        public double min;
        [DataMember]
        public double max;
    }
}