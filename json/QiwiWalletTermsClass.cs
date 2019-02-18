﻿////////////////////////////////////////////////
// © https://github.com/badhitman
////////////////////////////////////////////////

using System.Runtime.Serialization;

namespace QIWI.json
{
    [DataContract]
    public class QiwiWalletTermsClass
    {
        
        [DataMember]
        public string type;
        [DataMember]
        public string id;
        [DataMember]
        public QiwiCommissionClass commission;
        [DataMember]
        public QiwiLimitClass[] limits;
        [DataMember]
        public string description;
        [DataMember]
        public bool overpayment;
        [DataMember]
        public bool underpayment;
        [DataMember]
        public bool repeatablePayment;
        [DataMember]
        public QiwiIdentificationRequiredClass identification;
        [DataMember]
        public object[] cashbacks;
    }
}