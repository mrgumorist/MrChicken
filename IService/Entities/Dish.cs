using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IService.Entities
{

    

    [Table("Dishes")]
   public class Dish
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public string LittleDescription { get; set; }
        public string Recept { get; set; }
        [Required, ForeignKey("TypeV")]
        public int TypeID { get; set; }
        public virtual Type TypeV { get; set; }
        public virtual ICollection<Intermediate> intermediate { get; set; }
    }
}
