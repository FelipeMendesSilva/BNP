using BNP.CMM.Domain.Entities;
using BNP.CMM.Domain.Interfaces;
using BNP.CMM.Infra.Context;
using Microsoft.EntityFrameworkCore;

namespace BNP.CMM.Infra.Repositories
{
    public class ManualMovementsRepository : IManualMovementsRepository
    {
        private readonly AppDbContext _context;

        public ManualMovementsRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Product>> CreateAsync(CancellationToken cancellationToken)
        {
            return await _context.Produtos.ToListAsync();
        }
    }
}
