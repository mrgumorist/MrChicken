using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace IService.EntitiesReturn
{
    [DataContract]
    public class UserProductsS
    {
       [DataMember]
        public int ID { get; set; }
        [DataMember]
        public int UserID { get; set; }
        [DataMember]
        public int ProductID { get; set; }
        //[DataMember]
        //public DateTime AddedDate { get; set; }
    }
}
