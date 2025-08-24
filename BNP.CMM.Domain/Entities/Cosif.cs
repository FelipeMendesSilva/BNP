namespace BNP.CMM.Domain.Entities
{
    public class Cosif
    {
        public Cosif(string cosifId, string productId, string classificationCode, string status)
        {
            SetCosifId(cosifId);
            SetProdutoId(productId);
            SetClassificationCode(classificationCode);
            SetStatus(status);
        }

        public  string  CosifId { get; private set; } = null!;
        public string ProductId { get; private set; } = null!;
        public string ClassificationCode { get; private set; } = null!;
        public string Status { get; private set; } = null!;

        public virtual Product? Product { get; set; }

        
        public void SetCosifId(string cosifId) => CosifId = cosifId;
        public void SetProdutoId(string produtoId) => ProductId = produtoId;
        public void SetClassificationCode(string code) =>  ClassificationCode = code;
        public void SetStatus(string status) => Status = status;
    }
}
