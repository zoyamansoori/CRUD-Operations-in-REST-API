using Microsoft.EntityFrameworkCore;

namespace ElectronixWebAPI.EfCore
{
    public class EF_DataContext : DbContext
    {
        public EF_DataContext(DbContextOptions<EF_DataContext> options): base(options) { }

        //Adding DB sets table
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }

    }
}
