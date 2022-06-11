namespace Stride3DMarketPlace.Store.Dtos.AssetDtos
{
    public class IndexAssetsSectionDto
    {

        public string Name { get; set; }

        public IEnumerable<IndexAssetDto> Assets { get; set; }
    }
}
