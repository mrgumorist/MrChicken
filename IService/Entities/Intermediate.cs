using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IService.Entities
{
    class IntermediateEqualityComparer : IEqualityComparer<Intermediate>
    {
        public bool Equals(Intermediate x, Intermediate y)
        {
            // Two items are equal if their keys are equal.
            return x.DishID == y.DishID;
        }

        public int GetHashCode(Intermediate obj)
        {
            return obj.ID.GetHashCode();
        }
    }

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
