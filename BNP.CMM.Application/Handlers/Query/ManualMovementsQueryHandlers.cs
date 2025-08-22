using BNP.CMM.Application.Requests;
using BNP.CMM.Application.Responses;
using MediatR;

namespace BNP.CMM.Application.Handlers.Query
{
    public class ManualMovementsQueryHandlers : IRequestHandler<GetManualMovementsRequest, List<GetManualMovementsResponse>>
    {
        public ManualMovementsQueryHandlers()
        {
                
        }
        public async Task<List<GetManualMovementsResponse>> Handle(GetManualMovementsRequest request, CancellationToken cancellationToken)
        {
            return new List<GetManualMovementsResponse>() { };
        }
    }
}
