using BNP.CMM.Application.Requests;
using BNP.CMM.Application.Responses;
using MediatR;

namespace BNP.CMM.Application.Handlers.Query
{
    public class TodosMovimentosManuaisQueryHandlers : IRequestHandler<GetManualMovementsRequest, List<GetManualMovementsResponse>>
    {
        public TodosMovimentosManuaisQueryHandlers()
        {
                
        }
        public async Task<List<GetManualMovementsResponse>> Handle(GetManualMovementsRequest request, CancellationToken cancellationToken)
        {
            return new List<GetManualMovementsResponse>() { };
        }
    }
}
