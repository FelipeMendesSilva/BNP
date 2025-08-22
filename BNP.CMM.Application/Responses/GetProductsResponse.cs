namespace BNP.CMM.Application.Responses
{
    public class GetProductsResponse
    {
        public GetProductsResponse(string productId, string description, string status)
        {
            ProductId = productId;
            Description = description;
            Status = status;
        }
        public string ProductId { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
    }
}
