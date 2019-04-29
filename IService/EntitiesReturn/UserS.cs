using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace IService.EntitiesReturn
{
    [DataContract]
    public class UserS
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Surname { get; set; }
        [DataMember]
        public string Login { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public string TelegramID { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public bool ISConfirmed { get; set; }
        [DataMember]
        public DateTime DateOfRegister { get; set; }
        [DataMember]
        public DateTime DateOfBirth { get; set; }
        [DataMember]
        public bool DoesWantRecomendations { get; set; }
        
    }
}
