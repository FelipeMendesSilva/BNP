namespace BNP.CMM.Application.Responses
{
    public class GetManualMovementsResponse
    {
        public int Mes { get; set; }
        public int Ano { get; set; }
        public long NumeroLancamento { get; set; }
        public required string ProdutoId { get; set; }
        public required string CosifId { get; set; }
        public DateTime DataMovimento { get; set; }
        public decimal Valor { get; set; }
        public required string Descricao { get; set; }
        public required string CodigoUsuario { get; set; }
    }
}
