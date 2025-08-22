
using BNP.CMM.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BNP.CMM.Infra.EntityConfiguration
{

    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("produto");

            builder.HasKey(p => p.ProductId);

            builder.Property(p => p.ProductId)
                   .HasColumnName("cod_produto")
                   .HasMaxLength(4)
                   .IsRequired();

            builder.Property(p => p.Description)
                   .HasColumnName("des_produto")
                   .HasMaxLength(30)
                   .IsRequired();

            builder.Property(p => p.Status)
                   .HasColumnName("sta_status")
                   .HasMaxLength(1);
        }
    }

}
