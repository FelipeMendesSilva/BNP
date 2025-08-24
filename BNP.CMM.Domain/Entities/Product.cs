namespace BNP.CMM.Domain.Entities
{
    public class Product
    {
        public Product(string productId, string description, string status)
        {
            SetProdutoId(productId);
            SetDescription(description);
            SetStatus(status);
        }

        public string ProductId { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Status { get; set; } = null!;

        public void SetProdutoId(string produtoId) => ProductId = produtoId;
        public void SetDescription(string description) => Description = description;
        public void SetStatus(string status) => Status = status;
    }
}
