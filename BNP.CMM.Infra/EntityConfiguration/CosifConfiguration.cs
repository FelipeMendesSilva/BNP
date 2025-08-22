using BNP.CMM.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BNP.CMM.Infra.EntityConfiguration
{

    public class CosifConfiguration : IEntityTypeConfiguration<Cosif>
    {
        public void Configure(EntityTypeBuilder<Cosif> builder)
        {

            builder.ToTable("produto_cosif");

            builder.HasKey(pc => new { pc.ProductId, pc.CosifId });

            builder.Property(pc => pc.ProductId)
                   .HasColumnName("cod_produto")
                   .HasMaxLength(4)
                   .IsRequired();

            builder.Property(pc => pc.CosifId)
                   .HasColumnName("cod_cosif")
                   .HasMaxLength(11)
                   .IsRequired();

            builder.Property(pc => pc.ClassificationCode)
                   .HasColumnName("cod_classificacao")
                   .HasMaxLength(6);

            builder.Property(pc => pc.Status)
                   .HasColumnName("sta_status")
               .HasMaxLength(1);

            builder.HasOne(pc => pc.Product)
                   .WithMany()
                   .HasForeignKey(pc => pc.ProductId);
        }
    }
}
