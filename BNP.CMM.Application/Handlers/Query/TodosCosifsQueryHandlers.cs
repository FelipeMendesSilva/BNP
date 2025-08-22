using BNP.CMM.Application.Requests;
using BNP.CMM.Application.Responses;
using MediatR;

namespace BNP.CMM.Application.Handlers.Query
{
    public class TodosCosifsQueryHandlers : IRequestHandler<GetCosifsRequest, List<GetCosifsResponse>>
    {
        public TodosCosifsQueryHandlers()
        {
                
        }

        public async Task<List<GetCosifsResponse>> Handle(GetCosifsRequest request, CancellationToken cancellationToken)
        {
            return new List<GetCosifsResponse>() { new GetCosifsResponse() { CosifId = "1234567890", ProductId = "abcd", ClassificationCode = "code"} };
        }
    }
}
