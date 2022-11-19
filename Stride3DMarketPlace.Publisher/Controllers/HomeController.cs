using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Stride3DMarketPlace.Seller.CQRS.AssetCategoryCQRS.Queries;
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

        public IActionResult Error(int statusCode)
        {
            // set view-bag and cache error message
            ViewBag.ErrorMessage = TempData["ErrorMessage"];
            TempData["ErrorMessage"] = ViewBag.ErrorMessage;

            // set other data
            ViewBag.RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            ViewBag.ShowRequestId = !string.IsNullOrEmpty(ViewBag.RequestId);
            ViewBag.StatusCode = statusCode;

            // return view
            return View();
        }
    }
}