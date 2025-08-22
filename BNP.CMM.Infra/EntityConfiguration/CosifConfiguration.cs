using BNP.CMM.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BNP.CMM.Infra.EntityConfiguration
{  

    public class CosifConfiguration : IEntityTypeConfiguration<Cosif>
    {
        public void Configure(EntityTypeBuilder<Cosif> builder)
        {
            builder.ToTable("PRODUTO_COSIF");

            builder.HasKey(pc => new { pc.ProdutoId, pc.CosifId });

            builder.Property(pc => pc.ProdutoId)
                   .HasColumnName("COD_PRODUTO")
                   .HasMaxLength(4)
                   .IsRequired();

            builder.Property(pc => pc.CosifId)
                   .HasColumnName("COD_COSIF")
                   .HasMaxLength(11)
                   .IsRequired();

            builder.Property(pc => pc.ClassificationCode)
                   .HasColumnName("COD_CLASSIFICACAO")
                   .HasMaxLength(6);

            builder.Property(pc => pc.Status)
                   .HasColumnName("STA_STATUS")
                   .HasMaxLength(1);

            builder.HasOne<Product>()
                   .WithMany()
                   .HasForeignKey(pc => pc.ProdutoId);
        }
    }

}
