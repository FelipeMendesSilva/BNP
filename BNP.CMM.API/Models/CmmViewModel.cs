using BNP.CMM.Application.Requests;
using BNP.CMM.Application.Responses;

namespace BNP.CMM.API.Models
{
    public class CmmViewModel
    {
        public CreateManualMovementRequest? NewManualMovement { get; set; }
        public List<GetProductsResponse>? Products { get; set; }
        public List<GetCosifsResponse>? Cosifs { get; set; }
        public List<GetManualMovementsResponse>? ManualMovements { get; set; }
    }
}
