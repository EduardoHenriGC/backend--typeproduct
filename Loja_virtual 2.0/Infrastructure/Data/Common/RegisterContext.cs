using LojaVirtual.Domain.Entities;
using LojaVirtual.Infrastructure.Data.EntityConfig;
using Microsoft.EntityFrameworkCore;


namespace LojaVirtual.Infrastructure.Data.Common
{
    public class RegisterContext : DbContext
    {
        public RegisterContext(DbContextOptions<RegisterContext> options)
            : base(options)
        {

        }

        
        
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            
            modelBuilder.ApplyConfiguration(new ProductMap());
        }

        
    }
}
