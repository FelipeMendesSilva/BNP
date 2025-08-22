using BNP.CMM.Application.Requests;
using BNP.CMM.Application.Responses;
using MediatR;

namespace BNP.CMM.Application.Handlers.Query
{
    public class TodosProdutosQueryHandlers : IRequestHandler<GetProductsRequest, List<GetProductsResponse>>
    {
        public TodosProdutosQueryHandlers() { }

        public async Task<List<GetProductsResponse>> Handle(GetProductsRequest request, CancellationToken cancellationToken)
        { 
            return new List<GetProductsResponse>() { new GetProductsResponse() { ProductId = "abcd" ,Description = "Produto1"} }; 
        }


    }
}
