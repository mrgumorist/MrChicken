using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace IService.EntitiesReturn
{
    [DataContract]
    class IntermediateS
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public int DishID { get; set; }
        [DataMember]
        public int ProductID { get; set; }
    }
}
