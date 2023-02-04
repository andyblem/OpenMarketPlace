using Microsoft.AspNetCore.Mvc;
using Stride3dMarketplace.Store.Dtos.AssetDtos;

namespace Stride3dMarketplace.Store.ViewComponents
{
    public class HomeIndexAssetsSectionViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(string name, IEnumerable<IndexAssetDto> assets)
        {
            // create result
            var indexAssetsSection = new IndexAssetsSectionDto()
            {
                Name = name,
                Assets = assets
            };

            // return result
            return View(indexAssetsSection);
        }
    }
}
