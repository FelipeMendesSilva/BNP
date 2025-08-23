using Microsoft.EntityFrameworkCore;
using BNP.CMM.Domain.Entities;
using BNP.CMM.Infra.EntityConfiguration;
using BNP.CMM.Domain.DTO;

namespace BNP.CMM.Infra.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Produtos { get; set; }
        public DbSet<Cosif> ProdutosCosif { get; set; }
        public DbSet<ManualMovement> MovimentosManuais { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new CosifConfiguration());
            modelBuilder.ApplyConfiguration(new ManualMovimentConfiguration());

            modelBuilder.Entity<FunctionManualMovementsResult>().HasNoKey();

            base.OnModelCreating(modelBuilder);
            // Configurações adicionais
        }
    }
}
