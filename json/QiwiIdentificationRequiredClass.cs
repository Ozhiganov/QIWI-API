﻿////////////////////////////////////////////////
// © https://github.com/badhitman
////////////////////////////////////////////////
using System.Runtime.Serialization;

namespace QIWI.json
{
    [DataContract]
    public class QiwiIdentificationRequiredClass
    {
        [DataMember]
        public bool required;
    }
}