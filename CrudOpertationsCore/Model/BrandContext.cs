using Microsoft.EntityFrameworkCore;

namespace CrudOpertationsCore.Model
{
    public class BrandContext:DbContext
    {
        public BrandContext(DbContextOptions<BrandContext> options): base(options)
        {
            
        }
        public DbSet<Brand> Brands { get;set; }
    }
}
