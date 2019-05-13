using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace IService.EntitiesReturn
{
    class DishesEqualityComparer : IEqualityComparer<DishS>
    {
        public bool Equals(DishS x, DishS y)
        {
            // Two items are equal if their keys are equal.
            return x.ID == y.ID;
        }

        public int GetHashCode(DishS obj)
        {
            return obj.ID.GetHashCode();
        }
    }


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
        //[DataMember]
        //public byte[] Image { get; set; }
        [DataMember]
        public int TypeID { get; set; }
    }
}
