using BNP.CMM.Application.Requests;
using BNP.CMM.Application.Responses;
using BNP.CMM.Infra.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BNP.CMM.Application.Handlers.Query
{
    public class ProductsQueryHandlers : IRequestHandler<GetProductsRequest, List<GetProductsResponse>>
    {
        private readonly AppDbContext _dbContext;
        public ProductsQueryHandlers(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<GetProductsResponse>> Handle(GetProductsRequest request, CancellationToken cancellationToken)
        {
            var productsList = await _dbContext.Produtos.ToListAsync();
            var response = new List<GetProductsResponse>();

            foreach (var product in productsList)
            {
                response.Add(new GetProductsResponse(product.ProductId, product.Description, product.Status));
            }

            return response;


        }
    }
}
