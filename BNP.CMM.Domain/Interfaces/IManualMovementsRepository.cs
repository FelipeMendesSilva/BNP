using BNP.CMM.Domain.Entities;

namespace BNP.CMM.Domain.Interfaces
{
    public interface IManualMovementsRepository
    {
        Task<bool> CreateAsync(ManualMovement movement, CancellationToken cancellationToken);
    }
}
