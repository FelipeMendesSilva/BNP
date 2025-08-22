namespace BNP.CMM.Infra.EntityConfiguration
{
    using BNP.CMM.Domain.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class ManualMovimentConfiguration : IEntityTypeConfiguration<ManualMovement>
    {
        public void Configure(EntityTypeBuilder<ManualMovement> builder)
        {
            builder.ToTable("movimento_manual");

            builder.HasKey(mm => mm.EntryNumber);

            builder.Property(mm => mm.EntryNumber)
                   .HasColumnName("num_lancamento")
                   .IsRequired();

            builder.Property(mm => mm.Month)
                   .HasColumnName("dat_mes")
                   .IsRequired();

            builder.Property(mm => mm.Year)
                   .HasColumnName("dat_ano")
                   .IsRequired();

            builder.Property(mm => mm.ProductId)
                   .HasColumnName("cod_produto")
                   .HasMaxLength(4)
                   .IsRequired();

            builder.Property(mm => mm.CosifId)
                   .HasColumnName("cod_cosif")
                   .HasMaxLength(11)
                   .IsRequired();

            builder.Property(mm => mm.MovementDate)
                   .HasColumnName("dat_movimento")
                   .IsRequired();

            builder.Property(mm => mm.Value)
                   .HasColumnName("val_valor")
                   .HasColumnType("decimal(18,2)")
                   .IsRequired();

            builder.Property(mm => mm.Description)
                   .HasColumnName("des_descricao")
                   .HasMaxLength(50)
                   .IsRequired();

            builder.Property(mm => mm.UserCode)
                   .HasColumnName("cod_usuario")
                   .HasMaxLength(15)
                   .IsRequired();

            builder.HasOne(mm => mm.Cosif)
               .WithMany()
               .HasForeignKey(mm => new { mm.ProductId, mm.CosifId });

            builder.HasOne(mm => mm.Product)
                   .WithMany()
                   .HasForeignKey(mm => mm.ProductId);
        }
    }
}
