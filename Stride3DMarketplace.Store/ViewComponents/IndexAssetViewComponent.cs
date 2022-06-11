using Microsoft.AspNetCore.Mvc;
using Stride3DMarketPlace.Store.Dtos.AssetDtos;

namespace Stride3DMarketPlace.Store.ViewComponents
{
    public class IndexAssetViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(IndexAssetDto asset)
        {
            // return result
            return View(asset);
        }
    }
}
