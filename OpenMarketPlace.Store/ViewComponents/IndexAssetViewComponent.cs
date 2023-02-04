using Microsoft.AspNetCore.Mvc;
using Stride3dMarketplace.Store.Dtos.AssetDtos;

namespace Stride3dMarketplace.Store.ViewComponents
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
