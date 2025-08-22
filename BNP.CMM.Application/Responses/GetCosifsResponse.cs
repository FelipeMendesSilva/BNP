namespace BNP.CMM.Application.Responses
{
    public class GetCosifsResponse
    {
        public GetCosifsResponse(string cosifId, string productId, string classificationCode, string status)
        {
            CosifId = cosifId;
            ProductId = productId;
            ClassificationCode = classificationCode;
            Status = status;
        }
        public string CosifId { get; set; }
        public string ProductId { get; set; }
        public string ClassificationCode { get; set; }
        public string Status { get; set; }
    }
}
