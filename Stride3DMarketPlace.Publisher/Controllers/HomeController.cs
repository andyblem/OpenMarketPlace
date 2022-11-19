using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Stride3DMarketPlace.Seller.CQRS.AssetCategoryCQRS.Queries;
using Stride3DMarketPlace.Seller.Models;
using System.Diagnostics;

namespace Stride3DMarketPlace.Seller.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IMediator _mediator;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            // get data
            var assetCategories = await _mediator.Send(new GetAssetCategoriesSelectItemsQuery());

            // init view data
            ViewData["AssetCategories"] = new SelectList(assetCategories, "Id", "Name");

            // return view
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}