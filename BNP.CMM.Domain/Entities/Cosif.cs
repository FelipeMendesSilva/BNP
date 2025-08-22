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

        public  string  CosifId { get; private set; }
        public string ProductId { get; private set; }
        public string ClassificationCode { get; private set; }
        public string Status { get; private set; }

        public virtual Product Product { get; private set; }

        
        public void SetCosifId(string cosifId) => CosifId = cosifId;
        public void SetProdutoId(string produtoId) => ProductId = produtoId;
        public void SetClassificationCode(string code) =>  ClassificationCode = code;
        public void SetStatus(string status) => Status = status;
    }
}
