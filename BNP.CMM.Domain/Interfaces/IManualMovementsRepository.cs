using BNP.CMM.Domain.Entities;

namespace BNP.CMM.Domain.Interfaces
{
    public interface IManualMovementsRepository
    {
        Task<List<Product>> CreateAsync(CancellationToken cancellationToken);
    }
}
