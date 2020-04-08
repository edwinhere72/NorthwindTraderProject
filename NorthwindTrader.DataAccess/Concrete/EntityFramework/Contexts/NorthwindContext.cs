using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindTrader.DataAccess.Concrete.EntityFramework.Mappings;
using NorthwindTrader.Entities.Concrete;

namespace NorthwindTrader.DataAccess.Concrete.EntityFramework.Contexts
{
    public class NorthwindContext
    {
        public NorthwindContext() : base("Name=NorthwindContext")
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new UserMap());
        }
    }
}
