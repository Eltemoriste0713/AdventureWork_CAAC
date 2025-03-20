using AdventureWork_CAAC.Model;
using Microsoft.EntityFrameworkCore;

namespace AdventureWork_CAAC.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        
        public DbSet<ProductModel> ProductModel { get; set; }
        

    }
}
