using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IService.Entities
{
    [Table("EmailVerification")]
    class EmailAccept
    {
        [Key]
        public int ID { get; set; }
        [Required, ForeignKey("UserV")]
        public int UserID { get; set; }
        public virtual User UserV { get; set; }
        public string VerificationCode { get; set; }
    }
}
