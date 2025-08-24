using BNP.CMM.API.Models;
using BNP.CMM.Application.Requests;
using FluentValidation;
using FluentValidation.Results;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace BNP.CMM.API.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMediator _mediatr;
        private readonly IValidator<CreateManualMovementRequest> _validator;

        public HomeController(ILogger<HomeController> logger, IMediator mediator, IValidator<CreateManualMovementRequest> validator)
        {
            _logger = logger;
            _mediatr = mediator;
            _validator = validator;
        }

        public async Task<IActionResult> Index(CancellationToken cancellationToken)
        {
            var model = await CreateIndexModel(cancellationToken);

            if (model == null)
                TempData["Erro"] = "Erro ao carregar formulario.";

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Incluir(CmmViewModel model, CancellationToken cancellationToken)
        {
            try
            {
                ValidationResult result = await _validator.ValidateAsync(model.NewManualMovement);
                if (!result.IsValid)
                {
                    TempData["Erro"] = "Movimento Manual invalido";
                }

                var success = await _mediatr.Send(model.NewManualMovement, cancellationToken);
                if (!success)
                {
                    TempData["Erro"] = "Erro ao processar Movimento Manual. Tente novamente.";
                }
                else
                {
                    TempData["Alerta"] = "Dados salvos com sucesso!";
                }

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro inesperado");
                return RedirectToAction("Error");                
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private async Task<CmmViewModel?> CreateIndexModel(CancellationToken cancellationToken)
        {
            var products = await _mediatr.Send(new GetProductsRequest(), cancellationToken);
            var cosifs = await _mediatr.Send(new GetCosifsRequest(), cancellationToken);
            var movements = await _mediatr.Send(new GetManualMovementsRequest(), cancellationToken);

            if (!products.Any() || !cosifs.Any())
                return null;

            var model = new CmmViewModel()
            {
                Products = products,
                Cosifs = cosifs,
                ManualMovements = movements
            };

            return model;
        }
    }
}
