using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IService.Entities
{
    [Table("Intermediate")]
    public class Intermediate
    {
        [Key]
        public int ID { get; set; }
        [Required, ForeignKey("DishV")]
        public int DishID { get; set; }
        public virtual Dish DishV { get; set; }
        [Required, ForeignKey("ProductV")]
        public int ProductID { get; set; }
        public virtual Product ProductV { get; set; }
    }
}
