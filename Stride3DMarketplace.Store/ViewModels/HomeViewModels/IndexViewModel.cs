using Stride3DMarketPlace.Store.Dtos.AssetDtos;

namespace Stride3DMarketPlace.Store.ViewModels.HomeViewModels
{
    public class IndexViewModel
    {
        public IEnumerable<IndexAssetDto> Assets2d { get; set; }
        public IEnumerable<IndexAssetDto> Assets3d { get; set; }
        public IEnumerable<IndexAssetDto> AudioAssets { get; set; }
        public IEnumerable<IndexAssetDto> NewAssets { get; set; }
        public IEnumerable<IndexAssetDto> RecentlyUpdatedAssets { get; set; }
        public IEnumerable<IndexAssetDto> ScriptsAssets { get; set; }
        public IEnumerable<IndexAssetDto> StaffPickAssets { get; set; }
        public IEnumerable<IndexAssetDto> TemplateAssets { get; set; }
        public IEnumerable<IndexAssetDto> TopRatedAssets { get; set; }
    }
}
