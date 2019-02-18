////////////////////////////////////////////////
// © https://github.com/badhitman
////////////////////////////////////////////////
using System.Runtime.Serialization;

namespace QIWI.json
{
    [DataContract]
    public class QiwiReceiptItemsClass
    {
        [DataMember]
        public QiwiReceiptItemClass[] items;
    }
}
