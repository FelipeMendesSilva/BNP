using BNP.CMM.Application.Requests;
using BNP.CMM.Application.Responses;
using BNP.CMM.Infra.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BNP.CMM.Application.Handlers.Query
{
    public class CosifsQueryHandlers : IRequestHandler<GetCosifsRequest, List<GetCosifsResponse>>
    {
        private readonly AppDbContext _dbContext;
        public CosifsQueryHandlers(AppDbContext dbContext)
        {
                _dbContext = dbContext;
        }

        public async Task<List<GetCosifsResponse>> Handle(GetCosifsRequest request, CancellationToken cancellationToken)
        {
            var cosifsList = await _dbContext.ProdutosCosif.ToListAsync();
            var response = new List<GetCosifsResponse>();

            foreach (var cosifs in cosifsList) {
                response.Add(new GetCosifsResponse(cosifs.CosifId, cosifs.ProductId, cosifs.ClassificationCode, cosifs.Status));
            }

            return response;
        }
    }
}
