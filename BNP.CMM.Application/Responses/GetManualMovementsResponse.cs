namespace BNP.CMM.Application.Responses
{
    public class GetManualMovementsResponse
    {
        public int Month { get; set; }
        public int Year { get; set; }
        public required string ProductId { get; set; }
        public required string ProductDescription { get; set; }
        public long EntryNumber { get; set; }
        public required string Description { get; set; }
        public decimal Amount { get; set; }
    }
}
