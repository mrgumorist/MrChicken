using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace IService.EntitiesReturn
{
    [DataContract]
    public class DishS
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string LittleDescription { get; set; }
        [DataMember]
        public string Recept { get; set; }
        [DataMember]
        public byte[] Image { get; set; }
        [DataMember]
        public int TypeID { get; set; }
    }
}
