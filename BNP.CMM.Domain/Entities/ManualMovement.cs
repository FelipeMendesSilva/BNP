namespace BNP.CMM.Domain.Entities
{
    public class ManualMovement
    {
        public ManualMovement(
            int month,
            int year,
            string productId,
            string cosifId,            
            decimal amount,
            string description)
        {
            SetMonth(month);
            SetYear(year);
            SetProdutoId(productId);
            SetCosifId(cosifId);
            SetMovementDate(DateTime.UtcNow);
            SetValue(amount);
            SetDescription(description);
            SetUserCode("TESTE");
        }

        public int Month { get; private set; }
        public int Year { get; private set; }
        public long? EntryNumber { get; private set; }
        public string ProductId { get; private set; } = null!;
        public string CosifId { get; private set; } = null!;
        public DateTime MovementDate { get; private set; }
        public decimal Amount { get; private set; }
        public string Description { get; private set; } = null!;
        public string UserCode { get; private set; } = null!;

        public virtual Cosif? Cosif { get; set; }


        public void SetMonth(int month) => Month = month;
        public void SetYear(int year) => Year = year;
        public void SetEntryNumber(long entryNumber) => EntryNumber = entryNumber;
        public void SetProdutoId(string produtoId) => ProductId = produtoId;
        public void SetCosifId(string cosifId) => CosifId = cosifId;
        public void SetMovementDate(DateTime movementDate) => MovementDate = movementDate;
        public void SetValue(decimal value) => Amount = value;
        public void SetDescription(string description) => Description = description;
        public void SetUserCode(string userCode) => UserCode = userCode;
    }
}
