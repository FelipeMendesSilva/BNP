using BNP.CMM.Application.Requests;
using BNP.CMM.Domain.Entities;
using BNP.CMM.Domain.Interfaces;
using MediatR;

namespace BNP.CMM.Application.Handlers.Command
{
    public class CreateMovimentoManualCommandHandlers : IRequestHandler<CreateMovimentoManualRequest, bool>
    {
        private readonly IManualMovementsRepository _manualMovementsRepository;
        public CreateMovimentoManualCommandHandlers(IManualMovementsRepository manualMovementsRepository)
        {
            _manualMovementsRepository = manualMovementsRepository;
        }
        public async Task<bool> Handle(CreateMovimentoManualRequest novoMovimentoManual, CancellationToken cancellationToken)
        {
            var movementEntity = new ManualMovement(
                novoMovimentoManual.Month,
                novoMovimentoManual.Year,
                novoMovimentoManual.ProductId,
                novoMovimentoManual.CosifId,
                novoMovimentoManual.Amount,
                novoMovimentoManual.Description
                );

            return await _manualMovementsRepository.CreateAsync(movementEntity, cancellationToken);
        }
    }
}
