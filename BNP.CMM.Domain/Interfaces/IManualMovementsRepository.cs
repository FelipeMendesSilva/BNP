using BNP.CMM.Domain.Entities;

namespace BNP.CMM.Domain.Interfaces
{
    public interface IManualMovementsRepository
    {
        Task CreateAsync(ManualMovement movement, CancellationToken cancellationToken);
    }
}
