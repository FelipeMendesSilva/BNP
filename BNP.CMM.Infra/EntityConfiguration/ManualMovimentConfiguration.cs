namespace BNP.CMM.Infra.EntityConfiguration
{
    using BNP.CMM.Domain.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class ManualMovimentConfiguration : IEntityTypeConfiguration<ManualMovement>
    {
        public void Configure(EntityTypeBuilder<ManualMovement> builder)
        {
            builder.ToTable("MOVIMENTO_MANUAL");

            builder.HasKey(mm =>  mm.Entrynumber );


            builder.Property(mm => mm.Entrynumber)
                   .HasColumnName("NUM_LANCAMENTO")
                   .IsRequired();

            builder.Property(mm => mm.Month)
                   .HasColumnName("DAT_MES")
                   .IsRequired();

            builder.Property(mm => mm.Year)
                   .HasColumnName("DAT_ANO")
                   .IsRequired();

            builder.Property(mm => mm.ProdutoId)
                   .HasColumnName("COD_PRODUTO")
                   .HasMaxLength(4)
                   .IsRequired();

            builder.Property(mm => mm.CosifId)
                   .HasColumnName("COD_COSIF")
                   .HasMaxLength(11)
                   .IsRequired();

            builder.Property(mm => mm.MovementDate)
                   .HasColumnName("DAT_MOVIMENTO")
                   .IsRequired();

            builder.Property(mm => mm.Value)
                   .HasColumnName("VAL_VALOR")
                   .HasColumnType("decimal(18,2)")
                   .IsRequired();

            builder.Property(mm => mm.Description)
                   .HasColumnName("DES_DESCRICAO")
                   .HasMaxLength(50)
                   .IsRequired();

            builder.Property(mm => mm.UserCode)
                   .HasColumnName("COD_USUARIO")
                   .HasMaxLength(15)
                   .IsRequired();

            builder.HasOne<Cosif>()
                   .WithMany()
                   .HasForeignKey(mm => new { mm.ProdutoId, mm.CosifId });

            builder.HasOne<Product>()
                   .WithMany()
                   .HasForeignKey(mm => mm.ProdutoId);
        }
    }

}
