using Microsoft.AspNetCore.Mvc;
using Stride3DMarketPlace.Store.Dtos.AssetDtos;

namespace Stride3DMarketPlace.Store.ViewComponents
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
