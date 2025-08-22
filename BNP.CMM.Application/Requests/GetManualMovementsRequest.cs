using BNP.CMM.Application.Responses;
using MediatR;

namespace BNP.CMM.Application.Requests
{
    public class GetManualMovementsRequest : IRequest<List<GetManualMovementsResponse>>
    {
    }
}
