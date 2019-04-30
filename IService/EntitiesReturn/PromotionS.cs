using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace IService.EntitiesReturn
{
    [DataContract]
    class PromotionS
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string ProductNeeded { get; set; } //Просто строка щоб не паритись. Це всього лиш розсилкі, вказуються продукти через стрінгу
        [DataMember]
        public string Recept { get; set; }
    }
}
