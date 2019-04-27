using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IService.Entities
{
    public class Context : DbContext
    {
        public Context() : base("EmployeeConnection")
        {

        }
        public DbSet<Dish> dishes { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<EmailAccept> emailAccepts { get; set; }
        public DbSet<Intermediate> intermediate { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Promotion> promotions { get; set; }
        public DbSet<Type> Types { get; set; }
        public DbSet<UserProducts> userProducts { get; set; }
    }
}
