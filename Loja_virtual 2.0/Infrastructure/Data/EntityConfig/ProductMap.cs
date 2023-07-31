using LojaVirtual.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LojaVirtual.Infrastructure.Data.EntityConfig
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(m => m.Id);

            builder.Property(m => m.name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(m => m.type)
                .IsRequired();

            builder.Property(m => m.price)
                .IsRequired();
        }
    }
}
