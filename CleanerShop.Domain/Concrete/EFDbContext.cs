using CleanerShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanerShop.Domain.Concrete
{
   public class EFDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}
