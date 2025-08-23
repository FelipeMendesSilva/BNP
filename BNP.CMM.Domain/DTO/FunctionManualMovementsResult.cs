using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNP.CMM.Domain.DTO
{
    public class FunctionManualMovementsResult
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
