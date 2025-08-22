namespace BNP.CMM.Domain.Entities
{
    public class ManualMovement
    {
        public ManualMovement(
            int month,
            int year,
            long entryNumber,
            string productId,
            string cosifId,
            DateTime movementDate,
            decimal value,
            string description,
            string userCode)
        {
            SetMonth(month);
            SetYear(year);
            SetEntryNumber(entryNumber);
            SetProdutoId(productId);
            SetCosifId(cosifId);
            SetMovementDate(movementDate);
            SetValue(value);
            SetDescription(description);
            SetUserCode(userCode);
        }

        public int Month { get; private set; }
        public int Year { get; private set; }
        public long EntryNumber { get; private set; }
        public string ProductId { get; private set; }
        public string CosifId { get; private set; }
        public DateTime MovementDate { get; private set; }
        public decimal Value { get; private set; }
        public string Description { get; private set; }
        public string UserCode { get; private set; }

        public virtual Product Product { get; set; }
        public virtual Cosif Cosif { get; set; }



        public void SetMonth(int month) => Month = month;
        public void SetYear(int year) => Year = year;
        public void SetEntryNumber(long entryNumber) => EntryNumber = entryNumber;
        public void SetProdutoId(string produtoId) => ProductId = produtoId;
        public void SetCosifId(string cosifId) => CosifId = cosifId;
        public void SetMovementDate(DateTime movementDate) => MovementDate = movementDate;
        public void SetValue(decimal value) => Value = value;
        public void SetDescription(string description) => Description = description;
        public void SetUserCode(string userCode) => UserCode = userCode;
    }
}
