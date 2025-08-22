
using BNP.CMM.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BNP.CMM.Infra.EntityConfiguration
{

    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("PRODUTO");

            builder.HasKey(p => p.ProdutoId);

            builder.Property(p => p.ProdutoId)
                   .HasColumnName("COD_PRODUTO")
                   .HasMaxLength(4)
                   .IsRequired();

            builder.Property(p => p.Description)
                   .HasColumnName("DES_PRODUTO")
                   .HasMaxLength(30)
                   .IsRequired();

            builder.Property(p => p.Status)
                   .HasColumnName("STA_STATUS")
                   .HasMaxLength(1);
        }
    }

}
