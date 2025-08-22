namespace BNP.CMM.Domain.Entities
{
    public class Cosif
    {
        public string CosifId { get; set; }
        public string ProdutoId { get; set; }
        public string ClassificationCode { get; set; }
        public string Status { get; set; }

        public virtual Product Product { get; set; }
    }
}
