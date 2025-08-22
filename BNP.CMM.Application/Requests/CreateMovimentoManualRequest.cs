using MediatR;
using System.ComponentModel.DataAnnotations;

namespace BNP.CMM.Application.Requests
{
    public class CreateMovimentoManualRequest : IRequest<bool>
    {
        [Required(ErrorMessage = "O mês é obrigatório.")]
        [Range(1, 12, ErrorMessage = "O mês deve estar entre 1 e 12.")]
        public int Month { get; set; }

        [Required(ErrorMessage = "O ano é obrigatório.")]
        [Range(1900, 2100, ErrorMessage = "Ano inválido.")]
        public int Year { get; set; }

        [Required(ErrorMessage = "Selecione um produto.")]
        public required string ProductId { get; set; }

        [Required(ErrorMessage = "Selecione um cosif.")]
        public required string CosifId { get; set; }

        [Required(ErrorMessage = "Informe o valor.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "O valor deve ser maior que zero.")]
        public decimal Amount { get; set; }

        [StringLength(200, ErrorMessage = "A descrição não pode exceder 200 caracteres.")]
        public required string Description { get; set; }
    }
}
