namespace Stride3dMarketplace.Store.Dtos.AssetDtos
{
    public class IndexAssetsSectionDto
    {

        public string Name { get; set; }

        public IEnumerable<IndexAssetDto> Assets { get; set; }
    }
}
