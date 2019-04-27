using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IService.Entities
{
    [Table("Promotions")]
    public class Promotion
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string ProductNeeded { get; set; } //Просто строка щоб не паритись. Це всього лиш розсилкі
        public string Recept { get; set; }
    }
}
