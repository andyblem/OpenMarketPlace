namespace Stride3dMarketplace.Store.Dtos.AssetDtos
{
    public class IndexAssetDto
    {
        public int Id { get; set; }
        public int Rating { get; set; }
        public int Reviews { get; set; }

        public string AssetType { get; set; }
        public string IconImagePath { get; set; }
        public string Name { get; set; }
        public string Publisher { get; set; }

    }
}
