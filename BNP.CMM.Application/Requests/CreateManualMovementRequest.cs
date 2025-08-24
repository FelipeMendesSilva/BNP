using MediatR;

namespace BNP.CMM.Application.Requests
{
    public class CreateManualMovementRequest : IRequest<bool>
    {
        public int Month { get; set; }
        public int Year { get; set; }
        public required string ProductId { get; set; }
        public required string CosifId { get; set; }
        public decimal Amount { get; set; }
        public required string Description { get; set; }
    }
}
