﻿////////////////////////////////////////////////
// © https://github.com/badhitman
////////////////////////////////////////////////

using System.Runtime.Serialization;

namespace QIWI.json
{
    [DataContract]
    public class QiwiViewClass
    {
        [DataMember]
        public string title;
        [DataMember]
        public string prompt;
        [DataMember]
        public QiwiWidgetClass widget;
        [DataMember]
        public string hint;
    }
}