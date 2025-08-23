using System.Diagnostics;
using BNP.CMM.API.Models;
using BNP.CMM.Application.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BNP.CMM.API.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMediator _mediatr;

        public HomeController(ILogger<HomeController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediatr = mediator;
        }

        public async Task<IActionResult> Index(CancellationToken cancellationToken)
        {
            var model = new CmmViewModel()
            {
                Products = await _mediatr.Send(new GetProductsRequest(), cancellationToken),
                Cosifs = await _mediatr.Send(new GetCosifsRequest(), cancellationToken),
                ManualMovements = await _mediatr.Send(new GetManualMovementsRequest(), cancellationToken)
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Incluir(CmmViewModel model, CancellationToken cancellationToken)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Error");

            }
            await _mediatr.Send(model.NewManualMovement, cancellationToken); 


            // Processa os dados válidos
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
