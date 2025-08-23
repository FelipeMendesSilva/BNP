using AutoMapper;
using BNP.CMM.Application.Requests;
using BNP.CMM.Application.Responses;
using BNP.CMM.Domain.DTO;
using BNP.CMM.Infra.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BNP.CMM.Application.Handlers.Query
{
    public class ManualMovementsQueryHandlers : IRequestHandler<GetManualMovementsRequest, List<GetManualMovementsResponse>>
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;

        public ManualMovementsQueryHandlers(AppDbContext dbContext, IMapper mapper)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }

        public async Task<List<GetManualMovementsResponse>> Handle(GetManualMovementsRequest request, CancellationToken cancellationToken)
        {
            var result = await _dbContext.Set<FunctionManualMovementsResult>().FromSqlRaw( "select * from fn_consulta_movimento_manual();").ToListAsync();
            var response = _mapper.Map<List<GetManualMovementsResponse>>(result);

            return response;
        }
    }
}
