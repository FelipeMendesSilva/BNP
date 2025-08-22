namespace BNP.CMM.Domain.Entities
{
    public class ManualMovement
    {
        public int Month { get; set; }
        public int Year { get; set; }
        public long Entrynumber { get; set; }
        public required string ProdutoId { get; set; }
        public required string CosifId { get; set; }
        public DateTime MovementDate { get; set; }
        public decimal Value { get; set; }
        public required string Description { get; set; }
        public required string UserCode { get; set; }

        public virtual Product Product { get; set; }
        public virtual Cosif Cosif { get; set; }
    }
}
