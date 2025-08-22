using BNP.CMM.Application.Responses;
using MediatR;

namespace BNP.CMM.Application.Requests
{
    public class GetProductsRequest : IRequest<List<GetProductsResponse>>
    {
    }
}
