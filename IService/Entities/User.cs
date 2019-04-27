using IService.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IService
{
    [Table("Users")]
    public class User
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        public string TelegramID { get; set; }
        public string Email { get; set; }
        public bool ISConfirmed { get; set; }
        [Required]
        public DateTime DateOfRegister { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public bool DoesWantRecomendations { get; set; }
        public virtual ICollection<EmailAccept> IEmails { get; set; }
        public virtual ICollection<UserProducts> userProducts { get; set; }
    }
}
