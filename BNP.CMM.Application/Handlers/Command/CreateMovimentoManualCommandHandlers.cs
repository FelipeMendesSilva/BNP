using BNP.CMM.Application.Requests;
using MediatR;

namespace BNP.CMM.Application.Handlers.Command
{
    public class CreateMovimentoManualCommandHandlers : IRequestHandler<CreateMovimentoManualRequest, bool>
    {
        public CreateMovimentoManualCommandHandlers()
        {
                
        }
        public async Task<bool> Handle(CreateMovimentoManualRequest novoMovimentoManual, CancellationToken cancellationToken)
        {
            return true;
        }
    }
}
