using MediatR;
using Microsoft.AspNetCore.Mvc;
using Stride3dMarketplace.Store.CQRS.AssetsCQRS;
using Stride3dMarketplace.Store.ViewModels;
using Stride3dMarketplace.Store.ViewModels.HomeViewModels;
using System.Diagnostics;

namespace Stride3dMarketplace.Store.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMediator _mediator;

        public HomeController(ILogger<HomeController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        public async Task<ActionResult<IndexViewModel>> Index()
        {
            // create view model
            IndexViewModel indexViewModel = new IndexViewModel();

            // get data
            indexViewModel.Assets2d = await _mediator.Send(new Get2dAssetsQuery() { Amount = 5 });
            indexViewModel.Assets3d = await _mediator.Send(new Get3dAssetsQuery() { Amount = 5 });
            indexViewModel.AudioAssets = await _mediator.Send(new GetAudioAssetsQuery() { Amount = 5 });
            indexViewModel.NewAssets = await _mediator.Send(new GetNewAssetsQuery() { Amount = 5 });
            indexViewModel.RecentlyUpdatedAssets = await _mediator.Send(new GetRecentlyUpdatedAssetsQuery() { Amount = 5 });
            indexViewModel.ScriptsAssets = await _mediator.Send(new GetScriptsAssetsQuery() { Amount = 5 });
            indexViewModel.StaffPickAssets = await _mediator.Send(new GetStaffPickAssetsQuery() { Amount = 5 });
            indexViewModel.TemplateAssets = await _mediator.Send(new GetTemplatesAssetsQuery() { Amount = 5 });

            // return result
            return View(indexViewModel);
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